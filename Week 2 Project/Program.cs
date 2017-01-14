using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name:\n");   //ask user for first name
            string firstName = Console.ReadLine();

            Console.WriteLine("\nPlease enter your last name: \n"); //ask user for last name
            string lastName = Console.ReadLine();

            Greeting(firstName, lastName);                          //call method to greet user

            Console.WriteLine("How old are you?\n");                //ask user for age
            int age = int.Parse(Console.ReadLine());                //converts string to integer type

            AgeError(age);
            
        }
        static void Greeting (string firstName, string lastName)
        {
            //converts user input to lowercase and then capitalizes first letter
            firstName = firstName.ToLower();
            string firstName1 = firstName.Substring(0, 1);
            firstName1 = firstName1.ToUpper();
            firstName = firstName.Remove(0, 1);

            //converts user input to lowercase and then capitalizes first letter
            lastName = lastName.ToLower();
            string lastName1 = lastName.Substring(0, 1);
            lastName1 = lastName1.ToUpper();
            lastName = lastName.Remove(0, 1);

            Console.WriteLine("\n...\n...\n...\n\nHello, " + firstName1 + firstName + " " + lastName1 + lastName + ". Your fortune awaits.\n\nMUAHAHAHAHA\n");
        }
        static int Retirement (int age)
        {
            int retire;
            if (age % 2 == 0)
            {
                retire = 65;                                //returns retirement age of 65 if age is even
            }
            else
            {
                retire = 75;                                //returns retirement age of 75 if age is odd
            }
            return retire;
        }
        static int AgeError (int age)
        {
            while (age <= 0)                                 //prevents user from entering age below 1
            {
                Console.WriteLine("\nImpossible. Please enter your actual age:\n");
                int age1 = int.Parse(Console.ReadLine());
                age = age1;
            }
            while (age > 120)                               //prevents user from entering age greater than 100 
            {
                Console.WriteLine("\nI don't believe you. Please enter your actual age:\n");
                int age1 = int.Parse(Console.ReadLine());
                age = age1;
            }
            return age;
        }
    }
}
