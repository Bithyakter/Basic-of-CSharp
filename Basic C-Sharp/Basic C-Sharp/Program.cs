using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {

            /*=========================================IF-ELSE===============================================*/

            /*----------Example 01: Input Number, Get Number of Month-------------*/

            //int month;

            //Console.WriteLine("Enter Month Number: ");
            //month = Convert.ToInt32(Console.ReadLine());

            //if (month == 1)
            //{
            //    Console.WriteLine("For January Number of days = 31 Days");
            //}
            //else if (month == 2)
            //{
            //    Console.WriteLine("For February Number of days = 28/29 Days");
            //}
            //else if (month == 3)
            //{
            //    Console.WriteLine("For March Number of days = 31 Days");
            //}
            //else if (month == 4)
            //{
            //    Console.WriteLine("For April Number of days = 30 Days");
            //}
            //else if (month == 5)
            //{
            //    Console.WriteLine("For May Number of days = 31 Days");

            //}
            //else if (month == 6)
            //{
            //    Console.WriteLine("For June Number of days = 30 Days");
            //}
            //else if (month == 7)
            //{
            //    Console.WriteLine("For July Number of days = 31 Days");
            //}
            //else if (month == 8)
            //{
            //    Console.WriteLine("For August Number of days = 31 Days");
            //}
            //else if (month == 9)
            //{
            //    Console.WriteLine("For September Number of days = 30 Days");
            //}
            //else if (month == 10)
            //{
            //    Console.WriteLine("For October Number of days = 31 Days");
            //}
            //else if (month == 11)
            //{
            //    Console.WriteLine("For November Number of days = 30");
            //}
            //else if (month == 12)
            //{
            //    Console.WriteLine("For December Number of days = 31 Days");
            //}
            //else
            //{
            //    Console.WriteLine("U Enter a WRONG Number! \nPlease Enter Number Between (1-12).");
            //}


            /*---------------Example 02: Maximum Number -------------*/

            //int num1, num2, num3, num4, num5, max;

            //Console.Write("Enter 1st Number:");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter 2nd Number:");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter 3rd Number:");
            //num3 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter 4th Number:");
            //num4 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter 5th Number:");
            //num5 = Convert.ToInt32(Console.ReadLine());
            //max = num1;

            //if (num1 >= num2 && num1 >= num3 && num1 >= num4 && num1 >= num5)
            //{
            //    Console.WriteLine("The Maximum Number is: " + num1);

            //}
            //else if (num2 >= num1 && num2 >= num3 && num2 >= num4 && num2 >= num5)
            //{
            //    Console.WriteLine("The Maximum Number is: " + num2);

            //}
            //else if (num3 >= num1 && num3 >= num2 && num3 >= num4 && num3 >= num5)
            //{
            //    Console.WriteLine("The Maximum Number is: " + num3);

            //}
            //else if (num4 >= num1 && num4 >= num2 && num4 >= num3 && num4 >= num5)
            //{
            //    Console.WriteLine("The Maximum Number is: " + num4);

            //}
            //else
            //{
            //    Console.WriteLine("The Maximum Number is: " + num5);

            //}

            /*---------------Example 03: Student Grade-------------*/
            //int num1;
            //int num2;
            //int num3;
            //int grade;
            //int answer;
            //int A = 0;
            //int B = 0;
            //int C = 0;
            //int F = 0;

            //Console.WriteLine("Enter Your CT Score: ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();

            //Console.WriteLine("Enter Your Mid-term Score: ");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();

            //Console.WriteLine("Enter Your Final Score: ");
            //num3 = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();

            //answer = (num1 + num2 + num3) / 3;

            //Console.WriteLine("Your Average Marks is {0}", answer);

            //if (answer >= 90)
            //{
            //    Console.WriteLine("Your Grade is A");
            //    Console.ReadLine();
            //    grade = A;
            //}
            //else if ((answer >= 70) && (answer < 90))
            //{
            //    Console.WriteLine("Your Grade is B");
            //    Console.ReadLine();
            //    grade = B;
            //}
            //else if ((answer >= 50) && (answer < 70))
            //{
            //    Console.WriteLine("Your Grade is C");
            //    Console.ReadLine();
            //    grade = C;
            //}
            //else if ((answer >= 30) && (answer < 50))
            //{
            //    Console.WriteLine("Your Grade is D");
            //    Console.ReadLine();
            //    grade = C;
            //}
            //else if (answer < 30)
            //{
            //    Console.WriteLine("Your Grade is F");
            //    Console.ReadLine();
            //    grade = F;
            //}


            /*=========================================Switch Case=============================================*/

            /*----------Example 01: Input Number, Get Number of Month-------------*/
            //int month;
            //Console.WriteLine("Enter month number: ");
            //month = Convert.ToInt32(Console.ReadLine());

            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine("31 days");
            //        break;
            //    case 2:
            //        Console.WriteLine("28 / 29 days");
            //        break;
            //    case 3:
            //        Console.WriteLine("31 days");
            //        break;
            //    case 4:
            //        Console.WriteLine("30 days");
            //        break;
            //    case 5:
            //        Console.WriteLine("31 days");
            //        break;
            //    case 6:
            //        Console.WriteLine("30 days");
            //        break;
            //    case 7:
            //        Console.WriteLine("31 days");
            //        break;
            //    case 8:
            //        Console.WriteLine("31 days");
            //        break;
            //    case 9:
            //        Console.WriteLine("30 days");
            //        break;
            //    case 10:
            //        Console.WriteLine("31 days");
            //        break;
            //    case 11:
            //        Console.WriteLine("30 days");
            //        break;
            //    case 12:
            //        Console.WriteLine("31 days");
            //        break;
            //    default:
            //        Console.WriteLine("U Enter a WRONG Number! \nPlease Enter Number Between (1-12).");
            //        break;
            //}


            /*----------Example 02: Basic Calculator------------ - */
        //    int num1, num2, action;

        //    Console.WriteLine("Enter 1st input");
        //    num1 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Enter 2nd input");
        //    num2 = Convert.ToInt32(Console.ReadLine());

        //    //Console.WriteLine("Type *,/,+,-");

        //    Console.WriteLine("Press 1 for Addition");
        //    Console.WriteLine("Press 2 for Subtraction");
        //    Console.WriteLine("Press 3 for Multiplication");
        //    Console.WriteLine("Press 4 for Division");

        //    action = Convert.ToInt32(Console.ReadLine());
            
        //    int result = 0;

        //    switch (action)
        //    {
        //        case 1:
        //            {
        //                result = Addition(num1, num2);
        //                break;
        //            }
        //        case 2:
        //            {
        //                result = Subtraction(num1, num2);
        //                break;
        //            }
        //        case 3:
        //            {
        //                result = Multiplication(num1, num2);
        //                break;
        //            }
        //        case 4:
        //            {
        //                result = Division(num1, num2);
        //                break;
        //            }
        //        default:
        //            Console.WriteLine("Wrong action!! try again");
        //            break;
        //    }

        //    Console.WriteLine("The result is {0}", result);

        //    Console.ReadKey();

        //}
  
        //public static int Addition(int input1, int input2)                  //For Addition
        //{
        //    int result = input1 + input2;
        //    return result;
        //}
        
        //public static int Subtraction(int input1, int input2)               //For Subtraction
        //{
        //    int result = input1 - input2;
        //    return result;
        //}
  
        //public static int Multiplication(int input1, int input2)            //For Multiplication
        //{
        //    int result = input1 * input2;
        //    return result;
        //}
          
        //public static int Division(int input1, int input2)                  //For Division
        //{
        //    int result = input1 / input2;
        //    return result;
        //}

    }
}
