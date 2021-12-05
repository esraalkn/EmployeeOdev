using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOdev
{
    public abstract class Employee
    {
        public string _firstName { get; set; }
        public string _lastName { get; set; }
        public string _SSN { get; set; }
        public double _earnings { get; set; }

        protected Employee()
        {
        }

        public abstract void earning();
        public abstract void employeeInformation();
    }
}
