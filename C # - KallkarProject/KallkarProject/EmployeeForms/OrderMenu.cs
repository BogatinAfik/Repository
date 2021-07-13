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
    public partial class OrderMenu : Form
    {
        private Employee emp;

        public OrderMenu(Employee e)
        {
            InitializeComponent();
            this.emp = e;
            showText();
            Customerinsert.Hide();
            Id_Input.Hide();
            Submut.Hide();
        }
        public void showText()
        {

            try
            {
                foreach (Order or in Program.Orders)
                {
                    DateTime orddate = or.getorderDate();
                    DateTime today = DateTime.Now;
                    TimeSpan t = today - orddate;
                    double NrOfDays = t.TotalDays;
                    if (NrOfDays <= 7)
                    {
                        var row = new string[] { or.getOrderId(), or.GetCustomer().getID(), or.getOrderStatus().ToString(), or.GettargetDate().ToString(), or.getorderDate().ToString(), or.Getcapacity().ToString(), or.GetPrice().ToString() };
                        ListViewItem l = new ListViewItem(row);
                        l.Tag = or;
                        Orders_list.Items.Add(l);

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("there is no avalible orders from this week");

                this.Hide();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SearchOrder_byCustomer se = new SearchOrder_byCustomer(emp);
            se.Show();
            this.Hide();
        }

        private void Orders_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void search_dates_Click_1(object sender, EventArgs e)
        {
            SearchOrder_ByDate so = new SearchOrder_ByDate(emp);
            so.Show();
            this.Hide();
        }

        private void create_order_Click(object sender, EventArgs e)
        {
            if ((emp.get_role().ToString().Equals("manager")) || (emp.get_role().ToString().Equals("sales")))
            {
                Customerinsert.Show();
                Id_Input.Show();
                Submut.Show();

            }
            else
            {
                MessageBox.Show("you do not have permission to create new orders");
            }
        }

        private void Customerinsert_Click(object sender, EventArgs e)
        {

        }

        private void Id_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submut_Click(object sender, EventArgs e)
        {
            Customer cus = Program.seeCustomer(Id_Input.Text);
            if (cus == null)
            {
                InformationNotValid i = new InformationNotValid();
                i.Show();
                MessageBox.Show("please insert an exisiting customer");

            }
            makeNewOrder v = new makeNewOrder(cus, null);
            v.Show();
            
        }

        private void OrderMenu_Load(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Employee_Menu em = new Employee_Menu(emp);
            em.Show();
            this.Hide();
        }
    }
}