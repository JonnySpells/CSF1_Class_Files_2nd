namespace Block3
{
    class LogicComparison
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Logical and Comparison Operators");

            //Comparison Operators
            //"Relational" and "Equality" operators compare two
            //different values and return a bool (true or false) (Affirmative/Negative)

            /*
             *  > is greater than
             *  < is less than
             *  >= is greater than or equal to
             *  <= is less than or equal to
             *  == is equal to (strictly)
             *  != is NOT equal to      * In coding laguage "!" mean "NOT" *
             */

            int ceoPayGrade = 20;
            int mgrPayGrade = 12;
            int mailroomPayGrade = 2;

            //Comparisons return a boolean value (true or false) Example:
            bool isCeoPayHigher = ceoPayGrade > mgrPayGrade;
            Console.WriteLine("Is a CEO's pay greater than the Managers? " + isCeoPayHigher);

            Console.WriteLine("Is MGR pay greater than CEO? " + (mgrPayGrade > ceoPayGrade));

            Console.WriteLine("Is mailroom pay less than or equal to CEO? " + (mailroomPayGrade <= 
                ceoPayGrade));

            //A single = is how we perform assignment, so we use == to test equality
            Console.WriteLine("Is MGR pay equal to CEO? " + (mgrPayGrade == ceoPayGrade));

            //For not equal, we use !=. An exclemation mark in C# typically means "NOT"
            Console.WriteLine("Is MGR different than CEO? " + (mgrPayGrade != ceoPayGrade));

            //Comparing strings...
            string b = "batman";
            string b2 = "BATMAN"; //Different char
            string b3 = "BATMAN ";//Space counts as a char
           
            Console.WriteLine("Is b equal to b2? " + (b == b2));
            //C# is a case-sensetive language, so these are NOT equal.

            Console.WriteLine("Is b2 equal to b3? " + (b2 == b3));
            //Spaces are characters, so the extra space at the end of b3 makes it different.

            // To explore something in Intellisense, use a period (.)
            Console.WriteLine("Case INSENSETIVE, is b equal to b2? " +
                (b.ToUpper() == b2));
            //To Upper() is a method that capitalizes all letters in a string.
            //All methods, including ToUpper(), MUST have parens.

            //Logical Operators combine two comparison operators or boolean values
            //and return a boolean value.

            //  && is used for AND (in example both statements NEED to be TRUE.)
            //  || is used for OR  (in exmaple only one statement needs to be true.)

            bool payComparison = ceoPayGrade > mailroomPayGrade && ceoPayGrade < mgrPayGrade;

            Console.WriteLine("Is CEO less than MGR AND greater than Mailroom? " + payComparison);

            Console.WriteLine("Is 15 less than 5 OR equal to 15? " + (15 < 5 || 15 == 15));

        }// End Main()

    }//End class

}//End namespace

