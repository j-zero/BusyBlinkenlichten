using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Busylight;

namespace BusyBlinkenlichten
{
    public partial class Form1 : Form
    {


        private delegate void SetTextDeleg(string text);

        Busylight.KuandoSDK kuando = new KuandoSDK("BusyBlinkenlichten");
        

        DeviceUsageDetection deviceUsageDetection;
        SerialPort serialPort;
        bool allowExit = false;
        bool heartbeat = false;
        bool AllowDisplay = true;

        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(AllowDisplay ? value : AllowDisplay);
        }

        public Form1()
        {
            InitializeComponent();
            deviceUsageDetection = new DeviceUsageDetection();
            deviceUsageDetection.DeviceUsageDetected += DeviceUsageDetection_DeviceUsageDetected;
             
           

            SystemEvents.PowerModeChanged += SystemEvents_PowerModeChanged;
            SystemEvents.SessionSwitch += SystemEvents_SessionSwitch;

            this.Text = "Busy𝔅𝔩𝔦𝔠𝔨𝔢𝔫𝔩𝔦𝔠𝔥𝔱𝔢𝔫!";
        }


        private void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
        {
            switch (e.Reason)
            {
                case SessionSwitchReason.SessionLock:
                case SessionSwitchReason.SessionLogoff:
                    SetColorRGB(0, 0, 0);
                    kuando.Off();
                    break;
                case SessionSwitchReason.SessionUnlock:
                    Connect();
                    Blinkenlichten();
                    break;

            }
        }

        private void SystemEvents_PowerModeChanged(object sender, PowerModeChangedEventArgs e)
        {
            switch (e.Mode)
            {
                case PowerModes.Suspend:
                    SetColorRGB(0, 0, 0);
                    kuando.Off();
                    break;
                case PowerModes.Resume:
                    Connect();
                    Blinkenlichten();
                    break;
            }
        }

        void RefreshPorts()
        {
            cmbPorts.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            cmbPorts.Items.AddRange(ports);
            if (ports.Length > 0)
                cmbPorts.SelectedIndex = 0;

        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = "Error";
            try
            {
                data = serialPort.ReadLine();
            }
            catch
            {
                WriteLog("(E) Cannot read line from serial port!");
            }
            if(!data.StartsWith("heartbeat"))
                this.BeginInvoke(new SetTextDeleg(WriteLog), new object[] { data });
            else
            {
                this.heartbeat = !this.heartbeat;
                lblHeartbeat.ForeColor = this.heartbeat ? Color.Red : Color.Black;
            }
        }

        private void WriteLog(string data) {
            textBox1.AppendText(data.Trim() + Environment.NewLine);
        }

        private bool Connect()
        {
            try
            {
                if (serialPort == null)
                {
                    serialPort = new SerialPort(cmbPorts.Text, 115200);
                }
                else
                {
                    if (serialPort.IsOpen)
                        return serialPort.IsOpen;
                }
                serialPort.Open();
                serialPort.DtrEnable = true;
                serialPort.RtsEnable = true;
                serialPort.DataReceived += SerialPort_DataReceived;
                Blinkenlichten();
                btnDisconnect.Enabled = true;
                btnConnect.Enabled = false;
                return serialPort.IsOpen;
            }
            catch(Exception ex)
            {
                WriteLog(ex.Message);
            }
            return false;
        }

        private void Blinkenlichten()
        {
            lblMicrophoneUsage.Text = deviceUsageDetection.IsMicrophoneInUse.ToString();
            lblWebcamUsage.Text = deviceUsageDetection.IsWebcamInUse.ToString();
            if (!chkForceFree.Checked)
            {
                if (deviceUsageDetection.IsWebcamInUse || chkForceWebcam.Checked)
                {
                    SetColor(lblWebcamColor.BackColor);

                    if (chkBlinkWebcam.Checked) {
                        SetBlink(chkBlinkWebcam.Checked, tbBlinkSpeed.Value);
                        if (chkKuando.Checked)
                            kuando.Blink(lblWebcamColor.BackColor.R, lblWebcamColor.BackColor.B, lblWebcamColor.BackColor.G, 5, 5);
                    }
                    else if (chkFadeWebcam.Checked){
                        SetFade(chkFadeWebcam.Checked, 3);
                        if (chkKuando.Checked)
                            kuando.Pulse(lblWebcamColor.BackColor.R, lblWebcamColor.BackColor.B, lblWebcamColor.BackColor.G);
                    }
                    else {
                        SetBlink(false, 5);
                        SetFade(false, 5);
                        if (chkKuando.Checked)
                            kuando.Light(lblWebcamColor.BackColor.R, lblWebcamColor.BackColor.B, lblWebcamColor.BackColor.G);
                    }
                    
                    
                }
                else if (deviceUsageDetection.IsMicrophoneInUse || chkForceMic.Checked)
                {
                    SetColor(lblMicColor.BackColor);

                    if (chkBlinkMic.Checked) {
                        SetBlink(chkBlinkMic.Checked, tbBlinkSpeed.Value);
                        if (chkKuando.Checked) 
                            kuando.Blink(lblMicColor.BackColor.R, lblMicColor.BackColor.B, lblMicColor.BackColor.G, 5, 5);
                    }
                    else if (chkFadeMic.Checked){
                        SetFade(chkFadeMic.Checked, 3);
                        if (chkKuando.Checked) 
                            kuando.Pulse(lblMicColor.BackColor.R, lblMicColor.BackColor.B, lblMicColor.BackColor.G);
                    }
                    else {
                        SetBlink(false, 5);
                        SetFade(false, 5);
                        if (chkKuando.Checked) 
                            kuando.Light(lblMicColor.BackColor.R, lblMicColor.BackColor.B, lblMicColor.BackColor.G);
                    }
                    
                    
                }
                else
                {
                    SetColor(lblFreeColor.BackColor);
                    if (chkBlinkFree.Checked)
                    {
                        SetBlink(chkBlinkFree.Checked, tbBlinkSpeed.Value);
                        if (chkKuando.Checked)
                            kuando.Blink(lblFreeColor.BackColor.R, lblFreeColor.BackColor.B, lblFreeColor.BackColor.G, 5, 5);
                    }
                    else if (chkFadeFree.Checked)
                    {
                        SetFade(chkFadeFree.Checked, 3);
                        if (chkKuando.Checked)
                            kuando.Pulse(lblFreeColor.BackColor.R, lblFreeColor.BackColor.B, lblFreeColor.BackColor.G);
                    }
                    else
                    {
                        SetBlink(false, 5);
                        SetFade(false, 5);
                        if (chkKuando.Checked)
                            kuando.Light(lblFreeColor.BackColor.R, lblFreeColor.BackColor.B, lblFreeColor.BackColor.G);
                    }

                }
            }
            else
            {
                SetColor(lblFreeColor.BackColor);
                if (chkBlinkFree.Checked)
                {
                    SetBlink(chkBlinkFree.Checked, tbBlinkSpeed.Value);
                    if (chkKuando.Checked)
                        kuando.Blink(lblFreeColor.BackColor.R, lblFreeColor.BackColor.B, lblFreeColor.BackColor.G, 5, 5);
                }
                else if (chkFadeFree.Checked)
                {
                    SetFade(chkFadeFree.Checked, 3);
                    if (chkKuando.Checked)
                        kuando.Pulse(lblFreeColor.BackColor.R, lblFreeColor.BackColor.B, lblFreeColor.BackColor.G);
                }
                else
                {
                    SetBlink(false, 5);
                    SetFade(false, 5);
                    if (chkKuando.Checked)
                        kuando.Light(lblFreeColor.BackColor.R, lblFreeColor.BackColor.B, lblFreeColor.BackColor.G);
                }


            }



        }

        void SetColor(Color color)
        {
            SetColorRGB(color.R, color.G, color.B);
        }

        void SetColorBlinkColor(Color color)
        {
            SerialSendBytes(new byte[] { 0x04, color.R, color.G, color.B });
        }


        void SetColorRGB(byte r, byte g, byte b)
        {
            Image col = ImageManipulation.ReplaceColor(Properties.Resources.sirene_color, Color.Magenta, Color.FromArgb(r,g,b));
            pictureBox1.Image = ImageManipulation.MatrixBlend(col, Properties.Resources.sirene_white, 1.0f);
            SetFormIcon(pictureBox1.Image);
            SerialSendBytes(new byte[] { 0x01, r, g, b });
        }

        void SetColorHSV(byte h, byte s, byte v)
        {
            SerialSendBytes(new byte[] { 0x00, h, s, v });
        }

        void SetBlink(bool On, int Speed)
        {
            // 0x02 = Blink, 0x00/0x01 = Blink On/Off, 0x01 << 8 + 0xF4 = 500ms; 
            byte OnOff = On ? (byte)0x01 : (byte)0x00;
            byte speedUpper = (byte)((Speed & 0xFF00) >> 8);
            byte speedLower = (byte)(Speed & 0xFF);
            SerialSendBytes(new byte[] { 0x02, OnOff, speedUpper, speedLower });
        }
        void SetFade(bool On, byte Delay)
        {
            byte OnOff = On ? (byte)0x01 : (byte)0x00;
            SerialSendBytes(new byte[] { 0x05, OnOff, Delay, 0x00 });
        }
        void SetRainbow(bool On, byte Delay)
        {
            byte OnOff = On ? (byte)0x01 : (byte)0x00;
            SerialSendBytes(new byte[] { 0x06, OnOff, Delay, 0x00 });
        }

        void SetSettings(byte MaxBrightness, byte MaxBrightnessDebug)
        {
            SerialSendBytes(new byte[] { 0xF0, MaxBrightness, MaxBrightnessDebug, 0x00 });
        }

        void SerialSendBytes(byte[] bytes)
        {
            try
            {
                if (serialPort != null && serialPort.IsOpen)
                {
                    serialPort.Write(bytes, 0x00, bytes.Length);
                    System.Threading.Thread.Sleep(10);
                }
            }
            catch(Exception ex)
            {
                WriteLog("(E) " + ex.Message);
            }
        }

        private void SetFormIcon(Image img)
        {
            Bitmap b = (Bitmap)img;
            IntPtr pIcon = b.GetHicon();
            Icon i = Icon.FromHandle(pIcon);
            this.Icon = i;
            notifyIcon1.Icon = i;
            i.Dispose();
        }



        private void DeviceUsageDetection_DeviceUsageDetected()
        {
            Blinkenlichten();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshPorts();
            Connect();
            Blinkenlichten();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = !allowExit;
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Normal;
            this.Show();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            SetColor(Color.Black);
            if (chkKuando.Checked)
                kuando.Off();
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            Blinkenlichten();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void btnSetCustom_Click(object sender, EventArgs e)
        {
            
            SetColor(lblColor.BackColor);
        }

        private void lblColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = ((Label)sender).BackColor;
            colorDialog.ShowDialog();
            ((Label)sender).BackColor = colorDialog.Color;
            Blinkenlichten();
        }

        private void chkBlink_CheckedChanged(object sender, EventArgs e)
        {
            
            SetBlink(chkBlink.Checked, 500);

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                SetColor(Color.Black);
                serialPort.Close();
                btnDisconnect.Enabled = false;
                btnConnect.Enabled = true;
                this.heartbeat = false;
                lblHeartbeat.ForeColor = this.heartbeat ? Color.Red : Color.Black;
            }
            catch
            {

            }
        }

        private void lblsetBlinkColor_Click(object sender, EventArgs e)
        {
            SetColorBlinkColor(lblBlinkColor.BackColor);
        }

        void Exit()
        {
            allowExit = true;
            SetColorRGB(0, 0, 0);
            if (serialPort != null && serialPort.IsOpen)
                serialPort.Close();
            kuando.Off();
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void chkFade_CheckedChanged(object sender, EventArgs e)
        {
            SetFade(chkFade.Checked, 0x5);
        }

        private void tbBlinkSpeed_Scroll(object sender, EventArgs e)
        {
            SetBlink(chkBlink.Checked, tbBlinkSpeed.Value);
        }

        private void chkBlinkWebcam_CheckedChanged_1(object sender, EventArgs e)
        {
            Blinkenlichten();
        }

        private void tbBrightness_Scroll(object sender, EventArgs e)
        {
            SetSettings((byte)tbBrightness.Value, (byte)tbBrightnessDebug.Value);
        }

        private void chkRainbow_CheckedChanged(object sender, EventArgs e)
        {
            SetRainbow(chkRainbow.Checked, 50);
        }

        private void cmbPorts_DropDown(object sender, EventArgs e)
        {
            RefreshPorts();
        }

        private void chkForceWebcam_CheckedChanged(object sender, EventArgs e)
        {
            Blinkenlichten();
        }

        private void chkForceMic_CheckedChanged(object sender, EventArgs e)
        {
            Blinkenlichten();
        }

        private void chkForceFree_CheckedChanged(object sender, EventArgs e)
        {
            Blinkenlichten();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            
        }

        private void chkFadeFree_CheckedChanged(object sender, EventArgs e)
        {
            Blinkenlichten();
        }

        private void chkKuando_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkKuando.Checked)
                kuando.Off();
            else
                Blinkenlichten();
        }
    }
}
