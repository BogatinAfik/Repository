using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KallkarProject
{
   public class Storage
    {
        private int storageNum;
        private float capacity;

        public Storage(int sNum, float capacity)
        {
            this.storageNum = sNum;
            this.capacity = capacity;
        }

        public int getStorageNum() {
            return this.storageNum;
        }
        public float calculateFreeSpace() {
            float freeSpace = 0;
            foreach (Area a in Program.Areas)
            {
                   if (a.getStorage().getStorageNum() == this.storageNum && (a.getOccupied() == false))
                {
                    freeSpace = freeSpace + a.freeSpace();
                }
            }
            return freeSpace;
        }
        public float freeSpaceByPrecent(float freeCapacity)
        {
            float precent = ((freeCapacity / this.capacity) *100);
            return precent;
        }
    }
}
