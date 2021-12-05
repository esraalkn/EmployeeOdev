using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOdev
{
    public class CommisionEmployee:Employee
    {
        public double GrossSales { get; set; }
        public double ComissionRate { get; set; }

        public CommisionEmployee()
        {
        }

        public override void earning()
        {
            Console.Write("Please Enter Gross Information: ");
            this.GrossSales = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter Commision Rate:  ");
            this.ComissionRate = Convert.ToDouble(Console.ReadLine());
            this._earnings = ComissionRate * GrossSales;
            Console.WriteLine("Your salary is $" + this._earnings);
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
