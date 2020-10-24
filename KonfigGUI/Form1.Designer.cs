namespace KonfigGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.lblPort = new System.Windows.Forms.Label();
            this.lblAllowList = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtAllowList = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPort
            // 
            this.lblPort.Location = new System.Drawing.Point(41, 30);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(100, 23);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "Port";
            // 
            // lblAllowList
            // 
            this.lblAllowList.Location = new System.Drawing.Point(44, 93);
            this.lblAllowList.Name = "lblAllowList";
            this.lblAllowList.Size = new System.Drawing.Size(100, 23);
            this.lblAllowList.TabIndex = 1;
            this.lblAllowList.Text = "Allow List";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(152, 30);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(214, 22);
            this.txtPort.TabIndex = 2;
            // 
            // txtAllowList
            // 
            this.txtAllowList.Location = new System.Drawing.Point(152, 93);
            this.txtAllowList.Multiline = true;
            this.txtAllowList.Name = "txtAllowList";
            this.txtAllowList.Size = new System.Drawing.Size(214, 132);
            this.txtAllowList.TabIndex = 3;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(152, 238);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(107, 52);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(152, 58);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(214, 22);
            this.txtKey.TabIndex = 6;
            // 
            // lblKey
            // 
            this.lblKey.Location = new System.Drawing.Point(44, 53);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(100, 23);
            this.lblKey.TabIndex = 5;
            this.lblKey.Text = "Key";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(265, 238);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(101, 52);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 320);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtAllowList);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblAllowList);
            this.Controls.Add(this.lblPort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kontroller Konfig GUI";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox txtAllowList;
        private System.Windows.Forms.TextBox txtKey;

        private System.Windows.Forms.Label lblAllowList;
        private System.Windows.Forms.TextBox txtPort;

        private System.Windows.Forms.Label lblPort;

        #endregion
    }
}