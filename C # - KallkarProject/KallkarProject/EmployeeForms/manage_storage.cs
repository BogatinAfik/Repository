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
    public partial class manage_storage : Form
    {
        private Employee emp;
        public manage_storage(Employee e)
        {
            InitializeComponent();
            need_pick_storage.Hide();
            choose_storage.Hide();
            submit_button.Hide();
            this.emp = e;
        }

        private void show_storage_button_Click(object sender, EventArgs e)
        {
            need_pick_storage.Show();
            choose_storage.Show();
            submit_button.Show();


        }

        private void arrange_shipment_button_Click(object sender, EventArgs e)
        {
            arrange_shipment ar = new arrange_shipment(emp);
            ar.Show();
            this.Hide();
        }

        private void document_orders_button_Click(object sender, EventArgs e)
        {
            document_orders dor = new document_orders(emp);
            this.Hide();
            dor.Show();
            
        }

        private void choose_storage_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            if (choose_storage.Text == "A")
            {
                visualStorage1 s1 = new visualStorage1();
                s1.Show();
            }
            else if (choose_storage.Text == "B")
            {
                visualStorage2 s2 = new visualStorage2();
                s2.Show();
            }
            else if (choose_storage.Text == "C")
            {
                visualStorage3 s3 = new visualStorage3();
                s3.Show();
            }
            else if (choose_storage.Text == "D")
            {
                visualStorage4 s4 = new visualStorage4();
                s4.Show();
            }
            else if (choose_storage.Text == "E")
            {
                visualStorage5 s5 = new visualStorage5();
                s5.Show();
            }
        }

        private void manage_storage_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee_Menu em = new Employee_Menu(emp);
            em.Show();
            this.Hide();
        }
    }
}
