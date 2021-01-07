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

        public Form1()
        {
            InitializeComponent();
            deviceUsageDetection = new DeviceUsageDetection();
            deviceUsageDetection.DeviceUsageDetected += DeviceUsageDetection_DeviceUsageDetected;
            RefreshPorts();
        }
        void RefreshPorts()
        {
            cmbPorts.Items.Clear();
            cmbPorts.Items.AddRange(SerialPort.GetPortNames());
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
            textBox1.Text = data.Trim(); 
        }

        private void Blinkenlichten()
        {
            lblMicrophoneUsage.Text = deviceUsageDetection.IsMicrophoneInUse.ToString();
            lblWebcamUsage.Text = deviceUsageDetection.IsWebcamInUse.ToString();

            

            if (deviceUsageDetection.IsWebcamInUse)
            {
                SetColor(lblWebcamColor.BackColor);
                //SetColorHSV(0, 255, 255);
            }
            else if (deviceUsageDetection.IsMicrophoneInUse)
            {
                SetColor(lblMicColor.BackColor);
                //SetColorHSV(32, 255, 255);
            }
            else
            {
                SetColor(lblFreeColor.BackColor);
                //SetColorHSV(96, 255, 255);
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

        void SerialSendBytes(byte[] bytes)
        {
            if (serialPort != null && serialPort.IsOpen)
                serialPort.Write(bytes, 0x00, bytes.Length);
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
            e.Cancel = true;
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
            // 0x02 = Blink, 0x00/0x01 = Blink On/Off, 0x01 << 8 + 0xF4 = 500ms; 
            // On
            byte OnOff = chkBlink.Checked ? (byte)0x01 : (byte)0x00;
            SerialSendBytes(new byte[] { 0x02, OnOff, 0x01, 0xF4 });

        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort.Close();
        }

        private void lblsetBlinkColor_Click(object sender, EventArgs e)
        {
            SetColorBlinkColor(lblBlinkColor.BackColor);
        }

        void Exit()
        {
            SetColorRGB(0, 0, 0);
            if (serialPort.IsOpen)
                serialPort.Close();
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }
    }
}
