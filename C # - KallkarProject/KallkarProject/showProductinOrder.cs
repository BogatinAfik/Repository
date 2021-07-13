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
    public partial class showProductinOrder : Form
    {
        private Customer myCustomer;
        private Order myOrder;
        private DateTime targetDate;
        private List<ProductInOrder> mylist;
        private int Myindex;

        public showProductinOrder(Customer customer, Order myOrder, List<ProductInOrder> list, int index, DateTime targetDate)
        {
            myCustomer = customer;
            this.myOrder = myOrder;
            mylist = list;
            Myindex = index;
            this.targetDate = targetDate;
            InitializeComponent();

            textBoxPNUM.Text = mylist.ElementAt(Myindex).getProduct().getID();
            textBoxPNAME.Text = mylist.ElementAt(Myindex).getProduct().getName();

            textBoxQuantity.Text = (mylist.ElementAt(Myindex).getQuantity().ToString());
            textBoxComents.Text = mylist.ElementAt(Myindex).getComents();
        }

        private void textBoxPNUM_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxComents_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (myOrder == null)
            {
                this.myOrder = new Order(DateTime.Now, targetDate, myCustomer);
                myCustomer.orders.Add(myOrder);
                Program.Orders.Add(myOrder);
                myOrder.create_order();
            }

            Product tempP = mylist.ElementAt(Myindex).getProduct();

            if (myOrder.checkProductInOrder(tempP) == false)
            {
                myOrder.setPrice(tempP.getPrice());
                ApprovalStatus As = (ApprovalStatus)Enum.Parse(typeof(ApprovalStatus), "waitForApproval");
                ProductInOrder tempPIO = new ProductInOrder(tempP, myOrder, int.Parse(textBoxQuantity.Text), textBoxComents.Text.ToString(), As);
                Program.ProductInOrders.Add(tempPIO);
                tempPIO.create_ProductInOrder();
            }
            else
            {
                MessageBox.Show("This product is allredy exist in order");
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (Myindex + 1 < mylist.Count())
            {
                showProductinOrder oC = new showProductinOrder(myCustomer, myOrder, mylist, Myindex + 1, targetDate);
                oC.Show();
                this.Close();
            }
            else
            {
                view_orders oC = new view_orders(myCustomer, myOrder, targetDate);
                oC.Show();
                this.Close();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            makeNewOrder oC = new makeNewOrder(myCustomer, myOrder);
            oC.Show();
            this.Close();
        }
    }
}

