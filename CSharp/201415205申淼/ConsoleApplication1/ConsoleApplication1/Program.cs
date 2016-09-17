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
            // 201415205 申淼
            //日期：2016.09.09
            //第二次作业
            // 第一题：反序打印九九乘法表
            int k, num, a = 9;
            while (a > 0)
            {
                k = a;
                while (k > 0)
                {
                    num = k * a;
                    Console.Write("{0}*{1}={2} ", k, a, num);
                    k--;                           //保证每个数与本身依次递减到1的数相乘
                }
                a--;                               //从9到1
                Console.Write("\n");
            }
            Console.ReadKey();

            //第二题第五小题
            int t, s;
            for (t = 1; t < 5; t++)
            {                               //控制行
                for (s = 1; s < 11; s++)
                {                           //控制列
                    if (s < t)
                        Console.Write(" "); //保证每一行前面的空白
                    else if (s < 3 * t - 1)
                        Console.Write("*");  //输入图案
                }
                Console.Write("\n");
            }
            Console.ReadKey();

            //第三大题第五小题
            int m, n;
            for (m = 1; m < 5; m++)
            {                //控制行
                for (n = 1; n < 5; n++)
                {          //控制列
                    Console.Write("#*");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
