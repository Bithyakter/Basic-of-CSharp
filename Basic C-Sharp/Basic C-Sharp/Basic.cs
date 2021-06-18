using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*-----HELLO WORLD----*/
            Console.WriteLine("Hello World!");      //Output
            Console.ReadKey();                      //For Readable


            /*-----VARIABLE----*/
            string Message = "Hi This is Variable";
            Console.WriteLine(Message);


            int Number = 20;
            int Result = Number + 30;                          //Result is now 50
            Console.WriteLine("Output :" +Number+Result);      //Concrete=Operation of joining two strings together.


            /*-----VARIABLE with DATATYPE-------*/

            //int myNum = 5;                   //Integer (whole number)
            //double myDoubleNum = 5.99D;      //Floating point number
            //char myLetter = 'D';             //Character
            //bool myBool = true;              //Boolean
            //string myText = "Hello";         //String

            //long myNum = 15000000000L;
            //Console.WriteLine(myNum);


            //float f1 = 35e3F;                 //"e" to indicate the power of 10
            //double d1 = 12E4D;
            //Console.WriteLine(f1);
            //Console.WriteLine(d1);


            /*-----TYPE CASTING----*/
            //int myInt = 9;
            //double myDouble = myInt;               //Automatic casting: int to double

            //Console.WriteLine("Int: "+myInt);           //Outputs 9
            //Console.WriteLine("Double: " + myDouble);   //Outputs 9


            //double mydouble = 15.8;
            //int myint = (int) mydouble;
            //Console.WriteLine("Double: " + mydouble);      //Outputs 15.8
            //Console.WriteLine("Int: " + myint);            // Outputs 15


            //int myInt = 10;
            //double myDouble = 5.25;
            //bool myBool = true;

            //Console.WriteLine("Sting: " + Convert.ToString(myInt));         // convert int to string
            //Console.WriteLine("Double: "+ Convert.ToDouble(myInt));         // convert int to double
            //Console.WriteLine("Int: " + Convert.ToInt32(myDouble));         // convert double to int
            //Console.WriteLine("Boolean: " + Convert.ToString(myBool));      // convert bool to string


            /*----USER INPUT-----*/

            //Console.WriteLine("Enter username:");                 //Input from user
            //string userName = Console.ReadLine();                 //To get user input
            //Console.WriteLine("Username is: " + userName);        //display the input value

            //Console.Write("Enter Your Age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your Age: " + age);                


            /*----OPERATORS-----*/
            //int number1 = 120 + 60;                     //180(120+60)
            //int number2 = number1 + 50;                 //230(180+50)
            //int number3 = number1 + number2;            //410(180+230)
            //Console.WriteLine("Output: " + number3);    //Output = 410   

            //int x = 10;
            //x += 5;                 //Add a value to the operator (10+5)


            //int x = 5;
            //Console.WriteLine(x > 3 && x < 10);     //returns True because 5 is greater than 3 AND 5 is less than 10

            //int x = 5;
            //Console.WriteLine(x > 3 || x < 4);      //returns True because one of the conditions are True (5 is greater than 3, but 5 is not less than 4)

            //int x = 5;
            //Console.WriteLine(!(x > 3 && x < 10));  //returns False because ! (not) is used to reverse the result

            //int num1, num2;
            //num1 = 10;
            //Console.WriteLine(++num1);

            //num2 = num1;
            //Console.WriteLine("Output Num1: " + num1);
            //Console.WriteLine("Output Num2: " + num2);

            ///*----Postfix---*/
            //int x = 50;
            //Console.WriteLine(x++);                   
            //Console.WriteLine(x);

            ///*----Prefix---*/
            //int y = 55;
            //Console.WriteLine(++y);                   
            //Console.WriteLine(y);


            /*---------STRING IN C-SHARP-----------*/
            //string txt = "C-Sharp Learning";
            //Console.WriteLine("The length of the txt string is: " + txt.Length);         //Output:16

            //string upper = "C-Sharp Learning";
            //Console.WriteLine("The convert to Uppercase: " + upper.ToUpper());           //Output:C-SHARP LEARNING

            //string Lower = "C-Sharp Learning";
            //Console.WriteLine("The convert to Lowercase: " + Lower.ToLower());           //Output:c-sharp learning


            /* String Concatenation */
            //string firstName = "Mst ";
            //string lastName = "Bithy";
            //string fullName = firstName + lastName;
            //Console.WriteLine("My Name is : " + Environment.NewLine + fullName);  //ForNewLine=Environment.NewLine

            //string fullName = string.Concat(firstName, lastName);                 // use the string.Concat() method to concatenate two strings


            //string firstName = "Mst";                                             //Another option the name is string interpolation                 
            //string lastName = "Bithy";
            //string name = $"My full name is: {firstName} {lastName}";
            //Console.WriteLine(name);

            /* Access Strings */
            //string myString = "Hello";                  //String indexes start with 0: [0] is the first character. [1] is the second character   
            //Console.WriteLine(myString[0]);             // Outputs "H"


            /* Find INDEX Position */
            //string myString = "Hello";
            //Console.WriteLine(myString.IndexOf("e"));         // Outputs "1"


            /* UseOf Substring() Method, which extracts the characters from a string */

            //string myName = "Mst Bithy";                    // Full name

            //int charPos = myName.IndexOf("B");             // Location of the letter B

            //string lastName = myName.Substring(charPos);   // Get last name     

            //Console.WriteLine(lastName);                   // Print the result


            /* Special Characters */
            //string txt1 = "C# is a \"programming\" language developed by Microsoft.";
            //Console.WriteLine(txt1);
            //string txt2 = "It\'s alright.";
            //Console.WriteLine(txt2);
            //string txt3 = "The character \\ is called backslash.";
            //Console.WriteLine(txt3);


            /*----Boolean Expression-----*/
            //bool isCSharpEasy = true;
            //bool isCSharpHard = false;
            //Console.WriteLine(isCSharpEasy);         // Output True
            //Console.WriteLine(isCSharpHard);         // Output False

            //int x = 50;
            //int y = 40;
            //Console.WriteLine(x > y);               // returns True, because 50 is higher than 40



            /*-------If-Else-------*/
            //Console.WriteLine("Enter Temperature :");
            //double temperature = Convert.ToInt32(Console.ReadLine());
            //if (temperature > 32)
            //{   // Start of block
            //    Console.WriteLine("Current temperature = {0}", temperature);
            //    Console.WriteLine("It's hot");
            //}	// End of block
            //else
            //    Console.WriteLine("It's Cold");


            // Console.WriteLine("Type First number");
            // int x = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Type *,/,+,-");
            // string z = Console.ReadLine();
            // Console.WriteLine("Type Second number");
            // int y = Convert.ToInt32(Console.ReadLine());
            // if (z == "+")
            // {
                // Console.WriteLine("Answer: {0}", x + y);
            // }
            // if (z == "-")
            // {
                // Console.WriteLine("Answer: {0}", x - y);
            // }
            // if (z == "*")
            // {
                // Console.WriteLine("Answer: {0}", x * y);
            // }
            // if (z == "/")
            // {
                // Console.WriteLine("Answer: {0}", x / y);
            // }


            Console.ReadKey();
        }
    }
}
