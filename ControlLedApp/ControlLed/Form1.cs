using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLed
{
    public partial class Form1 : Form
    {
        public static byte[] data = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        byte[] buf = new byte[] { 7 };
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] port = SerialPort.GetPortNames();
            cbPortName.Items.AddRange(port);
            btDisconnet.Enabled = false;
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbPortName.Text)
                || string.IsNullOrEmpty(cbPortBaud.Text)
                || string.IsNullOrEmpty(cbParity.Text)
                || string.IsNullOrEmpty(cbDataSize.Text)
                || string.IsNullOrEmpty(cbStopBits.Text)
                )
            {
                tbMessage.Text += "Please complete setting!" + Environment.NewLine;
            }
            else
            {
                serialPort1.PortName = cbPortName.SelectedItem.ToString();
                serialPort1.BaudRate = int.Parse(cbPortBaud.SelectedItem.ToString());
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cbParity.SelectedItem.ToString(), true);
                serialPort1.DataBits = int.Parse(cbDataSize.SelectedItem.ToString());
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbStopBits.SelectedItem.ToString(), true);

                // Set the read/write timeouts
                serialPort1.ReadTimeout = 1500;
                serialPort1.WriteTimeout = 500;

                try
                {
                    serialPort1.Open();
                    if (serialPort1.IsOpen)
                    {
                        tbMessage.Text += "Open " + cbPortName.SelectedItem.ToString() + Environment.NewLine;
                        cbPortName.Enabled = false;
                        cbPortBaud.Enabled = false;
                        cbDataSize.Enabled = false;
                        cbParity.Enabled = false;
                        cbStopBits.Enabled = false;
                        btDisconnet.Enabled = true;
                        btConnect.Enabled = false;
                    }
                }
                catch (IOException ioe)
                {
                    tbMessage.Text += "Error " + ioe.ToString() + Environment.NewLine;
                }
            }
        }

        private void btDisconnet_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            tbMessage.Text += "Close " + cbPortName.SelectedItem.ToString() + Environment.NewLine;
            cbPortName.Enabled = true;
            cbPortBaud.Enabled = true;
            cbDataSize.Enabled = true;
            cbParity.Enabled = true;
            cbStopBits.Enabled = true;
            btConnect.Enabled = true;
            btDisconnet.Enabled = false;
        }

        private void btLed1On_MouseClick(object sender, MouseEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write(data, 0, 1);
                }
                catch (TimeoutException)
                {
                    tbMessage.Text += "Write timeout" + Environment.NewLine;
                }

                try
                {
                    //serialPort1.Read(buf, 0, 1);
                    var receive1 = serialPort1.ReadByte();
                    string receive = serialPort1.ReadExisting();
                    tbMessage.Text += "Receive " + receive + Environment.NewLine;
                }
                catch (TimeoutException)
                {
                    tbMessage.Text += "Read timeout value = " + buf[0]    + Environment.NewLine;
                }
            }
            else
            {
                tbMessage.Text += "Com isn't connecting" + Environment.NewLine;
            }
        }

    }
}
