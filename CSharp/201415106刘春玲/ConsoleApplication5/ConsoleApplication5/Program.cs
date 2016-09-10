using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            //作业要求
            //作者：201415106刘春玲 日期：2016年9月9日
            //1 反序打印九九乘法表，即
            //9*9=81  8*9=72  7*9=63  6*9=54      ............
            //8*8=64  7*8=56  6*8=48    ............
            //......       .......      .......
            //1*2=2  2*2=4
            //1*1=1
            int m, n, s;
            Console.WriteLine("一，反序打印九九乘法表");
            for (m = 9; m > 0; m--)
            {
                for (n = m; n > 0; n--)
                {
                    s = m * n;

                    Console.Write("{0}*{1}={2}", m, n, s);
                    Console.Write("\0");
                }
                Console.Write("\n");
            }
            Console.ReadKey();





            //作业要求
            //作者：201415106刘春玲 日期：2016年9月9日
            //二、用循环画图
            //   * 
            //  ***
            // *****
            //*******
            int a, b;
            Console.WriteLine("二、用循环画图");
            for (a = 1; a <= 4; a++)
            {
                for (b = 1; b<=a+3 ; b++)
                {
                    if (b <= 4 - a)
                   
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
                Console.Write("\n"); 
            }
            Console.ReadKey();
            
                

            //作业要求
            //作者：201415106刘春玲 日期：2016年9月9日
            //三、用循环画图
            //#*#*#*#*
            //*#*#*#*#
            //#*#*#*#*
            //*#*#*#*#
            int x, y, z;
            Console.WriteLine("三、用循环画图");
            for (x = 1; x <= 4; x++)
            {
                for (y = 1; y <= 4; y++)
                {
                    z = x % 2;
                    if (z == 1)
                        Console.Write("#*");
                    else
                        Console.Write("*#");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
