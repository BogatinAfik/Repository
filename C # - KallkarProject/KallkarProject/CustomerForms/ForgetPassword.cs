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
    public partial class ForgetPassword : Form
    {
        private Customer myCustomer;
        public ForgetPassword()
        {
            InitializeComponent();
            email_send_button.Hide();


            if (Id_Input.Text == null || Email_Input.Text == null)
            {
                InformationNotValid c = new InformationNotValid();
                c.Show();
            }
            
        }

        private void Resend_Password_Click(object sender, EventArgs e)
        {
            myCustomer = Program.seeCustomer(Id_Input.Text);
            SendEmail send = new SendEmail();
            send.sendEmail("Dear" + myCustomer.getFirstName() + " " + myCustomer.getLastName(), "We remind you that your Password is" + myCustomer.getPassword(), Email_Input.Text);
            email_send_button.Show();
        }

        private void Id_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_send_button_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void home_page_button_Click(object sender, EventArgs e)
        {
            main_form mn = new main_form();
            mn.Show();
            this.Hide();
        }
    }
}
