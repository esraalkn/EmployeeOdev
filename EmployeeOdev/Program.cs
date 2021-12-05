using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            backtotop:
            Console.Write("******HOME PAGE******\n1.Salaried Employee \n2.Hourly Employee \n3.Comission Employee \n4.Base Plus Commision Employee\nPlease Choose Your Criteria: ");
            string choose = Console.ReadLine();
            if (choose=="1")
            {
                SalariedEmployee S1 = new SalariedEmployee();
                S1.employeeInformation();
                S1.earning();
            }
            else if (choose=="2")
            {
                HourlyEmployee H1 = new HourlyEmployee();
                H1.employeeInformation();
                H1.earning();
            }
            else if (choose=="3")
            {
                CommisionEmployee C1 = new CommisionEmployee();
                C1.employeeInformation();
                C1.earning();
            }
            else
            {
                BasePlusCommisionEmployee B1 = new BasePlusCommisionEmployee();
                B1.employeeInformation();
                B1.earning();
            }
            Console.Write("Do you want to take another action? Y/N: " );
            string choose2 = Console.ReadLine();
            if (choose2.ToLower()=="y")
            {
                Console.WriteLine("You are being redirected to the home page...");
                
                goto backtotop;
            }
            else
            {
                Console.WriteLine("Good Bye!");
            }
            

            Console.ReadLine();


        }
    }
}
