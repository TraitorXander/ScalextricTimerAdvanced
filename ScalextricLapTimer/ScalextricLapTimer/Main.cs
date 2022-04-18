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
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            serialComm = new SerialComms();
            comboPort.Items.AddRange(serialComm.GetComPorts());
            comboPort.Sorted = true;
            comboPort.SelectedIndex = 0;
            comboBaud.Items.AddRange(serialComm.GetBaudRates());
            comboBaud.SelectedIndex = 0;
            timerRefresh.Enabled = true;
        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            //gridMsg.Rows.Clear();
            btnOpenPort.Enabled = false;
            btnClosePort.Enabled = true;
            comboPort.Enabled = false;
            comboBaud.Enabled = false;

            serialComm = new SerialComms();
            serialComm.SetConnectionSettings(comboPort.SelectedItem.ToString(), Convert.ToInt32(comboBaud.SelectedItem.ToString()));
            serialComm.Open();
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            if (serialComm != null && serialComm.IsOpen())
            {
                //DataGridViewRow row = new DataGridViewRow();
                //row.CreateCells(gridMsg);
                //row.Cells[0].Value = serialComm.LastMessage;
                //gridMsg.Rows.Add(row);
                //if (checkAutoScroll.Checked) { gridMsg.FirstDisplayedScrollingRowIndex = gridMsg.RowCount - 1; }

                //txtLightLevel.Text = "Light level: " + serialComm.LightLevel;
                //txtLightLevelAverage.Text = "Light level average: " + serialComm.LightLevelAverage;
                //txtLastTime.Text = "Last time: " + serialComm.LastTime;
            }
        }

        private void btnClosePort_Click(object sender, EventArgs e)
        {
            if (serialComm.IsOpen())
            {
                btnOpenPort.Enabled = true;
                btnClosePort.Enabled = false;
                comboPort.Enabled = true;
                comboBaud.Enabled = true;

                serialComm.Close();
                serialComm = null;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialComm != null && serialComm.IsOpen())
            {
                serialComm.Close();
            }
            serialComm = null;
        }

        DebugForm dbForm;
        private void subitemDebugWindow_Click(object sender, EventArgs e)
        {
            if(dbForm == null)
            {
                dbForm = new DebugForm(this);
                dbForm.Show();
            }
            else
            {
                dbForm.Close();
                dbForm = null;
            }
        }

        private void btnOpenPort_Click_1(object sender, EventArgs e)
        {
            //gridMsg.Rows.Clear();
            btnOpenPort.Enabled = false;
            btnClosePort.Enabled = true;
            comboPort.Enabled = false;
            comboBaud.Enabled = false;

            serialComm = new SerialComms();
            serialComm.SetConnectionSettings(comboPort.SelectedItem.ToString(), Convert.ToInt32(comboBaud.SelectedItem.ToString()));
            serialComm.Open();
        }

        private void btnClosePort_Click_1(object sender, EventArgs e)
        {
            if (serialComm.IsOpen())
            {
                btnOpenPort.Enabled = true;
                btnClosePort.Enabled = false;
                comboPort.Enabled = true;
                comboBaud.Enabled = true;

                serialComm.Close();
                serialComm = null;
            }
        }
    }
}
