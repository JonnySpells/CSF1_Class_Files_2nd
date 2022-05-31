namespace Block1
{
    internal class Variables
    {
        static void Main(string[] args)
        {



            //Adding // to the start of a line creates a single-line comment that is ignored by the compiler

            /*
             * You can also create multi-line comments like this.
             * They are also ignored by the compiler.
            */

            //To save changes, we can hit the floppy icons at the top of the Visual Studio window,
            //or we can hit Ctrl + S (save this file) or Ctrl + Shift + S (saves all files)


            /*****Important Things to Know About C#*******
                        * 
                        * 
                        * C# curly braces are used to define the scope of something. They say, all of the content inside of them relates to this one thing. Here all the code inside of the curly 
                        * braces relates to the Main(). 
                        * 
                        * A semicolon is used like a period to show the end of a line of code
                        * 
                        * C# largely ignores whitespace, except when inside of string (i.e. "Hello, world!" above)
                        * 
                        * C# is case sensitive meaning that example and Example could refer to different things. 
                        * 
                        * C# is type-safe which means when something is created you define what type of thing it is and it stays that type forever.
                        */

            //*******Variables******//

            //A variable is just a container to hold information. When a container is created, you must define what type of data it will hold (type-safety).
            //The data stored in a container can be changed. 
            //Variables are traditionally defined using the camelCase naming convention. 
            //Variable names can ....
            //   - only begin with alphabetic characters or underscores
            //   - cannot contain spaces
            //   - must contain at least 1 alpha or numeric character
            //   - cannot be a reserved keyword (i.e. class, static, void...all shown in dark blue)
            //   - be unique within their scope {}

            //When making a variable you go through three steps: Declaration, Initialization, and Assignment
            //1. Declaration: this is when the container is created. It is given a name and a data type. 
            //2. Initialization: this is when the container is given a value for the first time. 
            //3. Assignment: giving the container a new value, after the first time

            //**** Creating Variables ****
            // Declaration - data typ, then the name (camelCase)
            int firstExample;

            //string firstExample; This code didn't work because all variables in the same
            //scope must be uniquely named.

            //Initialization -giving variable value
            firstExample = 1; //Once a variable is declared, you refer to it by name only. 
                              //DO NOT put the data type when trying to reference (call) a variable, as C#
                              //would think you are trying to make a new variable.

            //Assignment / Reassignment
            firstExample = 2;

            //Usually, variables are declared and initialized in the same line...
            string name = "Jonny Spells";

            //Let's see the information stored in the name variable that holds string data
            //printed to the Console

            Console.WriteLine(name);

            name = "Luke Skywalker";

            Console.WriteLine(name);
            //What you see in the console depends on the value the variable has 
            //at that point in time


            //**** Declaring Mulitple Variables ****
            //You can make many vaiables at one time.
            //Let's declare several variables that all hold the same type of data.
            int burgers, frenchFries, onionRings, milkShakes;

            //The variables have been created, BUT they have no values. We need to initialize
            //each variable before we can use it. It does not matter which order yoiu do this in.
            frenchFries = 5;
            onionRings = 6;
            milkShakes = 7;
            burgers = 8;

            //You can also declare and initialize many variables at the same time, or do a
            //mix of both.

            string firstName = "Darth", lastName = "Vader", occupation;

            //The variables of firstName and lastName have values, so they can be used immediately...
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            //Console.WriteLine(occupation); This will not work because occupation has not been
            //initialized.

            //When declaring multiple variables, you cannot mix data types.
            //int mlsTeams + 19, mlsChampions + "Sporting KC"; **** This will not work. ****
            //int mlsTeams = 19, string mlsChampions + "Sporting KC"; **** This doesn't work either. ****
            int mlsTeams = 19; string kcSoccerTeam = "Sporting KC";

            // *** Constants ***
            //You can declare variables whose value NEVER changes. These are called constants
            //and they must be declared AND initialized at the same time.
            const int CURRENT_YEAR = 2022; //Naming Convention: UPPER_CASE
                                           //CURRENT_YEAR = 2023; **** This wont work ****
                                           //Constants can still be used like normal variables.
            Console.WriteLine(CURRENT_YEAR);

            //*** Literals ***
            //Difference between variables and literals (literal values)
            int bigNbr = 54321; //Don't use commas for big numbers
            Console.WriteLine(bigNbr);
            Console.WriteLine(54321);
            Console.WriteLine("54321");
            //All of these look the same in the console. However, I could call on 
            //bigNbr and use that value over and over. I do not have a way to call 
            //on 54321 and "54321" over and over again.

            // *** Difference Between a String and an Int ***
            // Strings store an unlimited number of text characters (alphabetical, numeric, and symbols)
            //Ints store only numeric values
            //These differences in the types of information stored causes them to behave differently.

            //Add two ints together
            Console.WriteLine(17 + 25); //This gives us a numeric calculation
            Console.WriteLine("17" + "25"); // Adding two strings together is called "Concatenation".
                                            //No calculations happen here. Instead, we are connecting one string to the other. // concatinating = connecting //

            //*** Generating Output ***
            //You can use concatenation to print out a combination of text, numeric, and other values
            int kuBasketballPts = 1068;
            int muBasketballPts = 1003;

            Console.WriteLine("KU Scored " + kuBasketballPts + " points in 15 games.");
            Console.WriteLine("Total KU & MU Points: " + (kuBasketballPts + muBasketballPts));

            //The () around the numeric calculation above states that we want to perform the math
            //THEN concatenate the result with the string. (Order of Operations)

        }//End Main()               () = method
    }//End Class
}//End Namespace
