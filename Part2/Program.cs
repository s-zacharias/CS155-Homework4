using System;
using System.Runtime.InteropServices;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int headCount, tailCount;
            String toss = Console.ReadLine();
            double percentHead, percentTail;

            Console.WriteLine("For each coin toss enter either 'h' for heads or 't' for tails.");
            
            for (let i = 1; i < 9; i++)
            {
                Console.WriteLine(`Toss ${i}`, toss);
                if (toss == 'h')
            {
                headCount++;
            } else if (toss == 't')
            {
                tailCount++;
            }
            }

            percentHead = headCount / 8;
            percentTail = tailCount / 8;
            
            Console.WriteLine("Number of heads: ", headCount);
            Console.WriteLine("Number of tails: ", tailCount);
            Console.WriteLine("Percent heads: ", percentHead);
            Console.WriteLine("Percent tails: ", percentTail);

        }
    }
}
