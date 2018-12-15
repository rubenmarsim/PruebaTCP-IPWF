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

namespace frmClient
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        SimpleTcpClient Client;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            Client = new SimpleTcpClient();
            Client.StringEncoder = Encoding.UTF8;
            Client.DataReceived += Client_DataReceived;
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtBoxStatus.Invoke((MethodInvoker)delegate ()
            {
                txtBoxStatus.Text += e.MessageString;
            });
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Client.WriteLineAndGetReply(txtBoxMessage.Text, TimeSpan.FromSeconds(3));
        }
    }
}
