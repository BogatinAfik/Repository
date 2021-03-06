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
    public partial class arrange_shipment : Form
    {
        private Employee emp;
        public arrange_shipment(Employee emp)
        {
            InitializeComponent();
            this.emp = emp;
            
        }

        private void shipment_id_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void shipment_button_Click(object sender, EventArgs e)
        {
            Shipment current_ship = Program.seeShipment(shipment_id_input.Text);
            if (shipment_id_input.Text == null)
            {
                InformationNotValid c = new InformationNotValid();
                c.Show();
            }
            if (current_ship != null)
            {
                foreach (Order o in Program.Orders)
                {
                    if (o.shipment.getID() == current_ship.getID())
                    {
                        orderText.Text += o.toString();
                    }
                }
            }
            else
            {
                InformationNotValid c = new InformationNotValid();
                c.Show();

            }
        }
        private void orderText_TextChanged(object sender, EventArgs e)
        {

        }

        private void take_order_Click(object sender, EventArgs e)
        {
            Order current_order = Program.seeOrder(order_id_input.Text);
            bool isDocument = false;
            if (current_order == null)
                MessageBox.Show("Order is not exsist!");
            else if (current_order.getOrderStatus().ToString().Equals("moveToShipment")) {
                MessageBox.Show("Order is already taken");
            }
            else if (current_order.getOrderStatus().ToString()!= ("ready")){
                MessageBox.Show("Order is not ready!");
            }
            else if((current_order.GetArea().getStorage().getStorageNum()) == 1) {
                visualStorage1 v1 = new visualStorage1(current_order.GetArea(), current_order, isDocument);
                v1.Show();
              }
            else if ((current_order.GetArea().getStorage().getStorageNum()) == 2)
            {
                visualStorage2 v2 = new visualStorage2(current_order.GetArea(), current_order, isDocument);
                v2.Show();
            }
            else if ((current_order.GetArea().getStorage().getStorageNum()) == 3)
            {
                visualStorage3 v3 = new visualStorage3(current_order.GetArea(), current_order, isDocument);
                v3.Show();
            }
            else if ((current_order.GetArea().getStorage().getStorageNum()) == 4)
            {
                visualStorage4 v4 = new visualStorage4(current_order.GetArea(), current_order, isDocument);
                v4.Show();
            }
            else if ((current_order.GetArea().getStorage().getStorageNum()) == 5)
            {
                visualStorage5 v5 = new visualStorage5(current_order.GetArea(), current_order, isDocument);
                v5.Show();
            }

        }

        private void arrange_shipment_Load(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            manage_storage mn = new manage_storage(emp);
            mn.Show();
            this.Hide();
        }
    }
}
