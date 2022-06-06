using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block5
{
    internal class ATMLab 
    {
        static void Main(string[] args)
        {
            bool exit = true;
            bool returnMenu = true;
            do
            {                
                string accountNumb, pin;
                int attempts = 3;
                
                string account;
                string menu;
                
                
                
                
                decimal userChecking = 1100.68m;
                decimal userSavings = 200;
                decimal amount;  
                
                        
                //Make a title/intro                
                Console.Title = "Welcome To Trust Banking - \"The Banking You Can Trust\"";

                Console.WriteLine(" -==@=@==@=<( Trust Bank )>=@==@=@==-\n\n");
                // DO WHILE loop to ask the user for ACCOUNT & PIN
                // KICK THEM IF THEY FAIL 3 TIMES
                do
                {
                    Console.WriteLine(" Please enter your information\n\n Enter you Account Number:\n");
                    accountNumb = Console.ReadLine();
                    Console.WriteLine("  Enter your pin number:\n");
                    pin = Console.ReadLine();
                    Console.Clear();

                    if (accountNumb != "3036975" || pin != "0220")
                    {
                        attempts--;
                        Console.Clear();
                        Console.WriteLine("\n Invalid Username or Pin. You have " + attempts + " remianing.\n\n  Please Try Again.");
                        Console.ReadKey();
                        Console.Clear();
                    
                    }
                    //else if (accountNumb != "3036975" || pin != "0220")
                    //{
                    //    Console.WriteLine("Welcome To Trust Banking!");
                    //}
                    if (attempts == 0)
                    {
                        Console.WriteLine("Logging Out");
                        Environment.Exit(1);
                    
                    }
                                                                          

                } while (accountNumb != "3036975" || pin != "0220");

                

                do
                {                   

                    Console.WriteLine("\n----------<( TRUST BANKING )>----------\n\n");
                    Console.WriteLine("[a] Account\n\n[d] Deposit\n\n[w] Withdrawl\n\n[e] Exit\n\n");

                    switch (menu = Console.ReadLine())
                    {
                        case "a":
                        case "account":
                            Console.Clear();
                            Console.WriteLine(" \n--------- (AccountDetails) ----------\n\n");
                            Console.WriteLine(" Checking Balance| $" + userChecking + "\n Savings Balance| $" + userSavings);
                            Console.WriteLine("\n" +
                                "<Press R to Return to Menu>" );

                            string userReturn = Console.ReadLine().ToLower();

                            if (userReturn == "r")
                            {
                                returnMenu = false;

                            }


                            break;

                        case "d":
                        case "D":
                        case "deposit":
                            Console.Clear();
                            Console.WriteLine(" \n------------- (Deposit) -------------\n\n");
                            Console.WriteLine(" *Please Select an amount to deposit*\n\n");
                            Console.WriteLine("  [1] $20\n  [2] $50\n  [3] $100\n  [4] $200");

                             string deposit = Console.ReadLine();

                            switch (deposit)
                            {
                                case "1":
                                
                                    Console.Clear();
                                    Console.WriteLine("Deposited $20 into your account!\nYour account now holds: " + (userChecking + 20m) + "\n\nThank you for choosing Trust Bank");
                                    Console.ReadKey();
                                    break;

                                case "2":
                                
                                    Console.Clear();
                                    Console.WriteLine("Deposited $50 into your account!\nYour account now holds: " + (userChecking + 50m) + "\n\nThank you for choosing Trust Bank");
                                    Console.ReadKey();
                                    break;

                                case "3":
                                
                                    Console.Clear();
                                    Console.WriteLine("Deposited $100 into your account!\nYour account now holds: " + (userChecking + 100m) + "\n\nThank you for choosing Trust Bank");
                                    Console.ReadKey();
                                    break;

                                case "4":
                                
                                    Console.Clear();
                                    Console.WriteLine("Deposited $200 into your account!\nYour account now holds: " + (userChecking + 200m) + "\n\nThank you for choosing Trust Bank");
                                    Console.ReadKey();
                                    break;

                                default:
                                    break;
                            }
                            break;

                        case "w":
                        case "W":
                        case "withdraw":
                            Console.Clear();
                            Console.WriteLine(" \n------------- (Withdraw) -------------\n\n");
                            Console.WriteLine(" *Please Select an amount to withdraw*");
                            Console.WriteLine("  [1] $20\n  [2] $50\n  [3] $100\n  [4] $200");

                            string withdraw = Console.ReadLine();

                            switch (withdraw)
                            {
                                case "1":

                                    Console.Clear();
                                    Console.WriteLine("Withdrew $20 from your account!\nYour account now holds: " + (userChecking - 20m) + "\n\nThank you for choosing Trust Bank");
                                    Console.ReadKey();
                                    break;

                                case "2":

                                    Console.Clear();
                                    Console.WriteLine("Withdrew $50 from your account!\nYour account now holds: " + (userChecking - 50m) + "\n\nThank you for choosing Trust Bank");
                                    Console.ReadKey();
                                    break;

                                case "3":

                                    Console.Clear();
                                    Console.WriteLine("Withdrew $100 from your account!\nYour account now holds: " + (userChecking - 100m) + "\n\nThank you for choosing Trust Bank");
                                    Console.ReadKey();
                                    break;

                                case "4":

                                    Console.Clear();
                                    Console.WriteLine("Withdrew $200 from your account!\nYour account now holds: " + (userChecking - 200m) + "\n\nThank you for choosing Trust Bank");
                                    Console.ReadKey();
                                    break;

                                default:
                                    break;
                                
                            }
                            break;

                        case "e":
                        case "E":
                        case "exit":
                            Console.Clear();
                            Console.WriteLine("Exiting to Login...\n\n");
                            Console.Clear();
                            exit = false;
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine(" \n*Invalid Input Please Try Again*");

                            break;
                    }

                } while (!returnMenu);

            } while (!exit);

        }//End Main

    }//End class

}//End Namespace
