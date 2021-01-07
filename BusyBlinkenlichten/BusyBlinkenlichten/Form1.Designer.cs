namespace BusyBlinkenlichten
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWebcamUsage = new System.Windows.Forms.Label();
            this.lblMicrophoneUsage = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Webcam in use:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Microphone in use:";
            // 
            // lblWebcamUsage
            // 
            this.lblWebcamUsage.AutoSize = true;
            this.lblWebcamUsage.Location = new System.Drawing.Point(109, 28);
            this.lblWebcamUsage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWebcamUsage.Name = "lblWebcamUsage";
            this.lblWebcamUsage.Size = new System.Drawing.Size(29, 13);
            this.lblWebcamUsage.TabIndex = 2;
            this.lblWebcamUsage.Text = "false";
            // 
            // lblMicrophoneUsage
            // 
            this.lblMicrophoneUsage.AutoSize = true;
            this.lblMicrophoneUsage.Location = new System.Drawing.Point(109, 62);
            this.lblMicrophoneUsage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMicrophoneUsage.Name = "lblMicrophoneUsage";
            this.lblMicrophoneUsage.Size = new System.Drawing.Size(25, 13);
            this.lblMicrophoneUsage.TabIndex = 3;
            this.lblMicrophoneUsage.Text = "true";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(433, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 343);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMicrophoneUsage);
            this.Controls.Add(this.lblWebcamUsage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Busy Blinkenlichten";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWebcamUsage;
        private System.Windows.Forms.Label lblMicrophoneUsage;
        private System.Windows.Forms.TextBox textBox1;
    }
}

