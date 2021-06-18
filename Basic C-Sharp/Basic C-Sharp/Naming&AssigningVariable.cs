using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceAnswer2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*-----------------------------Declaring naming & Assigning variable, using Primitive Datatype------------------------*/

            Console.Write("My ID is : ");
            int ID;                        //Primitive Data type
            ID = 1263995;                  //naming and assign variable
            Console.WriteLine(ID);

	    

            /*---------------------------------------------Arithmatic Operator-------------------------------------------------*/

            int Add, Sub, Mul, Div, Mod;       //Primitive Data type

            int x = 50;
            int y = 30;                 

            Add = x + y;
            Sub = x - y;
            Mul = x * y;
            Div = y / x;
            Mod = y % x;

            Console.WriteLine("Addition Of Two Operator:" + Add);
            Console.WriteLine("Subtraction Of Two Operator :" + Sub);
            Console.WriteLine("Multiplication Of Two Operator:" + Mul);
            Console.WriteLine("Division Of Two Operator:" + Div);
            Console.WriteLine("Modulus Of Two Operator:" + Mod);

            /*------------------------------------Difference of Postfix  and  Prefix------------------------------------------*/

            //Postfix
            Console.Write("Postfix : ");
            int x = 50;
            Console.WriteLine(x++);
            Console.WriteLine(x);

            //Prefix
            Console.Write("Prefix : ");
            int y = 55;
            Console.WriteLine(++y);
            Console.WriteLine(y);

            Console.ReadKey();
        }
    }
}
