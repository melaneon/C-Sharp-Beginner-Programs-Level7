using System;

namespace Polynomial
{
    class Program
    {
        static void Main()
        {

            //The following array represents
            // polynomial 2x^3 + 5x^2 - 4x + 8 
            int[] p1 = {8, -4, 5, 2};

            // The following array represents  
            // polynomial 5x^4 - x^3 + 2x^2 + 6
            int[] p2 = { 6, 0, 2, -1, 5 };

            int m = p1.Length;
            int n = p2.Length;

            Console.WriteLine("First coefficient array is");
            PrintPoly(p1);

            Console.WriteLine("\nSecond coefficient array is");
            PrintPoly(p2);

            int[] sum = AddPolynomial(p1, p2, m, n);
            int size = max(m, n);
            Console.WriteLine("\nThe sum of two coefficient arrays is");
            PrintPoly(sum);


            Console.WriteLine();
            Console.ReadKey();
        }
        static int max(int m, int n)
        {
            return (m > n) ? m : n;
        }
        
        static int[] AddPolynomial(int[] p1, int[] p2, int m, int n)
        {
            int size = max(m, n);
            int[] sum = new int[size];

            // Initialize the porduct polynomial  
            for (int i = 0; i < m; i++)
            {
                sum[i] = p1[i];
            }

            // Take ever term of first polynomial  
            for (int i = 0; i < n; i++)
            {
                sum[i] += p2[i];
            }

            return sum;
        }
        static void PrintPoly(int[] poly)
        {
            for (int i = 0; i < poly.Length; i++)
            {
                Console.Write(poly[i]);
                if (i != poly.Length)
                {
                    Console.Write(", ");
                }
                
            }
        }
    }
}
