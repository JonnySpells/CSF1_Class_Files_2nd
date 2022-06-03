using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3
{
    internal class InputLab
    {
        static void Main(string[] args)
        {
            


            Console.WriteLine(" Welcome to the Emperial Input Lab! \n\n" +
                "  <Press Enter to Begin>");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(" Welcome to the Imperial Base's second annual interigati- I mean \"Meet AND Greet.\"\n\n " +
                "We will be asking you a variety of questions, which you will answer.\n\n " +
                "You may now applaud silently to yourself if you wish.\n");


            Console.WriteLine(" Well trooper here is your first question: What is your favorite season for crushing the Rebellion?");
            string favSeason = Console.ReadLine();
            Console.Clear();
          
            Console.WriteLine(" \nYou say your favorite season is \n\n\"" + favSeason + "\"? \n\n Not what I was expecting, but I suppose it is *technically* still an answer.\n\n Proceeding to the next question.\n");


            Console.WriteLine(" What sort of vehicle is your favorite to hunt down the Jedi Scum in trooper?\n");
            string favVehicle = Console.ReadLine();
            Console.Clear();

            Console.WriteLine( "\n\"" + favVehicle + "\" you say? Interesting. No accounting for taste however. Very well.\n");


            Console.WriteLine(" What is your favorite song to listen to while you are hunting down the vile Rebel scum? \n\n I must note that any answer other than \"Imperial March\" will see a deduction in points.");
            string favSong = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\n Just as I suspected. You are the third person we have had to \"relocate\" for giving that same answer. *hmmph* \n");

            Console.WriteLine(" Now then. What is your yearly allowed salary of Imperial Credits as an subordinate of the Empire?");
            decimal spaceSalary = decimal.Parse(Console.ReadLine());
            
            Console.Clear();
            Console.WriteLine(" Just as I suspected. Your salary is in dire need for re-evaluation. Thank you for your cooperation trooper. However, due to unfortunate cutbacks along with the recent deduction to your salary of " + spaceSalary +" Credits, we have deemed it necessary to liquidate all assets associated to you including your..\"" + favVehicle + "\". However, I am confident you wont be late as a result as you enjoy the " + favSeason + "season do you not? Dismissed trooper. * The Imperial Officer cheerfully walks away wistling " + favSong + "*");
            Console.ReadKey();




            

        }
    }
}
