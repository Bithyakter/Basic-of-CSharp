using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8
{
    class Program
    {
        static void Main(string[] args)
        {
            int salary = 40000;
            SalaryCalculate(ref salary);
            Console.WriteLine("Salary with Bonus: " + salary);

            int tax;
            Tax(out tax);
            Console.WriteLine("Salary Excluded Tax: " + (salary -tax));


            Console.ReadKey();
        }

        static void SalaryCalculate(ref int salary)
        {
            int bonus = 3000;
            salary = bonus + salary;
        }
        static void Tax(out int tax)
        {
            tax = 500;
        }

       

    }
}
