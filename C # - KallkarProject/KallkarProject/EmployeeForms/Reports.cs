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
        private Employee employee;
        public Reports(Employee e)
        {
            InitializeComponent();
            this.employee = e;
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void Generate_Shipment_Report_Click(object sender, EventArgs e)
        {
            Shipment_Report SR = new Shipment_Report();
            SR.Show();

        }

        private void Generate_Production_Report_Click(object sender, EventArgs e)
        {
            MakeProductionReport pr = new MakeProductionReport(employee);
            pr.Show();
            this.Hide();

        }

        private void back_button1_Click(object sender, EventArgs e)
        {
            Employee_Menu em = new Employee_Menu(employee);
            em.Show();
            this.Hide();
        }
    }
}

