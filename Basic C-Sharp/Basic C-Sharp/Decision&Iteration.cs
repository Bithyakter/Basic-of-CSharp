using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceAnswer1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*================================Decision & Iteration Statements===================================*/

            /*-----Syntax Of IF ELSE :

            if(ControlingExpression)    
            {
                    //statement
            }
            else
            {
                    //statement
            }

            -----*/
            /*---------------If else -Example----------------*/
            Console.WriteLine("Enter Temperature :");                             //User Input
            double temperature = Convert.ToInt32(Console.ReadLine());

            if (temperature > 32)
            {
                Console.WriteLine("Current temperature = {0}", temperature);
                Console.WriteLine("It's Warm");
            }
            else
            {
                Console.WriteLine("It's Cold");
            }

         
            /*-------Syntax Of Switch Case :

              switch(ControlingExpression)    
              {
                   case ConstantExpression :
                       statements
                       break;
               case ConstantExpression :
                       statements
                       break;
               default:
                       statements
                       break;
              }

               -----------*/

            /*-------------switch case -Example----------------*/
            char grade = 'A';
            Console.WriteLine("The grade is {0} ", grade);

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("The Best One !!");
                    break;
                case 'B':
                    Console.WriteLine("Perform Good");
                    break;
                case 'C':
                    Console.WriteLine("Perform Better");
                    break;
                case 'D':
                    Console.WriteLine("Not good");
                    break;
                case 'E':
                    Console.WriteLine("You Failed");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }


            /*---------------For Loop----------------*/
            //Using FOR LOOP
            int i;
            for (i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            /*---------------While Loop----------------*/
            int i = 1;
            while (i <= 100)
            {
                Console.WriteLine(i);
                i++;
            }

            /*---------------Do while Loop----------------*/
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 100);

            /*---------------Foreach------------------*/
            List<string> nameOfFriends = new List<string>()
                { "Shammi", "Nitu", "Trisha" };

            // foreach loop begin 
            foreach (string friends in nameOfFriends)
            {
                Console.WriteLine(friends);
            }

            Console.ReadKey();
        }
    }
}
