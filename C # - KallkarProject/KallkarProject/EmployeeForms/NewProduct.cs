using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Drawing.Text;

namespace KallkarProject
{
    public partial class NewProduct : Form
    {
        private Employee employee;
        public NewProduct(Employee e)
        {
           InitializeComponent();
            this.employee = e;
            Product_Category_Input.DataSource = Enum.GetValues(typeof(Category));
        }

        private void Product_Category_Input_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (checkDetails()== true) { 
            
                Product.serialNum += 1;
                Product new_product = new Product(Product.serialNum.ToString(), name_input.Text, SqlMoney.Parse(price_input.Text), DateTime.Now, picture_input.Text, float.Parse(Weight_Input.Text), float.Parse(capacity_input.Text), (Category)Enum.Parse(typeof(Category), Product_Category_Input.Text));
                Program.Products.Add(new_product);
                new_product.create_Product();
                MessageBox.Show("product is create successfuly");
                ProductMenu m = new ProductMenu(employee);
                m.Show();
                this.Hide();
            }

        }

        private void Product_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void price_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Weight_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void capacity_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void picture_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            ProductMenu pm = new ProductMenu(employee);
            pm.Show();
            this.Hide();

        }
        private bool checkDetails()
        {
            if (name_input.Text == "")
            {
                MessageBox.Show("please insert product Name!");
                return false;
            }
            if (price_input.Text == "")
            {
                MessageBox.Show("please insert product price!");
                return false;
            }
            if (Weight_Input.Text == "")
            {
                MessageBox.Show("please insert product weight!");
                return false;
            }
            if (capacity_input.Text == "")
            {
                MessageBox.Show("please insert product capacity!");
                return false;
            }
            return true;
        }
    }
}
