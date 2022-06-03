using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block4
{
    internal class ArrayLab
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Please Enter 5 Test Scores One At A Time: ");

            int[] score = new int[4];

            string[] scoreIndex = new string[5];
            scoreIndex[0] = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\n Score 1: " + scoreIndex[0] + " \n Please Enter Next Score.\n");
            scoreIndex[1] = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\n Score 2: " + scoreIndex[1] + " \n Please Enter Next Score.\n");
            scoreIndex[2] = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\n Score 3: " + scoreIndex[2] + " \n Please Enter Next Score.\n");
            scoreIndex[3] = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\n Score 4: " + scoreIndex[3] + " \n Thank You!");
            scoreIndex[4] = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\n Score 5: " + Sort(scoreIndex[]) + " \\n");

            Console.WriteLine($""); //sort() DO FOR HW

            
            

            
            





        }
    }
}
