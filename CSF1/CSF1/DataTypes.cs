//Using statements in C# define resources from .NET that this file needs 
//to be able to execute.      (.NET = behind the scenes stuff to run an application)*
//In the current version of .NET, some using statements
// are "implicit" or automatically added by & available to the copmiler.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//As we need more resources, we will add using statements as necessary.

//A namespace refers to the project your code lives in. Here, it is Block1.
//Namespaces are traditionally defined using PascalCase naming convention.

namespace Block1
{ //Begin namespace

    //A class is a file that contains code that your app will use to run.
    //They are traditionally defined using the PascalCase naming convention.
    internal class DataTypes
    {//Begin class

        //A method is like a verb in the C# language. It is where action is performed.
        //The below is a unique method, as it is required for any classes we want
        //to run/execute in our console app. Shortcut: svm > Tab > Tab

        static void Main(string[] args)
        {//Begin Main()

            //ANY CODE WE WANT TO RUN MUST BE INSIDE THE MAIN()

            Console.WriteLine("Data Types: Bob Sure Is Loving");
            // S and U, Signed/ Unsigned, negative/ positive
            /*
                          Data Type             Bits           Value Range        |  Lesser Used Variant          Value Range
                                                                                  |
            Bob            byte                  8              0 - 255           |  sbyte                         -128 - 127
                                                                                  |
            Sure           short                 16             -32k - 32k        |  ushort                        0 - 65k
                                                                                  |
            Is             int                   32             -2bil - 2bil      |  uint                          0 - 4bil
                                                                                  |
            Loving         long                  64             -9quint - 9quint  |  ulong                         0 - 18quint
             */

            //bits can be one of two things: 0 or 1, on or off. This is how the computer sees things // 00000000 = 0   00000001 = 2

            // 00000000 00000000 00000000 00000000      *Jon Example*

            //SIGNED = +/-   ** CAN have negatives **

            // Declare
            byte byteNbr;

            //Initialize
            byteNbr = 0;

            //Assign / Reassign
            byteNbr = 255;

            //byteNbr = 1000;
            //The above does not work -- 1000 is too big for a byte.

            //Declare and Initialize (Initialization Syntax) 
            short shortNbr = -1234;
            int intNbr = 12345678;
            long longNbr = 1296723057389;

            //The name of a variable can be anything you want. However, GOOD variable names
            //are descriptive of what you are storing or how it will be used.
            //Example: Store shoes in a box called showBox

            //Use the C# lesser-used integer variants
            sbyte sbyteNbr = -7;
            ushort ushortNbr = 58000;
            uint uintNbr = 29584224;
            ulong ulongNbr = 8989988956565;

            //int pi = 3.14;  
            //int holds whole numbers. Therefore, we cannot put this value into an int.

            //      **** Floating Point Types **** (LIKE THE BYTE SITUATION, all about efficiency)

            //Floating point types support decimal values
            float smallFraction = 12.5f; 
            //The above works with f or F, both are shortcuts for a float.

            double smallFraction2 = 30.5; 
            //No suffix needed above - double is the DEFAULT floating point type.

            decimal smallFraction3 = 40.84m; //(most precise, long decimal)
            //The above works with m or M, both are shortcuts for a decimal (m for monye!)

            //float has 32 bits of storage available, allows for 45 digits
            //double is the default - has 64 bits, up to 324 digits (only 2 decimal places)
            //decimal has the greatest accuracy - 128 bits, 29 digits (can have ALL as decimal places)

            //Any decimal/floating point number can also accept a whole number
            //12 = 12.0
            float anotherFloat = 12.0f;

            Console.WriteLine("Calculation Result: " + (anotherFloat / 2f));

            // **** Booleans **** IMPORTANT USE THEM ALL THE TIME!
            //Booleans (also known as bools) accept only two values: true or false
            //Note: No quotes around the words... that would be a string

            //Doctor Who example:
            bool isTheDoctor = false;

            Console.WriteLine("Are you the Doctor? " + isTheDoctor);

            isTheDoctor = true; 

            Console.WriteLine("Are you the Doctor? " + isTheDoctor);


            // **** Char **** (CHARACTER)
            //The char datatype accepts a single character value
            //chars are contained in single quotes ***(single ticks)***
            char letter = 'A';

            char symbol = '%';

            //char someChar = "A"; // wont work
            //char someChar2 = 'abc'; //wont work

            Console.WriteLine("Symbol is: " + symbol + " and letter is: " + letter);


            //*** Strings ***
            //String accepts any number of characters in double quotes
            string firstName = "James";

            string lastName = "Bond";

            // *** Concatenation ***
            //With some creative concatenation, we can format our string outputs
            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine(firstName + ' ' + lastName); //either of these work. space take sup a "tick"

            //Use concatenation to output James Bond's signature intro
            Console.WriteLine(lastName + ". " + firstName + ' ' + lastName + '.');




            //"Syntax" referes to HOW you use the laguage/ information.
            //"Lexicon" is the collection of individual pieces.




        }//End main()

    }//End class

} //End namespace

