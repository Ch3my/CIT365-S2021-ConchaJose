using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, location;
            Console.WriteLine("Input your name ");
            name = Console.ReadLine();

            Console.WriteLine("Input your location ");
            location = Console.ReadLine();

            Console.WriteLine("\n");
            Console.WriteLine("  ██████  ██    ██ ████████ ██████  ██    ██ ████████ \r");
            Console.WriteLine(" ██    ██ ██    ██    ██    ██   ██ ██    ██    ██    \r");
            Console.WriteLine(" ██    ██ ██    ██    ██    ██████  ██    ██    ██    \r");
            Console.WriteLine(" ██    ██ ██    ██    ██    ██      ██    ██    ██    \r");
            Console.WriteLine("  ██████   ██████     ██    ██       ██████     ██    \r");
            Console.WriteLine("\n");

            Console.WriteLine("My name is {0}", name);
            Console.WriteLine("I am from {0}", location);

            string date = DateTime.Now.ToString().Substring(0, 10);
            Console.WriteLine("Today is {0}", date);

            // Days to Christmas
            DateTime today = DateTime.Today;
            DateTime xmas = new DateTime(2020, 12, 25);

            int numDays = (xmas - today).Days;
            Console.WriteLine("There are {0} days remaining for Christmas", numDays);
            Console.WriteLine("\n");
            Console.WriteLine("Press Enter to Continue with Glazer ...");
            Console.ReadLine();
            Console.Clear();

            // GlazerCalc
            Console.WriteLine("\n ");
            Console.WriteLine("  ██████  ██       █████  ███████ ███████ ██████ \r");
            Console.WriteLine(" ██       ██      ██   ██    ███  ██      ██   ██ \r");
            Console.WriteLine(" ██   ███ ██      ███████   ███   █████   ██████ \r");
            Console.WriteLine(" ██    ██ ██      ██   ██  ███    ██      ██   ██ \r");
            Console.WriteLine("  ██████  ███████ ██   ██ ███████ ███████ ██   ██ \r");
            Console.WriteLine("\n");

            double gWidth, gHeight, gWoodLength, gGlassArea;
            string gWidthString, gHeightString;

            Console.WriteLine("Please enter Width");
            gWidthString = Console.ReadLine();
            gWidth = double.Parse(gWidthString);

            Console.WriteLine("Please enter Height");
            gHeightString = Console.ReadLine();
            gHeight = double.Parse(gHeightString);

            gWoodLength = 2 * (gWidth + gHeight) * 3.25;
            gGlassArea = 2 * (gWidth * gHeight);

            Console.WriteLine("\n");
            Console.WriteLine("  ██████  ██    ██ ████████ ██████  ██    ██ ████████ \r");
            Console.WriteLine(" ██    ██ ██    ██    ██    ██   ██ ██    ██    ██    \r");
            Console.WriteLine(" ██    ██ ██    ██    ██    ██████  ██    ██    ██    \r");
            Console.WriteLine(" ██    ██ ██    ██    ██    ██      ██    ██    ██    \r");
            Console.WriteLine("  ██████   ██████     ██    ██       ██████     ██    \r");
            Console.WriteLine("\n");


            Console.WriteLine("The length of the wood is {0} feet", gWoodLength);
            Console.WriteLine("The area of the glass is {0} square metres", gGlassArea);

            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("Press Enter to Terminate");
            Console.ReadLine();
        }
    }
}
