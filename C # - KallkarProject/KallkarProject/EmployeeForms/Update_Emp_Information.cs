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

    public partial class Update_Emp_Information : Form
    {
        private Employee emp;
        public Update_Emp_Information(Employee e)
        {
            InitializeComponent();
            this.emp = e;
            Gender_Input.DataSource = Enum.GetValues(typeof(Gender));
            FullName_Input.Text = this.emp.get_name().ToString();
            Gender_Input.Text = this.emp.getGender().ToString();
            Email_Input.Text = this.emp.getemail().ToString();
            Password_Input.Text = this.emp.getPassword().ToString();

        }

        private void FullName_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gender_Input_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Email_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void DOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Role_Input_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Password_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            Employee ec = Program.seeEmployee(emp.getID());
            if (checkDetails() == true)
            {
                emp.set_Name(FullName_Input.Text);
                emp.setEmail(Email_Input.Text);
                emp.setPassword(Password_Input.Text);
                emp.set_Gender((Gender)Enum.Parse(typeof(Gender), Gender_Input.Text));
                emp.Update_Employee();
                MessageBox.Show("your details are update!");
            }
            this.Hide();
            Employee_Menu em = new Employee_Menu(emp);
            em.Show();
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Update_Emp_Information_Load(object sender, EventArgs e)
        {

        }
        private bool checkDetails()
        {
            if (FullName_Input.Text == "")
            {
                MessageBox.Show("please input first name!");
                return false;
            }
         
            if (Email_Input.Text == "")
            {
                MessageBox.Show("please input an email!");
                return false;
            }
            if (!(Email_Input.Text.Contains("@")))
            {
                MessageBox.Show("please input an email address with @!");
                return false;
            }
            if (Password_Input.Text == "")
            {
                MessageBox.Show("please input password!");
                return false;
            }
            if (Password_Input.Text.Length > 8)
            {
                MessageBox.Show("please input less than 9 digits to password!");
                return false;
            }

            return true;

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Employee_Menu em = new Employee_Menu(emp);
            em.Show();
            this.Hide();
        }
    }
}