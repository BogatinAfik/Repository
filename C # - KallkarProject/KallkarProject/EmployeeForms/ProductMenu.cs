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
    public partial class ProductMenu : Form
    {
        private Employee employee;
        public ProductMenu(Employee e)
        {
            InitializeComponent();
            this.employee = e;
        }

        private void Create_new_product_Click(object sender, EventArgs e)
        {
            NewProduct np = new NewProduct(employee);
            np.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       

        private void Update_Product_details_Click_1(object sender, EventArgs e)
        {
            Update_Product_Menu up = new Update_Product_Menu(employee);
            up.Show();
            this.Hide();

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Employee_Menu em = new Employee_Menu(employee);
            em.Show();
            this.Hide();
        }
    }
}