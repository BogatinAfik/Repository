using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KallkarProject
{
   public class compareByTargetDate : IComparer<Order>
    {

        public int Compare(Order x, Order y)
        {

            if (x.GettargetDate() > y.GettargetDate())
                return -1;
            else if (x.GettargetDate() < y.GettargetDate())
                return 1;

            return 1;
        }
    }
}
