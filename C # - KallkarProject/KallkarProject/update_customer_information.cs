using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KallkarProject
{
    public partial class update_customer_information : KallkarProject.create_new_order
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
            dob.Text = this.cus.getDob().ToString();
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
            string dt = dob.Value.ToString();
            Customer nc = Program.seeCustomer(cus.getID());
            nc.setfistName(FIrst_Name.Text);
            nc.setlastName(last_name_input.Text);
            nc.setphone(phone_input.Text);
            nc.setEmail(Email_input.Text);
            nc.setDob(DateTime.Parse(dt));
            nc.setAddress(Address_Input.Text);
            nc.setPassword(Passwprd_input.Text);
            nc.setGender((Gender)Enum.Parse(typeof(Gender), Gender_input.Text));
            nc.setType((customerType)Enum.Parse(typeof(customerType), Type_input.Text));



            nc.Update_Customer();

            /* if (FIrst_Name.Text != "")
             {


             }
             if (last_name_input.Text != "")
             {
                 nc.setlastName(last_name_input.Text);
                 nc.Update_Customer();
             }
             if (Email_input.Text != "")
             {
                 nc.setEmail(Email_input.Text);
                 nc.Update_Customer();
             }*/


            //PersonalDetails p = new PersonalDetails(nc);
            //p.Show();
            //this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dob_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}