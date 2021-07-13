using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KallkarProject
{
   public class Employee
    {
        private string id;
        private string name;
        private Gender gender; // enum
        private DateTime dateOfBirth;
        private string email;
        private DateTime startDate;
        private Role role;// enum
        private string password;
        public Employee(string id, string name, DateTime dateOfBirth, string email, DateTime startDate, string password, Role role, Gender gender)
        {
            this.id = id;
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.email = email;
            this.startDate = startDate;
            this.password = password;
            this.role = role;
            this.gender = gender;

        }
        public void create_employee()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_Add_Employee @EmployeeId, @name, @DOB @Email, @StartDate, @Password, @Role, @gender";
            c.Parameters.AddWithValue("@id", this.id);
            c.Parameters.AddWithValue("@name", this.name);
            c.Parameters.AddWithValue("@DOB", this.dateOfBirth);
            c.Parameters.AddWithValue("@Email", this.email);
            c.Parameters.AddWithValue("@StartDate", this.startDate);
            c.Parameters.AddWithValue("@Password", this.password);
            c.Parameters.AddWithValue("@Role", this.role.ToString());
            c.Parameters.AddWithValue("@gender", this.gender.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Update_Employee()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Employee  @EmployeeId, @name, @Email, @Password, @Role, @gender";
            c.Parameters.AddWithValue("@EmployeeId", this.id);
            c.Parameters.AddWithValue("@name", this.name);
            c.Parameters.AddWithValue("@Email", this.email);
            c.Parameters.AddWithValue("@Password", this.password);
            c.Parameters.AddWithValue("@Role", this.role.ToString());
            c.Parameters.AddWithValue("@gender", this.gender.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }




        public string getID()
        {
            return this.id;
        }
        public string getPassword()
        {
           return password;
        }
        public String get_email() {
            return this.email;
        }
        public DateTime getDateOfBirth() {
            return this.dateOfBirth;
        }
        public string get_name()
        {
            return this.name;
        }
        public Role get_role()
        {
            return this.role;
        }
        public void set_role(Role r)
        {
            this.role = r;
        }
        
        public Gender getGender()
        {
            return this.gender;
        }

        public string getemail()
        {
            return this.email;
        }

        
        public DateTime getDob()
        {
            return this.dateOfBirth;
        }
       
        public void set_Name(string name)
        {
            this.name = name;
        }
        public void set_Gender(Gender gender)
        {
            this.gender = gender;
        }

        public void setPassword(string pass)
        {
            this.password = pass;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

    }
}
