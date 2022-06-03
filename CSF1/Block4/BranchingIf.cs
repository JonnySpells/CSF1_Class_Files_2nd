using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block4
{
    internal class BranchingIf
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Branching with If");

            //If/When you encounter issues and/or cannot see files
            //in your Startup object list, make sure the file you 
            //want to run has a static void main() and BUILD
            //the solution (Ctrl + Shift + B)

            /* (IS THIS TRUE OR NOT)
            * If allows you to test for a condition. If that                  IF
            * condition is true it runs the code inside of the scope.
            * Otherwise, the scope is skipped.
            * 
            * (IF youre hungyr: Go eat - IF Not: Dont)
            * Optionally, you can add one or more else ifs that will        Else IF
            * run if the previous conditions were not met and their
            * condition is true.
            * 
            * Optionally, you can also include 1 final ELSE with NO         Always run*
            * condition, it will always run if nothing else above
            * did, and it MUST always be the last statement of
            * an IF tree.
            */

            Console.WriteLine("What day is it? Monday, Tuesday, etc."); 
            string userDay = Console.ReadLine().ToLower(); //strore response, convert to lower case

            if (userDay == "friday")
            {
                //The code in this scope will run ONLY IF the
                //above condition is true.
                Console.WriteLine("It's almost the weekend! :D");
            }
            else
                Console.WriteLine("Hang in there the week will be done before you know it!");
            Console.ReadLine();

            //Now for an IF Tree...

            int heroStrength;
            int monsterStrength = 100;
            Console.WriteLine("In this cave, you see bones and a white rabbit.");
            Console.WriteLine("Enter your attack strength: ");
            heroStrength = Convert.ToInt32(Console.ReadLine()); //converting string input to int


            // -----------  IF is Great for ranges of answeres like example * Multiple outcome RANGES below * -------------------
            //if -> tab -> tab                                                               * Use Notes for Dungeon App *
            if (heroStrength > monsterStrength)     //Hero is Stronger
            {
                //User entered a number greater than 100
                Console.WriteLine("You use your Holy Hand Grenade and blow the rabbit to bits.");
            }//End if

            else if (heroStrength == monsterStrength)   //Hero Equal to monster
            {
                //User entered 100 EXACTLY
                Console.WriteLine("You are evenly matched with your foe.");
            }
            else if (heroStrength >= monsterStrength * .75) //Hero is strong, but not as strong as monster
            {
                //User entered a number between 75 - 99
                Console.WriteLine("You fought valiantly, but ultimately perished by the rabit's fluffy paws.");
            }
            else if (heroStrength > 0)  //The Hero is overwhelmed by the rabbit
            {
                //User entered a number between 1 - 74
                Console.WriteLine("You join the pile of bones at the monsters feet!");
            }
            else if (heroStrength > 20)
            {
                //This code will NEVER run. In order for this 
                //condition to be true, one of the above conditions
                //would also be true, at which point that condition's
                //code would run and we would exit the if tree.
                //This is an example of a logic error.      *LOGIC ERROR*  
                Console.WriteLine("This will never run!");
            }
            else //* if nothing else then this * Else always comes last
            {
                //NO CONDITIONS FOR AN ELSE STATEMENT
                //This will run if NONE of the above if/else ifs are true.
                //User entered 0 or a negative number
                Console.WriteLine("You didn't stand a chance.");
            }

            //When working with IF, the condition just needs to be
            //a true or false value (or resolve to one)

            //Because a bool stores a true or false value, we 
            //can use a bool to determine whether or not an IF should run
            //  * one of the main reasons we have bools *

            bool runMe = true;

            if (!runMe) //! means NOT or FALSE. *IF NOT*
            {
                Console.WriteLine("\nProgram is running...\n");
            }
            //---------------- * SPECIFIC ANSWERES * ------------------------
            
            //if (x)
            {

            }

            //if (y)
            {

            }
            //if (z)
            {

            }
            //.-------------------------



        }//end main

    }//end class

}//end namespace
