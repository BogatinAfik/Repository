using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KallkarProject
{
    public enum OrderStatus
    {
        ready,
        arrived,
        canceled,
        delayed,
        waitingForApproval,
        inProduction,
        moveToShipment,
        approved

    }
}
