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
            //作者：古丽努尔  日期：2016年9月8日
            /*一.反序打印九九乘法表：
            9 * 9 = 81  8 * 9 = 72  7 * 9 = 63  6 * 9 = 54............
            8 * 8 = 64  7 * 8 = 56  6 * 8 = 48............
            ......       .......      .......
            1 * 2 = 2  2 * 2 = 4
            1 * 1 = 1
            */

            int j, V;
            int i = 9;
            Console.WriteLine("一：");
            for (; i > 0; i--)
            {
                for (j = i; j > 0; j--)
                {
                    V = i * j;
                    Console.Write("{0}*{1}={2}", i, j, V);
                    Console.Write("\0");
                }
                Console.Write("\n");
            }
            Console.ReadKey();


            /*二. 4.用循环画图：
             *******
               *****
                 ***
                   *
                   */

            int a, b;
            Console.WriteLine("2.4：");
            for (a = 1; a <= 4; a++)
            {
                for (b = 1; b <= 7; b++)
                {
                    if (b >= 2 * a - 1)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write("\0");
                }
                Console.Write("\n");
            }
            Console.ReadKey();



            /*三. 4用循环画出图形:
              ########
              ********
              ########
              ********
              */
            int m, n, s;
            Console.WriteLine("3.4：");
            for (s = 1; s <= 2; s++)
            {
                for (m = 1; m <= 8; m++)
                    Console.Write("#");
                Console.Write("\n");
                for (n = 1; n <= 8; n++)
                        Console.Write("*");
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}









