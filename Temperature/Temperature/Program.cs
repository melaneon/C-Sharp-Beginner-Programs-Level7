using System;

namespace Temperature
{
    
    class Program
    {
        
        static void Main(string[] args)
        {


            Temperature temp = new Temperature();
            Console.WriteLine(temp);

            Console.ReadKey();

        }
    }
    class Temperature
    {
        private int[] weektemp = { -2, 0, -3, -6, -1, 2, 5 };

        static int ReturnSmallest(int[] weektemp, int days)
        {
            int min = weektemp[0];
            
            
            for (int i = 0; i < days; i++)
            {
                if (min > weektemp[i])
                    min = weektemp[i];
                
            } 
            return min;
        }

        static int ReturnLargest(int[] weektemp, int days)
        {
            
            int max = weektemp[0];

            for (int i = 0; i < days; i++)
            {
                if (max < weektemp[i])
                    max = weektemp[i];
                
            }
            return max;
        }

        static int ReturnAverage(int[] weektemp, int days)
        {
            int Average = weektemp[0];
            int sum=0;
            int i;
            for (i = 0; i < days; i++)
            {
                sum = sum + weektemp[i];
            }
            Average = sum / i;
            return Average;
        }

        static int ReturnAverageExcludingSmallest(int[] weektemp, int days, int min)
        {
            int AverageBut = weektemp[0];
            int sum = 0;
            int i;
            for (i = 0; i < days; i++)
            {
                if (i != min)
                {
                    sum = sum + weektemp[i];
                }
                
                
            }
            AverageBut = sum / i;
            return AverageBut;
        }

        static int ReturnDaysBelow18(int[] weektemp, int days)
        {
            int i;
            int daysBelow=0;

            for (i = 0; i < days; i++)
            {
                if (weektemp[i] < 18)
                {
                    daysBelow++;
                }
            }
            return daysBelow;
            
        }

        //Override the ToString( ) method to return a listing of all 
        //temperatures in a three column formatted and the temperature range for the given week. Write a
        //second class to test your class.
        public override string ToString()
        {
            return
                "Values in the temperature array\n\n" +
                "MO: " + weektemp[0] + "\tTU: " + weektemp[1] + "\tWD: " + weektemp[2] + "\n" +
                "TH: " + weektemp[3] + "\tFR: " + weektemp[4] + "\tST: " + weektemp[5] + "\n" +
                "SU: " + weektemp[6] + "\n\n" +


                "Average Temp: " + ReturnAverage(weektemp, 7) +
                "\nLowest Temp: " + ReturnSmallest(weektemp, 7) +
                "\nHighest Temp: " + ReturnLargest(weektemp, 7) +
                "\nAverage Temp excluding Lowest: " + ReturnAverageExcludingSmallest(weektemp, 7, ReturnLargest(weektemp, 7)) +
                "\nNumber of Days below 18: " + ReturnDaysBelow18(weektemp, 7);

        }
    }
}
