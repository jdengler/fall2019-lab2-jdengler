using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        public const double CON_FAC = 0.413;
        public const int FEET_IN_MILE = 5280;

        static void Main(string[] args)
        {
            //Starter code for lab 2
            Console.WriteLine("Please enter your height in inches: ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the number of steps taken in a day: ");
            int steps = int.Parse(Console.ReadLine());

            Console.WriteLine("You walked " + calcDistance(height, steps) + " miles");
            Console.ReadLine();
        }

        public static double calcDistance(int height, int steps)
        {
            double strideLength = height * CON_FAC;
            strideLength /= 12;

            double feetWalked = strideLength * steps;
            double milesWalked = feetWalked / FEET_IN_MILE;

            milesWalked = Math.Round(milesWalked, 2);

            return milesWalked;

        }
    }
}
