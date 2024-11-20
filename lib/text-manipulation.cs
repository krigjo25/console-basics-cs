using console_basics_cs;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace console_basics_cs
{
    internal class TextManipulations : Base
    {

        internal static void ConsoleMenu(string name)
        {
            TextManipulations @self = new TextManipulations();
            Console.Write($@" Welcome {name} to the text manipulation Console Application !
Type the number of the application you want to run
0. Exit the application
-  Reverse a String
2. Jumble a string
3. Change vowels to number values ");
            var option = Console.ReadLine();

            Console.WriteLine("Initializing Choice...\n");
            Thread.Sleep(500);
            Console.WriteLine("Please wait...\n");
            Thread.Sleep(700);
            Console.WriteLine("Enter a string to manipulate:");
            string arg = Console.ReadLine();

            switch (Convert.ToInt32(option))
            {
                case 3:
                    Console.WriteLine("Collecting data...\n");
                    Thread.Sleep(500);
                    Console.WriteLine("Please wait...\n");
                    Thread.Sleep(700);

                    v0w3ls(arg);
                    break;

                case 2:
                    EncodeText(arg);
                    break;

                case 1:
                    //    @self.ReverseText();
                    break;

                case 0:
                    Console.WriteLine("Exiting the application");
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
        private static void EncodeText(string arg)
        {
            //  Initializing a StringBuilder
            StringBuilder @text = new StringBuilder(arg);
            
            //  Jumbleing the string
            Random r = new Random();

            for (int i = 0; i < @text.Length - 1; i++)
            {
                int j = r.Next(i, text.Length - 1);
                char temp = text[i];
                text[i] = text[j];
                text[j] = temp;

            }

            // Displaying the jumbled string
            Console.WriteLine($"Jumbled text : {text}");
            return;
        }
       
        private static void v0w3ls(string arg)
        {

            //  Initializing A dictionary
            Dictionary<char, char> @vowels = new Dictionary<char, char>()
            {
                {'6','a'}, {'3','e'}, {'1','i'},
                {'2','o' }, {'4','u' }, {'9','æ' },
                {'0', 'ø' }, {'8', 'å' }
            };

            //  Initializing a StringBuilder
            StringBuilder text = new StringBuilder(arg);

            for (int i = 0; i < text.Length; i++)
            {

                foreach (KeyValuePair<char, char> element in vowels)
                {

                    //  Ensure that the element is a vowel
                    if (Char.ToLower(text[i]) == element.Value)
                    {
                        // Replace vowels with numbers
                        text[i] = element.Key;
                    }
                }

            }
           
            Console.WriteLine(text);
        }


    }
}
