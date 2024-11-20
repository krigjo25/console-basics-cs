// Project: console-basics-cs                Author: @Krigjo25
// Date:  2024-11-15                         Description:  A simple console application that demonstrates the basics of C# programming language
//
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;
using System.Runtime.Remoting.Messaging;

namespace console_basics_cs
{
    internal class ConsoleApp
    {

        static void Main(string[] args)
        {
            //  Console Configurations
            bool isRunning = true;
            Console.WriteLine("Welcome to C# basics !");

            //  Initializing the username
            Console.WriteLine("What is your username?");
            var uname = Console.ReadLine().ToString();
            
            //  Initializing the password
            Console.WriteLine($"Greetings {uname} I'm pleased to meet you.\n What is your password?");
            var pass = Console.ReadLine();

            while (isRunning)
            {

                Console.WriteLine($"How wonderful. Correct me if im wrong.. Your name is {uname}, and you can confirm its the right password?");
                var confirm = Console.ReadLine();

                if (confirm == "yes" || confirm == "y" || confirm == "ye")
                {
                    Console.WriteLine($"How awesome, i'm happy i had the chance to meet you ! {uname}");
                    isRunning = false;
                }
                else
                {
                    //  Initializing the password
                    Console.WriteLine($"Greetings {uname} I'm pleased to meet you.\n What is your password?");
                    uname = Console.ReadLine().ToString();

                    //  Initializing the password
                    Console.WriteLine($"Greetings {uname} I'm pleased to meet you.\n What is your password?");
                    pass = Console.ReadLine();

                    Console.WriteLine(" I'm sad to hear that it was wrong, but its okay. Lets try again");
                    continue;
                }
            }

            //  Call Classes
            TypingValues.main();
            VariableAssignment.main();
            HobbyGenerator.main(uname);
            TextManipulations.ConsoleMenu(uname);
            CharacterCount();

            Console.WriteLine("Thank you for using this program. Good bye have a nice day.");
            Thread.Sleep(10000);

            return;
        }
        public static void CharacterCount()
        {
            /*
                A program that counts characters
                
             */
            // Adopted from https://github.com/GetAcademy/CountCharacters

            //  Initializing variables
            const int n = 250;
            var counts = new int[n];
            string text = "sometext";

            while (text != null)
            {
                //  Initialize a user input
                text = Console.ReadLine();

                //  linear algortihm n * text
                foreach (var character in text ?? String.Empty)
                {
                    // Casting an integer from char into int

                    counts[(int)Char.ToLower(character)]++;
                }
                for (var i = 0; i < n; i++)
                {
                    //  Ensure that Counts is greater than o
                    if (counts[i] > 0)
                    {
                        //  Initialize a character from numbers
                        var character = (char)i;
                        Console.WriteLine($"Char ->total -> Procentage of txt");
                        Console.WriteLine($"{character} -> {counts[i]} -> {Matte.Procent(counts[i], counts)}%");
                    }
                }
            }
        }

    }

    //  A Public class that inherits from ConsoelApp
    internal class TypingValues

    {
        //  Initializing value
        const int value = 8;

        public static void main()
        {

            //  Array of data types
            string[] array = new string[value] {
                "int", "long","char",
                "string", "boolean", "float",
                "decimal", "double"
            };

            //  User input
            Console.WriteLine("Enter an integer:");
            string number = Console.ReadLine();
            int num = Convert.ToInt32(number);

            Console.WriteLine("Enter a number with decimal points:");
            string decimal_number = Console.ReadLine();
            decimal decimal_num = Convert.ToDecimal(decimal_number);

            //  Calling the methods
            assignment_one(array);

            Console.WriteLine(" Sum of " + number + " and " + num + " is " + assignment_two(num, decimal_num));
            

        }
        private static decimal assignment_two(int arg, decimal arg2)
        {
            return arg + arg2;   // decimal sum
        }

        private static void assignment_one(string[] array)
        {
            //  Value types
            int intint = 10;            // A 32-bit / 4 bytes interger 1 byte = 8 bit
            long longint = 1000;        // A  64-bit / 8 bytes integer 1 byte = 8 bit
            char character = 'A';       // A single 16-bit unicode character
            string c = "Hello World";   // A string of Unicode characters
            bool boolean = false;       // A boolean value of true or false
            float floatint = 10.2f;     // A single-precision 32-bit floating point number
            decimal decimalint = 10.2m; // A 128-bit decimal value
            double doubleint = 10.2d;   // A double-precision 64-bit floating point number

            //  Initializing an array of data types
            object[] datatypes = new object[value]
            {
                intint, longint, character,
                c, boolean, floatint,
                decimalint, doubleint
            };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " : " + datatypes[i]);
            }
            return;
        }


    }

   internal class VariableAssignment
    {
        public static void main()
        {
            Console.WriteLine("Randomized String: " + randomizedString());
            return;
        }
        internal static string randomizedString()
        {
            return "Hello World !";
        }
    }

}
