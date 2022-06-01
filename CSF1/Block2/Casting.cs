using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block2
{
    internal class Casting
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Casting");

            #region Casting Notes

            /*
             * Casting is copying the value from avariable of one type (Casting = copying to another)
             * to a variable of a different (but similar) type.
             * 
             * IMPLICIT Casting: Copies the contents form a smaller container
             * into a larger container (data type). This always fits.
             * 
             * EXPLICIT Casting: Copies the contents from a larger container
             * into a smaller container. This requires extra work. You will 
             * have to explicitly state the data type you are casting to.
             * This can also create issues if the value won't fit.
             * 
             */

            #endregion

            byte toothpasteBox = 1;
            short shoeBox = 200;
            int movingBox = 32261;
            long fridgeBox; //Just declared, not initialized.

            //Assignement: The value on the right is assigned to the variable on the left.

            //Cast the value of toothpasteBox into fridgeBox:
            fridgeBox = toothpasteBox; //Implicit casting (byte to a long)
            //The above always works because the value can fit in the larger container
            Console.WriteLine("fridgeBox has a value of: " + fridgeBox);

            long ovenBox = fridgeBox;
            //Not casting, just assigning the value of a variable from one container
            //to another container of the SAME data type.

            //Cast the value of shoeBox into toothpasteBox
            toothpasteBox = (byte)shoeBox;//Explicit casting (short to a byte)

            Console.WriteLine("Toothpaste Box has a value of: " + toothpasteBox);

            Console.WriteLine("Shoe Box remains the same: " + shoeBox);


            toothpasteBox = (byte)movingBox;

            Console.WriteLine("Toothpaste Box is now: " + toothpasteBox);
            Console.WriteLine("Moving Box is still: " + movingBox);

            //byte - 8 bits - 00000000
            //short - 16 bits - 00000000 00000000
            //int - 32 bits - 00000000 00000000 00000000 00000000
            //long - 64 bits - 00000000 00000000 00000000 00000000 00000000 00000000 00000000 00000000 Just like the Nintendo 64 Wowie!

            //When you cast a larger value into a smaller container,
            //you get unexpected/undesireable results (truncation). **********TRUNCATION***************
            //Above, 32261 is too big to fit into a byte. When we tried
            //to copy it into the byte container, the value we see left over is 5.

            float flol = 4.3f;

            decimal dec1 = 4.3M;

            decimal dec2 = (decimal)4.3;

            //An example where truncation may actually be useful:

            int completedDS;

            decimal deathStars = 1.75m; // *******************  hW IMPORTANT  ****************

            completedDS = (int)deathStars;

            Console.WriteLine("Out of " + deathStars + " Death Stars, only " + completedDS + " was " +
                "completed");

         

        }//End Main()
    }//End Class
}//end Namespace
