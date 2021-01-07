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
            serialPort = new SerialPort("COM5", 115200);
            serialPort.Open();
            serialPort.DataReceived += SerialPort_DataReceived;
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();
            this.BeginInvoke(new SetTextDeleg(DataReceivedCallback), new object[] { data });
        }

        private void DataReceivedCallback(string data) { 
            textBox1.Text = data.Trim(); 
        }

        private void Blinkenlichten()
        {
            lblMicrophoneUsage.Text = deviceUsageDetection.IsMicrophoneInUse.ToString();
            lblWebcamUsage.Text = deviceUsageDetection.IsWebcamInUse.ToString();
            if (serialPort.IsOpen)
            {
                if (deviceUsageDetection.IsWebcamInUse)
                {
                    serialPort.Write(new byte[] { 0x00, 0x00, 0xff, 0xff }, 0x00, 0x04);
                }
                else if (deviceUsageDetection.IsMicrophoneInUse)
                {
                    serialPort.Write(new byte[] { 0x00, 0x40, 0xff, 0xff }, 0x00, 0x04);
                }
                else
                {
                    serialPort.Write(new byte[] { 0x00, 0x60, 0xff, 0xff }, 0x00, 0x04);
                }
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
    }
}
