namespace ScalextricLapTimer
{
    partial class ConnectionSettings
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
            this.btnClosePort = new System.Windows.Forms.Button();
            this.comboBaud = new System.Windows.Forms.ComboBox();
            this.comboPort = new System.Windows.Forms.ComboBox();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClosePort
            // 
            this.btnClosePort.Enabled = false;
            this.btnClosePort.Location = new System.Drawing.Point(408, 72);
            this.btnClosePort.Name = "btnClosePort";
            this.btnClosePort.Size = new System.Drawing.Size(132, 56);
            this.btnClosePort.TabIndex = 8;
            this.btnClosePort.Text = "Close COM Port";
            this.btnClosePort.UseVisualStyleBackColor = true;
            // 
            // comboBaud
            // 
            this.comboBaud.FormattingEnabled = true;
            this.comboBaud.Location = new System.Drawing.Point(36, 103);
            this.comboBaud.Name = "comboBaud";
            this.comboBaud.Size = new System.Drawing.Size(228, 21);
            this.comboBaud.TabIndex = 7;
            // 
            // comboPort
            // 
            this.comboPort.FormattingEnabled = true;
            this.comboPort.Location = new System.Drawing.Point(36, 72);
            this.comboPort.Name = "comboPort";
            this.comboPort.Size = new System.Drawing.Size(228, 21);
            this.comboPort.TabIndex = 6;
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(270, 72);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(132, 56);
            this.btnOpenPort.TabIndex = 5;
            this.btnOpenPort.Text = "Open COM Port";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            // 
            // ConnectionSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClosePort);
            this.Controls.Add(this.comboBaud);
            this.Controls.Add(this.comboPort);
            this.Controls.Add(this.btnOpenPort);
            this.Name = "ConnectionSettings";
            this.Text = "ConnectionSettings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClosePort;
        private System.Windows.Forms.ComboBox comboBaud;
        private System.Windows.Forms.ComboBox comboPort;
        private System.Windows.Forms.Button btnOpenPort;
    }
}