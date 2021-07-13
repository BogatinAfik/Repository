using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace KallkarProject
{
    static class Program 
    {
        /// <summary>
        /// 
        public static System.Collections.Generic.List<Employee> Employees;
        public static System.Collections.Generic.List<Customer> Customers;
        public static System.Collections.Generic.List<Order> Orders;
        public static System.Collections.Generic.List<Machine> Machines;
        public static System.Collections.Generic.List<Shipment> Shipments;
        public static System.Collections.Generic.List<Truck> Trucks;
        public static System.Collections.Generic.List<Product> Products;
        public static System.Collections.Generic.List<Storage> Storages;
        public static System.Collections.Generic.List<Area> Areas;
        public static System.Collections.Generic.List<kalkarFactory> kalkarFactory1;
        public static System.Collections.Generic.List<ProductInOrder> ProductInOrders;
        public static System.Collections.Generic.List<OrderInArea> OrderInAreas;
        public static System.Collections.Generic.List<EmployeesInFactory> EmployeesInFactory1;
        

        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            initLists();
            Application.EnableVisualStyles();
            //MessageBox.Show(Customers.Count().ToString());
            Application.SetCompatibleTextRenderingDefault(false);
          //אתחול כל הרשימות
           Application.Run(new main_form());
        }
        public static void initLists()//מילוי הרשימות מתוך בסיס הנתונים
        {
            init_KalkarFactory();
            init_Storage();
            init_Employee();
            init_Customer();
            init_Machine();
            init_Trucks();
            init_Shipment();
            init_Order();
            init_Area();
            init_Product();
            init_ProductInOrder();
            init_OrderInArea();
        }

        public static void init_Customer()//מילוי המערך מתוך בסיס הנתונים
        {

            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Customers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Customers = new List<Customer>();


            while (rdr.Read())
            {
                Gender G = (Gender)Enum.Parse(typeof(Gender), rdr.GetValue(8).ToString());
                customerType CT = (customerType)Enum.Parse(typeof(customerType), rdr.GetValue(9).ToString());
                Customer cus = new Customer(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString()
                                    , rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(),
                                     DateTime.Parse((rdr.GetValue(5).ToString())), rdr.GetValue(6).ToString(), rdr.GetValue(7).ToString(), G, CT);
                Customers.Add(cus);
            }
        }

        public static void init_Order()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Orders";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Orders = new List<Order>();

            while (rdr.Read())
            {
                OrderStatus Ord = (OrderStatus)Enum.Parse(typeof(OrderStatus), rdr.GetValue(9).ToString());
                Order o = new Order(rdr.GetValue(0).ToString(), DateTime.Parse(rdr.GetValue(1).ToString()), DateTime.Parse(rdr.GetValue(2).ToString()), seeCustomer(rdr.GetValue(3).ToString()), seeShipment(rdr.GetValue(4).ToString()), int.Parse(rdr.GetValue(5).ToString()), rdr.GetValue(6).ToString(), float.Parse(rdr.GetValue(7).ToString()), float.Parse(rdr.GetValue(8).ToString()), Ord,SqlMoney.Parse(rdr.GetValue(10).ToString()));
                Orders.Add(o);
            }
           
            Order.setserialNum(int.Parse(Orders.Last().getID()));
        }

        public static void init_Employee()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand r = new SqlCommand();
            r.CommandText = "EXECUTE dbo.Get_all_Employees";
            SQL_CON Se = new SQL_CON();
            SqlDataReader rdr = Se.execute_query(r);

            Employees = new List<Employee>();

            while (rdr.Read())
            {
                Gender G = (Gender)Enum.Parse(typeof(Gender), rdr.GetValue(7).ToString());
                Role R = (Role)Enum.Parse(typeof(Role), rdr.GetValue(6).ToString());
                Employee e = new Employee(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), DateTime.Parse(rdr.GetValue(4).ToString()), rdr.GetValue(5).ToString(), R, G);
                Employees.Add(e);
            }
            }
            
            public static void init_Machine()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Machines";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Machines = new List<Machine>();

            while (rdr.Read())
            {
                MachineStatus MS = (MachineStatus)Enum.Parse(typeof(MachineStatus), rdr.GetValue(3).ToString());
                MachineType MR = (MachineType)Enum.Parse(typeof(MachineType), rdr.GetValue(4).ToString());
                Machine m = new Machine(rdr.GetValue(0).ToString(), float.Parse(rdr.GetValue(1).ToString()), int.Parse(rdr.GetValue(2).ToString()), MS, MR);
                Machines.Add(m);
            }


        }
        public static void init_Shipment()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Shipments";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Shipments = new List<Shipment>();

            while (rdr.Read())
            {
                Shipment s = new Shipment(rdr.GetValue(0).ToString(),DateTime.Parse(rdr.GetValue(1).ToString()), seeTruck(rdr.GetValue(2).ToString()));
                Shipments.Add(s);
            }
            Shipment.setShipmentSrieal(int.Parse(Shipments.Last().getID()));
        }


        public static void init_Storage()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Storages";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Storages = new List<Storage>();

            while (rdr.Read())
            {
                Storage s = new Storage(int.Parse(rdr.GetValue(0).ToString()), float.Parse(rdr.GetValue(1).ToString()));
                Storages.Add(s);
            }
        }

        public static void init_Trucks()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Trucks";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Trucks = new List<Truck>();

            while (rdr.Read())
            {
                Truck t = new Truck(rdr.GetValue(0).ToString(), float.Parse(rdr.GetValue(1).ToString()),true,seeEmployee(rdr.GetValue(3).ToString()));
                Trucks.Add(t);
            }
        }


        public static void init_OrderInArea()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_OrdersInArea";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            OrderInAreas = new List<OrderInArea>();

            while (rdr.Read())
            {
                OrderInArea oa = new OrderInArea(seeOrder(rdr.GetValue(0).ToString()), seeArea((rdr.GetValue(1).ToString())));
                OrderInAreas.Add(oa);
                foreach (Area a in Areas) {
                    if (oa.getareaNum().getAreaNum() == a.getAreaNum()) {
                        a.setOrders(oa.getOrder());
                    }
                }
                oa.getOrder().setAreaInStorage(oa.getareaNum());
            }
        }



        public static void init_Product()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Products";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Products = new List<Product>();


            while (rdr.Read())
            {
                Category cp = (Category)Enum.Parse(typeof(Category), rdr.GetValue(7).ToString());
                Product p = new Product(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), SqlMoney.Parse(rdr.GetValue(2).ToString()), DateTime.Parse(rdr.GetValue(3).ToString()), rdr.GetValue(4).ToString(), float.Parse(rdr.GetValue(5).ToString()), float.Parse(rdr.GetValue(6).ToString()), cp);
                Products.Add(p);
            }
            Product.setserialNum(int.Parse(Products.Last().getID()));

        }


        public static void init_ProductInOrder()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_ProductsInOrder";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            ProductInOrders = new List<ProductInOrder>();

            while (rdr.Read())
            {
                ApprovalStatus ap = (ApprovalStatus)Enum.Parse(typeof(ApprovalStatus), rdr.GetValue(4).ToString());
                ProductInOrder ps = new ProductInOrder(seeProduct(rdr.GetValue(0).ToString()), seeOrder(rdr.GetValue(1).ToString()), int.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), ap);
                ProductInOrders.Add(ps);
            }
        }

        public static void init_KalkarFactory()//מילוי המערך מתוך בסיס הנתונים
        {

            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_KALKARFactory";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            kalkarFactory1 = new List<kalkarFactory>();


            while (rdr.Read())
            {
                kalkarFactory kl = new kalkarFactory(rdr.GetValue(0).ToString());
                kalkarFactory1.Add(kl);
            }
        }

        public static void init_Area()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Areas";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Areas = new List<Area>();


            while (rdr.Read())
            {
                
                Area a = new Area(int.Parse(rdr.GetValue(0).ToString()), Boolean.Parse(rdr.GetValue(1).ToString()), seeStorage(rdr.GetValue(2).ToString()), float.Parse(rdr.GetValue(3).ToString()));
                Areas.Add(a);
            }
        }

        public static void init_EmployeesInFactory()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_EmployeesInFactory";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            EmployeesInFactory1 = new List<EmployeesInFactory>();

            while (rdr.Read())
            {
                EmployeesInFactory ef = new EmployeesInFactory(seeFactory(rdr.GetValue(0).ToString()), seeEmployee(rdr.GetValue(1).ToString()));
                EmployeesInFactory1.Add(ef);
            }
        }


        public static Order seeOrder(string id)
        {
            foreach (Order o in Orders)
            {
                if (o.getID() == id)
                    return o;
            }
            return null;
        }

        public static Product seeProduct(string id)
        {
            foreach (Product p in Products)
            {
                if (p.getID() == id)
                    return p;
            }
            return null;
        }

        public static kalkarFactory seeFactory(string id)
        {
            foreach (kalkarFactory k in kalkarFactory1)
            {
                if (k.getName() == id)
                    return k;
            }
            return null;
        }

        public static Customer seeCustomer(string id)
            {
                foreach (Customer c in Customers)
                {
                    if (c.getID() == id)
                        return c;
                }
                return null;
            }


            public static Shipment seeShipment(string id)
            {
                foreach (Shipment s in Shipments)
                {
                    if (s.getID() == id)
                        return s;
                }
                return null;
            }

        public static Storage seeStorage(string id)
        {
            foreach (Storage s in Storages)
            {
                if (s.getStorageNum() == int.Parse(id))
                    return s;
            }
            return null;
        }


        public static Area seeArea(string areaNum)
        {
            foreach (Area a in Areas)
            {
                if (a.getAreaNum () == int.Parse(areaNum))
                return a;
            }
            return null;
        }


        public static Employee seeEmployee(string id)
        {
            foreach (Employee e in Employees)
            {
                if (e.getID() == id)
                    return e;
            }
            return null;
        }
        public static Truck seeTruck(string id)
        {
            foreach (Truck t in Trucks)
            {
                if (t.getID() == id)
                    return t;
            }
            return null;
        }


    }
}

