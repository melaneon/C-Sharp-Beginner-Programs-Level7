using System;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SAMPLE_SIZE = 10;
            int[] number = new int[SAMPLE_SIZE];
            int total = 0; //Sum of all entered numbers.
            float average = 0; //Average of the entered numbers.

            for (int i = 0; i < SAMPLE_SIZE; i++)
            {
                Console.WriteLine("Enter number #{0}: ", i + 1);
                if (int.TryParse(Console.ReadLine(), out number [i]) == false)
                {
                    Console.WriteLine("Oooops.Your input was invalid. Entering 0 instead.");

                }
                total += number[i];

            }

            average = (float) total / SAMPLE_SIZE;
            Console.WriteLine("The average of entered numbers is {0}", average);
        }
    }
}
