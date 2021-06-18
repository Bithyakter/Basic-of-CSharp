using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*=========================================IF-ELSE===============================================*/

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

            /*--------------------------If-Else Example 01--------------------------*/

            //Console.WriteLine("Enter Your Number : ");                         //User Input

            //int Number = Convert.ToInt32(Console.ReadLine());

            //if (Number == 10)
            //{   

            //    Console.WriteLine("The Result of Number is 10");

            //}
            //else if (Number == 20)
            //{
            //    Console.WriteLine("The Result of Number is 20");
            //}

            //else
            //{
            //    Console.WriteLine("The Result of Number is not 10 or 20");
            //}

            /*--------------------------If-Else Example 02--------------------------*/

            //int x = 30;

            //if (x % 2 == 0)
            //{
            //    Console.WriteLine("{0}, The Number is Even", x);
            //}
            //else
            //{
            //    Console.WriteLine("{0}, The Number is Odd", x);
            //}


            ////User Input
            //Console.WriteLine("Enter Your Number: ");                           

            //int n = Convert.ToInt32(Console.ReadLine());

            //if (n % 2 == 0)
            //{
            //    Console.WriteLine("{0}, The Number is Even", n);
            //}
            //else
            //{
            //    Console.WriteLine("{0}, The Number is Odd", n);
            //}

            /*--------------------------If-Else Example 03--------------------------*/

            //Console.WriteLine("Enter Temperature :");                             //User Input
            //double temperature = Convert.ToInt32(Console.ReadLine());

            //if (temperature > 32)
            //{
            //    Console.WriteLine("Current temperature = {0}", temperature);
            //    Console.WriteLine("It's Warm");
            //}
            //else
            //{
            //    Console.WriteLine("It's Cold");
            //}


            /*=======================================Switch Case================================================*/

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

            /*-------------switch case -Example 1----------------*/
            //int day = 2;

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Sunday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Friday");
            //        break;
            //    default:
            //        Console.WriteLine("Unknown");
            //        break;
            //}


            /*-------------switch case -Example 2----------------*/
            //char grade = 'A';
            //Console.WriteLine("The grade is {0} ", grade);

            //switch (grade)
            //{
            //    case 'A':
            //        Console.WriteLine("The Best One !!");
            //        break;
            //    case 'B':
            //        Console.WriteLine("Perform Good");
            //        break;
            //    case 'C':
            //        Console.WriteLine("Perform Better");
            //        break;
            //    case 'D':
            //        Console.WriteLine("Not good");
            //        break;
            //    case 'E':
            //        Console.WriteLine("You Failed");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Choice");
            //        break;
            //}

            Console.ReadKey();
        }
    }
}








  



   
