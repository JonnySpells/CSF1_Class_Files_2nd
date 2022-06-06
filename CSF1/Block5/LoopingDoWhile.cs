using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block5
{
    internal class LoopingDoWhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Looping with Do While\n");

            /* Do While Loop - best for when you want to run code
             * an indeterminable number of times BUT
             * at least once!!!
             * (1 to ???)
             * 
             * COUNTER
             * 
             * do
             * {
             *      //code to run
             *      UPDATE
             *      
             * } while (CONDITION);
             */

            bool repeat = true; //COUNTER

            do
            {
                //do while ALWAYS RUNS ONCE... it may run additional times later
                Console.WriteLine("B) Bill\nP) Payment\nX) Exit");
                string userChoice = Console.ReadLine().ToUpper();

                //Clear the console after they input
                Console.Clear();

                switch (userChoice)
                {
                    case "B":
                        Console.WriteLine("Your Balance is $500.00\n\n");
                        break;

                    case "C":
                        Console.WriteLine("Your Payment is pending...\n\n");
                        break;

                    case "X":
                        Console.WriteLine("Thanks for using our app.");
                        repeat = false; //UPDATE
                        break;

                    default:
                        Console.WriteLine("Invalid selection. Please try again.\n\n");
                        break;
                }

            } while (repeat);//CONDITION


        }//End Main()

    }//End class

}//End Namespace
