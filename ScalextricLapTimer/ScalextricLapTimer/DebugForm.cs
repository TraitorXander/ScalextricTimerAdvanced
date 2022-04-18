using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScalextricLapTimer
{
    public partial class DebugForm : Form
    {
        Main main;
        public DebugForm(Main _main)
        {
            InitializeComponent();
            main = _main;
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            if (main.serialComm != null && main.serialComm.IsOpen())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(gridMsg);
                row.Cells[0].Value = main.serialComm.LastMessage;
                gridMsg.Rows.Add(row);
                if (checkAutoScroll.Checked) { gridMsg.FirstDisplayedScrollingRowIndex = gridMsg.RowCount - 1; }

                txtLightLevel.Text = "Light level: " + main.serialComm.LightLevel;
                txtLightLevelAverage.Text = "Light level average: " + main.serialComm.LightLevelAverage;
                txtLastTime.Text = "Last time: " + main.serialComm.LastTime;
            }
        }
    }
}
