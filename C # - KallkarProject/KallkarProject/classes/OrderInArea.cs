using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KallkarProject
{
    public class OrderInArea
    {
        private Order order;
        private Area areaNum;

        public OrderInArea(Order order, Area areaNum)
        {
            this.order = order;
            this.areaNum = areaNum;
        }
        public void create_AreaInOrder()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE [dbo].[SP_Add_OrderInArea] @OrderID , @AreaNumber";
            c.Parameters.AddWithValue("@OrderID", this.order.getID());
            c.Parameters.AddWithValue("@AreaNumber", this.areaNum.getAreaNum().ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Move_Order_From_Area(string orderId1, int areaNum)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_delete_OrderInArea @OrderID , @AreaNumber";
            c.Parameters.AddWithValue("@OrderID", orderId1);
            c.Parameters.AddWithValue("@AreaNumber", areaNum.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
       

        public Order getOrder()
        {
            return this.order;
        }
        public Area getareaNum()
        {
            return this.areaNum;
        }

    }
}


