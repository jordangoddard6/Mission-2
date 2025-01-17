namespace Mission1
{
    internal class Program
    {
        private static void Main(string[] args)
        {   // Intro text
            Console.WriteLine("Welcome to the dice throwing simulator!\n");

            // Ask user to input desired number of dice rolls and store to rolls variable
            Console.Write("How many dice rolls would you like to simulate? ");
            int rolls = int.Parse(Console.ReadLine());

            // Create new instance of Game class
            Game game = new Game();

            // Call AllRolls method from Game class and store results in results_array
            int[] results_array = game.AllRolls(rolls);

            // Create new array to store percentage of each number rolled
            int[] number_percentage = new int[11];

            // Calculate percentage of each number rolled and store in number_percentage array
            for (int i = 0; i < 11; i++)
            {
                float rawPercentage = (float)results_array[i] / rolls * 100;
                number_percentage[i] = (int)Math.Round(rawPercentage);
            }

            // Display results header
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + rolls);

            // Display results in histogram
            for (int i = 0; i < 11; i++)
            {
                Console.Write("\n" + (i + 2) + ": ");
                for (int j = 0; j < number_percentage[i]; j++)
                {
                    Console.Write("*");
                }
            }

            // Closing statement
            Console.WriteLine("\n\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}