namespace ScalextricLapTimer
{
    partial class Main
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
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.subitemConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.subitemDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.subitemConnectionSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.itemExtras = new System.Windows.Forms.ToolStripMenuItem();
            this.subitemDebugWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblLive = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerRefresh
            // 
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemConnection,
            this.itemExtras});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(818, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemConnection
            // 
            this.itemConnection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subitemConnect,
            this.subitemDisconnect,
            this.subitemConnectionSettings});
            this.itemConnection.Name = "itemConnection";
            this.itemConnection.Size = new System.Drawing.Size(81, 20);
            this.itemConnection.Text = "Connection";
            // 
            // subitemConnect
            // 
            this.subitemConnect.Name = "subitemConnect";
            this.subitemConnect.Size = new System.Drawing.Size(181, 22);
            this.subitemConnect.Text = "Connect";
            this.subitemConnect.Click += new System.EventHandler(this.subitemConnect_Click);
            // 
            // subitemDisconnect
            // 
            this.subitemDisconnect.Name = "subitemDisconnect";
            this.subitemDisconnect.Size = new System.Drawing.Size(181, 22);
            this.subitemDisconnect.Text = "Disconnect";
            this.subitemDisconnect.Click += new System.EventHandler(this.subitemDisconnect_Click);
            // 
            // subitemConnectionSettings
            // 
            this.subitemConnectionSettings.Name = "subitemConnectionSettings";
            this.subitemConnectionSettings.Size = new System.Drawing.Size(181, 22);
            this.subitemConnectionSettings.Text = "Connection Settings";
            this.subitemConnectionSettings.Click += new System.EventHandler(this.subitemConnectionSettings_Click);
            // 
            // itemExtras
            // 
            this.itemExtras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subitemDebugWindow});
            this.itemExtras.Name = "itemExtras";
            this.itemExtras.Size = new System.Drawing.Size(50, 20);
            this.itemExtras.Text = "Extras";
            // 
            // subitemDebugWindow
            // 
            this.subitemDebugWindow.Name = "subitemDebugWindow";
            this.subitemDebugWindow.Size = new System.Drawing.Size(226, 22);
            this.subitemDebugWindow.Text = "Debug Window (Show/Hide)";
            this.subitemDebugWindow.Click += new System.EventHandler(this.subitemDebugWindow_Click);
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(34, 53);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(76, 17);
            this.lblLast.TabIndex = 6;
            this.lblLast.Text = "Last Time:";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(34, 95);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(97, 17);
            this.lblCurrent.TabIndex = 7;
            this.lblCurrent.Text = "Current Time:";
            // 
            // lblLive
            // 
            this.lblLive.AutoSize = true;
            this.lblLive.Location = new System.Drawing.Point(34, 148);
            this.lblLive.Name = "lblLive";
            this.lblLive.Size = new System.Drawing.Size(74, 17);
            this.lblLive.TabIndex = 8;
            this.lblLive.Text = "Live Time:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 415);
            this.Controls.Add(this.lblLive);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Scalextric Lap Timer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemConnection;
        private System.Windows.Forms.ToolStripMenuItem subitemConnect;
        private System.Windows.Forms.ToolStripMenuItem subitemDisconnect;
        private System.Windows.Forms.ToolStripMenuItem subitemConnectionSettings;
        private System.Windows.Forms.ToolStripMenuItem itemExtras;
        private System.Windows.Forms.ToolStripMenuItem subitemDebugWindow;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblLive;
    }
}

