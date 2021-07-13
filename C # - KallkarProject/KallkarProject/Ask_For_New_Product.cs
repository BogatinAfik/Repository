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
    public partial class Ask_For_New_Product : Form
    {
        private Customer cus;
        public Ask_For_New_Product(Customer customer)
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(Category));
            this.cus = customer;

        }

        private void Ask_For_New_Product_Load(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            SendEmail se = new SendEmail();
            se.sendEmail("A new Product has been submited", cus.getID() + "   has requested a new product" + Environment.NewLine + "here is the product informatiom:" + Environment.NewLine + "Product name:   " + ProductName_input.Text + Environment.NewLine + "Product weight:   " + Weight_Input.Text + Environment.NewLine + "Product Capacity:   " + Product_Capacity_Input.Text + Environment.NewLine + "Product Picture URl:   " + Picture_URL_Input.Text + Environment.NewLine + "Product Category:   " + comboBox1.Text + Environment.NewLine + " CreateDate is:   " + DateTime.Now, "KalKarFactory@gmail.com");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProductName_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Weight_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Product_Capacity_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Picture_URL_Input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}