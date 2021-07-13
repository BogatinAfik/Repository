using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KallkarProject
{
    public class Area
    {
        private int areaNum;
        private Boolean occupied;
        private float capacity;
        public Storage storage;
        public System.Collections.Generic.List<Order> orders;



        public Area(int areaNum, bool occupied, Storage storage, float capacity)
        {
            this.areaNum = areaNum;
            this.occupied = occupied;
            this.capacity = capacity;
            this.storage = storage;
            orders = new List<Order>();

        }

        // set ו get לווקטור של הזמנות
    /*    public System.Collections.Generic.List<Order> Orders
        {
            get
            {
                if (orders == null)
                    orders = new System.Collections.Generic.List<Order>();
                return orders;
            }
            set
            {
                RemoveAllOrders();
                if (value != null)
                {
                    foreach (Order oOrder in value)
                        AddOrders(oOrder);
                }
            }
        }*/

        public void Update_Area_Occuiped(int areaNum1, Boolean isItOccupied)
        {
            this.occupied = isItOccupied;
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_Update_Area_Occuiped @AreaNumber, @Occuiped";
            c.Parameters.AddWithValue("@AreaNumber", areaNum1);
            c.Parameters.AddWithValue("@Occuiped", isItOccupied);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
            
        }

        public void RemoveAllOrders()
        {
            if (orders != null)
            {
                System.Collections.ArrayList tmpOrders = new System.Collections.ArrayList();
                foreach (Order oldOrder in orders)
                    tmpOrders.Add(oldOrder);
                orders.Clear();
                foreach (Order oldOrder in tmpOrders)
                    //  oldOrder.Worker = null;
                    tmpOrders.Clear();
            }
        }
       

        public void RemoveOrders(Order oldOrder)
        {
            if (oldOrder == null)
                return;
            if (this.orders != null)
                if (this.orders.Contains(oldOrder))
                {
                    this.orders.Remove(oldOrder);
                    //  oldOrder.Worker = null;
                }
        }

        public int getAreaNum()
        {
            return this.areaNum;
        }

        public float freeSpace()
        {
            float ordersCapacity = 0;
            foreach (Order ord in this.orders)
            {
                //  ord.CalculateOrdeSize();
                ordersCapacity = (ordersCapacity + ord.Getcapacity());
            }
            float free_space = (this.capacity - ordersCapacity);
            return free_space;
        }
        public void changeOccupied(bool b)
        {

        }

        public Storage getStorage()
        {
            return this.storage;
        }
        public void setOrders(Order o)
        {
            orders.Add(o);
        }
        public void RemoveFromOrders(Order o)
        {
            orders.Remove(o);
        }
        public string toString()
        {
            if (this.storage.getStorageNum() == 1)
                return ("a"+areaNum.ToString());
            else if (this.storage.getStorageNum() == 2)
                return ("b" + areaNum.ToString());
            else if (this.storage.getStorageNum() == 3)
                return ("c" + areaNum.ToString());
            else if (this.storage.getStorageNum() == 4)
                return ("d" + areaNum.ToString());
            else
                return ("e" + areaNum.ToString());
        }
        public bool getOccupied(){
            float f = freeSpace();
            if (f == 0) {
                Update_Area_Occuiped(this.areaNum, true);
            }
            return this.occupied;
        }
    }
}


