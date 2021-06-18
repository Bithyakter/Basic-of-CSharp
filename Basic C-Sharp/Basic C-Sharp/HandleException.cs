using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceAnswer4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*==========================Handle Exception Using Try-Catch-Finally============================*/
			
			/*------------------------------SYNTAX---------------------------*/
            /*-------------------------------------
                    try
                    {
                        // statements causing exception
                    }
                    catch (ExceptionName e1)
                    {
                        // error handling code
                    }
                    catch (ExceptionName e2)
                    {
                        // error handling code
                    }
                    catch (ExceptionName eN)
                    {
                        // error handling code
                    }
                    finally
                    {
                        // statements to be executed
                    }
            ----------------------------------------------*/
            /*---------Example 01--------------*/

            int x = 0;
            int div = 0;
            try
            {
                div = 100 / x;
                Console.WriteLine("Not executed line");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception occured");
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }
            Console.WriteLine($"Result is {div}");
			
		
            Console.ReadKey();
        }
    }
}
