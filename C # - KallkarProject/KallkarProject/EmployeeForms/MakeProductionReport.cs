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
        private Employee employee;
        SortedSet<Order> tempWaitingOrders = new SortedSet<Order>(new compareByTargetDate());
        public MakeProductionReport(Employee e)
        {
            InitializeComponent();
            this.employee = e;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            setupOrderForProduction();
            int counter = tempWaitingOrders.Count();
            DateTime tempDate = DateTime.Now;
            for (int i = 0; i < comboBox1.SelectedIndex+1; i++) // check for specific day
            {
                if (counter == 0) break;
                richTextBox1.Text += tempDate.Date.ToString() + Environment.NewLine;
                foreach (Machine M in Program.Machines)
                { // check for each machine
                    float tempaDailyProd = M.getProductionRate() * 24; //maximum production value each day
                    richTextBox1.Text += M.ToString() + " produce the orders:" + Environment.NewLine;
                    foreach (Order o in tempWaitingOrders)
                    {
                     
                        {
                            // chacking a match for production
                            if (o.getTotalNumOfProduct() < tempaDailyProd && (o.getOrderStatus().ToString().Equals("waitingForApproval"))) //have place in machine rate
                            {  
                                M.dailyProduction.Add(o);
                                tempaDailyProd -= o.getTotalNumOfProduct();
                                o.Update_Order_Status(o.getID(), ((OrderStatus)Enum.Parse(typeof(OrderStatus), "approved")));
                                richTextBox1.Text += o.getID() + Environment.NewLine;
                                counter --;

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
        public void setupOrderForProduction() {
            foreach (Order tempOrder in Program.Orders) // insert all relevent Orders to sortedSet 
            { 
                tempOrder.checkDelayed(DateTime.Now);   // check delayed orders
                if (tempOrder.getOrderStatus().ToString().Equals("waitingForApproval"))
                {
                    tempWaitingOrders.Add(tempOrder);
                }

            }


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

        private void MakeProductionReport_Load(object sender, EventArgs e)
        {

        }

        private void send_email_Click(object sender, EventArgs e)
        {
            SendEmail se = new SendEmail();
            se.sendEmail("Production Report to " + DateTime.Now.ToString(), richTextBox1.Text, employee.getemail());
        }

        private void back_button1_Click(object sender, EventArgs e)
        {
            Reports re = new Reports(employee);
            re.Show();
            this.Hide();
        }
    }
}
