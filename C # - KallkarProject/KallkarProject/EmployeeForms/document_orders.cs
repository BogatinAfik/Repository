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
    public partial class document_orders : Form
    {
        private Employee emp;
        public document_orders(Employee emp)
        {
            InitializeComponent();
            this.emp = emp;
            show_production_orders();
        }

        private void move_to_storage_Click(object sender, EventArgs e)
        {
            Order current_order = Program.seeOrder(order_input.Text);
            bool document = true;
            if (current_order == null)
                MessageBox.Show("Order is not exsist!");
            else if (current_order.getOrderStatus().ToString() != ("inProduction"))
            {
                MessageBox.Show("Order is not in production status!");
            }
            else
            {
                Area find_area = (current_order.findPlaceInStorage());
                if ((find_area.getStorage().getStorageNum()) == 1) {
                    visualStorage1 v1 = new visualStorage1(find_area, current_order, document);
                    v1.Show();
                }
                else if ((find_area.getStorage().getStorageNum()) == 2)
                {
                    visualStorage2 v2 = new visualStorage2(find_area, current_order, document);
                    v2.Show();
                }
                else if ((find_area.getStorage().getStorageNum()) == 3)
                {
                    visualStorage3 v3 = new visualStorage3(find_area, current_order, document);
                    v3.Show();
                }
                else if ((find_area.getStorage().getStorageNum()) == 4)
                {
                    visualStorage4 v4 = new visualStorage4(find_area, current_order, document);
                    v4.Show();
                }
                else if ((find_area.getStorage().getStorageNum()) == 5)
                {
                    visualStorage5 v5 = new visualStorage5(find_area, current_order, document);
                    v5.Show();
                }
            }
        }

        public void show_production_orders()
        {
            foreach (Order o in Program.Orders)
            {
                if (o.getOrderStatus().ToString().Equals("inProduction"))
                {
                    in_production_text.Text += o.toString();
                }
            }
            if (in_production_text.Text == null)
            {
                MessageBox.Show("there is not orders in production");
            }
        }

        private void document_orders_Load(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            manage_storage ms = new manage_storage(emp);
            ms.Show();
            this.Hide();
        }

        private void in_production_text_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
