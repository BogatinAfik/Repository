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
    public partial class MakeProductionReport : Form
    {
        public MakeProductionReport()
        {
            InitializeComponent();
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            
            SortedSet <Order> tempWaitingOrders = new SortedSet <Order> (new compareByTargetDate());
            
            foreach (Order tempOrder in Program.Orders) {

                if (tempOrder.getOrderStatus().ToString().Equals("waitingForApproval")) {
                    tempWaitingOrders.Add(tempOrder);
                }
            }
            DateTime tempDate = dateTimePicker1.Value;
            for (int i = 0; i < comboBox1.SelectedIndex+1; i++) // check for specific day
            {
                
                richTextBox1.Text += tempDate.Date.ToString() + Environment.NewLine;
                foreach (Machine M in Program.Machines)
                { // check for each machine
                    float tempaDailyProd = M.getProductionRate() * 24; //maximum production value each day
                    richTextBox1.Text += M.ToString() + " produce the orders:" + Environment.NewLine;
                    foreach (Order o in tempWaitingOrders)
                    {
                        if (o.checkDelayed(tempDate))
                        {

                            if (o.getTotalNumOfProduct() < tempaDailyProd && (o.getOrderStatus().ToString().Equals("waitingForApproval")))
                            { //have place in machine rate
                                M.dailyProduction.Add(o);
                                tempaDailyProd -= o.getTotalNumOfProduct();
                                o.Update_Order_Status(o.getID(), ((OrderStatus)Enum.Parse(typeof(OrderStatus), "approved")));
                                richTextBox1.Text += o.getID() + Environment.NewLine;

                            }

                        }
                       

                    }
                   
                }
                tempDate = tempDate.AddDays(1);
                richTextBox1.Text += Environment.NewLine;
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        /*private void SendtoEmail_Click(object sender, EventArgs e)
        {

        }*/
    }
}
