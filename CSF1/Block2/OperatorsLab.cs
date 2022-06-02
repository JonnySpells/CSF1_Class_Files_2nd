using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block2
{
    internal class OperatorsLab
    {
        static void Main(string[] args)
        {
            //1)  Calculate the perimeter of a square whose sides are 75 inches long. (Hint: side * 4)
            Console.WriteLine("(Question 1)");
            int squareSide = 75;
            int nbrOfSides = 4;
            int perimeter = (squareSide * nbrOfSides);

            Console.WriteLine("One side of the square is " + squareSide + " inches.");
            Console.WriteLine("The square has a total of " + nbrOfSides + " sides.");
            Console.WriteLine("The perimeter of the square is: " + perimeter + " inches.");
            Console.WriteLine();

            //2)  Calculate the volume of a cuboid that is 45 inches high, 20 inches deep, and 65 inches long.
            //     (Hint: height * depth* length*)
            Console.WriteLine("(Question 2)");
            int height = 45;
            int depth = 20;
            int length = 65;
            int volume = height * depth * length;

            Console.WriteLine("The cuboid is " + height + " inches high.");
            Console.WriteLine("The cuboid has " + depth + " inches of depth.");
            Console.WriteLine("The cuboid also has " + length + " inches of length.");
            Console.WriteLine("Therefore, the volume of the cuboid is " + volume + " inches total.");
            Console.WriteLine();

            //3)  146 poeple were transported in vans that each carry 9 passengers. How many vans were there? How many people still need transportation?
            Console.WriteLine("(Question 3)");
            int people = 146;
            int vanCapacity = 9;
            int peopleRemaining = people % 9;
            
            Console.WriteLine("They had a total of " + people / vanCapacity + 
                " vans with unfortunately " + peopleRemaining + " people still needing a ride.");
            Console.WriteLine();


            //4)  A girl scout is selling Girl Scout Cookies. Assume that she takes 5 boxes of cookies to her neighbor's door and sells 2. Print out the amount of Girl Scout Cookies the girl started out with and then print out the amount of cookies the girl is taking to the next house.
            //Use only variables to keep track of the amount of Girl Scout Cookies
            Console.WriteLine("(Question 4)");
            int cookieBoxes = 5;
            int cookiesSold = 2;
            int cookiesRemaining = cookieBoxes - cookiesSold;
            Console.WriteLine("The girl scout started with " + cookieBoxes + " cookie Boxes. She sold " + cookiesSold + " boxes to her neighbore, and had " + cookiesRemaining + " remaining boxes for the next house.");
            Console.WriteLine();

            //Console.WriteLine("The girl scout started out with " + cookieBoxes);

            //5)  Create an int Variable called aliens with a value of 5. In a Console.WriteLine() using concatenation, print out the story below and replace each value surrounded in curly braces with an expression. Each expression must alter the value stored in the aliens variable. (Hint: use () to trump the order of operations)            
            //     A.{5} aliens came to Earth but one went home. There were then four aliens. Two more aliens came to Earth which means there were a total of {6}. Another alien came to Earth making the total {7}. Most of the aliens formed pairs and travelled to other planets but there was {1} alien left alone on Earth.
            int aliens = 5;
            Console.WriteLine("(Question 5)"); 
            
            Console.WriteLine(aliens + " aliens came to Earth but one went home. There were then " + (--aliens) + " aliens. Two more aliens came to Earth which means there were a total of " + (aliens += 2) + ". Another alien came to Earth making the total " +
                (++aliens) + " Most of the aliens formed pairs and travelled to other planets but there was " + (aliens -= 6) + " aliens left alone on Earth.");
            Console.WriteLine();






        }

    }

}
