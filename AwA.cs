using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_w_A
{
    class Program
    {
        //        4 Napisz program drukujący na ekranie literę A złożoną z literek A. Wielkość litery A wczytujemy z klawiatury. Minimalna wielkość to 5. Ta ma 6
        //         A
        //       A  A
        //     A      A
        //    AAAAAA
        //  A            A 
        //A               A
        static void Main(string[] args)
        {
            
            Console.WriteLine("podaj wysokość (nie mniejszą niż 5)");
            int h = int.Parse(Console.ReadLine());
            int średnia = (int)Math.Ceiling((double)h / 2);

                if (h < 5)
                {
                    Console.WriteLine("czytaj...");
                }
             
                else
                {


                    for (int i = 0; i < h; i++)
                    {
                   
                   

                        for (int f = 0; f < h - i; f++)
                        {
                            Console.Write(" ");
                        }

                         if (i == średnia)
                        {
                            for (int ś = 0; ś <= h; ś++)
                            {
                            Console.Write("A");
                            }
                        }
                         else
                         {
                        Console.Write("A");

                        for (int t = 1; t < i; t++)
                        {
                            Console.Write(" ");
                        }

                        for (int m = 1; m <= i; m++)
                        {
                            Console.Write(" ");
                        }

                        if (i > 0)
                        {
                            Console.Write("A");
                        }
                             
                    }

                    Console.WriteLine();
                }
                   
                }

            Console.ReadKey();
        }
    }
}

