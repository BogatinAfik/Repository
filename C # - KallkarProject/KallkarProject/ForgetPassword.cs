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

        }

        private void Id_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_Input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
