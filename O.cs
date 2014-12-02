using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stożek_O
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("podaj wysokość");

            int m = int.Parse(Console.ReadLine());
            if (m < 0)
            {
                Console.WriteLine("ekhem...");
            }
            for (int s = 1; s <= m ; s++)
            {
                for (int d = 0; d < s ; d++)
                {

                    Console.Write("O");
                }
                Console.WriteLine();
                
            }
            Console.ReadKey();
        }
    }
}
