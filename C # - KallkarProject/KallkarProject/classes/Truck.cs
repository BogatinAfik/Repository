using System;

namespace KallkarProject
{
    public class Truck
    {
        private string truckID;
        private float capacity;
        private Boolean occupied;
        public Employee driver;


        public Truck(string tID, float capa, bool ocuup, Employee driver)
        {
            this.truckID = tID;
            this.capacity = capa;
            this.occupied = ocuup;
            this.driver = driver;
            
        }
        public float getcapacity()
        {
            return this.capacity;
        }
        public bool getoccupied()
        {
            return this.occupied;
        }
        public void Setoccupied(bool b)
        {
            this.occupied = b;
        }

        public string getID()
        {
            return this.truckID;
        }
        public Employee getDriver()
        {
            return this.driver;
        }

    }
}