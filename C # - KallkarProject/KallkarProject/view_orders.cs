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
    public partial class view_orders : Form
    {
        private Customer myCustomer;
        private Order myOrder;
        private DateTime targetDate;

        public view_orders(Customer customer, Order myOrder, DateTime targetDate)
        {
            this.targetDate = targetDate;
            this.myCustomer = customer;
            this.myOrder = myOrder;
            InitializeComponent();
            //richTextBox1.Enabled = false;
            bool counter = true;
            foreach (Order o in Program.Orders)
            {
                if (o.getCustomer().getID() == myCustomer.getID())
                {
                    counter = false;
                    richTextBox1.Text += o.displayOrders();
                }


            }
            if (counter)
            {
                richTextBox1.Text = " You have no order until naw";
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Order tempO = Program.seeOrder(textBox1.Text);

            List<ProductInOrder> templist = new List<ProductInOrder>();
            foreach (ProductInOrder po in Program.ProductInOrders)
            {
                if (tempO.getID() == po.getOrder().getID())
                {
                    templist.Add(po);
                }
            }
            MessageBox.Show(templist.Count().ToString());

            showProductinOrder oC = new showProductinOrder(myCustomer, myOrder, templist, 0, targetDate);
            oC.Show();
            this.Close();

            /*foreach (ProductInOrder po in Program.ProductInOrders) {
                if (tempO.getID()==po.getOrder().getID()) {

                    Product tempP = Program.seeProduct(po.getProduct().getID());

                    ApprovalStatus As = (ApprovalStatus)Enum.Parse(typeof(ApprovalStatus), "waitForApproval");
                    ProductInOrder tempPIO = new ProductInOrder(tempP, tempO, po.getQuantity(), "no", As);
                    Program.ProductInOrders.Add(tempPIO);
                    tempPIO.create_ProductInOrder();

                }

            }*/




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            makeNewOrder oC = new makeNewOrder(myCustomer, myOrder);
            oC.Show();
            this.Close();
        }
    }
}
