using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cahpter7_ClassObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee objem = new Employee();
            Console.WriteLine(objem.getExp());

            objem.EmSalary = 30000;
            Console.WriteLine(objem.EmSalary);
            Console.ReadKey();
        }
    }
}
