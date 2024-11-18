using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Xml.Schema;

namespace console_basics_cs
{
    internal class Base
    {
        //   Define a max value
        internal const int max_hobbies = 60;

        internal static string RandomArrayGenerator()
        {

            /*
             -  Generate a random item from the date
             -  Generate a random number between 0 and 60
             */
            //  Generate a random number
            Random r = new Random();
            int rand = r.Next(0, max_hobbies);

            //  Initializing an date of hobbies
            string[] hobbies = new string[max_hobbies]
            {
                "Reading", "Coding", "Gaming",
                "Cooking", "Traveling", "Swimming",
                "Hiking", "Dancing", "Singing",
                "Writing", "Drawing", "Painting",
                "Exercising", "Running", "Walking",
                "Cycling", "Skating", "Skiing",
                "Snowboarding", "Surfing", "Skateboarding",
                "Rollerblading", "Scootering", "Biking",
                "Fishing", "Hunting", "Camping",
                "Horseback Riding", "Bird Watching", "Photography",
                "Videography", "Editing", "Designing",
                "Crafting", "Sewing", "Knitting",
                "Crocheting", "Quilting", "Embroidery",
                "Cross-Stitching", "Weaving", "Macrame",
                "Pottery", "Ceramics", "Woodworking",
                "Metalworking", "Blacksmithing", "Leatherworking",
                "Glassblowing", "Candle Making", "Soap Making",
                "Brewing", "Distilling", "Wine Making",
                "Mixology", "Bartending", "Barista",
                "Cooking", "Baking", "Pastry",

            };
            
            foreach (string element in hobbies)
            {
                //  Ensure the hobby is not repeated

                if (element == hobbies[rand])
                {
                    return hobbies[r.Next(0, max_hobbies)];
                }
            }

            return hobbies[rand];

        }
        internal dynamic DateHandler(string[] array)
        {
            //  Convert the array to an integer
            int[] date = Array.ConvertAll(array, int.Parse);


            //  Ensure the date is correctly formated date [0] = day, date[1] = month, date[2] = year
            if (date.Length != 3)
            {
               Console.WriteLine("Invalid date format use Using the metric date system e.g (17-11-2024)");
            }

            //  Ensure that the day is between 1 and 31
            if (date[0] > 31 && date[0] < 1)
            {
                //  Februrary has 28 days
                if (date[1] == 2 && date[0] > 28)
                {
                    //  Ensure the year is not a leap year

                    Console.WriteLine("Invalid day");
                }

                //  April, June, September and November have 30 days

                Console.WriteLine("Invalid day");
            }

            else if (date[date.Length - 2] < 1 && date[date.Length - 2] > 12)
            {
                Console.WriteLine("Invalid month");
            }

            //  Ensure the date is correctly formated date [0] = day, date[1] = month, date[2] = year

            return date;
        }

        internal static void ComparePrompts()
        {
            Console.WriteLine("Check if prompt one is the same as prompt two.");
            var arg = Console.ReadLine();
            var kwarg = Console.ReadLine();


            //  Ensure the prompts are the same
            if (IsStringBool(arg, kwarg))
            {
                Console.WriteLine("Prompt one is the same as prompt two.");
                return;

            }
            Console.WriteLine("Prompt one is not the same as prompt two.");
            

            return;

        }
       
        private static bool IsStringBool(string arg, string kwarg)
        {
            if (arg == kwarg)
            {
                return true;
            }

            return false;
        }
        private static bool IsIntBool(int arg, int kwarg, int kwarg1)
        {
            if (arg == kwarg || (arg + kwarg) == kwarg1)
            {
                return true;
            }
            return false;
        }
            //  Random Generator
    
        protected private static void GuessTheNUmber()
        {

            Console.WriteLine("Guess the number?\nIn this addition assignment we want you to use two integers to get the number im thinking of it is a number between 10-30");

            //  Initialize variables & responses
            int max = 30;
            var arg = Console.ReadLine();
            var kwarg = Console.ReadLine();
            

            //  Ensure that the sum of the two numbers is equal to 30
            if (IsIntBool(Convert.ToInt32(arg), Convert.ToInt32(kwarg), Convert.ToInt32(max)))
            {
                Console.Write("Number equals to 30");
                return;
            }

            Console.Write("Does not equal to 30");
        }

    }
    internal class HobbyGenerator: Base
    {

        //   Initialize a Data Structure called hobby within the class
        private List<string> hobbies = new List<string>();

        public static void main(string uname)
        {

            //  Ensures that the prompt one is the same as prompt two
            ComparePrompts();

            //  Guess the number between 10 and 30
            Base.GuessTheNUmber();

            //  Generate a new Hobb
           InteractiveHobbyGenerator(uname);


            //  Calendar Days
            Conditions.CalendarDays();

            return;
        }
        
        private static void InteractiveHobbyGenerator(string uname)
        {
           HobbyGenerator self = new HobbyGenerator();
            /*
             -  A function that generates a random hobby
             -  The function is static and does not return any value
             */

            // Prompts a prompt to the user to generate a new hobby yes / no
            Console.WriteLine("Would you like to generate a random hobby");
            string answer = Console.ReadLine().ToLower();


            //  Ensure the user want to generate a new hobby
            if (answer == "yes" || answer == "ye" || answer == "y")
            {
                //  Initialize a new variable of type int
                int i = 0;

                //  A while loop that will generate untill its false or if user wants to exit
                while (i < max_hobbies)
                {
                    // Initialize a new hobby
                    string hobby = Base.RandomArrayGenerator();

                    Console.WriteLine($"Is {hobby} a desired hobby for you?");
                    answer = Console.ReadLine().ToLower();

                    //  Ensure the user is happy with the hobby
                    if (answer == "y" || answer == "yes" || answer == "ye")
                    {
                        //  Push hobby into a new date
                        self.hobbies.Add(hobby);

                        Console.WriteLine("Great! I'm happy you like it.\nWant a new hobby idea?");
                        answer = Console.ReadLine();

                        if (answer != "y" && answer != "yes" && answer != "ye")
                        {
                            Console.WriteLine("Thats alright, enough hobbies generated today !");
                            foreach (string element in self.hobbies)
                            {
                                Console.WriteLine($"{uname}, enjoys {element}");
                            }
                            break;

                        }

                    }
                    else
                    {
                        Console.WriteLine("I'm sorry to hear that, I hope you find a hobby that you like.");
                        break;
                    }
                    i++;
                }
            }
        }

    }
    internal class Conditions: Base
    {
        private const int max_date_value = 3;

        internal static void CalendarDays()

        {
            //  Initialize a new instance of the class
            Base bs = new Base();

            //  Initialize a new string
            string text_date = "";

            //  Initialize a new array of type int and string
            int[] dateArray = new int[max_date_value];
            string[] seperator = new string[] { ",", "-" };

            Console.WriteLine(" Convert a date into a string. Using the metric date system e.g (17-11-2024)");

            while (true)
            {
                //  Read the date from the user
                string[] date = Console.ReadLine().Split(seperator, StringSplitOptions.None);

                // Ensure the date is not empty
                if (date.Length != max_date_value)
                {
                    //  Prompt the user to enter a valid date
                   Console.WriteLine("Invalid date, enter a valid date,Using the metric date system e.g (17-11-2024)");
                }
                else
                {
                    //  Call the method to handle the date
                    dateArray = bs.DateHandler(date);
                    break;
                }

            }

            //  Initialize a new switch statement -> Day
            switch (dateArray[0])
            {
                case 1:
                  text_date += "First";
                    break;

                case 2:
                   text_date += "Second";
                    break;

                case 3:
                   text_date += "Third";
                    break;

                case 4:
                   text_date += "Fourth";
                    break;

                case 5:
                   text_date += "Fifth";
                    break;

                case 6:
                   text_date += "Sixth";
                    break;

                case 7:
                   text_date += "Seventh";
                    break;

                case 8:
                   text_date += "Eighth";
                    break;

                case 9:
                   text_date += "Ninth";
                    break;

                case 10:
                   text_date += "Tenth";
                    break;
                
                case 11:
                   text_date += "Eleventh";
                    break;
                case 12:
                   text_date += "Twelfth";
                    break;

                case 13:
                   text_date += "Thirteenth";
                    break;

                case 14:
                   text_date += "Fourteenth";
                    break;
                case 15:
                   text_date += "Fifteenth";
                    break;
                case 16:
                   text_date += "Sixteenth";
                    break;

                case 17:
                   text_date += "Seventeenth";
                    break;

                case 18:
                   text_date += "Eighteenth";
                    break;

                case 19:
                   text_date += "Nineteenth";
                    break;

                case 20:

                   text_date += "Twentieth";
                    break;
                
                case 21:
                   text_date += "Twenty First";
                    break;

                case 22:
                   text_date += "Twenty Second";
                    break;

                 case 23:
                   text_date += "Twenty Third";
                    break;

                case 24:
                   text_date += "Twenty Fourth";
                    break;

                case 25:
                   text_date += "Twenty Fifth";
                    break;

                case 26:
                   text_date += "Twenty Sixth";
                    break;

                case 27:
                   text_date += "Twenty Seventh";
                    break;

                case 28:
                   text_date += "Twenty Eighth";
                    break;

                case 29:
                   text_date += "Twenty Ninth";
                    break;

                case 30:
                   text_date += "Thirtieth";
                    break;

                case 31:
                   text_date += "Thirty First";
                    break;

                default:
                    text_date += "Invalid Day";
                    break;
            }

            //  Initialize a new switch statement -> Month
            switch (dateArray[1])
            {
                case 1:
                    // add to a variable.
                   text_date += " January";
                    break;

                case 2:
                   text_date += " February";
                    break;

                case 3:
                   text_date += " March";
                    break;

                case 4:
                   text_date += " April";
                    break;

                case 5:
                   text_date += " May";
                    break;

                case 6:
                   text_date += " June";
                    break;

                case 7:
                   text_date += " July";
                    break;

                case 8:
                   text_date += " August";
                    break;

                case 9:
                   text_date += " September";
                    break;

                case 10:
                   text_date += " October";
                    break;

                case 11:
                   text_date += " November";
                    break;

                case 12:
                   text_date += " December";
                    break;

                default:
                   text_date += " Invalid Month";
                    break;
            }

            // Initialize a new switch statement -> Year

            text_date += $" {dateArray[2]}";
            Console.WriteLine($"The {text_date}");
        }


    //  End of class
    }
    //  End of namespace
}
