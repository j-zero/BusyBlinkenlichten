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

namespace BusyBlinkenlichten
{
    public partial class Form1 : Form
    {


        private delegate void SetTextDeleg(string text);

        DeviceUsageDetection deviceUsageDetection;
        SerialPort serialPort;
        bool allowExit = false;
        public Form1()
        {
            InitializeComponent();
            deviceUsageDetection = new DeviceUsageDetection();
            deviceUsageDetection.DeviceUsageDetected += DeviceUsageDetection_DeviceUsageDetected;
            RefreshPorts();

            SystemEvents.PowerModeChanged += SystemEvents_PowerModeChanged;
            SystemEvents.SessionSwitch += SystemEvents_SessionSwitch;
        }

        private void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
        {
            switch (e.Reason)
            {
                case SessionSwitchReason.SessionLock:
                case SessionSwitchReason.SessionLogoff:
                    SetColorRGB(0, 0, 0);
                    break;
                case SessionSwitchReason.SessionUnlock:
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
                    break;
                case PowerModes.Resume:
                    Blinkenlichten();
                    break;
            }
        }

        void RefreshPorts()
        {
            cmbPorts.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            cmbPorts.Items.AddRange(ports);
            if(ports.Length > 0)
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

            }
            this.BeginInvoke(new SetTextDeleg(DataReceivedCallback), new object[] { data });
        }

        private void DataReceivedCallback(string data) {
            textBox1.AppendText(data.Trim() + Environment.NewLine);
        }

        private void Blinkenlichten()
        {
            lblMicrophoneUsage.Text = deviceUsageDetection.IsMicrophoneInUse.ToString();
            lblWebcamUsage.Text = deviceUsageDetection.IsWebcamInUse.ToString();

            if (deviceUsageDetection.IsWebcamInUse)
            {
                SetColor(lblWebcamColor.BackColor);
                SetFade(chkBlinkWebcam.Checked, 5);
                //SetBlink(true, 500);
            }
            else if (deviceUsageDetection.IsMicrophoneInUse)
            {
                SetColor(lblMicColor.BackColor);
                SetFade(chkBlinkMic.Checked, 5);
                //SetBlink(false, 500);
            }
            else
            {
                SetColor(lblFreeColor.BackColor);
                SetFade(chkBlinkFree.Checked, 5);
                //SetBlink(false, 500);
            }
            
        }

        void SetColor(Color color)
        {
            SerialSendBytes(new byte[] { 0x01, color.R, color.G, color.B });
        }

        void SetColorBlinkColor(Color color)
        {
            SerialSendBytes(new byte[] { 0x04, color.R, color.G, color.B });
        }


        void SetColorRGB(byte r, byte g, byte b)
        {
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
        void SerialSendBytes(byte[] bytes)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Write(bytes, 0x00, bytes.Length);
                System.Threading.Thread.Sleep(10);
            }
        }

        private void DeviceUsageDetection_DeviceUsageDetected()
        {
            Blinkenlichten();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            SetColorRGB(0, 0, 0);
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            Blinkenlichten();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            serialPort = new SerialPort(cmbPorts.Text, 115200);
            serialPort.Open();
            serialPort.DataReceived += SerialPort_DataReceived;
            Blinkenlichten();
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

        private void button1_Click(object sender, EventArgs e)
        {
            SetColorRGB(0, 0, 0);
            serialPort.Close();
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
    }
}
