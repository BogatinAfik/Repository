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
    public partial class visualStorage3 : Form
    {
        private Area findPlace;
        private Order takenOrder;
        private bool isItDocument;
        public visualStorage3(Area a, Order o, bool b)
        {
            InitializeComponent();
            free_space_text.Hide();
            exit_button.Hide();
            this.findPlace = a;
            this.takenOrder = o;
            this.isItDocument = b;
            if (isItDocument == true)
                take_label.Hide();
            else
                document_label.Hide();
            markArea(findPlace);


        }
        public visualStorage3()
        {
            InitializeComponent();
            finish_button.Hide();
            take_label.Hide();
            no_take_button.Hide();
            document_label.Hide();
            Show_Storage_Status();
        }

        private void visualStorage_Load(object sender, EventArgs e)
        {

        }

        public void markArea(Area a)
        {
            foreach (var button in this.Controls.OfType<Button>())
            {
                if (button.Name.Equals(findPlace.toString()))
                {

                    button.BackColor = System.Drawing.Color.Red;
                }

            }
        }

        public void unMarkArea(Area temp)
        {
            foreach (var button in this.Controls.OfType<Button>())
            {
                if (button.Name.Equals(temp.toString()))
                {
                    button.BackColor = System.Drawing.SystemColors.ControlLight;
                }

            }
        }


        private void finish_button_Click(object sender, EventArgs e)
        {
            if (isItDocument == false)
            {
                takenOrder.moveToShipment();
                MessageBox.Show("move order to shipment!");
            }
            else
            {
                takenOrder.documentInStorage(findPlace);
                MessageBox.Show("the order is document and move to 'ready' status");
            }
            unMarkArea(findPlace);
            this.Hide();

        }
        private void Show_Storage_Status()
        {
            Storage c = Program.Storages.ElementAt(2);
            float freeSpace = c.calculateFreeSpace();
            float byPrecent = c.freeSpaceByPrecent(freeSpace);
            free_space_text.Text = "there is " + freeSpace + " capacity available" + Environment.NewLine + byPrecent + " % is free";
            free_space_text.Show();
            foreach (var button in this.Controls.OfType<Button>())
            {
                foreach (Area area in Program.Areas)
                {
                    if (button.Name.Equals(area.toString()))
                    {
                        if (area.getOccupied() == true)
                            button.BackColor = System.Drawing.Color.MidnightBlue;
                        else
                            button.BackColor = System.Drawing.Color.LightSkyBlue;
                    }
                }
            }


        }
        private void take_label_Click(object sender, EventArgs e)
        {

        }

        private void no_take_button_Click(object sender, EventArgs e)
        {
            unMarkArea(findPlace);
            this.Hide();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            foreach (Area area in Program.Areas)
            {
                unMarkArea(area);
            }
            manage_storage m = new manage_storage();
            m.Show();
            this.Hide();
        }
    }
}
