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
    public partial class Update_My_Orders : Form
    {
        private Customer cus;
        private Order ord;
        public Update_My_Orders(Customer customer, Order order)
        {
            InitializeComponent();
            this.cus = customer;
            this.ord = order;
        }

        private void Update_My_Orders_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Comments_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("the updated order was sent to the factory for approval");
            SendEmail se = new SendEmail();
            se.sendEmail(cus.getID() + "  has requested to change his order", "customer number: " + cus.getID() + "  " + cus.getFirstName() + "  " + cus.getLastName() + "   has change his order, here is the order information and changes:" + Environment.NewLine + "Order id is:" + ord.getID() + Environment.NewLine + Comments_input.Text, "KalKarFactory@gmail.com");
            this.Hide();
            MyOrders_ForUpdate mo = new MyOrders_ForUpdate(cus);
            mo.Show();


        }


        private void back_button_Click(object sender, EventArgs e)
        {
            MyOrders_ForUpdate mo = new MyOrders_ForUpdate(cus);
            mo.Show();
            this.Hide();
        }
    }
}