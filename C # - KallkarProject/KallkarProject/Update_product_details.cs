using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KallkarProject
{
    public partial class Update_product_details : Form
    {
        private Product product;
        private Employee emp;
        public Update_product_details(Product p, Employee e)
        {
            InitializeComponent();
            this.product = p;
            this.emp = e;
            Category_input.DataSource = Enum.GetValues(typeof(Category));
            Id_Input.Text = this.product.getID().ToString();
            name_input.Text = this.product.getName().ToString();
            weight_input.Text = this.product.getWeight().ToString();
            capacity_input.Text = this.product.getCapacity().ToString();
            price_input.Text = this.product.getPrice().ToString();
            url_input.Text = this.product.getURL().ToString();
            Category_input.Text = this.product.getCategory().ToString();
            Category_input.DataSource = Enum.GetValues(typeof(Category));
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            Product po = Program.seeProduct(product.getID());
            Employee EP = Program.seeEmployee(emp.getID());
            if (EP.get_role().ToString().Equals("manager"))
            {
                product.setName(name_input.Text);
                product.setPrice(SqlMoney.Parse(price_input.Text));
                product.setSketch(url_input.Text);
                product.setCapacity(float.Parse(capacity_input.Text));
                product.setWeight(float.Parse(weight_input.Text));
                product.setCategory((Category)Enum.Parse(typeof(Category), Category_input.Text));
                product.Update_Product();
                MessageBox.Show("Product Updated successfully");
                this.Hide();
            }
            else
            {
                MessageBox.Show("You do not have permision to change product information");
                this.Hide();
            }

        }
        private void Id_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void weight_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void capacity_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void price_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void url_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Category_input_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}




