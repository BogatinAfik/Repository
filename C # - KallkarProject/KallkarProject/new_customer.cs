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
    public partial class new_customer : Form
    {
       // private Customer new_Customer;
        public new_customer()
        {
            InitializeComponent();
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
            if (new_id.Text == "")
            {
                MessageBox.Show("please input ID!");
            }
            if (new_fname.Text == "")
            {
                MessageBox.Show("please input first name!");
            }
            if (new_lname.Text == "")
            {
                MessageBox.Show("please input last name!");
            }
            if (new_phone.Text == "" ) 
            { 
                MessageBox.Show("please input phone number!");
            }
            if (new_phone.Text.Length != 10){
                MessageBox.Show("please input 10 digits phone number!");
            }
            if (new_email.Text == "" ) 
            {
                MessageBox.Show("please input an email!");
            }
            if (!(new_email.Text.Contains("@")))
            {
                MessageBox.Show("please input an email address with @!");
            }
            if (new_address.Text == "")
            {
                MessageBox.Show("please input an address!");
            }
            if (new_password.Text == "")
            {
                MessageBox.Show("please input password!");
            }
            if (new_password.Text.Length > 8)
            {
                MessageBox.Show("please input less than 9 digits to password!");
            }
            else
            {
                Customer new_Customer = new Customer(new_id.Text, new_fname.Text, new_lname.Text, new_phone.Text, new_email.Text, DateTime.Parse(dt), new_address.Text, new_password.Text, (Gender)Enum.Parse(typeof(Gender), gender.Text), (customerType)Enum.Parse(typeof(customerType), type.Text));
                Program.Customers.Add(new_Customer);
                new_Customer.create_Customer();
                main_form m = new main_form();
                m.Show();
                this.Hide();
            }
        }
    }
}
