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
            //tells user that he or she can quit or restart at any time
            Console.WriteLine("You may exit the program at any time by entering \"quit\".\n");
            Console.WriteLine("You may restart the program at any time by entering \"restart\".\n");

            //ask user for first name
            Console.WriteLine("Please enter your first name:\n");   
            string firstName = Console.ReadLine();

            //quit/restart method. see mthod below
            End(firstName);

            //ask user for last name
            Console.WriteLine("\nPlease enter your last name: \n"); 
            string lastName = Console.ReadLine();

            //quit/restart method. see method below
            End(lastName);

            //call method to greet user. see method below
            Greeting(firstName, lastName);                          

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

            //ask user for age and converts string to integer type
            Console.WriteLine("How old are you?\n");
            string ageInput = Console.ReadLine();

            //quit/restart method
            End(ageInput);

            //converts ageInput to integer
            int age = int.Parse(ageInput);

            //confirms age is between 0 and 130. see method below
            age = AgeError(age);

            //stores numbers of years until retirement. see method below                                 
            int retire = Retirement(age);                           

            //ask user what month he or she was born in
            Console.WriteLine("\nPlease enter your month of birth: (i.e. 1 for January, 12 for December):\n");
            string monthInput = Console.ReadLine();

            //quit/restart method
            End(monthInput);

            //convert monthInput to integer
            int birthMonth = int.Parse(monthInput);

            //stores bank account balance as double. see method below
            double money = BankAccount(birthMonth);

            //asks user for his or her favorite ROYGBIV color
            //allows user to input "help" in case he or she is not familiar with ROYGBIV
            Console.WriteLine("\nPlease enter your favorite ROYGBIV color:\n\nFor help, enter \"help\"\n");
            string color = Console.ReadLine();

            //quit/restart method
            End(color);

            //print out ROYGIBIV info if user asks for help. see method below
            string colorNew = ColorHelp(color);

            //picks mode of transportation based on favorite color
            string whip = Vehicle(colorNew);

            //asks user to enter number of siblings
            Console.WriteLine("\nPlease enter number of siblings:\n");
            string siblingInput = Console.ReadLine();

            //quit/restart method
            End(siblingInput);

            //converts siblingInput to integer
            int numSibling = int.Parse(siblingInput);

            //stores vacation home based on number of siblings. see method below
            string vacaHome = Vacation(numSibling);

            //write fortune based on user input
            Console.WriteLine("\nBased on the answers, the crystal ball shows...\n...\n...\n...\n\n" + firstName1 + firstName + " " + lastName1 + lastName + ", you will retire in " + retire + " years with $" + money + ".00 in the bank, a vacation home in " + vacaHome + ", and a " + whip + ".");

            //final remark
            Conclusion();
        }
        static void End (string end)
        {
            if (end.Equals("quit", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("\nNo one likes a quitter...\n");
                Environment.Exit(0);
            }
            else if (end.Equals("restart", StringComparison.CurrentCultureIgnoreCase))
            {
                string[] args = { };    //creates arbitrary string array to be used to restart Main method
                Console.Clear();        //clears previous console
                Main(args);             //starts Main method
                Environment.Exit(0);    //clears previous information
            }
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

            //greeting
            Console.WriteLine("\n...\n...\n...\n");
            Console.WriteLine("      _");
            Console.WriteLine("     ( )");
            Console.WriteLine("      H");
            Console.WriteLine("      H");
            Console.WriteLine("     _H_");
            Console.WriteLine("  .-'-.-'-.");
            Console.WriteLine(" /         \\");
            Console.WriteLine("|           |");
            Console.WriteLine("|   .-------'._");
            Console.WriteLine("|  / /  '.' '. \\");
            Console.WriteLine("|  \\ \\ @   @ / /");
            Console.WriteLine("|   '---------'");
            Console.WriteLine("|    _______|");
            Console.WriteLine("|  .'-+-+-+|\tMUAHAHAHAHAHAHA. Hello, " + firstName1 + firstName + " " + lastName1 + lastName + ". Your fortune awaits.");
            Console.WriteLine("|  '.-+-+-+|");
            Console.WriteLine("|    \"\"\"\"\"\" |");
            Console.WriteLine("'-.__   __.-'");
            Console.WriteLine("     \"\"\"\n");
        }
        static int Retirement (int age)
        {
            int retire;
            int yearsUntilRetire;
            if (age % 2 == 0)
            {
                retire = 65;    //returns retirement age of 65 if age is even
            }
            else
            {
                retire = 75;    //returns retirement age of 75 if age is odd
            }

            yearsUntilRetire = retire - age;
            return yearsUntilRetire;
        }
        static int AgeError (int age)
        {
            while (age <= 0)    //prevents user from entering age below 1
            {
                Console.WriteLine("\nImpossible. Please enter your actual age:\n");
                int age1 = int.Parse(Console.ReadLine());
                age = age1;
            }
            while (age > 120)   //prevents user from entering age greater than 100 
            {
                Console.WriteLine("\nI don't believe you. Please enter your actual age:\n");
                int age1 = int.Parse(Console.ReadLine());
                age = age1;
            }
            return age;
        }
        static double BankAccount (int birthMonth)
        {
            double money;

            //sets conditions for meny left in bank based on birthMonth
            if (birthMonth >= 1 && birthMonth <= 4)
            {
                money = 500000;
            }
            else if (birthMonth > 4 && birthMonth <= 8)
            {
                money = 900000;
            }
            else if (birthMonth > 8 && birthMonth <= 12)
            {
                money = 50000;
            }
            else
            {
                money = 0;
            }

            return money;
        }
        static string ColorHelp (string color)
        {            
            //displays ROYGBIV colors if user inputs help
            while (color.Equals("help", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("\nROYGBIV Colors\nR = Red\nO = Orange\nY = Yellow\nG = Green\nB = Blue\nI = Indigo\nV = Violet\n");
                Console.WriteLine("\nPlease enter your favorite ROYGBIV color:\n");
                string color1 = Console.ReadLine();
                if (color1.Equals("quit", StringComparison.CurrentCultureIgnoreCase))    //option to quit/restart
                {
                    Console.WriteLine("\nNo one likes a quitter...\n");
                    Environment.Exit(0);
                }
                else if (color1.Equals("restart", StringComparison.CurrentCultureIgnoreCase))
                {
                    string[] args = { };    //creates arbitrary string array to be used to restart Main method
                    Console.Clear();        //clears previous console
                    Main(args);             //starts Main method
                    Environment.Exit(0);    //clears previous information
                }
                color = color1;
            }
            string colorNew = color;
            return colorNew;
        }
        static string Vehicle (string color)
        {
            //assigns vehicle based on favorite color
            string colorLower = color.ToLower();
            string whip;
            switch (color)
            {
                case "red":
                    whip = "Lambo";
                    break;
                case "orange":
                    whip = "Toyota Camry";
                    break;
                case "yellow":
                    whip = "Bentley";
                    break;
                case "green":
                    whip = "Subaru";
                    break;
                case "blue":
                    whip = "Ducati";
                    break;
                case "indigo":
                    whip = "Tesla";
                    break;
                case "violet":
                    whip = "Volkswagen";
                    break;
                default:
                    whip = "squeaky shopping cart";
                    break;
            }
            return whip;
        }
        static string Vacation (int numSibling)
        {
            string vacaHome;

            //assigns vacation home based on number of siblings
            if (numSibling == 0)
            {
                vacaHome = "Paris";
            }
            else if (numSibling == 1)
            {
                vacaHome = "Barcelona";
            }
            else if (numSibling == 2)
            {
                vacaHome = "Venice";
            }
            else if (numSibling == 3)
            {
                vacaHome = "Madrid";
            }
            else if (numSibling > 3)
            {
                vacaHome = "Miami";
            }
            else
            {
                vacaHome = "Antarctica";
            }
            return vacaHome;
        }
        static void Conclusion ()
        {

            Console.WriteLine("      _");
            Console.WriteLine("     ( )");
            Console.WriteLine("      H");
            Console.WriteLine("      H");
            Console.WriteLine("     _H_");
            Console.WriteLine("  .-'-.-'-.");
            Console.WriteLine(" /         \\");
            Console.WriteLine("|           |");
            Console.WriteLine("|   .-------'._");
            Console.WriteLine("|  / /  '.' '. \\");
            Console.WriteLine("|  \\ \\ @   @ / /");
            Console.WriteLine("|   '---------'");
            Console.WriteLine("|    _______|");
            Console.WriteLine("|  .'-+-+-+|\tWhat a great fortune! That'll be $100,000.");
            Console.WriteLine("|  '.-+-+-+|");
            Console.WriteLine("|    \"\"\"\"\"\" |");
            Console.WriteLine("'-.__   __.-'");
            Console.WriteLine("     \"\"\"\n");
        }
    }
}
