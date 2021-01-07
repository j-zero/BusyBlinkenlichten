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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWebcamUsage = new System.Windows.Forms.Label();
            this.lblMicrophoneUsage = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnOn = new System.Windows.Forms.Button();
            this.cmbPorts = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnSetCustom = new System.Windows.Forms.Button();
            this.lblWebcamColor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMicColor = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFreeColor = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chkBlink = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBlinkColor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblsetBlinkColor = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Webcam in use:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Microphone in use:";
            // 
            // lblWebcamUsage
            // 
            this.lblWebcamUsage.AutoSize = true;
            this.lblWebcamUsage.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWebcamUsage.Location = new System.Drawing.Point(128, 48);
            this.lblWebcamUsage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWebcamUsage.Name = "lblWebcamUsage";
            this.lblWebcamUsage.Size = new System.Drawing.Size(34, 15);
            this.lblWebcamUsage.TabIndex = 2;
            this.lblWebcamUsage.Text = "false";
            // 
            // lblMicrophoneUsage
            // 
            this.lblMicrophoneUsage.AutoSize = true;
            this.lblMicrophoneUsage.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMicrophoneUsage.Location = new System.Drawing.Point(128, 63);
            this.lblMicrophoneUsage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMicrophoneUsage.Name = "lblMicrophoneUsage";
            this.lblMicrophoneUsage.Size = new System.Drawing.Size(29, 15);
            this.lblMicrophoneUsage.TabIndex = 3;
            this.lblMicrophoneUsage.Text = "true";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 316);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(417, 23);
            this.textBox1.TabIndex = 4;
            // 
            // btnOff
            // 
            this.btnOff.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOff.Location = new System.Drawing.Point(75, 94);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(57, 27);
            this.btnOff.TabIndex = 5;
            this.btnOff.Text = "Off";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnOn
            // 
            this.btnOn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOn.Location = new System.Drawing.Point(14, 94);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(55, 27);
            this.btnOn.TabIndex = 6;
            this.btnOn.Text = "On";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // cmbPorts
            // 
            this.cmbPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPorts.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.Location = new System.Drawing.Point(48, 12);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(140, 23);
            this.cmbPorts.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Port:";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(194, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(72, 23);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 298);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Received:";
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.Blue;
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblColor.Location = new System.Drawing.Point(293, 172);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(32, 32);
            this.lblColor.TabIndex = 11;
            this.lblColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // btnSetCustom
            // 
            this.btnSetCustom.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetCustom.Location = new System.Drawing.Point(194, 94);
            this.btnSetCustom.Name = "btnSetCustom";
            this.btnSetCustom.Size = new System.Drawing.Size(108, 27);
            this.btnSetCustom.TabIndex = 12;
            this.btnSetCustom.Text = "Set Custom Color";
            this.btnSetCustom.UseVisualStyleBackColor = true;
            this.btnSetCustom.Click += new System.EventHandler(this.btnSetCustom_Click);
            // 
            // lblWebcamColor
            // 
            this.lblWebcamColor.BackColor = System.Drawing.Color.Red;
            this.lblWebcamColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWebcamColor.Location = new System.Drawing.Point(132, 139);
            this.lblWebcamColor.Name = "lblWebcamColor";
            this.lblWebcamColor.Size = new System.Drawing.Size(32, 32);
            this.lblWebcamColor.TabIndex = 13;
            this.lblWebcamColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Webcam Color:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 172);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Microphone Color:";
            // 
            // lblMicColor
            // 
            this.lblMicColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMicColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMicColor.Location = new System.Drawing.Point(132, 171);
            this.lblMicColor.Name = "lblMicColor";
            this.lblMicColor.Size = new System.Drawing.Size(32, 32);
            this.lblMicColor.TabIndex = 15;
            this.lblMicColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 204);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Free Color:";
            // 
            // lblFreeColor
            // 
            this.lblFreeColor.BackColor = System.Drawing.Color.Lime;
            this.lblFreeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFreeColor.Location = new System.Drawing.Point(132, 203);
            this.lblFreeColor.Name = "lblFreeColor";
            this.lblFreeColor.Size = new System.Drawing.Size(32, 32);
            this.lblFreeColor.TabIndex = 17;
            this.lblFreeColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(172, 173);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Custom Color:";
            // 
            // chkBlink
            // 
            this.chkBlink.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkBlink.Location = new System.Drawing.Point(138, 94);
            this.chkBlink.Name = "chkBlink";
            this.chkBlink.Size = new System.Drawing.Size(50, 27);
            this.chkBlink.TabIndex = 20;
            this.chkBlink.Text = "Blink";
            this.chkBlink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBlink.UseVisualStyleBackColor = true;
            this.chkBlink.CheckedChanged += new System.EventHandler(this.chkBlink_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(172, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Blink Color:";
            // 
            // lblBlinkColor
            // 
            this.lblBlinkColor.BackColor = System.Drawing.Color.Black;
            this.lblBlinkColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBlinkColor.Location = new System.Drawing.Point(293, 139);
            this.lblBlinkColor.Name = "lblBlinkColor";
            this.lblBlinkColor.Size = new System.Drawing.Size(32, 32);
            this.lblBlinkColor.TabIndex = 21;
            this.lblBlinkColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(272, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Disconnect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblsetBlinkColor
            // 
            this.lblsetBlinkColor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsetBlinkColor.Location = new System.Drawing.Point(308, 94);
            this.lblsetBlinkColor.Name = "lblsetBlinkColor";
            this.lblsetBlinkColor.Size = new System.Drawing.Size(108, 27);
            this.lblsetBlinkColor.TabIndex = 24;
            this.lblsetBlinkColor.Text = "Set Blink Color";
            this.lblsetBlinkColor.UseVisualStyleBackColor = true;
            this.lblsetBlinkColor.Click += new System.EventHandler(this.lblsetBlinkColor_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(382, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 23);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 351);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblsetBlinkColor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBlinkColor);
            this.Controls.Add(this.chkBlink);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblFreeColor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblMicColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblWebcamColor);
            this.Controls.Add(this.btnSetCustom);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPorts);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMicrophoneUsage);
            this.Controls.Add(this.lblWebcamUsage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Busy Blinkenlichten";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.ComboBox cmbPorts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnSetCustom;
        private System.Windows.Forms.Label lblWebcamColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMicColor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFreeColor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkBlink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBlinkColor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button lblsetBlinkColor;
        private System.Windows.Forms.Button btnExit;
    }
}

