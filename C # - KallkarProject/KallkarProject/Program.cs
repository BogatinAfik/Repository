using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Media;

namespace KallkarProject
{
    static class Program
    {
        /// <summary>
        /// 
        public static System.Collections.Generic.List<Employee> Employees;
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            foreach (Employee e in Employees)
            {
                Console.WriteLine(e);

            }


        }
        public static void initLists()//מילוי הרשימות מתוך בסיס הנתונים
        {
            init_Employee();//אתחול הרשימה של העובדים
        }



        public static void init_Employee()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Employees";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Employees= new List<Employee>();

            while (rdr.Read())
            {
                Gender G = (Gender)Enum.Parse(typeof(Gender), rdr.GetValue(2).ToString());
                Role R= (Role)Enum.Parse(typeof(Role), rdr.GetValue(6).ToString());
                Employee e = new Employee(rdr.GetValue(0).ToString() ,rdr.GetValue(1).ToString(), G, DateTime.Parse(rdr.GetValue(3).ToString()), rdr.GetValue(4).ToString(), DateTime.Parse(rdr.GetValue(5).ToString()), R, rdr.GetValue(7).ToString(), false);
                Employees.Add(e);
            }
        }
    }
}
