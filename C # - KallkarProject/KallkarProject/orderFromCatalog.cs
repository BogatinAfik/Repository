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
        public orderFromCatalog(Customer tempCostomer, Order newOrder, DateTime targetDate)
        {
            this.targetDate = targetDate;
            InitializeComponent();
            this.tempCostomer = tempCostomer;
            this.newOrder = newOrder;

        }

        private void orderFromCatalog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sADM_4DataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.sADM_4DataSet.Product);

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
            if (newOrder == null)
            {

                this.newOrder = new Order(DateTime.Now, targetDate, tempCostomer);// פה צריך לעדכן את המחיר
                tempCostomer.orders.Add(newOrder);
                Program.Orders.Add(newOrder);
                newOrder.create_order();
            }


            Product tempP = Program.seeProduct(textBox1.Text);

            if (newOrder.checkProductInOrder(tempP) == false)
            {
                newOrder.setPrice(tempP.getPrice());
                ApprovalStatus As = (ApprovalStatus)Enum.Parse(typeof(ApprovalStatus), "waitForApproval");
                ProductInOrder tempPIO = new ProductInOrder(tempP, this.newOrder, int.Parse(cuantity.Text), textBox2.Text, As);
                Program.ProductInOrders.Add(tempPIO);
                tempPIO.create_ProductInOrder();
            }
            else
            {
                MessageBox.Show("This product is allredy exist in order");
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

        //מה שקורה בסוף ההזמנה
        private void Finish_Click(object sender, EventArgs e)
        {
            makeNewOrder v = new makeNewOrder(tempCostomer, newOrder);
            v.Show();
            this.Hide();
        }
    }
}

