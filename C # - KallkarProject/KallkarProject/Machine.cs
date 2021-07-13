using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KallkarProject
{
   public class Machine
    {
        private string id;
        private float productionRate;
        private int numOfEmployee;
        private MachineStatus machineStatus; // enummmmm
        private MachineType machinType;
        public System.Collections.Generic.List<Order> dailyProduction;
        

        public Machine(string id, float productionRate, int numOfEmployee, MachineStatus machineStatus, MachineType machinType)
        {
            this.id = id;
            this.productionRate = productionRate;
            this.numOfEmployee = numOfEmployee;
            this.machineStatus = machineStatus;
            this.machinType = machinType;
            dailyProduction = new List<Order>();
            
        }

        public float getProductionRate() {
            return this.productionRate;
        }
        public string ToString() {

            return (this.machinType.ToString() + " Number: " + this.id);
        }


    }
}
