using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二周作业
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 9; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}*{1}={2}\t", i, j, i * j);
                }
                    Console.WriteLine();
           }
            int a, b;
            for (a = 4; a > 0; a--)
            {  //循环空格
                for (b = 0; b < 2 * (4 - a); b++)
                {
                    Console.Write(" ");
                }                    //循环图形
                for (int k = 2 * a - 1; k > 0; k--)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }
            int m;
            for (m = 4; m > 0; m--)
            {
                if (m % 2 == 0)
                {
                    for (int c = 8; c > 0; c--)
                        Console.Write("#");
                    Console.Write("\n");
                }
                else if (m % 2 == 1)
                {
                    for (int c = 8; c > 0; c--)
                        Console.Write("*");
                    Console.Write("\n");
                }
            }

            Console.ReadKey();
        }
        }
    }

