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
            this.btnClosePort = new System.Windows.Forms.Button();
            this.comboBaud = new System.Windows.Forms.ComboBox();
            this.comboPort = new System.Windows.Forms.ComboBox();
            this.btnOpenPort = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(667, 24);
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
            // 
            // subitemDisconnect
            // 
            this.subitemDisconnect.Name = "subitemDisconnect";
            this.subitemDisconnect.Size = new System.Drawing.Size(181, 22);
            this.subitemDisconnect.Text = "Disconnect";
            // 
            // subitemConnectionSettings
            // 
            this.subitemConnectionSettings.Name = "subitemConnectionSettings";
            this.subitemConnectionSettings.Size = new System.Drawing.Size(181, 22);
            this.subitemConnectionSettings.Text = "Connection Settings";
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
            // btnClosePort
            // 
            this.btnClosePort.Enabled = false;
            this.btnClosePort.Location = new System.Drawing.Point(419, 51);
            this.btnClosePort.Name = "btnClosePort";
            this.btnClosePort.Size = new System.Drawing.Size(132, 56);
            this.btnClosePort.TabIndex = 12;
            this.btnClosePort.Text = "Close COM Port";
            this.btnClosePort.UseVisualStyleBackColor = true;
            this.btnClosePort.Click += new System.EventHandler(this.btnClosePort_Click_1);
            // 
            // comboBaud
            // 
            this.comboBaud.FormattingEnabled = true;
            this.comboBaud.Location = new System.Drawing.Point(47, 82);
            this.comboBaud.Name = "comboBaud";
            this.comboBaud.Size = new System.Drawing.Size(228, 25);
            this.comboBaud.TabIndex = 11;
            // 
            // comboPort
            // 
            this.comboPort.FormattingEnabled = true;
            this.comboPort.Location = new System.Drawing.Point(47, 51);
            this.comboPort.Name = "comboPort";
            this.comboPort.Size = new System.Drawing.Size(228, 25);
            this.comboPort.TabIndex = 10;
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(281, 51);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(132, 56);
            this.btnOpenPort.TabIndex = 9;
            this.btnOpenPort.Text = "Open COM Port";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 672);
            this.Controls.Add(this.btnClosePort);
            this.Controls.Add(this.comboBaud);
            this.Controls.Add(this.comboPort);
            this.Controls.Add(this.btnOpenPort);
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
        private System.Windows.Forms.Button btnClosePort;
        private System.Windows.Forms.ComboBox comboBaud;
        private System.Windows.Forms.ComboBox comboPort;
        private System.Windows.Forms.Button btnOpenPort;
    }
}

