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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.forceWebcamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceMicrophoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceFreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.setCustomColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blinkenlichtenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblsetBlinkColor = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.chkFade = new System.Windows.Forms.CheckBox();
            this.tbBlinkSpeed = new System.Windows.Forms.TrackBar();
            this.chkBlinkWebcam = new System.Windows.Forms.CheckBox();
            this.chkBlinkMic = new System.Windows.Forms.CheckBox();
            this.chkBlinkFree = new System.Windows.Forms.CheckBox();
            this.tbBrightness = new System.Windows.Forms.TrackBar();
            this.chkRainbow = new System.Windows.Forms.CheckBox();
            this.chkForceWebcam = new System.Windows.Forms.CheckBox();
            this.chkForceMic = new System.Windows.Forms.CheckBox();
            this.chkForceFree = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHeartbeat = new System.Windows.Forms.Label();
            this.tbBrightnessDebug = new System.Windows.Forms.TrackBar();
            this.chkKuando = new System.Windows.Forms.CheckBox();
            this.chkFadeFree = new System.Windows.Forms.CheckBox();
            this.chkFadeMic = new System.Windows.Forms.CheckBox();
            this.chkFadeWebcam = new System.Windows.Forms.CheckBox();
            this.kuandoForceTimer = new System.Windows.Forms.Timer(this.components);
            this.btnMediaPlayStop = new System.Windows.Forms.Button();
            this.chkStopMedia = new System.Windows.Forms.CheckBox();
            this.chkKuandoFallback = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlinkSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightnessDebug)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Busy𝔅𝔩𝔦𝔠𝔨𝔢𝔫𝔩𝔦𝔠𝔥𝔱𝔢𝔫!";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forceWebcamToolStripMenuItem,
            this.forceMicrophoneToolStripMenuItem,
            this.forceFreeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.setCustomColorToolStripMenuItem,
            this.blinkenlichtenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 120);
            // 
            // forceWebcamToolStripMenuItem
            // 
            this.forceWebcamToolStripMenuItem.Name = "forceWebcamToolStripMenuItem";
            this.forceWebcamToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.forceWebcamToolStripMenuItem.Text = "Force Webcam";
            this.forceWebcamToolStripMenuItem.Click += new System.EventHandler(this.forceWebcamToolStripMenuItem_Click);
            // 
            // forceMicrophoneToolStripMenuItem
            // 
            this.forceMicrophoneToolStripMenuItem.Name = "forceMicrophoneToolStripMenuItem";
            this.forceMicrophoneToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.forceMicrophoneToolStripMenuItem.Text = "Force Microphone";
            this.forceMicrophoneToolStripMenuItem.Click += new System.EventHandler(this.forceMicrophoneToolStripMenuItem_Click);
            // 
            // forceFreeToolStripMenuItem
            // 
            this.forceFreeToolStripMenuItem.Name = "forceFreeToolStripMenuItem";
            this.forceFreeToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.forceFreeToolStripMenuItem.Text = "Force Free";
            this.forceFreeToolStripMenuItem.Click += new System.EventHandler(this.forceFreeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(168, 6);
            // 
            // setCustomColorToolStripMenuItem
            // 
            this.setCustomColorToolStripMenuItem.Name = "setCustomColorToolStripMenuItem";
            this.setCustomColorToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.setCustomColorToolStripMenuItem.Text = "Set Custom Color";
            this.setCustomColorToolStripMenuItem.Click += new System.EventHandler(this.setCustomColorToolStripMenuItem_Click);
            // 
            // blinkenlichtenToolStripMenuItem
            // 
            this.blinkenlichtenToolStripMenuItem.Name = "blinkenlichtenToolStripMenuItem";
            this.blinkenlichtenToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.blinkenlichtenToolStripMenuItem.Text = "Blinkenlichten!";
            this.blinkenlichtenToolStripMenuItem.Click += new System.EventHandler(this.blinkenlichtenToolStripMenuItem_Click);
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
            this.textBox1.Location = new System.Drawing.Point(11, 435);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(469, 89);
            this.textBox1.TabIndex = 4;
            // 
            // btnOff
            // 
            this.btnOff.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOff.Location = new System.Drawing.Point(131, 94);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(60, 27);
            this.btnOff.TabIndex = 5;
            this.btnOff.Text = "Off";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnOn
            // 
            this.btnOn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOn.Location = new System.Drawing.Point(14, 94);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(110, 27);
            this.btnOn.TabIndex = 6;
            this.btnOn.Text = "𝔅𝔩𝔦𝔠𝔨𝔢𝔫𝔩𝔦𝔠𝔥𝔱𝔢𝔫!";
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
            this.cmbPorts.DropDown += new System.EventHandler(this.cmbPorts_DropDown);
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
            this.label4.Location = new System.Drawing.Point(10, 417);
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
            this.lblColor.Location = new System.Drawing.Point(92, 267);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(32, 32);
            this.lblColor.TabIndex = 11;
            this.lblColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // btnSetCustom
            // 
            this.btnSetCustom.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetCustom.Location = new System.Drawing.Point(131, 267);
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
            this.lblWebcamColor.Location = new System.Drawing.Point(92, 138);
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
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Webcam";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 172);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Microphone";
            // 
            // lblMicColor
            // 
            this.lblMicColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMicColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMicColor.Location = new System.Drawing.Point(92, 170);
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
            this.label9.Size = new System.Drawing.Size(30, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Free";
            // 
            // lblFreeColor
            // 
            this.lblFreeColor.BackColor = System.Drawing.Color.Lime;
            this.lblFreeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFreeColor.Location = new System.Drawing.Point(92, 203);
            this.lblFreeColor.Name = "lblFreeColor";
            this.lblFreeColor.Size = new System.Drawing.Size(32, 32);
            this.lblFreeColor.TabIndex = 17;
            this.lblFreeColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 269);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Custom";
            // 
            // chkBlink
            // 
            this.chkBlink.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkBlink.Location = new System.Drawing.Point(216, 94);
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
            this.label5.Location = new System.Drawing.Point(11, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Blink";
            // 
            // lblBlinkColor
            // 
            this.lblBlinkColor.BackColor = System.Drawing.Color.Black;
            this.lblBlinkColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBlinkColor.Location = new System.Drawing.Point(92, 235);
            this.lblBlinkColor.Name = "lblBlinkColor";
            this.lblBlinkColor.Size = new System.Drawing.Size(32, 32);
            this.lblBlinkColor.TabIndex = 21;
            this.lblBlinkColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Location = new System.Drawing.Point(272, 12);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(83, 23);
            this.btnDisconnect.TabIndex = 23;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblsetBlinkColor
            // 
            this.lblsetBlinkColor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsetBlinkColor.Location = new System.Drawing.Point(130, 236);
            this.lblsetBlinkColor.Name = "lblsetBlinkColor";
            this.lblsetBlinkColor.Size = new System.Drawing.Size(109, 27);
            this.lblsetBlinkColor.TabIndex = 24;
            this.lblsetBlinkColor.Text = "Set Blink Color";
            this.lblsetBlinkColor.UseVisualStyleBackColor = true;
            this.lblsetBlinkColor.Click += new System.EventHandler(this.lblsetBlinkColor_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(427, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 23);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chkFade
            // 
            this.chkFade.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkFade.Location = new System.Drawing.Point(272, 94);
            this.chkFade.Name = "chkFade";
            this.chkFade.Size = new System.Drawing.Size(50, 27);
            this.chkFade.TabIndex = 26;
            this.chkFade.Text = "Fade";
            this.chkFade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkFade.UseVisualStyleBackColor = true;
            this.chkFade.CheckedChanged += new System.EventHandler(this.chkFade_CheckedChanged);
            // 
            // tbBlinkSpeed
            // 
            this.tbBlinkSpeed.Location = new System.Drawing.Point(246, 237);
            this.tbBlinkSpeed.Maximum = 5000;
            this.tbBlinkSpeed.Minimum = 10;
            this.tbBlinkSpeed.Name = "tbBlinkSpeed";
            this.tbBlinkSpeed.Size = new System.Drawing.Size(136, 45);
            this.tbBlinkSpeed.TabIndex = 27;
            this.tbBlinkSpeed.TickFrequency = 1000;
            this.tbBlinkSpeed.Value = 500;
            this.tbBlinkSpeed.Scroll += new System.EventHandler(this.tbBlinkSpeed_Scroll);
            // 
            // chkBlinkWebcam
            // 
            this.chkBlinkWebcam.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkBlinkWebcam.Location = new System.Drawing.Point(186, 140);
            this.chkBlinkWebcam.Name = "chkBlinkWebcam";
            this.chkBlinkWebcam.Size = new System.Drawing.Size(50, 27);
            this.chkBlinkWebcam.TabIndex = 28;
            this.chkBlinkWebcam.Text = "Blink";
            this.chkBlinkWebcam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBlinkWebcam.UseVisualStyleBackColor = true;
            this.chkBlinkWebcam.CheckedChanged += new System.EventHandler(this.chkBlinkWebcam_CheckedChanged_1);
            // 
            // chkBlinkMic
            // 
            this.chkBlinkMic.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkBlinkMic.Location = new System.Drawing.Point(186, 173);
            this.chkBlinkMic.Name = "chkBlinkMic";
            this.chkBlinkMic.Size = new System.Drawing.Size(50, 27);
            this.chkBlinkMic.TabIndex = 29;
            this.chkBlinkMic.Text = "Blink";
            this.chkBlinkMic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBlinkMic.UseVisualStyleBackColor = true;
            this.chkBlinkMic.CheckedChanged += new System.EventHandler(this.chkBlinkWebcam_CheckedChanged_1);
            // 
            // chkBlinkFree
            // 
            this.chkBlinkFree.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkBlinkFree.Location = new System.Drawing.Point(186, 206);
            this.chkBlinkFree.Name = "chkBlinkFree";
            this.chkBlinkFree.Size = new System.Drawing.Size(50, 27);
            this.chkBlinkFree.TabIndex = 30;
            this.chkBlinkFree.Text = "Blink";
            this.chkBlinkFree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBlinkFree.UseVisualStyleBackColor = true;
            this.chkBlinkFree.CheckedChanged += new System.EventHandler(this.chkBlinkWebcam_CheckedChanged_1);
            // 
            // tbBrightness
            // 
            this.tbBrightness.Location = new System.Drawing.Point(194, 300);
            this.tbBrightness.Maximum = 255;
            this.tbBrightness.Name = "tbBrightness";
            this.tbBrightness.Size = new System.Drawing.Size(297, 45);
            this.tbBrightness.TabIndex = 31;
            this.tbBrightness.TickFrequency = 5;
            this.tbBrightness.Value = 255;
            this.tbBrightness.Scroll += new System.EventHandler(this.tbBrightness_Scroll);
            // 
            // chkRainbow
            // 
            this.chkRainbow.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkRainbow.Location = new System.Drawing.Point(331, 94);
            this.chkRainbow.Name = "chkRainbow";
            this.chkRainbow.Size = new System.Drawing.Size(66, 27);
            this.chkRainbow.TabIndex = 32;
            this.chkRainbow.Text = "Rainbow";
            this.chkRainbow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkRainbow.UseVisualStyleBackColor = true;
            this.chkRainbow.CheckedChanged += new System.EventHandler(this.chkRainbow_CheckedChanged);
            // 
            // chkForceWebcam
            // 
            this.chkForceWebcam.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkForceWebcam.Location = new System.Drawing.Point(130, 140);
            this.chkForceWebcam.Name = "chkForceWebcam";
            this.chkForceWebcam.Size = new System.Drawing.Size(50, 27);
            this.chkForceWebcam.TabIndex = 33;
            this.chkForceWebcam.Text = "Force";
            this.chkForceWebcam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkForceWebcam.UseVisualStyleBackColor = true;
            this.chkForceWebcam.CheckedChanged += new System.EventHandler(this.chkForceWebcam_CheckedChanged);
            // 
            // chkForceMic
            // 
            this.chkForceMic.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkForceMic.Location = new System.Drawing.Point(130, 173);
            this.chkForceMic.Name = "chkForceMic";
            this.chkForceMic.Size = new System.Drawing.Size(50, 27);
            this.chkForceMic.TabIndex = 34;
            this.chkForceMic.Text = "Force";
            this.chkForceMic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkForceMic.UseVisualStyleBackColor = true;
            this.chkForceMic.CheckedChanged += new System.EventHandler(this.chkForceMic_CheckedChanged);
            // 
            // chkForceFree
            // 
            this.chkForceFree.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkForceFree.Location = new System.Drawing.Point(130, 206);
            this.chkForceFree.Name = "chkForceFree";
            this.chkForceFree.Size = new System.Drawing.Size(50, 27);
            this.chkForceFree.TabIndex = 35;
            this.chkForceFree.Text = "Force";
            this.chkForceFree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkForceFree.UseVisualStyleBackColor = true;
            this.chkForceFree.CheckedChanged += new System.EventHandler(this.chkForceFree_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(403, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // lblHeartbeat
            // 
            this.lblHeartbeat.AutoSize = true;
            this.lblHeartbeat.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeartbeat.Location = new System.Drawing.Point(361, 12);
            this.lblHeartbeat.Name = "lblHeartbeat";
            this.lblHeartbeat.Size = new System.Drawing.Size(31, 23);
            this.lblHeartbeat.TabIndex = 37;
            this.lblHeartbeat.Text = "♥";
            // 
            // tbBrightnessDebug
            // 
            this.tbBrightnessDebug.Location = new System.Drawing.Point(194, 351);
            this.tbBrightnessDebug.Maximum = 255;
            this.tbBrightnessDebug.Name = "tbBrightnessDebug";
            this.tbBrightnessDebug.Size = new System.Drawing.Size(297, 45);
            this.tbBrightnessDebug.TabIndex = 31;
            this.tbBrightnessDebug.TickFrequency = 5;
            this.tbBrightnessDebug.Value = 64;
            this.tbBrightnessDebug.Scroll += new System.EventHandler(this.tbBrightness_Scroll);
            // 
            // chkKuando
            // 
            this.chkKuando.AutoSize = true;
            this.chkKuando.Location = new System.Drawing.Point(194, 47);
            this.chkKuando.Name = "chkKuando";
            this.chkKuando.Size = new System.Drawing.Size(115, 19);
            this.chkKuando.TabIndex = 38;
            this.chkKuando.Text = "Kuando Enabled";
            this.chkKuando.UseVisualStyleBackColor = true;
            this.chkKuando.CheckedChanged += new System.EventHandler(this.chkKuando_CheckedChanged);
            // 
            // chkFadeFree
            // 
            this.chkFadeFree.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkFadeFree.Location = new System.Drawing.Point(242, 206);
            this.chkFadeFree.Name = "chkFadeFree";
            this.chkFadeFree.Size = new System.Drawing.Size(50, 27);
            this.chkFadeFree.TabIndex = 41;
            this.chkFadeFree.Text = "Pulse";
            this.chkFadeFree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkFadeFree.UseVisualStyleBackColor = true;
            this.chkFadeFree.CheckedChanged += new System.EventHandler(this.chkFadeFree_CheckedChanged);
            // 
            // chkFadeMic
            // 
            this.chkFadeMic.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkFadeMic.Location = new System.Drawing.Point(242, 173);
            this.chkFadeMic.Name = "chkFadeMic";
            this.chkFadeMic.Size = new System.Drawing.Size(50, 27);
            this.chkFadeMic.TabIndex = 40;
            this.chkFadeMic.Text = "Pulse";
            this.chkFadeMic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkFadeMic.UseVisualStyleBackColor = true;
            this.chkFadeMic.CheckedChanged += new System.EventHandler(this.chkFadeFree_CheckedChanged);
            // 
            // chkFadeWebcam
            // 
            this.chkFadeWebcam.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkFadeWebcam.Location = new System.Drawing.Point(242, 140);
            this.chkFadeWebcam.Name = "chkFadeWebcam";
            this.chkFadeWebcam.Size = new System.Drawing.Size(50, 27);
            this.chkFadeWebcam.TabIndex = 39;
            this.chkFadeWebcam.Text = "Pulse";
            this.chkFadeWebcam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkFadeWebcam.UseVisualStyleBackColor = true;
            this.chkFadeWebcam.CheckedChanged += new System.EventHandler(this.chkFadeFree_CheckedChanged);
            // 
            // kuandoForceTimer
            // 
            this.kuandoForceTimer.Tick += new System.EventHandler(this.kuandoForceTimer_Tick);
            // 
            // btnMediaPlayStop
            // 
            this.btnMediaPlayStop.Location = new System.Drawing.Point(14, 337);
            this.btnMediaPlayStop.Name = "btnMediaPlayStop";
            this.btnMediaPlayStop.Size = new System.Drawing.Size(91, 33);
            this.btnMediaPlayStop.TabIndex = 42;
            this.btnMediaPlayStop.Text = "play/stop";
            this.btnMediaPlayStop.UseVisualStyleBackColor = true;
            this.btnMediaPlayStop.Visible = false;
            this.btnMediaPlayStop.Click += new System.EventHandler(this.btnMediaPlayStop_Click);
            // 
            // chkStopMedia
            // 
            this.chkStopMedia.AutoSize = true;
            this.chkStopMedia.Checked = true;
            this.chkStopMedia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStopMedia.Location = new System.Drawing.Point(322, 47);
            this.chkStopMedia.Name = "chkStopMedia";
            this.chkStopMedia.Size = new System.Drawing.Size(88, 19);
            this.chkStopMedia.TabIndex = 43;
            this.chkStopMedia.Text = "Stop Media";
            this.chkStopMedia.UseVisualStyleBackColor = true;
            this.chkStopMedia.CheckedChanged += new System.EventHandler(this.chkStopMedia_CheckedChanged);
            // 
            // chkKuandoFallback
            // 
            this.chkKuandoFallback.AutoSize = true;
            this.chkKuandoFallback.Checked = true;
            this.chkKuandoFallback.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKuandoFallback.Location = new System.Drawing.Point(194, 69);
            this.chkKuandoFallback.Name = "chkKuandoFallback";
            this.chkKuandoFallback.Size = new System.Drawing.Size(118, 19);
            this.chkKuandoFallback.TabIndex = 44;
            this.chkKuandoFallback.Text = "Kuando Fallback";
            this.chkKuandoFallback.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 544);
            this.Controls.Add(this.chkKuandoFallback);
            this.Controls.Add(this.chkStopMedia);
            this.Controls.Add(this.btnMediaPlayStop);
            this.Controls.Add(this.chkFadeFree);
            this.Controls.Add(this.chkFadeMic);
            this.Controls.Add(this.chkFadeWebcam);
            this.Controls.Add(this.chkKuando);
            this.Controls.Add(this.lblHeartbeat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkForceFree);
            this.Controls.Add(this.chkForceMic);
            this.Controls.Add(this.chkForceWebcam);
            this.Controls.Add(this.chkRainbow);
            this.Controls.Add(this.tbBrightnessDebug);
            this.Controls.Add(this.tbBrightness);
            this.Controls.Add(this.chkBlinkFree);
            this.Controls.Add(this.chkBlinkMic);
            this.Controls.Add(this.chkBlinkWebcam);
            this.Controls.Add(this.tbBlinkSpeed);
            this.Controls.Add(this.chkFade);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblsetBlinkColor);
            this.Controls.Add(this.btnDisconnect);
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
            this.ShowInTaskbar = false;
            this.Text = "Busy Blinkenlichten";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbBlinkSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightnessDebug)).EndInit();
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
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button lblsetBlinkColor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chkFade;
        private System.Windows.Forms.TrackBar tbBlinkSpeed;
        private System.Windows.Forms.CheckBox chkBlinkWebcam;
        private System.Windows.Forms.CheckBox chkBlinkMic;
        private System.Windows.Forms.CheckBox chkBlinkFree;
        private System.Windows.Forms.TrackBar tbBrightness;
        private System.Windows.Forms.CheckBox chkRainbow;
        private System.Windows.Forms.CheckBox chkForceWebcam;
        private System.Windows.Forms.CheckBox chkForceMic;
        private System.Windows.Forms.CheckBox chkForceFree;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHeartbeat;
        private System.Windows.Forms.TrackBar tbBrightnessDebug;
        private System.Windows.Forms.CheckBox chkKuando;
        private System.Windows.Forms.CheckBox chkFadeFree;
        private System.Windows.Forms.CheckBox chkFadeMic;
        private System.Windows.Forms.CheckBox chkFadeWebcam;
        private System.Windows.Forms.Timer kuandoForceTimer;
        private System.Windows.Forms.Button btnMediaPlayStop;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem forceWebcamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceMicrophoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceFreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setCustomColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blinkenlichtenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.CheckBox chkStopMedia;
        private System.Windows.Forms.CheckBox chkKuandoFallback;
    }
}

