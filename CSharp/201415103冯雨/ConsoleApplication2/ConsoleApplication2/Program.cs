using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //作业要求
            //作者：冯雨    日期：2016.9.8


            /*一、反序打印九九乘法表，即
                  9*9=81  8*9=72  7*9=63  6*9=54      ............
                  8*8=64  7*8=56  6*8=48    ............
                  ......       .......      .......
                  1*2=2  2*2=4
                  1*1=1
            */
            int i, j, s;
            Console.WriteLine("一、反序打印九九乘法表");
            for (j = 9; j > 0; j--)
            {
                for (i = j; i > 0; i--)
                {
                    s = i * j;
                    Console.Write(" {0}*{1}={2}", i, j, s);
                    Console.Write("\0");
                }
                Console.Write("\n");
            }

            Console.ReadKey();


            /*二、用循环画图 
                        *
                      ***
                    *****
                  *******
            */
            int x, y, a;
            Console.WriteLine("二、用循环画图");
            for (a = 6; a >= 0; a -= 2)
            {
                for (x = 1; x <= a; x++)
                    Console.Write("\0");
                for (y = 1; y <= 7 - a; y++)
                    Console.Write("*");
                Console.Write("\n");
            }
            Console.ReadKey();



            /*三、用循环画图
                  ********
                  ########
                  ********
                  ########
            */
            int m, n, b;
            Console.WriteLine("三、用循环画图");
            for (b = 1; b <= 3; b += 2)
            {
                for (m = 1; m <= 8; m++)
                    Console.Write("*");
                Console.WriteLine("\n");
                for (n = 1; n <= 8; n++)
                    Console.Write("#");
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
