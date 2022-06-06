using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block5
{
    internal class LoopingWhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Looping with While");

            /*WHILE LOOP - best for when you want to run code
             * an indeterminable number of times *Could be no loops or many*
             * (0 to ???)
             * 
             * COUNTER
             * 
             * while (CONDITION)
             * {
             *      //code to run
             *      UPDATE
             * }
             */

            int deathStick = 1; //COUNTER

            while (deathStick <= 5) //CONDITION
            {
                Console.WriteLine("You sold Obi-wan " + deathStick + " Death Sticks!");
                deathStick++;//UPDATE
            }


            //It is most common to use a WHILE LOOP with a BOOL for a COUNTER.
            //This lets us conditionally change the bool when we want to exit.\

            //Assume Han may have cargo to smuggle in  in
            bool cargo = true; //COUNTER

            while (cargo)
            {
                Console.WriteLine("\nYou have unloaded some cargo");

                //Ask the user if they have more cargo
                Console.WriteLine("Do you have more bags? Y/N: ");
                //ConsoleKey... Which key did they press?
                ConsoleKey userAnswer = Console.ReadKey(true).Key; //.Key ??????

                if (userAnswer == ConsoleKey.N)
                {
                    cargo = false; //UPDATE
                }

                Console.WriteLine("Chewie lets get out of here!");

            }





        }//End Main()

    }//End class

}//End namespace
