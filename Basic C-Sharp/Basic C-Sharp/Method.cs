﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence
{
    class Program
    {	
	/*===================================Method======================================*/

        public static int result = 0;               //Global scope variable

        static void Main(string[] args)
        {
            //Example 01
            PrintFullName(FirstName: "Shammi", LastName: "Ahmed");                                       //Named Arguments
            PrintFullName("Nafiya");

            //Example 02
            ProductDetails(ProductName: "Computer", ProductPrice: 1500, ProductCategory: "Electronics");  //Named Arguments
            ProductDetails(ProductName: "Coffee", ProductPrice: 1200);

            //Method Overloading
            /*--------
            int addTwo = GetValue(50, 30);
            int addThree = GetValue(80, 20);
            Console.WriteLine("Sum of Two Number: " + addTwo);
            Console.WriteLine("Sum of Three Number: " + addThree); 
            ---------*/

            GetValue(80, 20);
            Console.WriteLine("Sum of Two Number: " + result);

            GetValue(50, 30, 40);
            Console.WriteLine("Sum of Three Number: " + result);           //Global variable can be access from here

            Console.ReadLine();
        }


        //Example 01
        public static void PrintFullName(string FirstName, string LastName = "Tabassum")                //PrintFullName is Method
                                                                                                        //Here FirstName,LastName is Parameter 
        {                                                                                               //LastName is Optional Parameter (Tabassum)
            Console.WriteLine("Student Full Name: {0} {1}", FirstName, LastName);
        }

        //Example 02
        public static void ProductDetails(string ProductName, int ProductPrice, string ProductCategory = "Food")           //Optional Parameter
        {
            Console.WriteLine("ProductName = {0}, ProductPrice = {1}, ProductCategory = {2}", ProductName, ProductPrice, ProductCategory);
        }

        //Method Overloading
        public static void GetValue(int number1, int number2)                //Method
        {
            //int TotalNumber = number1 + number2;                            //TotalNumber is Local Scope Variable
            //return TotalNumber;

            int TotalNumber = number1 + number2;                              //TotalNumber is Local Scope Variable
            result = TotalNumber;
            Console.WriteLine("{0}+{1}", number1, number2, TotalNumber);
        }

        public static void GetValue(int number1, int number2, int number3)       //Same Method with different parameter    
        {
            //int TotalNumber = number1 + number2 + number3;                    //TotalNumber is Local Scope Variable
            //return TotalNumber;

            int TotalNumber = number1 + number2 + number3;                       //TotalNumber is Local Scope Variable
            result = TotalNumber;
            Console.WriteLine("{0}+{1}+{2}", number1, number2, number3, TotalNumber);
        }
    }
}


