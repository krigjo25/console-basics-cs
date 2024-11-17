using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace console_basics_cs
{
    internal class FundamentalsCS
    {
        //   Initialize max value
        private const int max = 60;

        //   Initialize a Data Structure called hobby within the class
        private List<string> hobbies = new List<string>();

        public static void main(string uname)
        {
            //  Ensures that the prompt one is the same as prompt two
            //ComparePrompts();

            //  Guess the number between 10 and 30
            //GuessTheNUmber();

            //  Generate a new Hobb
            FundamentalsCS fcs = new FundamentalsCS();
            fcs.InteractiveHobbyGenerator(uname);

            return;
        }

        internal static bool ComparePrompts()
        {
            Console.WriteLine("Check if prompt one is the same as prompt two.");
            var arg = Console.ReadLine();
            var kwarg = Console.ReadLine();
            return IsBool(arg, kwarg);
        }
        internal static bool IsBool(string arg, string kwarg)
        {
            if (arg == kwarg)
            {
                return true;
            }

            return false;
        }

        internal static bool GuessTheNUmber()
        {

            Console.WriteLine("Guess the number?\nIn this addition assignment we want you to use two integers to get the number im thinking of it is a number between 10-30");
            var arg = Console.ReadLine();
            var kwarg = Console.ReadLine();

            //  Ensure that the sum of the two numbers is equal to 30
            if ((Convert.ToInt32(arg) + Convert.ToInt32(kwarg)) == 30)
            {
                return true;
            }

            return false;
        }

        internal void InteractiveHobbyGenerator(string uname)
        {
            Console.WriteLine("Would you like to generate a random hobby");

            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "ye" || answer == "y")
            {

            int i = 0;

                while (i < max)
                {
                    // Initialize a new hobby
                    string hobby = RandomGenerator.HobbyGenerator();

                    Console.WriteLine($"Is {hobby} a desired hobby for you?");
                    answer = Console.ReadLine().ToLower();

                    //  Ensure the user is happy with the hobby
                    if (answer == "y" || answer == "yes" || answer == "ye")
                    {
                        //  Push hobby into a new array
                        hobbies.Add(hobby);

                        Console.WriteLine("Great! I'm happy you like it.\nWant a new hobby idea?");
                        answer = Console.ReadLine();

                        if (answer != "y" && answer != "yes" && answer != "ye")
                        {
                            Console.WriteLine("Thats alright, enough hobbies generated today !");
                            foreach (string element in hobbies)
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
            Console.WriteLine();

        }
    }

    internal class RandomGenerator : FundamentalsCS
    {
        private const int max = 60;

        internal static string HobbyGenerator()
        {
            //  Generate a random number
            Random r = new Random();
            int rand = r.Next(0, max);

            //  Initializing an array of hobbies
            string[] hobbies = new string[max] 
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
            foreach ( string element in hobbies)
            {
                //  Ensure the hobby is not repeated

                if (element == hobbies[rand])
                {
                    return hobbies[r.Next(0, max)];
                }
            }

            return hobbies[rand];

        }
    }
}
