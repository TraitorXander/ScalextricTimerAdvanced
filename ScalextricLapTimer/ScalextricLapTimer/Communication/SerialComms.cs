using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ScalextricLapTimer.Constants;

namespace ScalextricLapTimer
{
    public class SerialComms
    {
        private SerialPort serialPort;
        public string Port { get; set; }
        public int BaudRate { get; set; }
        public string LastMessage { get; private set; }
        public int LightLevel { get; private set; }
        public int LightLevelAverage { get; private set; }
        public double LastTime { get; private set; }
        public double LiveTime { get; private set; }
        public int InvalidMsgCount { get; private set; }

        public SerialComms()
        {
            serialPort = new SerialPort();
        }

        public SerialComms(string _port, int _baudrate)
        {
            this.Port = _port;
            this.BaudRate = _baudrate;
            serialPort = new SerialPort(Port, (int)BaudRate);
        }

        public void SetConnectionSettings(string _port, int _baudrate)
        {
            if (GetComPorts().Contains(_port) && _baudrate > 0)
            {
                this.Port = _port;
                this.BaudRate = _baudrate;

                serialPort.PortName = Port;
                serialPort.BaudRate = BaudRate;
            }
        }

        public string[] GetComPorts()
        {
            return SerialPort.GetPortNames();
        }

        public string[] GetBaudRates()
        {
            return BaudRates;
        }

        public bool Open()
        {
            if (GetComPorts().Contains(Port) && BaudRate > 0)
            {
                serialPort.Open();
                if (serialPort.IsOpen)
                {
                    serialPort.DataReceived += new SerialDataReceivedEventHandler(OnDataReceived);
                    return true;
                }

            }

            return false;
        }

        public bool IsOpen()
        {
            return serialPort.IsOpen;
        }

        public bool Close()
        {
            if (serialPort.IsOpen)
            {
                LastMessage = String.Empty;
                LightLevel = 0;
                LightLevelAverage = 0;
                LastTime = 0;

                serialPort.DiscardInBuffer();
                serialPort.Close();
                return true;
            }
            return false;
        }

        public void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //received.Enqueue(serialPort.ReadExisting());
            string msg = serialPort.ReadExisting();
            msg = msg.Replace("\r\n", "");
            msg = msg.Replace("\n", "");
            LastMessage = msg;
            string[] splitData = msg.Split(MSG_DELIM);
            switch (splitData[0])
            {
                // TIME [current light level] [average light level] [live time]
                case ("TIME"):
                    if (splitData.Length == 5)
                    {
                        LightLevel = Convert.ToInt32(splitData[1]);
                        LightLevelAverage = Convert.ToInt32(splitData[2]);
                        LiveTime = Convert.ToDouble(splitData[3]) / 1000;
                        LastTime = Convert.ToDouble(splitData[4]) / 1000;

                    }
                    else
                    {
                        InvalidMsgCount++;
                        LightLevel = -9999;
                        LightLevelAverage = -9999;
                    }
                    break;
                // Time message
                // TIME [time since last trigger]
                //case ("TIME"):
                //    if (splitData.Length == 2)
                //    {
                //        LastTime = Convert.ToDouble(splitData[1]) / 1000;
                //    }
                //    else
                //    {
                //        InvalidMsgCount++;
                //        LastTime = -9999;
                //    }
                //    break;
                default:
                    InvalidMsgCount++;
                    break;
            }
        }
    }
}

