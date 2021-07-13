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
    public partial class SearchOrder_ByDate : Form
    {
        public SearchOrder_ByDate()
        {
            InitializeComponent();
        }

        private void OrderList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (dateTimePicker1.Text != "")
            {

                try
                {
                    foreach (Order o in Program.Orders)
                    {
                        int Days = o.GettargetDate().Day;
                        int Months = o.GettargetDate().Month;
                        int Years = o.GettargetDate().Year;
                        int DaysP = dateTimePicker1.Value.Day;
                        int MonthsP = dateTimePicker1.Value.Month;
                        int YearsP = dateTimePicker1.Value.Year;

                        DateTime a = new DateTime(Years, Months, Days);
                        DateTime p = new DateTime(YearsP, MonthsP, DaysP);
                        if (a == p)
                        {
                            var row = new string[] { o.getID().ToString(), o.GettargetDate().ToString(), o.getorderDate().ToString(), o.getOrderStatus().ToString(), o.Getcapacity().ToString(), o.Getweight().ToString() };
                            ListViewItem l = new ListViewItem(row);
                            l.Tag = p;
                            OrderList.Items.Add(l);

                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("There is no orders in this target date");
                    this.Hide();
                }
            }

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}