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
    public partial class MyOrders_ForUpdate : Form
    {
        private Customer customer;
        private Order ord;
        public MyOrders_ForUpdate(Customer c)
        {
            InitializeComponent();
            this.customer = c;
            showText();
            ProductInOrder.Hide();
            Update_Order.Hide();
            Product_inOrder.Hide();


        }
        // private void OrderDetails_SelectedIndexChanged(object sender, EventArgs e)// table for orders 
        public void showText()
        {
            //  ord = Program.seeOrder(Order_input.Text);

            try
            {
                foreach (Order or in Program.Orders)
                {
                    if ((or.getCustomer().getID() == customer.getID()) && ((or.getOrderStatus().ToString().Equals("approved")) || (or.getOrderStatus().ToString().Equals("waitingForApproval"))))
                    {
                        var row = new string[] { or.getID().ToString(), or.GettargetDate().ToString(), or.getOrderStatus().ToString() };
                        ListViewItem l = new ListViewItem(row);
                        l.Tag = or;
                        OrderDetails.Items.Add(l);

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("you don't have avalible orders to update");
                /*InformationNotValid f = new InformationNotValid();
                f.Show();
                this.Hide();*/
            }
        }

        private void ProductInOrder_SelectedIndexChanged(object sender, EventArgs e)// table for products in order
        {

        }

        private void Order_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            Product_inOrder.Show();
            ProductInOrder.Show();
            Update_Order.Show();
            ord = Program.seeOrder(Order_input.Text);
            if (ord == null)
            {
                InformationNotValid f = new InformationNotValid();
                f.Show();
                this.Hide();
            }
            else
            {
                if (Order_input.Text != "")
                {

                    try
                    {
                        foreach (ProductInOrder po in Program.ProductInOrders)
                        {
                            if (po.getOrder().getID() == ord.getID())
                            {
                                var row = new string[] { po.getOrder().getID(), po.getProduct().getID(), po.getProduct().getName(), po.getProduct().getWeight().ToString(), po.getProduct().getCapacity().ToString(), po.getProduct().getPrice().ToString(), po.getProduct().getCategory().ToString(), po.getQuantity().ToString() };
                                ListViewItem l = new ListViewItem(row);
                                l.Tag = po;
                                ProductInOrder.Items.Add(l);

                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        InformationNotValid f = new InformationNotValid();
                        f.Show();
                        this.Hide();
                    }
                }
            }


        }

        private void Product_inOrder_Click(object sender, EventArgs e)
        {

        }

        private void Update_Order_Click(object sender, EventArgs e)
        {
            Update_My_Orders upm = new Update_My_Orders(customer, ord);
            upm.Show();
            this.Hide();
        }
    }
}