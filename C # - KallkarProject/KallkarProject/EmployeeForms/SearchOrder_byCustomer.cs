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
    public partial class SearchOrder_byCustomer : Form
    {
        private Employee emp;
        public SearchOrder_byCustomer(Employee e)
        {
            InitializeComponent();
            this.emp = e;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Customer c = Program.seeCustomer(ID_Input.Text);
            if (c == null)
            {
                InformationNotValid f = new InformationNotValid();
                f.Show();
            }
            else
            {

                if (ID_Input.Text != "")
                {

                    try
                    {
                        foreach (Order p in Program.Orders)
                        {
                            if (p.getCustomer().getID() == ID_Input.Text)
                            {
                                var row = new string[] { p.getID().ToString(), p.GettargetDate().ToString(), p.getorderDate().ToString(), p.getOrderStatus().ToString(), p.Getcapacity().ToString(), p.Getweight().ToString() };
                                ListViewItem l = new ListViewItem(row);
                                l.Tag = p;
                                OrderList.Items.Add(l);
                                Search.Hide();
                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("This Customer don't have orders yet");
                        this.Hide();
                    }
                }
                
            }
        }

        private void ID_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            OrderMenu om = new OrderMenu(emp);
            om.Show();
            this.Hide();
        }
    }
}