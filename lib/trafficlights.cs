/*using System;
namespace console_basics_cs
{
    internal class EnumerateBase
    {
        enum RGB()
        {
		    //	 Default value starts with 0

		    red // customize the value by adding = 1,
            red_yellow,
            green
            yellow,
        }
    }

    internal class Trafficlights: Base
    {
        public void run()
        {
            //	 Enumerations for the traffic lights Starts at zero
            int[] RGB = { RGB.red, RGB.red_yellow, RGB.green, RGB.yellow };

            while (true)
            {
                for (int i = 0; i < RGB.Length; i++)
                {
                    switch (RGB[i])
                    {
                        case 0:
                            Console.WriteLine("(red)");
                            break;

                        case 1:
                            Console.WriteLine("(red and Yellow)");
                            break;

                        case 2:
                            Console.WriteLine("(Green)");
                            break;

                        case 3:
                            Console.WriteLine("(Yellow)");
                            break;
                    }
                }

            }
        }
    }

    internal Overload
    {

    }
}
*/