using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPIP
{
    public partial class frmServer : Form
    {
        public frmServer()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;
        System.Net.IPAddress ip;

        private void frmServer_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13; //enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtBoxStatus.Invoke((MethodInvoker)delegate ()
            {
                txtBoxStatus.Text += e.MessageString;
                e.ReplyLine(string.Format("You said: {0}", e.MessageString));
            });

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtBoxStatus.Text += "Server Starting...";
            //long hola = long.Parse(txtBoxHost.Text);
            //ip = new System.Net.IPAddress(hola);
            ip = new System.Net.IPAddress(long.Parse(txtBoxHost.Text));
            //ip = new System.Net.IPAddress((long)txtBoxHost.Text);
            server.Start(ip, Convert.ToInt32(txtBoxPort.Text));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (server.IsStarted) server.Stop();
        }
    }
}
