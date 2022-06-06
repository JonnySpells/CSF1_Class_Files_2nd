using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block5
{
    internal class LoopingForeEach
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Looping with Foreach"); //computer smooshes it into one word lol

            /* FOREACH is a specialized loop made for collections. //************** (FASTEST, MOST SIMPLE, EASY TO USE LOOPS)***************
            * You can see the values in the collection, but you
            * can NOT change them in a foreach.
            * 
            * foreach (DATATYPE MADEUPNAME in COLLECTION) 
            * {
            *      //code to run with MADEUPNAME
            * }
            * 
            * This is the easiest, least error-prone loop. 
            * It is preferred in many program contexts,
            * but we lose some flexibility with it.
            * 
            * The foreach-loop is versatile.
            * We will end up using them in strings,
            * string arrays, and even DataTables.
            */

            string[] colors = { "red", "blue", "green", "purple", "black", "pink" };       //ARRAY

            foreach (string color in colors) 
            {
                Console.WriteLine(color);
            }
            //----------------------------------------------------------------------------------------------------------------------
            decimal[] cartPrices = { 12.99m, 2, 9.99m, 10, 20 };

            //Let's total up the prices in the cart and output each
            //value as we add it up.

            decimal totalSale = 0;

            foreach (decimal price in cartPrices)
            {
                totalSale += price;

                Console.WriteLine("After adding {0:c}, the total is now {1:c}", price, totalSale);
            }

            Console.WriteLine("\nYour total purchase is {0:c}", totalSale);

            //TIPS FOR CHOOSING A LOOP
            // If you know how many times you need to loop (count as an example), use FOR

            //If you dont know how many time you needed to loop, use WHILE

            //If you dont know how many times to loop, but you need to loop AT LEAST ONCE, use DO WHILE

            //If you are using a collection (arrays, for example) use FOREACH


        }//End Main

    }//End class

}//End namespace
