using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterpriseWcfClient
{
    public partial class Form1 : Form
    {
        MsmqEnterpriseContractClient client = new MsmqEnterpriseContractClient("MsmqEnterpriseService");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.TellTheTime();
        }
    }
}
