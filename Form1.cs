using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SerialComwithArduino
{
    public partial class Form1 : Form
    {
        int StartButtonState;

        public Form1()
        {
            InitializeComponent();
            int[] baudRates = { 9600, 19200, 38400, 57600, 115200 };
            foreach (int baudRate in baudRates)
            {
                comboBoxBaudRate.Items.Add(baudRate);
            }
        }

        private void comboBoxPort_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames(); //Get Port Names from Device Manager
            comboBoxPort.Items.Clear(); // Clear the ComboBox when clicked
            foreach (string port in ports)
            {
                comboBoxPort.Items.Add(port); // Add as a ComboBox item which Comport is avaiable
            }
        }



        private void SendButton_Click(object sender, EventArgs e)
        {
            string SendMessage = SendBox.Text;
            SendMessage += "\r\n";
            serialPort1.Write(SendMessage);
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string receivedData = serialPort1.ReadExisting();
            Inbox.BeginInvoke(new Action(() => Inbox.AppendText(receivedData)));
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Inbox.Clear();
        }

        private void StartComButton_Click(object sender, EventArgs e)
        {
            StartButtonState++;
            if (StartButtonState % 2 == 1)
            {
                serialPort1.PortName = comboBoxPort.Text;
                serialPort1.BaudRate = (int)comboBoxBaudRate.SelectedItem;
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), comboBoxParity.SelectedItem.ToString());
                serialPort1.Open();
                StartComButton.Text = "STOP COM";
            }
            else
            {
                serialPort1.Close();
                StartComButton.Text = "START COM";

            }
        }


    }
}
