using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KallkarProject
{
    public class EmployeesInFactory
    {
        public kalkarFactory factory;
        public Employee employee;


        public EmployeesInFactory(kalkarFactory factory, Employee employee)
        {
            this.employee = employee;
            this.factory = factory;
        }
    }
}
