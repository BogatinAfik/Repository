using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace KallkarProject
{
    public class Shipment
    {
        private string shipmentID;
        private DateTime shipmentDate;
        public Truck shipmentTruck;
        private static int serialNum;
        public Shipment(string sID, DateTime sDT, Truck tr)
        {
            this.shipmentID = sID;
            this.shipmentDate = sDT;
            this.shipmentTruck = tr;
        }

        public Shipment(DateTime sDT, Truck tr)
        {
            serialNum += 1;
            shipmentID = serialNum.ToString();
            this.shipmentDate = sDT;
            this.shipmentTruck = tr;

        }

        public void create_Shipment()
        {
            MessageBox.Show(shipmentTruck.getID());

            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_Add_Shipment @ShipmentId, @ShipmentDate, @TruckID";
            c.Parameters.AddWithValue("@ShipmentId", this.shipmentID);
            c.Parameters.AddWithValue("@ShipmentDate", this.shipmentDate.ToString());
            c.Parameters.AddWithValue("@TruckID", this.shipmentTruck.getID().ToString());

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }




        public static void setShipmentSrieal(int num)
        {
            serialNum = num;
        }


        public string getID()
        {
            return this.shipmentID;
        }
    }
}
