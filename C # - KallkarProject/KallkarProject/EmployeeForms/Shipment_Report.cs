using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace KallkarProject
{
    public partial class Shipment_Report : Form
    {
        public List<Order> OrderNorth = new List<Order>();
        public List<Order> OrderSouth = new List<Order>();
        private List<Order> OrderCenter = new List<Order>();
        private List<Truck> TruckToNorth = new List<Truck>();
        private List<Truck> TruckToSouth = new List<Truck>();
        private List<Truck> TruckToCenter = new List<Truck>();
        private List<Truck> TruckTest = new List<Truck>();
        float TotalCapacityNorth = 0;
        float TotalCapacitySouth = 0;
        float TotalCapacityCenter = 0;
        float TotalTruckNorth = 0;
        float TotalTruckSouth = 0;
        float TotalTruckCenter = 0;
        string Truck1 = null;
        string Truck2 = null;
        string Truck3 = null;
        string Truck4 = null;
        string Truck5 = null;

        public Shipment_Report()
        {
            InitializeComponent();
            HideButtons();
        }

        private void HideButtons()
        {
            Shipment1.Hide();
            listView3.Hide();
            listView4.Hide();
            listView5.Hide();
            listView6.Hide();
            Shipment1Text.Hide();
            Shipment2Text.Hide();
            Shipment3Text.Hide();
            label5.Hide();
            Shipment5Text.Hide();
        }

        private void Shipment_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sADM_4DataSet.Truck' table. You can move, or remove it, as needed.
            this.truckTableAdapter.Fill(this.sADM_4DataSet.Truck);
            // TODO: This line of code loads data into the 'sADM_4DataSet.area' table. You can move, or remove it, as needed.
            this.areaTableAdapter.Fill(this.sADM_4DataSet.area);
            // TODO: This line of code loads data into the 'sADM_4DataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.sADM_4DataSet.Order);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int DriversInput = int.Parse(NumOfDrivers.Text);// the user input for drivers
            if (DriversInput > 5 || DriversInput <= 0)
            {
                MessageBox.Show("There are no enough trucks in the factory, please try again");
                this.Hide();
            }

            if (dateTimePicker1.Text != "")
            {

                try
                {
                    bool orderCheck = true;
                    foreach (Order o in Program.Orders)
                    {
                        
                        if (DateToCopmare(o) == true && o.getOrderStatus().ToString().Equals("ready"))///divide vectors by region- north,center,south
                        {
                            orderCheck = false;

                            var row = new string[] { o.getOrderId(), o.getorderDate().ToString(), o.GettargetDate().ToString(), o.Getcapacity().ToString(), o.Getdestenation(), o.Getweight().ToString() };
                            ListViewItem l = new ListViewItem(row);
                            l.Tag = o;
                            listView1.Items.Add(l);
                            if (o.Getdestenation().Contains("North") && o.getOrderStatus().ToString().Equals("ready"))
                            {
                                OrderNorth.Add(o);
                            }
                            if (o.Getdestenation().Contains("South") && o.getOrderStatus().ToString().Equals("ready"))
                            {
                                OrderSouth.Add(o);
                            }
                            if (o.Getdestenation().Contains("Center") && o.getOrderStatus().ToString().Equals("ready"))
                            {
                                OrderCenter.Add(o);
                            }
                        }
                    }
                    if (orderCheck) {
                        MessageBox.Show("There are no orders in the choosen target date ");
                    }

                    foreach (Order North in OrderNorth)
                    {
                        TotalCapacityNorth = TotalCapacityNorth + North.Getcapacity(); // calculate total capacity for north orders
                    }
                    foreach (Order South in OrderSouth)
                    {
                        TotalCapacitySouth = TotalCapacitySouth + South.Getcapacity();// calculate total capacity for south orders
                    }
                    foreach (Order Center in OrderCenter)
                    {
                        TotalCapacityCenter = TotalCapacityCenter + Center.Getcapacity(); // calculate total capacity for center orders
                    }
                    DividNorth(); // divide shipment by north
                    DividSouth(); // divide shipment by south
                    DividCenter(); // divide shipment by center
                    button1.Hide();
                }

                catch (Exception ex)
                {
                    InformationNotValid f = new InformationNotValid();
                    f.Show();
                    this.Hide();
                }

            }
            DividToShipment();

        }
        private void Shipment1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NumOfDrivers_TextChanged(object sender, EventArgs e)
        {

        }

        private void Shipment1Text_Click(object sender, EventArgs e)
        {

        }

        private void Shipment2Text_Click(object sender, EventArgs e)
        {

        }

        private void Shipment3Text_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Shipment5Text_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {

            this.Hide();
        }
        private void Waze_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.waze.com/he/livemap/directions?utm_expid=.K6QI8s_pTz6FfRdYRPpI3A.0&utm_referrer=&from=place.ChIJ2w9OVbGmHRUR6kNazqJE9hU");
        }

        private bool DateToCopmare(Order o)
        {

            int Days = o.GettargetDate().Day;
            int Months = o.GettargetDate().Month;
            int Years = o.GettargetDate().Year;
            int DaysP = dateTimePicker1.Value.Day;
            int MonthsP = dateTimePicker1.Value.Month;
            int YearsP = dateTimePicker1.Value.Year;

            DateTime ordersTargetDate = new DateTime(Years, Months, Days);
            DateTime inputDate = new DateTime(YearsP, MonthsP, DaysP);
            if (ordersTargetDate == inputDate)
            {
                return true;
            }
            else
                return false;
        }

        private void DividNorth()
        {
            foreach (Truck t in Program.Trucks)
            {

                if ((t.getcapacity() >= (TotalCapacityNorth) && (t.getoccupied() == true) && TruckTest.Contains(t) == false))
                {
                    int routeOrderNumN = 0;
                    Shipment tempShipment = null;
                    foreach (Order o in OrderNorth)
                    {
                        routeOrderNumN++;
                        var row = new string[] { o.getOrderId(), t.getID().ToString() };
                        ListViewItem l = new ListViewItem(row);
                        l.Tag = o;
                        o.setrouteOrderNum(routeOrderNumN);
                        if (tempShipment == null)
                        {
                            tempShipment = CreateShipment(t);
                        }
                        o.setOrderShipment(tempShipment);
                        o.Update_Order();
                        Shipment1.Items.Add(l);
                        TruckTest.Add(t);
                        SendEmail se = new SendEmail();
                        se.sendEmail("Dear" + t.getDriver().get_name(), "You have new assigment for shipment, here are the full information" + Environment.NewLine + o.getID(), t.getDriver().get_email());
                    }

                    break;
                }
                else
                {
                    if (TruckTest.Contains(t) == false)
                    {
                        TruckToNorth.Add(t);
                        foreach (Truck tr in TruckToNorth)
                        {
                            TotalTruckNorth = TotalTruckNorth + tr.getcapacity();
                            if (TotalTruckNorth >= TotalCapacityNorth && (tr.getoccupied() == true))
                            {
                                int routeOrderNumN = 0;
                                Shipment tempShipment = null;
                                foreach (Order o in OrderNorth)
                                {
                                    routeOrderNumN++;
                                    var row = new string[] { o.getOrderId(), tr.getID().ToString() };
                                    ListViewItem l = new ListViewItem(row);
                                    float CapacityTest = tr.getcapacity();
                                    if (CapacityTest > o.Getcapacity())
                                    {
                                        CapacityTest = CapacityTest - o.Getcapacity();
                                        l.Tag = o;
                                        Shipment1.Items.Add(l);
                                        Truck1 = tr.getID().ToString();
                                        o.setrouteOrderNum(routeOrderNumN);
                                        if (tempShipment == null)
                                        {
                                            tempShipment = CreateShipment(t);
                                        }
                                        o.setOrderShipment(tempShipment);
                                        o.Update_Order();
                                        SendEmail se = new SendEmail();
                                        se.sendEmail("Dear" + tr.getDriver().get_name(), "You have new assigment for shipment, here are the full information" + Environment.NewLine + o.getID(), tr.getDriver().get_email());
                                        SendEmail eo = new SendEmail();
                                        eo.sendEmail("Your order has been assign to shipment", "Dear   " + o.getCustomer().getFirstName() + "   " + o.getCustomer().getLastName() + Environment.NewLine + "Your order:   " + o.getID() + " " + "has been assigned to a shipment, the date is:  " + DateTime.Now + Environment.NewLine + "The driver name is " + tr.getDriver().get_name(), o.getCustomer().getEmail());
                                    }
                                    else
                                    {
                                        l.Tag = o;
                                        listView5.Items.Add(l);
                                        Truck4 = tr.getID().ToString();
                                        o.setrouteOrderNum(routeOrderNumN);
                                        o.setOrderShipment(tempShipment);
                                        o.Update_Order();

                                        SendEmail se = new SendEmail();
                                        se.sendEmail("Dear" + t.getDriver().get_name(), "You have new assigment for shipment, here are the full information" + Environment.NewLine + o.getID(), t.getDriver().get_email());
                                        SendEmail eo = new SendEmail();
                                        eo.sendEmail("Your order has been assign to shipment", "Dear   " + o.getCustomer().getFirstName() + "   " + o.getCustomer().getLastName() + Environment.NewLine + "Your order:   " + o.getID() + " " + "has been assigned to a shipment, the date is:  " + DateTime.Now + Environment.NewLine + "The driver name is " + tr.getDriver().get_name(), o.getCustomer().getEmail());

                                    }
                                }
                            }
                        }

                    }
                }



            }
        }

        private void DividSouth()
        {
            foreach (Truck ts in Program.Trucks)
            {

                if ((ts.getcapacity() >= (TotalCapacitySouth) && (ts.getoccupied() == true) && TruckTest.Contains(ts) == false))
                {
                    Shipment tempShipment = null;
                    int routeOrderNumS = 0;

                    foreach (Order o in OrderSouth)
                    {
                        routeOrderNumS++;
                        var row = new string[] { o.getOrderId(), ts.getID().ToString() };
                        ListViewItem l = new ListViewItem(row);
                        l.Tag = o;
                        listView3.Items.Add(l);
                        TruckTest.Add(ts);
                        o.setrouteOrderNum(routeOrderNumS);
                        if (tempShipment == null)
                        {
                            tempShipment = CreateShipment(ts);
                        }
                        o.setOrderShipment(tempShipment);
                        o.Update_Order();
                        SendEmail se = new SendEmail();
                        se.sendEmail("Dear" + ts.getDriver().get_name(), "You have new assigment for shipment, here are the full information" + Environment.NewLine + o.getID(), ts.getDriver().get_email());
                        SendEmail eo = new SendEmail();
                        eo.sendEmail("Your order has been assign to shipment", "Dear   " + o.getCustomer().getFirstName() + "   " + o.getCustomer().getLastName() + Environment.NewLine + "Your order:   " + o.getID() + " " + "has been assigned to a shipment, the date is:  " + DateTime.Now + Environment.NewLine + "The driver name is " + ts.getDriver().get_name(), o.getCustomer().getEmail());


                    }

                    break;

                }
                else
                 if (TruckTest.Contains(ts) == false)
                {
                    {
                        int routeOrderNumS = 0;

                        TruckToSouth.Add(ts);
                        foreach (Truck tr in TruckToSouth)
                        {
                            routeOrderNumS++;
                            TotalTruckSouth = TotalTruckSouth + tr.getcapacity();
                            if (TotalTruckSouth >= TotalCapacitySouth && (tr.getoccupied() == true))
                            {
                                Shipment tempShipment = null;
                                foreach (Order o in OrderSouth)
                                {
                                    routeOrderNumS++;
                                    var row = new string[] { o.getOrderId(), tr.getID().ToString() };

                                    ListViewItem l = new ListViewItem(row);
                                    float CapacityTest = tr.getcapacity();
                                    if (CapacityTest > o.Getcapacity())
                                    {
                                        CapacityTest = CapacityTest - o.Getcapacity();
                                        l.Tag = o;
                                        listView3.Items.Add(l);
                                        o.setrouteOrderNum(routeOrderNumS);
                                        if (tempShipment == null)
                                        {
                                            tempShipment = CreateShipment(tr);
                                        }
                                        o.setOrderShipment(tempShipment);
                                        o.Update_Order();
                                        Truck2 = tr.getID().ToString();
                                        SendEmail se = new SendEmail();
                                        se.sendEmail("Dear" + tr.getDriver().get_name(), "You have new assigment for shipment, here are the full information" + Environment.NewLine + o.getID(), tr.getDriver().get_email());
                                        SendEmail eo = new SendEmail();
                                        eo.sendEmail("Your order has been assign to shipment", "Dear   " + o.getCustomer().getFirstName() + "   " + o.getCustomer().getLastName() + Environment.NewLine + "Your order:   " + o.getID() + " " + "has been assigned to a shipment, the date is:  " + DateTime.Now + Environment.NewLine + "The driver name is " + tr.getDriver().get_name(), o.getCustomer().getEmail());

                                    }
                                    else
                                    {
                                        l.Tag = o;
                                        listView6.Items.Add(l);
                                        Truck4 = tr.getID().ToString();
                                        o.setrouteOrderNum(routeOrderNumS);
                                        if (tempShipment == null)
                                        {
                                            tempShipment = CreateShipment(tr);
                                        }
                                        o.setOrderShipment(tempShipment);
                                        o.Update_Order();
                                        SendEmail se = new SendEmail();
                                        se.sendEmail("Dear" + tr.getDriver().get_name(), "You have new assigment for shipment, here are the full information" + Environment.NewLine + o.getID(), tr.getDriver().get_email());
                                        SendEmail eo = new SendEmail();
                                        eo.sendEmail("Your order has been assign to shipment", "Dear   " + o.getCustomer().getFirstName() + "   " + o.getCustomer().getLastName() + Environment.NewLine + "Your order:   " + o.getID() + " " + "has been assigned to a shipment, the date is:  " + DateTime.Now + Environment.NewLine + "The driver name is " + tr.getDriver().get_name(), o.getCustomer().getEmail());
                                    }

                                }
                            }

                        }
                    }
                }

            }
        }

        private void DividCenter()
        {
            foreach (Truck tc in Program.Trucks)
            {

                if ((tc.getcapacity() >= (TotalCapacityCenter) && (tc.getoccupied() == true) && TruckTest.Contains(tc) == false))
                {
                    int routeOrderNumC = 0;
                    Shipment tempShipment = null;

                    foreach (Order o in OrderCenter)
                    {
                        routeOrderNumC++;
                        var row = new string[] { o.getOrderId(), tc.getID().ToString() };
                        ListViewItem l = new ListViewItem(row);
                        l.Tag = o;
                        listView4.Items.Add(l);
                        Truck3 = tc.getID().ToString();
                        o.setrouteOrderNum(routeOrderNumC);
                        if (tempShipment == null)
                        {
                            tempShipment = CreateShipment(tc);
                        }
                        o.setOrderShipment(tempShipment);
                        o.Update_Order();
                        SendEmail se = new SendEmail();
                        se.sendEmail("Dear" + tc.getDriver().get_name(), "You have new assigment for shipment, here are the full information" + Environment.NewLine + o.getID(), tc.getDriver().get_email());
                        SendEmail eo = new SendEmail();
                        eo.sendEmail("Your order has been assign to shipment", "Dear   " + o.getCustomer().getFirstName() + "   " + o.getCustomer().getLastName() + Environment.NewLine + "Your order:   " + o.getID() + " " + "has been assigned to a shipment, the date is:  " + DateTime.Now + Environment.NewLine + "The driver name is " + tc.getDriver().get_name(), o.getCustomer().getEmail());

                    }


                    break;
                }
                else
                 if (TruckTest.Contains(tc) == false)
                {
                    {

                        TruckToCenter.Add(tc);
                        foreach (Truck tr in TruckToCenter)
                        {

                            TotalTruckCenter = TotalTruckCenter + tc.getcapacity();
                            if (TotalTruckCenter >= TotalCapacityCenter && (tr.getoccupied() == true))
                            {
                                Shipment tempShipment = null;
                                int routeOrderNumC = 0;
                                foreach (Order o in OrderCenter)
                                {
                                    routeOrderNumC++;
                                    var row = new string[] { o.getOrderId(), tc.getID().ToString() };
                                    ListViewItem l = new ListViewItem(row);
                                    float CapacityTest = tr.getcapacity();
                                    if (CapacityTest > o.Getcapacity())
                                    {
                                        CapacityTest = CapacityTest - o.Getcapacity();
                                        l.Tag = o;
                                        listView4.Items.Add(l);
                                        Truck3 = tr.getID().ToString();
                                        o.setrouteOrderNum(routeOrderNumC);
                                        if (tempShipment == null)
                                        {
                                            tempShipment = CreateShipment(tc);
                                        }
                                        o.setOrderShipment(tempShipment);
                                        o.Update_Order();
                                        SendEmail se = new SendEmail();
                                        se.sendEmail("Dear" + tr.getDriver().get_name(), "You have new assigment for shipment, here are the full information" + Environment.NewLine + o.getID(), tr.getDriver().get_email());
                                        SendEmail eo = new SendEmail();
                                        eo.sendEmail("Your order has been assign to shipment", "Dear   " + o.getCustomer().getFirstName() + "   " + o.getCustomer().getLastName() + Environment.NewLine + "Your order:   " + o.getID() + " " + "has been assigned to a shipment, the date is:  " + DateTime.Now + Environment.NewLine + "The driver name is " + tr.getDriver().get_name(), o.getCustomer().getEmail());
                                    }
                                    else
                                    {
                                        l.Tag = o;
                                        listView6.Items.Add(l);
                                        o.setrouteOrderNum(routeOrderNumC);
                                        if (tempShipment == null)
                                        {
                                            tempShipment = CreateShipment(tc);
                                        }
                                        o.setOrderShipment(tempShipment);
                                        o.Update_Order();
                                        Truck5 = tr.getID().ToString();
                                        SendEmail se = new SendEmail();
                                        se.sendEmail("Dear" + tr.getDriver().get_name(), "You have new assigment for shipment, here are the full information" + Environment.NewLine + o.getID(), tr.getDriver().get_email());
                                        SendEmail eo = new SendEmail();
                                        eo.sendEmail("Your order has been assign to shipment", "Dear   " + o.getCustomer().getFirstName() + "   " + o.getCustomer().getLastName() + Environment.NewLine + "Your order:   " + o.getID() + " " + "has been assigned to a shipment, the date is:  " + DateTime.Now + Environment.NewLine + "The driver name is " + tr.getDriver().get_name(), o.getCustomer().getEmail());
                                    }

                                }
                            }

                        }
                    }
                }

            }
        }

        private void DividToShipment()
        {
            int DriversInput = int.Parse(NumOfDrivers.Text);// the user input for drivers

            if (DriversInput >= 1)
            {
                Shipment1Text.Show();
                Shipment1.Show();
                List<Order> Shipment11 = new List<Order>();

            }

            if (DriversInput >= 2)
            {
                Shipment2Text.Show();
                listView3.Show();
                List<Order> Shipment12 = new List<Order>();

            }

            if (DriversInput >= 3)
            {
                Shipment3Text.Show();
                listView4.Show();
                List<Order> Shipment13 = new List<Order>();

            }
            if (DriversInput >= 4)
            {
                label5.Show();
                listView5.Show();
                List<Order> Shipment14 = new List<Order>();

            }
            if (DriversInput >= 5)
            {
                Shipment5Text.Show();
                listView6.Show();
                List<Order> Shipment15 = new List<Order>();

            }

        }


        public Shipment CreateShipment(Truck t)
        {
            Shipment newShipment = new Shipment(DateTime.Now, t);
            Program.Shipments.Add(newShipment);
            newShipment.create_Shipment();
            return newShipment;
        }



    }




}