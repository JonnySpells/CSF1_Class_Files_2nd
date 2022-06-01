namespace Block2
{
    internal class Operators
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Mathematical Operators");
            //Shortcut: cw -> Tab -> Tab
            Console.WriteLine();

            //Concatenation
            Console.WriteLine(3 + 5); //Adding two literal numbers
            Console.WriteLine(3 + "5");//Concatenation - outputs 35

            //Other basic operators
            Console.WriteLine(12 - 8); //Subtraction
            Console.WriteLine(10 / 5);//Division
            Console.WriteLine(2 * 11);//Multiplicaton

            int legos = 15 + 27;
            Console.WriteLine(legos); //this works

            //We can make a lego car form 9 pieces. How many cars can we make? ********Problem Solving EXAMPLE********
            //What info do we need?
            // - How many legos we have (legos variable)
            // - How many legos are required to make a car? (9)
            // - A variable to hold the result  (legoCars)

            int legoCars = legos / 9;
            Console.WriteLine("We can make " + legoCars + " cars made out of legos!");

            //42 is not evenly devisable by 9, so we will have pieces left over.
            //How many pieces are left over? To find out, we can use modulo/modulus:(%)

            int piecesLeftOver = legos % 9; //modulus tells us if there is a remainder in division**

            Console.WriteLine(piecesLeftOver + " Pieces Remaining!");

            Console.WriteLine();


            //We have 75 nails. It takes 30 nails to make a dresser.
            //How many dressers can we make? How many nails will be left over?

            int nails = 75;
            int nailsRequired = 30;

            int dressersMade = nails / nailsRequired; //Dressers made, no remainder
            int nailsLeftOver = nails % nailsRequired;// 


            //For both variables, we asked the same question but requested a
            //different piece of the answer (the division result & the remainder)

            Console.WriteLine("We made " + dressersMade 
                + " dressers and have " + nailsLeftOver + " nails left.");

            Console.WriteLine();


            //Unary Operators are used to quickly increment/decrement
            //a variable's value. (Increment: +1 / Decrement: -1)

            int hobbits = 2;
            Console.WriteLine("We have " + hobbits + " hobbits.");


            //To add one the long way, we could write it like this:
            hobbits = hobbits + 1;
            Console.WriteLine("Hobbits is now " + hobbits);


            //Shorthand (Unary operator)
            hobbits++; //Incrementer (means to increase by 1)
            Console.WriteLine("Hobbits is now " + hobbits);


            //To decrease the value:
            //The long way...
            hobbits = hobbits - 1;
            Console.WriteLine("Hobbits is now " + hobbits);


            //Shorthand (Unary operator)
            hobbits--; //Decrementer

            Console.WriteLine();

            //Above, we put the unary operator AFTER the variable name.
            //However, it can also come beofre the variable, which effects
            //how the incrementation occurs.
            //variables++ is a POST-FIX increment (the increment happens last)
            //++variable is a PRE-FIX increment (the increment happens first)

            int goblins = 12, orcs = 1; // didnt work as planned*
            int badGuys = goblins + orcs++;

            Console.WriteLine("badGuys was assigned BEFORE orcs became two: " + badGuys);
            Console.WriteLine("orcs was incremented AFTER badGuys was assigned: " + orcs);

            Console.WriteLine();

            int xboxGames = 12, psGames = 1;
            int games = xboxGames + ++psGames;
            
            Console.WriteLine("games was assigned AFTER psGames became two: " + games);
            Console.WriteLine("psGames became two BEFORE games was assigned: " + psGames);

            Console.WriteLine();

            //Assignment Operators:******************************************************
            // = assigns the value on the right to the variable on the left.
            //It can also be used with mathmatical operators to create a shortcut
            //to perform math on a variable and reassign the value back to that variable.
            //Examples of assignment operators:
            // +=, -=, *=, /=, %=

            int players = 2;
            Console.WriteLine(players);

            //Long way to add 4 to players:
            players = players + 4;
            Console.WriteLine(players);//6

            //Shorthand (Assignment operator) //SH
            players += 4;
            Console.WriteLine(players);//10

            //Multiply by 3 the long way:
            players = players * 3;
            Console.WriteLine(players);//30

            //Shorthand (Assignment Operator) //SH
            players *= 3;
            Console.WriteLine(players);//90

            players %= 2;
            Console.WriteLine(players);

            //Finally, when using modulus, we can use modulus 2 (% 2)
            //to determine is a value is even or odd. If the result is 0,
            //the value is even. If the result is 1, the value is odd.




        }//End Main

    }//End class

}//End Namespace
    





