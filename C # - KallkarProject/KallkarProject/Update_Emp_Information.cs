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
            FullName_Input.Text = this.emp.get_name().ToString();
            Gender_Input.Text = this.emp.getGender().ToString();
            Gender_Input.DataSource = Enum.GetValues(typeof(Gender));
            Email_Input.Text = this.emp.getemail().ToString();
            //DOB.Text = this.emp.getDob().ToString();
            Role_Input.Text = this.emp.get_role().ToString();
            Role_Input.DataSource = Enum.GetValues(typeof(Role));
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
            // string dt = DOB.Value.ToString();
            Employee ec = Program.seeEmployee(emp.getID());
            emp.set_Name(FullName_Input.Text);
            emp.setEmail(Email_Input.Text);
            emp.setPassword(Password_Input.Text);
            emp.set_role((Role)Enum.Parse(typeof(Role), Role_Input.Text));
            emp.set_Gender((Gender)Enum.Parse(typeof(Gender), Gender_Input.Text));
            //    emp.setDOB(DateTime.Parse(dt));
            emp.Update_Employee();
            this.Hide();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}