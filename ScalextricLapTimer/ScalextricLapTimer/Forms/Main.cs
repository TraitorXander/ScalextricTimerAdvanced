using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ScalextricLapTimer.Constants;

namespace ScalextricLapTimer
{
    public partial class Main : Form
    {
        public SerialComms serialComm;
        private DebugForm dbForm;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timerRefresh.Enabled = true;
        }

        private void StartComm()
        {
            this.Text = Constants.APP_NAME + "                " + Properties.Settings.Default.COMPort + " | " + Properties.Settings.Default.BaudRate;

            serialComm = new SerialComms(Properties.Settings.Default.COMPort, Properties.Settings.Default.BaudRate);
            //serialComm.SetConnectionSettings(Properties.Settings.Default.COMPort, Properties.Settings.Default.BaudRate);
            serialComm.Open();

            if (serialComm.IsOpen())
            {
                subitemConnect.Enabled = false;
                subitemDisconnect.Enabled = true;
            }
        }

        private void StopComm()
        {
            if (serialComm.IsOpen())
            {
                serialComm.Close();
                
                if (!serialComm.IsOpen())
                {
                    subitemConnect.Enabled = true;
                    subitemDisconnect.Enabled = false;
                    serialComm = null;
                }
            }
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            if (serialComm != null && serialComm.IsOpen())
            {
                // Refresh the form
            }
            else
            {
                subitemConnect.Enabled = true;
                subitemDisconnect.Enabled = false;
            }
        }

        private void btnClosePort_Click(object sender, EventArgs e)
        {

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialComm != null && serialComm.IsOpen())
            {
                serialComm.Close();
            }
            serialComm = null;
        }

        private void subitemDebugWindow_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form form in fc)
            {
                if (form.GetType() == typeof(DebugForm))
                {
                    dbForm.Close();
                    dbForm = null;
                    return;
                }
            }

            if (dbForm == null)
            {
                dbForm = new DebugForm(this);
                dbForm.Show();
            }
        }

        private void subitemConnect_Click(object sender, EventArgs e)
        {
            StartComm();
        }

        private void subitemDisconnect_Click(object sender, EventArgs e)
        {
            StopComm();
        }

        private void subitemConnectionSettings_Click(object sender, EventArgs e)
        {
            ConnectionSettings connSettings = new ConnectionSettings();
            connSettings.Show();

        }
    }
}
