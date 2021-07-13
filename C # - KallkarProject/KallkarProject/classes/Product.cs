using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace KallkarProject
{
   public class Product
    {
        private string productID;
        private string productName;
        private float weight;
        private float capacity;
        private SqlMoney price;
        private string pictureURL;
        private DateTime createDate;
        private Category productCategory; // enummmmm
        public static int serialNum;

        public Product(string productID, string productName, SqlMoney price, DateTime createDate, string pictureURL, float capacity, float weight, Category productCategory)
        {
            this.productID = productID;
            this.productName = productName;
            this.weight = weight;
            this.capacity = capacity;
            this.price = price;
            this.pictureURL = pictureURL;
            this.createDate = createDate;
            this.productCategory = productCategory;
        }

        public static void setserialNum(int temp)
        {
            serialNum = temp;
        }
        public string getID()
        {
            return this.productID;
        }
        public string getName()
        {
            return this.productName;
        }
        public float getCapacity()
        {
            return this.capacity;
        }
        public float getWeight()
        {
            return this.weight;
        }
        public SqlMoney getPrice()
        {
            return this.price;
        }
        public string getURL()
        {
            return this.pictureURL;
        }
        public DateTime getCreateDate()
        {
            return this.createDate;
        }
        public Category getCategory()
        {
            return this.productCategory;
        }
        public void setName(string name)
        {
            this.productName = name;
        }
        public void setPrice(SqlMoney price)
        {
            this.price = price;
        }
        public void setSketch(string url)
        {
            this.pictureURL = url;
        }
        public void setCapacity(float capa)
        {
            this.capacity = capa;
        }
        public void setWeight(float weight)
        {
            this.weight = weight;
        }
        public void setCategory(Category cat)
        {
            this.productCategory = cat;
        }


        public void Update_Product()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Product @ProductID , @ProductName , @Price  , @visualSKetch , @Capacity , @Weight , @Category";
            c.Parameters.AddWithValue("@ProductID", this.productID);
            c.Parameters.AddWithValue("@ProductName", this.productName);
            c.Parameters.AddWithValue("@Price", this.price);
            c.Parameters.AddWithValue("@visualSKetch", this.pictureURL);
            c.Parameters.AddWithValue("@Capacity", this.capacity);
            c.Parameters.AddWithValue("@Weight", this.weight);
            c.Parameters.AddWithValue("@category", this.productCategory.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void create_Product()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Add_Product @ProductID , @ProductName , @Price , @CreateDate , @visualSKetch , @Capacity , @Weight , @category";
            c.Parameters.AddWithValue("@ProductID", this.productID);
            c.Parameters.AddWithValue("@ProductName", this.productName);
            c.Parameters.AddWithValue("@Price", this.price);
            c.Parameters.AddWithValue("@CreateDate", this.createDate);
            c.Parameters.AddWithValue("@visualSKetch", this.pictureURL);
            c.Parameters.AddWithValue("@Capacity", this.capacity);
            c.Parameters.AddWithValue("@Weight", this.weight);
            c.Parameters.AddWithValue("@category", this.productCategory.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

    }
}
