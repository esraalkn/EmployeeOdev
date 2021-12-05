using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOdev
{
    public class SalariedEmployee:Employee
    {
        public double weeklySalary { get; set; }

        public SalariedEmployee()
        {
        }

        public override void earning()
        {
            Console.Write("Enter the Number of Weeks You Worked: ");
            this.weeklySalary = Convert.ToDouble(Console.ReadLine());
            this._earnings = weeklySalary*490;
            Console.WriteLine("Your salary is $" + this._earnings );
        }

        public override void employeeInformation()
        {
            Console.Write("Please Enter First Name: ");
            this._firstName = Console.ReadLine();
            Console.Write("Please Enter Last Name: ");
            this._lastName = Console.ReadLine();
            Console.WriteLine("Please Enter Social security number: ");
            this._SSN = Console.ReadLine();

            Console.WriteLine("Welcome Miss./Mrs. " + this._firstName +" "+ this._lastName + "\n"+this._SSN);
            
        }
    }
}
