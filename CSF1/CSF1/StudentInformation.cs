using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block1
{
    internal class StudentInformation
    {
        static void Main(string[] args)
        {
            int studentID = 3036975;
            string firstName = "Eleanor";
            string lastName = "Kucia";
            char studentGender = 'F';
            string studentMajor = "Biology";
            double studentGPA = 3.8;
            decimal tuitionPaid = 30_000m;
            decimal tuitionOwed = 20_000m;
            int semesterCreditHours = 8;
            int totalCreditHours = 24;

            //--- StudentInformation Information ---
            //Student ID:
            Console.WriteLine("Student ID: " + studentID);

            //First Name:
            Console.WriteLine("First Name: " + firstName);

            //Last Name:
            Console.WriteLine("Last Name: " + lastName);

            //Gender:
            Console.WriteLine("Gender: " + studentGender);

            //Major:
            Console.WriteLine("Major: " + studentMajor);

            //GPA:
            Console.WriteLine("GPA: " + studentGPA);

            //Tuition Paid: $
            Console.WriteLine("Tuition Amount Paid: " + tuitionPaid);

            //Tuition Owed: $
            Console.WriteLine("Tuition Amount Owed: " + tuitionOwed);

            //Credit Hours This Semester:
            Console.WriteLine("Credit Hours This Semester: " + semesterCreditHours);

            //Total Credit Hours:
            Console.WriteLine("Total Credit Hours: " + totalCreditHours);

            
        }
    }
}
