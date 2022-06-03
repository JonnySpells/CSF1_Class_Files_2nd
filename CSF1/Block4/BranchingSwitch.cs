using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block4
{
    internal class BranchingSwitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Branching: Switch Statements\n\n");

            /*
             * SWITCHES are the other form of branching.
             * Not as flexible as IF (don't handle ranges well)
             * But GREAT at * exact matching *.
             * 
             * SYNTAX:
             * 
             * switch (valueToCheck) If loooks for condition, switch looks for specs
             * {
             *      case TEST:
             *          //code
             *          break;
             *          
             *      default:
             *          //code
             *          break;
             * }
             */

            Console.Write("Enter a number: ");
            short userNumber = short.Parse(Console.ReadLine());    // REMEMBER THIS FOR  changing ReadLines()

            switch (userNumber)
            {
                case 1:
                    Console.WriteLine("\nYou typed 1!");
                    break;

                case 2:
                case 3:
                case 4:
                case 5:
                case 42:
                    Console.WriteLine("\nYou typed either: 2, 3, 4, 5, or 42!");
                    break;

                case 6:
                    Console.WriteLine("\nYou typed 6!");
                    break;

                default:  
                    //OPTIONAL - Has no test, must come at the end 
                    //DEFAULT is like an "else" statement
                    Console.WriteLine("\nYou typed a number outside of the options. Good prank bro.");
                    break;
            }

            //IF YOU SEE A "CONTROL CANNOT FALL THROUGH" ERROR:
            //You are missing a break; somewhere in your switch.


            //Switches are perfect for menus!
            Console.WriteLine("\n\n Please choose a program to run.\n" +
                "1) Numbers\n2) Drawing\n3) Water\n4) Change");
            string userOption = Console.ReadLine().ToUpper();

            switch (userOption)
            {
                case "1":
                case "NUMBERS":
                case "N":                    
                    Console.WriteLine(" 1, 2, 3, 4, 5, 6, 7, 8, 9, 10");
                    break;

                case "2":
                case "DRAWING":
                case "D":
                    Console.WriteLine(" Its a sword!\n");
                    Console.WriteLine(@" 0==={:::::::::::::>");
                    break;

                case "3":
                case "WATER":
                case "W":
                    Console.WriteLine("Water Weight Lab!");
                    //You can copy & paste your water lab code here

                    //Each case could be hundreds of lines of code... no real limit
                    break;

                case "4":
                case "CHANGE":
                    case "C":
                    Console.WriteLine("Change Lab!");
                    //You can add your change lab code here
                    break;

                default:
                    Console.WriteLine("Invalid input. Please restart and try again.");
                    break;
            }

            //EXAMPLE of an IF statement inside of a switch
            Console.WriteLine("Please choose an option:\n" +
                "1) Login\n" +
                "2) About\n" +
                "3) Contact\n");

            string userInput = Console.ReadLine().ToUpper();

            switch (userInput)
            {
                case "1":
                    //Login
                    Console.WriteLine("Please enter your username:");
                    string username = Console.ReadLine().ToLower();

                    if (username == "jonny" || username == "admin")
                    {
                        //Valid username, proceed to password entry
                        Console.WriteLine("\nPlease enter your password: ");
                        string password = Console.ReadLine();

                        if ((username == "jonny" && password == "3036975") ||
                            (username == "admin" && password == "centriqguy25"))
                        {
                            Console.WriteLine("Credentials accepted. Now logging you in...");
                        }
                        else 
                        {
                            Console.WriteLine("Invalid password. Please restart and try again.");
                        }

                    }
                    else
                    {
                        //Invalid username
                        Console.WriteLine("Invalid username. Please restart and try again.");
                    }


                    break;


                case "2":
                    //About
                    Console.WriteLine("Centriq Training is the premier tech training company in KC & STL.");
                    break;


                case "3":
                    //Contact
                    Console.WriteLine("Interested? Email us at admissions@centriq.com");
                    break;


                default:
                    Console.WriteLine("Invalid");
                    break;
            }




        }//end main

    }//end class

}//end namespace
