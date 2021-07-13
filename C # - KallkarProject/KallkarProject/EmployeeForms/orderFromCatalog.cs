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
    public partial class orderFromCatalog : Form
    {
        private Customer tempCostomer;
        private Order newOrder;
        private DateTime targetDate;
        private bool submited;
        public orderFromCatalog(Customer tempCostomer, Order newOrder, DateTime targetDate)
        {
            this.targetDate = targetDate;
            InitializeComponent();
            this.productTableAdapter.Fill(this.sADM_4DataSet.Product);
            this.tempCostomer = tempCostomer;
            this.newOrder = newOrder;
            submited = false;

        }

        private void orderFromCatalog_Load(object sender, EventArgs e)
        {
            
            

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productTableAdapter.FillBy(this.sADM_4DataSet.Product);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            if (int.Parse(cuantity.Text) <= 100)
            {


                if (newOrder == null)
                {

                    this.newOrder = new Order(DateTime.Now, targetDate, tempCostomer);
                    tempCostomer.orders.Add(newOrder);
                    Program.Orders.Add(newOrder);
                    newOrder.create_order();
                }


                Product tempP = Program.seeProduct(textBox1.Text);

                if (newOrder.checkProductInOrder(tempP) == false)
                {

                    ApprovalStatus As = (ApprovalStatus)Enum.Parse(typeof(ApprovalStatus), "waitForApproval");
                    ProductInOrder tempPIO = new ProductInOrder(tempP, this.newOrder, int.Parse(cuantity.Text), textBox2.Text, As);
                    Program.ProductInOrders.Add(tempPIO);
                    newOrder.setPrice(tempP.getPrice() * int.Parse(cuantity.Text));
                    newOrder.setWight(tempP.getWeight() * int.Parse(cuantity.Text));
                    newOrder.setcapacity(tempP.getCapacity() * int.Parse(cuantity.Text));
                    newOrder.Update_OrderWeightPrice();
                    tempPIO.create_ProductInOrder();
                    submited = true;
                    MessageBox.Show("The product was added to your chart");
                }
                else
                {
                    MessageBox.Show("This product is allredy exist in order");
                }
            }
            else {
                MessageBox.Show("maximum Quantity is 100");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.productTableAdapter.FillBy(this.sADM_4DataSet.Product);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        
        private void Finish_Click(object sender, EventArgs e)
        {
            if (newOrder != null && submited) {
                MessageBox.Show("Your order hes been accepted");
            }
            makeNewOrder v = new makeNewOrder(tempCostomer, newOrder);
            v.Show();
            this.Hide();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            makeNewOrder mno = new makeNewOrder(tempCostomer, null);
            mno.Show();
            this.Hide();
        }
    }
}

