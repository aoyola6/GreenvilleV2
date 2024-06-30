using System;
namespace GreenvilleIdol{

}
    class Program
    {        
        public static void Main(string[] args)
        {
            GreenvilleRevenue.Run();
        }
        public static void DisplayMottoAndMenu(string motto)
        {
            Console.WriteLine("************************");
            Console.WriteLine("* " + motto + " *");
            Console.WriteLine("*************************");
            Console.WriteLine("\nMenu:");
            Console.WriteLine("Please enter the following number below from the following menu:");
            Console.WriteLine("1. Calculate Expected Revenue");
            Console.WriteLine("2. Exit");
        }
        class GreenvilleRevenue

        {
            public static void Run()
            {
                string greenvilleMotto = "The stars shine in Greenville.";
                DisplayMottoAndMenu(greenvilleMotto);
                bool keepRunning = true;
                while (keepRunning)
                {
                    Console.WriteLine("\nEnter your choice:");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            CalculateExpectedRevenue();
                            break;
                        case 2:
                            Console.WriteLine("Exit.");
                            Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
                            keepRunning = false;
                            break;
                        // Add cases for other menu options
                        default:
                            Console.WriteLine("Invalid selection.");
                            break;
                    }
                }
            }
            private static void DisplayGreenvilleMenu(string motto)
            {
                Console.WriteLine(motto);
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Calculate Greenville Revenue Year-Over-Year");
                Console.WriteLine("2. Exit");
            }
            private static void CalculateExpectedRevenue()
            {
                Console.Write("Enter the number of contestants this year: ");
                int currentYearContestants = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the number of contestants last year: ");
                int lastYearContestants = Convert.ToInt32(Console.ReadLine());
                double expectedRevenue = (currentYearContestants > lastYearContestants) ?
                                      (currentYearContestants * 25) :
                                      (lastYearContestants * 25);
                Console.WriteLine($"\nThis year's expected revenue: ${expectedRevenue}");
                Console.WriteLine($"Comparison: {(currentYearContestants > lastYearContestants ? "The competition is more than twice as big this year!" : "Fewer contestants")}");
            }
        }
    }
