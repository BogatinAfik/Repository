using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KallkarProject
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void Generate_Shipment_Report_Click(object sender, EventArgs e)
        {
            Shipment_Report SR = new Shipment_Report();
            SR.Show();

        }
    }
}

