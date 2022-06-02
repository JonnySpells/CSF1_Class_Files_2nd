using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3
{
    internal class StringsRevisited
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Strings Revisited -");

            // You can use the ToString() to get the string version of any value
            //from a variable of any datatype. You call this method
            //from the variable directly. This allows us to output values
            //as strings and apply special formatting with format specifiers.

            decimal someDecimal = 125341.2356m;                 //****IMPORANT****
            string nbrString = someDecimal.ToString();
            Console.WriteLine(nbrString);

            //Format Specifiers let us change the way the information in a string
            //is output, depending on how we want to format it.

            Console.WriteLine(someDecimal.ToString("n") + " with n for number.");

            //Since "n" defaults to 2 decimal places, we can also specify a number
            //for n to denote how many decimal places it should allow after the period

            //--EXAMPLES--
            Console.WriteLine(someDecimal.ToString("n6") + " with n6 formatting.");
            Console.WriteLine(someDecimal.ToString("c") + " with currency formatting.");
            Console.WriteLine(someDecimal.ToString("e") + " with exponential formatting.");

            //double money2 = 50.25;
            //decimal money = 50.25m;
            //decimal money3 = (decimal)50.25;

            //_____________________________________________________________________________________________
            //String Formatting


            //This allows us to use placeholders inside of a string, then
            //fill in those placeholders with values of our choice.
            //The numbers used for the placeholders always start at 0
            //and increase over time as they are used in the string.
            //The values to insert into the placeholders are placed 
            //after a comma following the string.

            Console.WriteLine("{0} is the value of our decimal.", someDecimal); //*pretty cool*
                                                                                //* LOOK AT THIS FOR REFERENCE *
            Console.WriteLine("{0:n3} is the value with n3 formatting and {0:c} is the value with currency formatting.", someDecimal);

            //String Interpolation-------------------------------------------------------------------------
                                                    //* EITHER WAY BUT THIS WAY IS LESS WORK *
            //This also allows us to insert values into a string but
            //does not require placeholders. Instead, the values are 
            //inserted directly using curly braces. For string interpolation
            //to work, we must place a $ at the beginning of the string.

            Console.WriteLine($"{someDecimal:n3} for n3 format and {someDecimal:c} for currency format.");

            //Escape Characters-----------------------------------------------------------------------------
                                                            // * THIS IS HOW TO USE QUOTES IN STRING
                                                            // * SUPER IMPORTANT!!!

            //Special pieces of code used inside a string that ignore certain characters.
            //These differ based on the language. In C#, they begin with a \.

            // --- \n Creates a new line inside of a string        
            Console.WriteLine("I love escapes!\nThey are easy!");

            // ---  \" Escapes the quote( " ) and allows it to be used as a character
            Console.WriteLine("The Zombie Kid said, \"I like turtles.\"");

            // ---  \\ Escapes the excape and prints the \ character
            Console.WriteLine("C:\\VS2022\\Projects\\CSF1");

            // --- @ Verbatim Character             
            // 
            string fileLocation = @"C:\student\documents\ubergeek.doc"; //Verbatin @

            Console.WriteLine("This is the file location: " + fileLocation); //String Concatenation
            Console.WriteLine("This is the file location: {0}", fileLocation); //String Formatting {}
            Console.WriteLine($"This is the file location: {fileLocation}"); //String Interpolation $

            string doggo = @"^..^      /
                             /_/\_____/
                                /\   /\
                               /  \ /  \";

            Console.WriteLine(doggo);

            //We can format strings withouut Console.WriteLine():    * USEFUL AND SAVES TIME *
            string formattedString = string.Format("This is the file location: {0}", fileLocation);

            //This method is extremely useful because it gives us a reusable string variable:
            Console.WriteLine(formattedString);







        }//end main

    }//end class

}//end namespace
