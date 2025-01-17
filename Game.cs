using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Mission1
{
    internal class Game
    {
        // Method to simulate all dice rolls and return results in an array
        public int[] AllRolls(int rolls)
        {
            // Create new instances of Random class for each die
            Random die1 = new Random();
            Random die2 = new Random();

            // Create new array to store instances of each possible dice roll
            int[] results_array = new int[11];

            // Loop through each dice roll and add results in results_array
            for (int i = 0; i < rolls; i++)
            {
                int result = die1.Next(1, 7) + die2.Next(1, 7);

                if (result == 2)
                {
                    results_array[0] += 1;
                }
                else if (result == 3)
                {
                    results_array[1] += 1;
                }
                else if (result == 4)
                {
                    results_array[2] += 1;
                }
                else if (result == 5)
                {
                    results_array[3] += 1;
                }
                else if (result == 6)
                {
                    results_array[4] += 1;
                }
                else if (result == 7)
                {
                    results_array[5] += 1;
                }
                else if (result == 8)
                {
                    results_array[6] += 1;
                }
                else if (result == 9)
                {
                    results_array[7] += 1;
                }
                else if (result == 10)
                {
                    results_array[8] += 1;
                }
                else if (result == 11)
                {
                    results_array[9] += 1;
                }
                else if (result == 12)
                {
                    results_array[10] += 1;
                }
            }

            // Return results_array
            return results_array;
        }

    }
}
