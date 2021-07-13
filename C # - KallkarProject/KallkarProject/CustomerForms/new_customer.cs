using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KallkarProject
{
    public partial class new_customer : Form
    {
       // private Customer new_Customer;
        public new_customer()
        {
            InitializeComponent();
            succeeded_button.Hide();
            gender.DataSource = Enum.GetValues(typeof(Gender));//אתחול הקומבובוקס
            type.DataSource = Enum.GetValues(typeof(customerType));
           
        }

        private void new_customer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void new_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            string dt = dateTimePicker1.Value.ToString();
            if (checkDetails() == true){

                Customer new_Customer = new Customer(new_id.Text, new_fname.Text, new_lname.Text, new_phone.Text, new_email.Text, DateTime.Parse(dt), new_address.Text, new_password.Text, (Gender)Enum.Parse(typeof(Gender), gender.Text), (customerType)Enum.Parse(typeof(customerType), type.Text));
                Program.Customers.Add(new_Customer);
                new_Customer.create_Customer();
                succeeded_button.Show();
               
          
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            customersForm cf = new customersForm();
            cf.Show();
            this.Hide();
        }

        private void succeeded_button_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }
        private bool checkDetails()
        {
            if (new_id.Text == "" && new_id.Text.Length!= 9)
            {
                MessageBox.Show("please input your ID!");
                return false;
            }
            if (Program.seeCustomer(new_id.Text) != null)
            {
                MessageBox.Show("customer id is already exsist, please choose other id");
                return false;
            }
            if (new_fname.Text == "")
            {
                MessageBox.Show("please input first name!");
                return false;
            }
            if (new_lname.Text == "")
            {
                MessageBox.Show("please input last name!");
                return false;
            }
            if (new_phone.Text == "")
            {
                MessageBox.Show("please input phone number!");
                return false;
            }
            if (new_phone.Text.Length != 10)
            {
                MessageBox.Show("please input 10 digits phone number!");
                return false;
            }
            if (new_email.Text == "")
            {
                MessageBox.Show("please input an email!");
                return false;
            }
            if (!(new_email.Text.Contains("@")))
            {
                MessageBox.Show("please input an email address with @!");
                return false;
            }
            if (new_address.Text == "")
            {
                MessageBox.Show("please input an address!");
                return false;
            }
            if (!((new_address.Text.Contains("North")) || (new_address.Text.Contains("South") || (new_address.Text.Contains("Center")))))
            {
                MessageBox.Show("must contain North/Center/South in address");
                return false;
            }
            if (new_password.Text == "")
            {
                MessageBox.Show("please input password!");
                return false;
            }
            if (new_password.Text.Length > 8)
            {
                MessageBox.Show("please input less than 9 digits to password!");
                return false;
            }

            return true;

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
