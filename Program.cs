using System;
using System.Collections.Generic;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            // Create a list of random numbers from 1 to 50
            List<double> rtnlist = new List<double>();
            List<double> newlist = new List<double>();

            for (double i = 1; i < 20; i++)
            {
                rtnlist.Add(random.Next(50));
            }
            Console.WriteLine("The 20 random numbers are:");
            foreach(double r  in rtnlist)
            {
                Console.WriteLine(r);
                newlist.Add(Math.Pow(r,2));

            }
            Console.WriteLine("The 20 random numbers now squared are:");
            foreach(double n in newlist)
            {
              
                Console.WriteLine(n);
            }

            Console.WriteLine("The list of even numbers are:");
            foreach(double n in newlist)
            {
                if (n%2 == 0)
                {
                        Console.WriteLine(n);
                }
                
                   
            }
        }
    }
}
