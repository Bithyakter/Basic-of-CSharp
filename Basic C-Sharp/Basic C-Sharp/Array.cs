using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Chapter10
    {
        static void Main(string[] args)
        {

            // different types of array


            // Declare a single-dimensional array.

            int[] array1 = new int[5];


            // Declare and set array element values.

            int[] array2 = new int[] { 1, 3, 5, 7, 9 };


            // Alternative syntax.

            int[] array3 = { 1, 2, 3, 4, 5, 6 };


            // Declare a two dimensional array.

            int[,] multiDimensionalArray1 = new int[2, 3];


            // Declare and set array element values.

            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };


            // Declare a jagged array.

            int[][] jaggedArray = new int[6][];


            // Set the values of the first array in the jagged array structure.

            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };


            string[] strs = new string[5]; // declare array with length

            strs[1] = "B";

            strs[2] = "C";

            strs[0] = "A"; // assign value to a specific index

            strs[3] = "D";

            strs[4] = "E";

            Console.WriteLine("Display all assigned array");

            DisplayArray(strs);


            strs[4] = "F"; // change value by an index

            Console.WriteLine("Display all after changing array of particular index");

            DisplayArray(strs);


            strs = strs.Where((item, index) => index != 2).ToArray(); //remove spefice item byindex

            Console.WriteLine("Display all after changing array of particular index");

            DisplayArray(strs);



            Console.ReadLine();

        }



        static void DisplayArray(string[] strArray)

        {

            foreach (string str in strArray)

            {

                Console.WriteLine(str);

            }

        }
		
		
		     //int[] intArray		// integer array
            //string[] stringArray    // string array

            //Declaration
            int[] intArray = { 2, 4, 6, 8, 10 };  //Single Array

            string[] stringArray = { "Bithy", "Nitu", "Shammi" };

            /*----Multi Array----*/

            var names = new[] {
              new{ name="Bithy", ID=95},
              new { name = "Nitu", ID = 23},
              new { name = "Shammi", ID = 41}
              };

              foreach (var friends in names)
              {
                  Console.WriteLine($"Name: { friends.name} ID:{friends.ID}");

              }

            string[] array = new string[5];
            array[0] = "Bithy";
            array[1] = "Shammi";
            array[2] = "Nitu";
            array[3] = "Monisha";
            array[4] = "Jelly";

            Console.WriteLine("ArrayList");

            array[4] = "Radi";
            Console.WriteLine("After Changing:");


            ArrayList(array);
            array = array.Where((item, index) => index != 2).ToArray();
            ArrayList(array);
          

            Console.ReadKey();

        }
		
        static void ArrayList(string[] listOfArray)
        {
            foreach (string show in listOfArray) ;
            {
                Console.WriteLine("show");
            }

        }

        
            //List<string> nameOfFriends = new List<string>()
            //{ "Shammi", "Nitu", "Trisha" };

            //// foreach loop begin 
            //foreach (string friends in nameOfFriends)
            //{
            //    Console.WriteLine(friends);
            //}



    }
}
