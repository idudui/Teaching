using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {



            //学号：201415210   姓名：孙冠群
            //第二周作业  2016年9月10号




            //第一题、反序打印九九乘法表，即
            //9*9=81  8*9=72  7*9=63  6*9=54      ............
            //8*8=64  7*8=56  6*8=48    ............
            //......       .......      .......
            //2*2=2  1*2=4
            //1*1=1

            int i, j, k;
            for (i = 9; i >= 1; i--)
            {
                for (j = i; j >= 1; j--)
                {
                    k = i * j;
                    Console.Write("{0}*{1}={2}", i, j, k);
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.ReadKey();




            //第二题、用循环画图  即:
            // *
            //  ***
            //   *****
            //    *******
            int x, y;
            for (x = 1; x <= 4; x++)
            {
                for (y = 1; y <= 3 * x - 2; y++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadKey();




            //第三题：用循环画图，即
            //#*#*#*#*
            //#*#*#*#*
            //#*#*#*#*
            //#*#*#*#*
            int a, b;
            for (a = 1; a <= 4; a++)
            {
                for (b = 1; b <= 8; b++)
                {
                    if (b % 2 == 1)
                        Console.Write("#");
                    else
                        Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
