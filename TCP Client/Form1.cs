using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;

namespace TCP_Client_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;
        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            textBox_messageRecv.Invoke((MethodInvoker)delegate ()
            {
                textBox_messageRecv.Text += e.MessageString;
            });
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            button_connect.Enabled = false;
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(textBox_ipAddress.Text);
            client.Connect(textBox_ipAddress.Text, Convert.ToInt32(textBox_port.Text));
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            client.WriteLine(textBox_message.Text);
        }
    }
}
