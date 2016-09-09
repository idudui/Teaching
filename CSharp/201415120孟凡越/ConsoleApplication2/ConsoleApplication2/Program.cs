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
            //作业要求：
            //作者：，201415120孟凡越    日期：2016.09.09



            int a, b, c;
            Console.WriteLine("一、反序打印九九乘法表");
            for (b = 9; b > 0; b--)
            {
                for (a = b; a > 0; a--)
                {
                    c = b * a;
                    Console.Write(" {0}*{1}={2}", a, b, c);
                    Console.Write("\0");
                }
                Console.Write("\n");
            }

            Console.ReadKey();




            //二、用循环画图
            int x, y, z;//定义3个变量
            for (x = 1; x <= 4; x++)//限定行数
            {
                for (y = 1; y <= x; y++)//打印空格
                {
                    Console.Write("\0");
                }
                for (z = 1; z <= 2 * x - 1; z++)//打印星号
                {
                    Console.Write("*");
                }


                Console.WriteLine("\n");
            }
            Console.ReadKey();



            //三.用循环画图

            int m, n;
            for (m = 1; m <= 4; m++)
            {
                for (n = 1; n <= 4; n++)
                {
                    Console.Write("#*");  //将“#*”组合一起打印
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();

           



        }
    }
}
