using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3
{
    internal class InputParseConvert
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Capturing input, parsing, and converting");

            #region Input/Output Notes            
            /*
             * There are 2 main options for output in console:
             * Write() and WriteLine()
             * 
             * WriteLine() adds a line break after your output.
             * Write() does *not*.
             * 
             * There are 3 options for Input in console: 
             * 
             * Read() - Only takes 1 keystroke of input and stores the
             * ascii value of the key.
             * ReadKey() - Similar idea, but captures the key's
             *              character value 
             * ReadLine() - Most common. It allows the user to input
             * something and reads the input as a *string* after they
             * hit enter.
             *  
             * The important part is capturing or using the information  * IMPORTANT *
             * they gave you.
             * */
            #endregion


            string firstName = "Doctor", lastName = "Who";

            Console.WriteLine();
            Console.Write(firstName);  // Console.Write() does NOT create a new line *************
            Console.Write(" " + lastName);

            Console.WriteLine(" - and now, a line break...");

            Console.WriteLine();

            //ReadLine() lets a user type input, however, you must        * ReadLine() *
            //capture that input or it is lost.

            //Console.ReadLine();

            #region ReadLine Notes

            /*
             * You cannot put any code inside the parens of the 
             * ReadLine(). Using ReadLine() by itself without storing 
             * the input or using it immediately results in the input 
             * being lost.
             * Using ReadLine() ------------------------------------------------------------
             * 
             * Step 1 - Explain to the user what to type!
             *          They cannot read your mind.....
             *          
             * Step 2 - Allow them to type by using
             *          Console.ReadLine()
             *          
             * Step 3 - Capture their input into a variable and store it 
             *          or use it immediately
             */

            #endregion

            //Step 1 - Prompt the user
            Console.Write("What is your name?");
            Console.WriteLine();

            //Step 2 & 3 - Let the user type AND store it in a variable
            string userName = Console.ReadLine();

            //Now we can use their input
            Console.WriteLine("Hello, " + userName + "!");
            Console.WriteLine();

            //Here's an example of using their input immediately.
            //We don't need a variable here but we also cannot reuse it.

            // Step 1 - Prompt the User
            Console.Write("What is your quest? ");

            // Step 2 - Let Them Type * we will use that info immediately *
            Console.WriteLine(Console.ReadLine() + "is a silly quest... ");

            // ___________________________  MINI-LAB!  ______________________________________________
            //Ask the user for their favorite color. Tell
            //what you think of their favorite color and be sure
            //to include what they typed in the response.
            Console.Clear();                      

            Console.WriteLine(" Hi friend! Question: What is your favorite lightsaber color?");
            Console.WriteLine();

            string userColor = Console.ReadLine();
            Console.WriteLine();
            string myColor = "Green";

            Console.WriteLine(" " + userColor + " huh? Youre right! " + userColor + " is awesome! Personally my favorite lightsaber color is " + myColor + ".");
            Console.WriteLine();

            // EVANS LAB EXAMPLE:  FUN FACT!: Evan likes Yellow
            Console.WriteLine("What is your favorite color? ");

            string userColo = Console.ReadLine();

            Console.WriteLine("\n" + userColor + " is a great color, " + userName + "!");
            Console.WriteLine();

            //Another example - * change later with STAR WARS *

            Console.WriteLine("What planet are you from?");
            string userPlanet = Console.ReadLine();

            //String Formatting uses 0-based counting for placeholders
            //and inserts variables into those places.
            Console.WriteLine("{0} is a great planet, {1}", userPlanet, userName);

            //Since ReadLine() always returns a string, we will need to do
            //extra work to use that information as another datatype.
            //One option for this is called "Parsing".
            //SYNTAX: datatype.Parse(stringValue)

            //*******************( Parsing Example )***********************

            Console.WriteLine("Enter your age: ");
            string userAge = Console.ReadLine();

            int age = int.Parse(userAge); //This turns the string into an int! userAge -> age

            int yearsTo100 = 100 - age;

            Console.WriteLine("Only {0} more years until you are 100!", yearsTo100);

            // ********EXAMPLE ********************
            // Step 1 - Prompt the User
            Console.WriteLine("How many \"Republic Credits\" do you want to make per galactic year? " + 
                "Decimal values are OK, but no $ symbols are allowed."
                );

            // Steps 2 & 3 - Capture the input and store it
            string salaryString = Console.ReadLine();

            //Parse their response into a numeric type
            decimal salary = decimal.Parse(salaryString);

            //String Interpolation {}
            Console.WriteLine($"Well, {salary * .3m : c} will go to space taxes...");

            //True names: **********************(CHEAT CHART)**********************************
            /*
             * All of the data types we have used up to this point are
             * "intrinsic" or "simple" datatypes that have their own
             * C# reserved keyword associated with them. In reality
             * the keyword is just an alias for class that exists
             * by default in the framework. You 
             * can use either the alias or the true name:
             * 
             * byte = Byte
             * short = Int16
             * int = Int32
             * long = Int64
             * 
             * decimal = Decimal
             * double = Double
             * float = Single * used to store variables with ONE value *
             * 
             * string = String
             * bool = Boolean
             * char = Char
             */
            //*************************************************************************************

            //Example:
            int x = 1;
            Int32 y = 2;

            // Convert is another option for changing the datatype.         ---------(CONVERT)----------
            // It works similar to Parse(), but the syntax is different:
            // Convert.ToTrueName(valueToConvert)

            //Step 1 - Prompt the user
            Console.WriteLine("How many times have you been smuggled" +
                "through Imperial lines by Han Solo & Chewie shipping LLC");

            //Steps 2 & 3 - Catch the input and store it
            string timesSmuggledString = Console.ReadLine();

            //( Parse ) ---------------------------------------------------------------------------------
            //short timesSmuggled = short.Parse(timesSmuggledString);

            //Now, do the same using ( Convert )       *WILL ALWAYS USE TRUE NAME TO CONVERT!!!*
            short timesSmuggled = Convert.ToInt16(timesSmuggledString);

            Console.WriteLine("You have {0} more trips to get your free lightsaber.", 10 - timesSmuggled);





        }//End Main

    }//End Class

}//End Namespace

