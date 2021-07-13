using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KallkarProject
{
    public partial class update_customer_information : Form
    {
        private Customer cus;
        public update_customer_information(Customer c)
        {
            InitializeComponent();
            this.cus = c;
            FIrst_Name.Text = this.cus.getFirstName().ToString();
            last_name_input.Text = this.cus.getLastName().ToString();
            phone_input.Text = this.cus.getPhone().ToString();
            Email_input.Text = this.cus.getEmail().ToString();
            //dob.Text = this.cus.getDob().ToString();
            Address_Input.Text = this.cus.getAddress().ToString();
            Gender_input.Text = this.cus.getGender().ToString();
            Type_input.Text = this.cus.getGender().ToString();
            Passwprd_input.Text = this.cus.getPassword().ToString();
            Gender_input.DataSource = Enum.GetValues(typeof(Gender));
            Type_input.DataSource = Enum.GetValues(typeof(customerType));
        }
        private void update_customer_information_Load(object sender, EventArgs e)
        {

        }
        private void FIrst_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void last_name_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_input_TextChanged(object sender, EventArgs e)
        {

        }



        private void Address_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gender_input_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Type_input_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Passwprd_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            if (checkDetails() == true)
            {
                Customer nc = Program.seeCustomer(cus.getID());
                nc.setfistName(FIrst_Name.Text);
                nc.setlastName(last_name_input.Text);
                nc.setphone(phone_input.Text);
                nc.setEmail(Email_input.Text);
                // nc.setDob(DateTime.Parse(dt));
                nc.setAddress(Address_Input.Text);
                nc.setPassword(Passwprd_input.Text);
                nc.setGender((Gender)Enum.Parse(typeof(Gender), Gender_input.Text));
                nc.setType((customerType)Enum.Parse(typeof(customerType), Type_input.Text));
                nc.Update_Customer();
                MessageBox.Show("your update succeeded!");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            exsist_customer ec = new exsist_customer(cus);
            ec.Show();
            this.Hide();
        }

        private void dob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private bool checkDetails()
        {

            if (FIrst_Name.Text == "")
            {
                MessageBox.Show("please input first name!");
                return false;
            }
            if (last_name_input.Text == "")
            {
                MessageBox.Show("please input last name!");
                return false;
            }
            if (phone_input.Text == "")
            {
                MessageBox.Show("please input phone number!");
                return false;
            }
            if (phone_input.Text.Length != 10)
            {
                MessageBox.Show("please input 10 digits phone number!");
                return false;
            }
            if (Email_input.Text == "")
            {
                MessageBox.Show("please input an email!");
                return false;
            }
            if (!(Email_input.Text.Contains("@")))
            {
                MessageBox.Show("please input an email address with @!");
                return false;
            }
            if (Address_Input.Text == "")
            {
                MessageBox.Show("please input an address!");
                return false;
            }
            if (!(Address_Input.Text.Contains("North")) && !(Address_Input.Text.Contains("South") && !(Address_Input.Text.Contains("Center"))))
            {
                MessageBox.Show("must contain North/Center/South in address");
                return false;
            }
            if (Passwprd_input.Text == "")
            {
                MessageBox.Show("please input password!");
                return false;
            }
            if (Passwprd_input.Text.Length > 8)
            {
                MessageBox.Show("please input less than 9 digits to password!");
                return false;
            }

            return true;
        }
    }
}