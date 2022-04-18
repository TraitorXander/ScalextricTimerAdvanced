using System;
using System.Windows.Forms;

namespace ScalextricLapTimer
{
    public partial class ConnectionSettings : Form
    {
        SerialComms serialComms;

        public ConnectionSettings()
        {
            InitializeComponent();
        }

        private void ConnectionSettings_Load(object sender, EventArgs e)
        {
            serialComms = new SerialComms();
            comboPort.DataSource = serialComms.GetComPorts();
            comboPort.SelectedIndex = 0;
            comboBaud.DataSource = serialComms.GetBaudRates();
            comboBaud.SelectedIndex = 0;
        }

        private void btnTestPort_Click(object sender, EventArgs e)
        {
            try
            {
                if (Helper.SettingsValid())
                {
                    serialComms.Port = Properties.Settings.Default.COMPort;
                    serialComms.BaudRate = Properties.Settings.Default.BaudRate;
                    serialComms.Open();
                    if (serialComms.IsOpen())
                    {
                        MessageBox.Show("Test success!", Constants.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Settings are not valid, please check and try again.", Constants.APP_NAME + " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Constants.APP_NAME + " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboPort.SelectedItem.ToString()))
            {
                Properties.Settings.Default.COMPort = comboPort.SelectedItem.ToString();
            }
        }

        private void comboBaud_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBaud.SelectedItem.ToString()))
            {
                Properties.Settings.Default.BaudRate = Convert.ToInt32(comboBaud.SelectedItem.ToString());
            }
        }

        private void ConnectionSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show(Properties.Settings.Default.COMPort + " " + Properties.Settings.Default.BaudRate);
        }
    }
}
