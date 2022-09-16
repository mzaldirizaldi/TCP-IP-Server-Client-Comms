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


namespace TCP_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;
        private void button_start_Click(object sender, EventArgs e)
        {
            listBox_log.Items.Add("Server starting...");
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(textBox_ipAddress.Text);
            server.Start(ip, Convert.ToInt32(textBox_port.Text));
            button_start.Enabled = false;
            button_stop.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            listBox_log.Invoke((MethodInvoker)delegate ()
            {
                listBox_log.Text += e.MessageString;
                e.ReplyLine(string.Format("Message sent: {0}\n", e.MessageString));

                listBox_log.Items.Add(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + " : " + e.MessageString.ToString());
                listBox_log.SelectedIndex = listBox_log.Items.Count - 1;
                listBox_log.SelectedIndex = -1;
            });
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            if(server.IsStarted)
            {
                server.Stop();
                button_start.Enabled = true;
                button_stop.Enabled = false;
            }

        }
    }
}
