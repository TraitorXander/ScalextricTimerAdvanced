namespace ScalextricLapTimer
{
    partial class DebugForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridMsg = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLastTime = new System.Windows.Forms.TextBox();
            this.txtLightLevelAverage = new System.Windows.Forms.TextBox();
            this.txtLightLevel = new System.Windows.Forms.TextBox();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.checkAutoScroll = new System.Windows.Forms.CheckBox();
            this.txtLiveTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridMsg)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMsg
            // 
            this.gridMsg.AllowUserToAddRows = false;
            this.gridMsg.AllowUserToDeleteRows = false;
            this.gridMsg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMsg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1});
            this.gridMsg.Location = new System.Drawing.Point(12, 12);
            this.gridMsg.Name = "gridMsg";
            this.gridMsg.ReadOnly = true;
            this.gridMsg.RowHeadersVisible = false;
            this.gridMsg.Size = new System.Drawing.Size(320, 206);
            this.gridMsg.TabIndex = 9;
            // 
            // col1
            // 
            this.col1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col1.HeaderText = "Message";
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            // 
            // txtLastTime
            // 
            this.txtLastTime.Location = new System.Drawing.Point(338, 113);
            this.txtLastTime.Name = "txtLastTime";
            this.txtLastTime.Size = new System.Drawing.Size(263, 20);
            this.txtLastTime.TabIndex = 12;
            // 
            // txtLightLevelAverage
            // 
            this.txtLightLevelAverage.Location = new System.Drawing.Point(338, 61);
            this.txtLightLevelAverage.Name = "txtLightLevelAverage";
            this.txtLightLevelAverage.Size = new System.Drawing.Size(263, 20);
            this.txtLightLevelAverage.TabIndex = 11;
            // 
            // txtLightLevel
            // 
            this.txtLightLevel.Location = new System.Drawing.Point(338, 35);
            this.txtLightLevel.Name = "txtLightLevel";
            this.txtLightLevel.Size = new System.Drawing.Size(263, 20);
            this.txtLightLevel.TabIndex = 10;
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // checkAutoScroll
            // 
            this.checkAutoScroll.AutoSize = true;
            this.checkAutoScroll.Checked = true;
            this.checkAutoScroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAutoScroll.Location = new System.Drawing.Point(338, 12);
            this.checkAutoScroll.Name = "checkAutoScroll";
            this.checkAutoScroll.Size = new System.Drawing.Size(77, 17);
            this.checkAutoScroll.TabIndex = 13;
            this.checkAutoScroll.Text = "Auto Scroll";
            this.checkAutoScroll.UseVisualStyleBackColor = true;
            // 
            // txtLiveTime
            // 
            this.txtLiveTime.Location = new System.Drawing.Point(338, 87);
            this.txtLiveTime.Name = "txtLiveTime";
            this.txtLiveTime.Size = new System.Drawing.Size(263, 20);
            this.txtLiveTime.TabIndex = 14;
            // 
            // DebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 234);
            this.Controls.Add(this.txtLiveTime);
            this.Controls.Add(this.checkAutoScroll);
            this.Controls.Add(this.txtLastTime);
            this.Controls.Add(this.txtLightLevelAverage);
            this.Controls.Add(this.txtLightLevel);
            this.Controls.Add(this.gridMsg);
            this.Name = "DebugForm";
            this.Text = "DebugForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridMsg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.TextBox txtLastTime;
        private System.Windows.Forms.TextBox txtLightLevelAverage;
        private System.Windows.Forms.TextBox txtLightLevel;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.CheckBox checkAutoScroll;
        private System.Windows.Forms.TextBox txtLiveTime;
    }
}