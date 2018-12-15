using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inicio
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        TCPIP.frmServer Server;
        frmClient.frmClient Client;

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Client.Show();
            Server.Show();
            this.Hide();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            Server = new TCPIP.frmServer();
            Client = new frmClient.frmClient();
        }
    }
}
