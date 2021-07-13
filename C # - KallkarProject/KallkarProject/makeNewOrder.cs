using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KallkarProject
{
    public partial class makeNewOrder : Form
    {
        private Order newOrder;
        private Customer customer;
        public makeNewOrder(Customer customer, Order exist)
        {
            newOrder = exist;
            InitializeComponent();

            this.customer = customer;
        }

        private void catalog_Click(object sender, EventArgs e)
        {
            String dt = dateTimePicker1.Value.ToString();
            orderFromCatalog oC = new orderFromCatalog(customer, newOrder, DateTime.Parse(dt));
            oC.Show();
            this.Close();
        }

        private void newProduct_Click(object sender, EventArgs e)
        {
            Ask_For_New_Product ak = new Ask_For_New_Product(customer);
            ak.Show();
            this.Hide();

        }

        private void previwesOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString());
            String dt = dateTimePicker1.Value.ToString();
            view_orders vO = new view_orders(customer, newOrder, DateTime.Parse(dt));
            vO.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void makeNewOrder_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            exsist_customer v = new exsist_customer(customer);
            v.Show();
            this.Hide();
        }
    }
}
