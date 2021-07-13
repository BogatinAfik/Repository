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
    public partial class Update_Product_Menu : Form
    {
        private Product pro;
        private Employee employee;

        public Update_Product_Menu(Employee e)
        {
            InitializeComponent();
            this.employee = e;
            Update.Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {
            pro = Program.seeProduct(textBox1.Text);
            if (pro == null)
            {
                InformationNotValid f = new InformationNotValid();
                f.Show();
                this.Hide();
            }
            else
            {

                if (textBox1.Text != "")
                {

                    try
                    {
                        foreach (Product p in Program.Products)
                        {
                            if (p.getID() == textBox1.Text)
                            {
                                var row = new string[] { p.getID().ToString(), p.getName(), p.getWeight().ToString(), p.getCapacity().ToString(), p.getPrice().ToString(), p.getURL().ToString(), p.getCreateDate().ToString(), p.getCategory().ToString() };
                                ListViewItem l = new ListViewItem(row);
                                l.Tag = p;
                                product_list.Items.Add(l);
                                Update.Show();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (employee.get_role().ToString().Equals("manager"))
            {
                Update_product_details a = new Update_product_details(pro, employee);
                a.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You do not have the permission to change Products details");
                this.Hide();
            }

        }

        private void Update_Product_Info_Load(object sender, EventArgs e)
        {


        }

        private void product_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
