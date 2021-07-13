using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace KallkarProject
{
    public class Customer
    {
        private string id;
        private string firstName;
        private string lastName;
        private string phone;
        private string email;
        private DateTime dateOfBirth;
        private string address;
        private Gender gender; // enum
        private customerType type; // enum
        private string password;
        public System.Collections.Generic.List<Order> orders;// חסר גאטרים וסאטרים


        public Customer(string id, string firstName, string lastName, string phone, string email, DateTime dateOfBirth,
            string address, string password, Gender gender, customerType type)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.email = email;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            this.password = password;
            this.gender = gender;
            this.type = type;
            orders = new List<Order>();
         //   if (isNew)
         //    {
         //       this.create_Customer();
         //       Program.Customers.Add(this);
         //  }
        }
        public void create_Customer()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Add_Customer @CustomerID, @CustomerFirstName,@CustomerLastName,@CustomerPhone,@CustomerEmail,@DOB,@address,@password,@gender,@customerType";
            c.Parameters.AddWithValue("@CustomerID", this.id);
            c.Parameters.AddWithValue("@CustomerFirstName", this.firstName);
            c.Parameters.AddWithValue("@CustomerLastName", this.lastName);
            c.Parameters.AddWithValue("@CustomerPhone", this.phone);
            c.Parameters.AddWithValue("@CustomerEmail", this.email);
            c.Parameters.AddWithValue("@DOB", this.dateOfBirth);
            c.Parameters.AddWithValue("@address", this.address);
            c.Parameters.AddWithValue("@password", this.password);
            c.Parameters.AddWithValue("@gender", this.gender.ToString());
            c.Parameters.AddWithValue("@customerType", this.type.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void Update_Customer()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Customer @CustomerID,@CustomerFirstName, @CustomerLastName , @CustomerPhone,@CustomerEmail,@DOB, @address,@password,@gender,@customerType";
            c.Parameters.AddWithValue("@CustomerID", this.id);
            c.Parameters.AddWithValue("@CustomerFirstName", this.firstName);
            c.Parameters.AddWithValue("@CustomerLastName", this.lastName);
            c.Parameters.AddWithValue("@CustomerPhone", this.phone);
            c.Parameters.AddWithValue("@CustomerEmail", this.email);
            c.Parameters.AddWithValue("@DOB", this.dateOfBirth);
            c.Parameters.AddWithValue("@address", this.address);
            c.Parameters.AddWithValue("@password", this.password);
            c.Parameters.AddWithValue("@gender", this.gender.ToString());
            c.Parameters.AddWithValue("@CustomerType", this.type.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);


        }
        public string getID()
        {
            return this.id;
        }
        public string getPassword()
        {
            return this.password;
        }
        public string getFirstName()
        {
            return this.firstName;
        }
        public string getLastName()
        {
            return this.lastName;
        }
        public string getEmail()
        {
            return this.email;
        }
        public string getPhone()
        {
            return this.phone;
        }
        public string getAddress()
        {
            return this.address;
        }
        public DateTime getDob()
        {
            return this.dateOfBirth;
        }
        public Gender getGender()
        {
            return this.gender;
        }
        public void setfistName(string s)
        {
            this.firstName = s;

        }
        public void setlastName(string s)
        {
            this.lastName = s;

        }
        public void setphone(string s)
        {
            this.phone = s;

        }
        public void setEmail(string s)
        {
            this.email = s;

        }
        public void setAddress(string s)
        {
            this.address = s;

        }
        public void setDob(DateTime s)
        {
            this.dateOfBirth = s;

        }
        public void setType(customerType js)
        {
            this.type = js;

        }
        public void setGender(Gender js)
        {
            this.gender = js;

        }
        public void setPassword(string pass)
        {
            this.password = pass;

        }
       
        
        }
    }