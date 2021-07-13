using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Data.SqlTypes;
namespace KallkarProject
{
    public class Order
    {
        private string orderId;
        private DateTime orderDate;
        private DateTime targetDate;
        private float capacity;
        private OrderStatus orderStatus; // enummmm
        public Customer customer;
        public Shipment shipment;
        private int routeOrderNum;
        private string destenation;
        private float weight;
        public static int serialNum;
        public Area areaInStorage;
        private DateTime ProductionDate;
        private SqlMoney Price;



        // public System.Collections.Generic.List<Area> inAreas; //  לא עשינו עדיין שיטת גטרים וסאטרים


        public Order(string orderId, DateTime orderDate, DateTime targetDate, Customer customer, Shipment shipment, int routeOrderNum, string destenation, float weight, float capa, OrderStatus orderStatus, SqlMoney price)
        {
            this.orderId = orderId;
            this.orderDate = orderDate;
            this.targetDate = targetDate;
            this.capacity = capa;
            this.orderStatus = orderStatus;
            this.customer = customer;
            this.shipment = shipment;
            this.routeOrderNum = routeOrderNum;
            this.destenation = destenation;
            this.weight = weight;
     //       inAreas = new List<Area>();
            shipment = null;
            this.Price = price;
           

        }

        public int getTotalNumOfProduct() {
            int counter = 0;
            foreach (ProductInOrder po in Program.ProductInOrders) {
                if (po.getOrder().getID() == this.orderId) {
                    counter += po.getQuantity();
                }
            
            }
            return counter;
        
        }

        public Order(DateTime curentDate, DateTime targetDate1, Customer customer)   {  //order provide by customer
            serialNum += 1;
            orderId = serialNum.ToString();

            this.orderDate = curentDate;
            this.targetDate = targetDate1;
            this.customer = customer;
            destenation = customer.getAddress();
            capacity = 0;
        //    inAreas = new List<Area>();
            OrderStatus Os = (OrderStatus)Enum.Parse(typeof(OrderStatus), " waitingForApproval");
            orderStatus = Os;
            Price = 0;
        }


        public string getID()
        {
            return this.orderId;
        }
        public static void setserialNum(int temp)
        {
            serialNum = temp;
        }

        public void create_order()
        {

            MessageBox.Show(this.targetDate.ToString());
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_Add_Order34 @OrderID, @OrderDate, @TargetDate, @CustomerID, @ShipmentId, @RouteOrderNum, @Destenation, @Weight, @Capacity, @OrderStatus,@Price";
            c.Parameters.AddWithValue("@OrderID", this.orderId);
            c.Parameters.AddWithValue("@OrderDate", orderDate);
            c.Parameters.AddWithValue("@TargetDate", this.targetDate);
            c.Parameters.AddWithValue("@CustomerID", this.customer.getID());
            c.Parameters.AddWithValue("@ShipmentId", "0000");
            c.Parameters.AddWithValue("@RouteOrderNum", this.routeOrderNum);
            c.Parameters.AddWithValue("@Destenation", this.destenation);
            c.Parameters.AddWithValue("@Capacity", this.capacity);
            c.Parameters.AddWithValue("@Weight", this.weight);
            c.Parameters.AddWithValue("@OrderStatus", this.orderStatus.ToString());
            c.Parameters.AddWithValue("@Price", this.Price);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Update_Order()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_Update_Order @OrderID, @TargetDate, @ShipmentId, @RouteOrderNum, @Destenation, @Weight, @Capacity";
            c.Parameters.AddWithValue("@OrderID", this.orderId);
            c.Parameters.AddWithValue("@TargetDate", this.targetDate);
            c.Parameters.AddWithValue("@ShipmentId", this.shipment.getID());
            c.Parameters.AddWithValue("@RouteOrderNum", this.routeOrderNum.ToString());
            c.Parameters.AddWithValue("@Destenation", this.destenation);
            c.Parameters.AddWithValue("@Weight", this.weight.ToString());
            c.Parameters.AddWithValue("@Capacity", this.capacity.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
       

        public String displayOrders()
        {
            String temp = "order number:" + orderId + Environment.NewLine + "products: " + Environment.NewLine;
            foreach (ProductInOrder po in Program.ProductInOrders)
            {

                if (orderId == po.getOrder().getID())
                {

                    temp += po.getProduct().getID() + " " + po.getProduct().getName() + " -" + po.getProduct().getCapacity() + "-" + Environment.NewLine;
                }
            }
            return temp;
        }



        public string toString()
        {
            return "order number:" + orderId + ", customer:" + customer.getFirstName() + customer.getLastName() + ", destination:" + destenation + ", route Order Number:" + routeOrderNum+ Environment.NewLine;
        }
        public string getOrderId()
        {
            return this.orderId;
        }

        public void Update_Order_Status(string orderId1, OrderStatus newStatus)
        {
            this.orderStatus = newStatus;
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_Update_Order_Status @OrderID , @OrderStatus";
            c.Parameters.AddWithValue("@OrderID", orderId1);
            c.Parameters.AddWithValue("@OrderStatus", newStatus.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void Update_OrderPrice(string orderId1, SqlMoney Price)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_OrderPrice @OrderID , @Price";
            c.Parameters.AddWithValue("@OrderID", orderId1);
            c.Parameters.AddWithValue("@Price", Price);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public bool checkProductInOrder(Product temp)
        {

            foreach (ProductInOrder po in Program.ProductInOrders)
            {
                if (po.getOrder().getID() == this.orderId && po.getProduct().getID() == temp.getID())
                {
                    return true;

                }

            }
            return false;
        }



        public void moveToShipment()
        {
            
            areaInStorage = null;
            this.Update_Order_Status(this.orderId, ((OrderStatus)Enum.Parse(typeof(OrderStatus), "moveToShipment")));
            foreach (OrderInArea oia in Program.OrderInAreas)  {
                if (oia.getOrder().getOrderId() == this.orderId)  {
                    oia.Move_Order_From_Area(this.orderId, oia.getareaNum().getAreaNum());
                    oia.getareaNum().RemoveFromOrders(this);
                }

            }
        }

        public void CalculateOrdeSize()
        {
            float finalCapacity = 0;
            foreach (ProductInOrder pr in Program.ProductInOrders)
            {
                if ((this.orderId) == (pr.getOrder().getOrderId()))
                {
                    finalCapacity = ((float)finalCapacity + ((float)pr.getQuantity() * pr.getProduct().getCapacity()));
                }
            }
            capacity = finalCapacity;
            this.Update_Order();
            
        }
        public void CalculateOrderPrice()
        {
            SqlMoney FinalPrice = 0;
            foreach (ProductInOrder pr in Program.ProductInOrders)
            {
                if ((this.orderId) == (pr.getOrder().getOrderId()))
                {
                    FinalPrice = ((SqlMoney)FinalPrice + ((SqlMoney)pr.getQuantity() * pr.getProduct().getPrice()));
                }
            }
            Price = FinalPrice;
            this.Update_OrderPrice(this.orderId, FinalPrice);
        }

        public Area findPlaceInStorage(){
            CalculateOrdeSize();
            foreach (Area a in Program.Areas)
            {
                if (a.getOccupied() == false)       //the area is not occupied
                {
                    if (this.capacity <= a.freeSpace()){
                        return a;
                    }
                }
            }
            MessageBox.Show("there is not place in storages!!!");
             return null;
         }

        public void documentInStorage(Area a) {
            areaInStorage = a;
            a.setOrders(this);
            OrderInArea oa = new OrderInArea(this, a);
            this.Update_Order_Status(this.orderId, ((OrderStatus)Enum.Parse(typeof(OrderStatus), "ready")));
        }
        public bool checkDelayed(DateTime temp) {
            if (!this.orderStatus.ToString().Equals("delayed")) {
                if ((temp=temp.AddDays(5))> targetDate)
                {

                    SendEmail se = new SendEmail();
                    se.sendEmail("Your order is delayed", "dear customer," + Environment.NewLine + "your order number:" + this.orderId + " won't be ready on time, please make contact with the factory sales for new target date.", this.customer.getEmail());
                    this.Update_Order_Status(this.orderId, ((OrderStatus)Enum.Parse(typeof(OrderStatus), "delayed")));
                    return false;
                }
                else
                  return true;
                
            }
            else {
                return false;
            }
        }

        public DateTime GetProductionDate() {
            return this.ProductionDate;
        }
       
        
        public void setProductionDate(DateTime temp)
        {
            this.ProductionDate = temp;
        }

        public Area GetArea()   {
           return areaInStorage;
        }

        public void setAreaInStorage(Area a) {
            areaInStorage = a;
        }

        public OrderStatus getOrderStatus()     {
            return orderStatus;
        }
        public Customer getCustomer()
        {
            return customer;
        }
      
        public DateTime GettargetDate()
        {
            return this.targetDate;
        }
        public float Getcapacity()
        {
            CalculateOrdeSize();
            return this.capacity;
        }
        public Customer GetCustomer()
        {
            return this.customer;
        }
       /* public Shipment Getshipment()
        {
            return this.shipment;
        }*//* public Shipment Getshipment()
        {
            return this.shipment;
        }*/
        public int GetrouteOrderNum()
        {
            return this.routeOrderNum;
        }
        public String Getdestenation()
        {
            return this.destenation;
        }
        public float Getweight()
        {
            return this.weight;
        }
        
        public Shipment GetShipment()
        {

            return this.shipment;

        }
        public DateTime getorderDate()
        {
            return orderDate;
        }
        public SqlMoney GetPrice()
        {
            CalculateOrderPrice();
            return this.Price;
        }

        public void setPrice(SqlMoney tempPrice) {
            this.Price += tempPrice;
        }
    }


}