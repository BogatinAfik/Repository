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
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customer_button_Click(object sender, EventArgs e)
        {
            customersForm c = new customersForm();
            c.Show();
            this.Hide();
        }

        private void worker_button_Click(object sender, EventArgs e)
        {
            Employee_login el = new Employee_login();
            el.Show();
            this.Hide();
        }

        private void aboutus_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://kal-kar.co.il/about-the-company/");
        }
    }
}
