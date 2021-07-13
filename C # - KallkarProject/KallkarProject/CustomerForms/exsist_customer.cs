using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace KallkarProject
{


    public partial class exsist_customer : Form
    {
        private Customer cus;
        public String temp;
        public exsist_customer(Customer c)
        {
            InitializeComponent();
            this.cus = c;
            ID_input.Text = this.cus.getID().ToString();
            ID_input.Enabled = false;
            First_Name_input.Text = this.cus.getFirstName().ToString();
            First_Name_input.Enabled = false;
            Last_Name_input.Text = this.cus.getLastName().ToString();
            Last_Name_input.Enabled = false;
            Phone_input.Text = this.cus.getPhone().ToString();
            Phone_input.Enabled = false;
            Email_input.Text = this.cus.getEmail().ToString();
            Email_input.Enabled = false;
            Birthday_input.Text = this.cus.getDob().ToString();
            Birthday_input.Enabled = false;
            Address_input.Text = this.cus.getAddress().ToString();
            Address_input.Enabled = false;
            Gender_input.Text = this.cus.getGender().ToString();
            Gender_input.Enabled = false;
            Type_input.Text = this.cus.GetType().ToString();
            Type_input.Enabled = false;




        }



        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void New_Order(object sender, EventArgs e)
        {
            makeNewOrder v = new makeNewOrder(cus,null);
            v.Show();
            this.Hide();
        }


        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }






        private void update_customer_information_Click(object sender, EventArgs e)
        {

            update_customer_information f = new update_customer_information(cus);
            f.Show();
            this.Hide();
        }



        private void ID_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Last_Name_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Phone_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Birthday_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Address_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gender_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Type_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void First_Name_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Old_Orders_Click(object sender, EventArgs e)
        {

        }

        private void UpdateOrder_Click(object sender, EventArgs e)
        {
            MyOrders_ForUpdate my = new MyOrders_ForUpdate(cus);
            my.Show();
            this.Hide();
        }

        private void home_page_button_Click(object sender, EventArgs e)
        {
            main_form mf = new main_form();
            mf.Show();
            this.Hide();
        }
    }



}
