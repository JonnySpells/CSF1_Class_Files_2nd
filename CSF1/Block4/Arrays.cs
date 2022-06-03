namespace Block4
{
    class Arrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Arrays");
            Console.WriteLine();


            /*
            * An array stores a fixed-size sequential * collection * of  ( "COLLECTION" IS KEY WORD)
            * objects of the same type. 
            * 
            * An array is used to store a collection of 
            * data, but it is often more useful to think of an array as 
            * a collection of variables of the same type.                      |***************|
            * 
            * ----------------( Standard Arrays ):  ------------------------------
            * 
            * * Think dresser. once you make the dresser, that's the size of the Array *
            * 
            * - Have a fixed size (can't change it programmatically)
            * - The size is called the Length (1-based counting) 
            *          * Length = how many drawers are in it*
            *          
            * - Uses 0-based counting for the positions of the indexes.
            * - Type safe
            * - Use the "new" keyword to call the "
            */

            //---------------------------------------------------------------------

            // MINI LAB!!
            // One way to create an Array:
            //Declare the Array with a set Length (1-based counting!)

            //Create a string array[] named dresser and assign it a Length of 4

            string[] spaceDresser = new string[4];

            //Now we can initialize the values individually.
            //You MUST initialize them before you can use them.
            //You can initialize them in any order.

            //For our dresser, we access the "drawers" (indexes) by their number (0-based!)
            spaceDresser[0] = "Jedi Robes"; // In the drawer with an index of 0, put "shirts"
            spaceDresser[1] = "Lightsaber";
            spaceDresser[3] = "Space Boots";
            spaceDresser[2] = "Space Shorts";

            //Each of the indexes called by spaceDresser[indexNumber] is
            //a variable you can use in your program.

            Console.WriteLine("{0} are in the drawer with an index of 2.", spaceDresser[2]);

            //Write the last index to the screen using string interpolation $
            Console.WriteLine($"{spaceDresser[3]} are in the last space drawer.");

            //You can reassign the drawers (indexes) of an Array[] just like normal variables.
            spaceDresser[3] = "\"TIE\"-Shirts";

            Console.WriteLine($"{spaceDresser[3]} are in the last space drawer.");

            //To explore an object in Intellisense use a period
            Console.WriteLine(spaceDresser.Length + " is the Length of the Array.");

            //The first index is ALWAYS 0
            Console.WriteLine("The first item in the array is " + spaceDresser[0]);

            //The last index is ALWAYS 1 less than the Length
            Console.WriteLine("The last item in the Array is " + spaceDresser[spaceDresser.Length - 1]);

            //Another example:
            decimal[] spacePrices = new decimal[5];
            //Generally, collections have a pluralized name

            spacePrices[0] = 24.99m;
            spacePrices[1] = 100;
            spacePrices[2] = 50;
            spacePrices[4] = 9.75m;
            spacePrices[3] = 200;

            //Just like the string array, you can write a single index's value to the screen
            Console.WriteLine(spacePrices[1]);

            //BUT... you cannot write the entire array to the screen by name...
            Console.WriteLine(spacePrices);

            //The compiler doesn't know how to format complex types like our Array.
            //SO, it simply outputs the object's namespace.classname *****

            //You can use Array index values in calculations
            decimal totalSpaceSale = spacePrices[0] + spacePrices[1] + spacePrices[2] + spacePrices[3] + spacePrices[4];
            //There is a shorter way to perform many calculation... (explore with Intellisense)
            //decimal totalSpaceSale = spacePrices.Sum();

            


            Console.WriteLine("\nSpace prices has {0} indexes." +
                "\nThe first index holds {1:c} and the last index holds {2:c}.",
                spacePrices.Length, spacePrices[0], spacePrices[spacePrices.Length - 1]);

            //Sort() is a method called from the Array class. It sorts the indexes
            //of the Array from lowest to highest value. For alphabetical characters,
            //it sorts from A-Z. This is reffered to as an "Ascending Sort".

            Array.Sort(spacePrices);

            Console.WriteLine("\nSpace prices has {0} indexes." +
                "\nThe first index holds {1:c} and the last index holds {2:c}.",
                spacePrices.Length, spacePrices[0], spacePrices[spacePrices.Length - 1]);

            //To get a Descending "Sort()" (highest to lowest) there is no direct method.
            //Instead, we can Sort() the Array and then "Reverse()" it.

            Array.Reverse(spacePrices);

            Console.WriteLine("\nSpace prices has {0} indexes." +
                "\nThe first index holds {1:c} and the last index holds {2:c}.",
                spacePrices.Length, spacePrices[0], spacePrices[spacePrices.Length - 1]);

            //There is also a shortcut to both declare and initialize an Array.
            //You must know all of the values you want in the Array first.
            //This is called "Collection Initialization Syntax"

            string[] toolbox = { "Wrenches", "screwdrivers", "hammers", "sockets" };
            //The compiler will determine the Length based upon the number of items
            //being initialized. It will then put them into the indexes in the order provided.

            int number = 42;
            int anotherNumber = 987;

            int[] numbers = { 50, number, 87, anotherNumber, 35, 15 };

            bool[] boolpen = { true, false, true, false };

            //A string is also a collection (of chars)
            string stringName = "Anakin Skywalker";
            int location = stringName.IndexOf(" ");

            //The IndexOd() gives us the Index location of a char in the string.
            //Above, we got the index of the space, which is 5 in this case. 

            //Substring 
            string firstName = stringName.Substring(0, location);

            string lastName = stringName.Substring(location + 1);

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            string emailSuffix = "@centriq.com";
            string myName = "Jon Pedroza";

            string emailPrefix = myName.Substring(0,4) + myName.Substring(5); //WORK ON THIS FOR HW
            string completedEmail = emailPrefix + emailSuffix;

            Console.WriteLine(completedEmail.ToLower());

        }//End Main

    }//End Class

}//End Namespace