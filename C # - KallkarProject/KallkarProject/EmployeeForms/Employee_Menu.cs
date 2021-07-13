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
    public partial class Employee_Menu : Form
    {
        private Employee employee;

        public Employee_Menu(Employee e)
        {
            this.employee = e;
            InitializeComponent();
            emp_Role.DataSource = Enum.GetValues(typeof(Role));//אתחול הקומבובוקס

            User_ID.Text = this.employee.getID().ToString();
            User_ID.Enabled = false;
            FullNameFill.Text = this.employee.get_name().ToString();
            FullNameFill.Enabled = false;
            EmailFill.Text = this.employee.get_email().ToString();
            EmailFill.Enabled = false;
            DOB_Fill.Text = this.employee.getDateOfBirth().Date.ToString();
            DOB_Fill.Enabled = false;
            emp_Role.Text = this.employee.get_role().ToString();
            emp_Role.Enabled = false;
        }

        private void FullNameFill_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailFill_TextChanged(object sender, EventArgs e)
        {

        }

        private void Employee_Menu_Load(object sender, EventArgs e)
        {

        }

        private void DOB_Fill_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void emp_Role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Date_OF_Birth_Click(object sender, EventArgs e)
        {

        }

        private void User_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Products_Click(object sender, EventArgs e)
        {
            ProductMenu pm = new ProductMenu(employee);
            pm.Show();
            this.Hide();
        }

        private void Update_Emp_Details_Click(object sender, EventArgs e)
        {
            Update_Emp_Information up = new Update_Emp_Information(employee);
            up.Show();
            this.Hide();
        }

        private void Orders_Click(object sender, EventArgs e)
        {
            OrderMenu om = new OrderMenu(employee);
            om.Show();
            this.Hide();

        }

        private void Reports_Click(object sender, EventArgs e)
        {
            if (employee.get_role().ToString().Equals("manager"))
            {
                Reports r = new Reports(employee);
                r.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You have no premition");
            }
        }

        private void ID_Number_Click(object sender, EventArgs e)
        {

        }

        private void storage_Click(object sender, EventArgs e)
        {
            manage_storage m = new manage_storage(employee);
            m.Show();
            this.Hide();
        }

        private void home_page_button_Click(object sender, EventArgs e)
        {
            main_form mf = new main_form();
            mf.Show();
            this.Hide();
        }
    }
}