using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ///*=====================================SYNTAX================================*/
            ///*-----Syntax of For Loop----*/
            //for(condition)
            //{
            //    //Code Execute Here
            //}

            ///*-----Syysntax of For While Loop----*/
            //while (condition)
            //{
            //    //Code Execute Here
            //}

            ///*-----Syntax of For Do While Loop----*/
            //do
            //{
            //    //Code Execute Here
            //}
            //while (condition);

            ///*-----Syysntax of Foreach----*/
            //foreach (Condition)
            //{
            //    //Code Execute Here
            //}




            /*------------For Loop------------*/
            int x;
            for (x = 1; x <= 100; x++)
            {
                Console.WriteLine(x);
            }

            //int x;
            //for (x = 100; x >= 1; x--)
            //{
            //    Console.WriteLine(x);
            //}


            /*------------While Loop------------*/

            //int y = 0;
            //while (y < 10)
            //{
            //    Console.WriteLine(y);
            //    y++;
            //}


            ///*------------Do While Loop------------*/
            //int z = 0;
            //do
            //{
            //    Console.WriteLine(z);
            //    z++;
            //}
            //while (z < 10);

            
            ///*------------Foreach------------*/
            ///
            //string[] cSharp = { "C-Sharp" + " is a programming language" + " developed by Microsoft" };
            //foreach (string answer in cSharp)
            //{
            //    Console.WriteLine(answer);
            //}

            //List<string> nameOfFriends = new List<string>() { "Shammi", "Nitu", "Trisha" };

            //// foreach loop begin 
            //foreach (string friends in nameOfFriends)
            //{
            //    Console.WriteLine(friends);
            //}

		
	// A list of popular browsers
  //          List<string> browsers = new List<string>()
  //          {
  //              "Google Chrome", "Mozilla Firefox",
  //              "Microsoft Edge", "Apple Safari",
  //              "Samsung Internet", "UC Browser",
  //          };

  //              // Create a list with browsers that aren't supported by the app
  //              List<string> unsupported = new List<string>()
  //          {
  //              "Microsoft Edge", "Samsung Internet", "UC Browser",
  //          };

  //          // Loop through all browsers, and see which are unsupported
  //          foreach (string browser in browsers)
  //          {
  //              if (unsupported.Contains(browser))
  //              {
  //                  Console.WriteLine("Sorry, {0} is not supported.",
  //                      browser);
  //              }

		////Example
	 //List<int> values = new List<int>()
  //          {
  //              9, 26, 77, 75, 73, 77,
  //              59, 93, 9, 13, 64, 50
  //          };

  //          foreach (int value in values.Select(x => x).Reverse())
  //          {
  //              Console.Write(value + " ");
            //}


            Console.ReadLine();

        }
    }
}
