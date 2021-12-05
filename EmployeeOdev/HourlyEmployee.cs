using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOdev
{
    public class HourlyEmployee:Employee
    {
        public double HourlyWage { get; set; }
        public double HoursWorked { get; set; }

        public HourlyEmployee()
        {
        }

        public override void earning()
        {
            Console.Write("Please Enter Your Hourly Wage ");            
            this.HourlyWage = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter Your Total Working Hours: ");
            this.HoursWorked = Convert.ToDouble(Console.ReadLine());
            if (HoursWorked<=40)
            {
                this._earnings = HourlyWage * HoursWorked;
                Console.WriteLine("Your salary is $" + this._earnings); 
            }
            else
            {
                this._earnings = 40 * HourlyWage + (HoursWorked - 40) * HourlyWage * 1.5;
                Console.WriteLine("Your salary is $" + this._earnings);
            }

        }
        public override void employeeInformation()
        {
            Console.Write("Please Enter First Name: ");
            this._firstName = Console.ReadLine();
            Console.Write("Please Enter Last Name: ");
            this._lastName = Console.ReadLine();
            Console.Write("Please Enter Social security number: ");
            this._SSN = Console.ReadLine();


            Console.WriteLine("Welcome Miss./Mrs. " + this._firstName + " " + this._lastName + "\n" + this._SSN);
        }
    }
}
