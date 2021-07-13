using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KallkarProject
{
    public class ProductInOrder
    {
        public Product product;
        public Order order;
        private int quantity;
        private ApprovalStatus approveStatus;
        private string additionakComments= "no";

        public ProductInOrder(Product product, Order order, int quantity, string additionakComments, ApprovalStatus approveStatus)
        {
            this.product = product;
            this.order = order;
            this.quantity = quantity;
            this.approveStatus = approveStatus;
            this.additionakComments = additionakComments;
        }

        public void create_ProductInOrder()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Add_ProductInOrder1 @ProductID, @OrderID, @quantity, @AdditionalComment, @ApprovalStatus";
            c.Parameters.AddWithValue("@ProductID", this.product.getID());
            c.Parameters.AddWithValue("@OrderID", this.order.getID());
            c.Parameters.AddWithValue("@quantity", this.quantity.ToString());
            c.Parameters.AddWithValue("@AdditionalComment", this.additionakComments);
            c.Parameters.AddWithValue("@ApprovalStatus", this.approveStatus.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public Order getOrder()
        {
            return this.order;
        }
        public Product getProduct()
        {
            return this.product;
        }
        public int getQuantity()
        {
            return this.quantity;
        }
        public string getComents()
        {
            return additionakComments;
        }
    }
}
