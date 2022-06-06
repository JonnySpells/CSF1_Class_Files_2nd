namespace Block5
{
    class loopingFor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Looping with For\n");

            /*
             * FOR LOOP SYNTAX
             * 
             * for (COUNTER; CONDITION; UPDATE)
             * 
             * COUNTER = variable (keeping track) * also known as INITIALIZER *
             * CONDITION = decide whether to loop 
             * UPDATE = alter amount for CONDITION
             * 
             * {
             *      //code to run
             * }
             * 
             * Some books refer to COUNTER as INITIALIZER
             * //! Mnemonic device: ICU 
             * 
             * Counter - the starting point where you initailize a 
             * variable that is used to check the condition. The 
             * counter gets updated after each pass through the loop.
             *
             * Condition - A Boolean statement that tells the loop
             * when to stop. It is checked before each pass.
             * 
             * Update - the change to the counter after each 
             *          pass of the loop (increment, decrement, etc.)
             * 
             * Remember: a for loop is best used when you know exactly 
             *           how many times you want to run the code
             *           
             * For loops are common and useful in many algorithms 
             * and methods in the C# language
             */

            for(int deathStick = 1; deathStick <= 7; deathStick++)
            {
                Console.WriteLine("You sold Obi-Wan " + deathStick + " deathSticks.");
            }

            Console.WriteLine("\nYou need to go home and re-think your life...");
            Console.ReadKey();

            //The continue keyword stops the current iteration the loop
            //and moves on to the next iteration.

            //Count to 20 BUY skip 13           // i  generally means iteration
            for (int i = 0; i <= 20; i++)
            {
                if (i == 13)
                {
                    continue;      //stops the current iteration of the loop so when we hit continue we're done
                }
                Console.WriteLine(i);
            }

            //Running Total Variable
            //Creating a variable in an outer scope allows you to
            //use it and make changes to it in an inner scope

            string listOfNames = ""; //Empty string

            Console.WriteLine("How many people would you like to register for Comic Con?");
            int totalReg = int.Parse(Console.ReadLine());

            for (int reg = 0; reg < totalReg; reg++)  //loops are theie own enclosed place meaning variables dont initially exist outside of it
            {
                Console.Write("Please Enter A Name: ");
                listOfNames += Console.ReadLine() + "\n";
            }

            Console.WriteLine($"\nYou have registered:\n{listOfNames}");

        }//End Main()

    }//End Class

}//End Namespace