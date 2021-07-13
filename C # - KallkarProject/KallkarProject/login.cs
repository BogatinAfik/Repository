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
    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();
        }



        private void log_in_button_Click(object sender, EventArgs e)
        {
            Customer Exist_Customer = Program.seeCustomer(Id_Number.Text);
            if (Id_Number.Text == null || Password.Text == null)
            {
                InformationNotValid c = new InformationNotValid();
                c.Show();
            }
            if (Exist_Customer != null)
            {
                if (Exist_Customer.getPassword() == Password.Text && Exist_Customer.getID() == Id_Number.Text)
                {
                    exsist_customer ex = new exsist_customer(Exist_Customer);
                   ex.Show();
                    this.Hide();
                }
                else
                {
                    InformationNotValid c = new InformationNotValid();
                    c.Show();

                }
            }
            else
            {
                InformationNotValid c = new InformationNotValid();
                c.Show();

            }


        }

        private void Id_Number_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Forget_Password_Click(object sender, EventArgs e)
        {
            ForgetPassword fs = new ForgetPassword();
            fs.Show();


        }
    }
}