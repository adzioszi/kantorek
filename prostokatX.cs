using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prostokat3
{
    class Program
    {
                                    //        3 Napisz program drukujący na ekranie prostokąt z literek X. Wysokość i szerokość prostokąta wczytujemy z klawiatury:
                                    //         XXXXXXXXXX
                                    //         X        X
                                    //         X        X
                                    //         XXXXXXXXXX

        
        static void Main(string[] args)
        {
            Console.WriteLine("szerokość:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("wysokość:");
            int h = int.Parse(Console.ReadLine());

            string u = "X";


            for (int s = 1; s < n +1 ; s++)
            {
                Console.Write(u);

            }
            Console.WriteLine();

            for (int m = 1; m < h-1;m++ )
            {
                Console.Write(u);
                {
                    for (int p = 0; p < n-2; p++)
                        Console.Write(" ");
                }
                Console.Write(u);
                Console.WriteLine();
            }

            for (int s = 1; s < n + 1; s++)
            {
                Console.Write(u);
            }

                Console.ReadKey();
        }  
    } 
}


