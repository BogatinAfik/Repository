using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KallkarProject
{
    public partial class customersForm : Form
    {
        public customersForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newCustomer_Click(object sender, EventArgs e) //newCustomer
        {
            new_customer n = new new_customer();
            n.Show();
            this.Hide();
        }


         private void existCustomer_Click(object sender, EventArgs e)
        {
            login f = new login();
            f.Show();
            this.Hide();
        }
    }
}
