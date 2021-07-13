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
    public partial class Employee_login : Form
    {
        public Employee_login()
        {
            InitializeComponent();
        }

        private void Employee_login_Load(object sender, EventArgs e)
        {

        }

        private void Password_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            Employee Exist_Employee = Program.seeEmployee(User_Name_Input.Text);
            if (User_Name_Input.Text == null || Password_Input.Text == null)
            {
                InformationNotValid c = new InformationNotValid();
                c.Show();
            }
            if (Exist_Employee != null)
            {
                if (Exist_Employee.getPassword() == Password_Input.Text && Exist_Employee.getID() == User_Name_Input.Text)
                {
                    Employee_Menu f = new Employee_Menu(Exist_Employee);
                    f.Show();
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
    }
}
