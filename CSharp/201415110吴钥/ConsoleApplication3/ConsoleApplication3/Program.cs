using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*题目要求：反序打印九九乘法表，例：
             * 9*9=81 8*9=72 7*9=63 6*9=54 ……
             * 8*8=64 7*8=56 6*8=48 ……
             * …… …… ……
             * 1*2=2 2*2=4
             * 1*1=1*/
            //作者：201415110 吴钥  时间：2016.9.10
            //1
            int a, b;
            int m;
            //输入三个整型变量
            //两个for循环语句
            for (a = 9; a > 0; a--)
            {
                for (b = a; b > 0; b--)
                {
                    m = a * b;
                    Console.Write("{0}*{1}={2}", b, a, m);
                    //输出三个变量的集合表示

                }
                Console.Write("\n");
                //换行，循环执行
            }
            Console.ReadKey();

            //题目要求：用循环画图；如下：
            //*
            // ***
            //  *****
            //   *******
            //作者：201415110 吴钥  时间：2016.09.10

            int c, d;
            //输入整型变量c，d；
            for (c = 1; c < 5; c++)//c代表行数
            {
                for (d = 1; d <= (3 * c - 2); d++)//找出d与行c之间的关系
                {
                    if (d < c)
                        Console.Write("\0");//若d<c，输出空格；
                    else
                        Console.Write("*");//否则输出“*”，直到循环结束
                }
                Console.Write("\n");//每个行循环结束后都进行换行
            }
            Console.ReadKey();

            //题目要求：用循环画图
            //#*#*#*#*
            //#*#*#*#*
            //#*#*#*#*
            //#*#*#*#*
            //作者：201415110 吴钥  日期：2016.09.10

            int p, q;//输入整型变量p，q；p代表行数，q代表每行的位置
            for (p = 1; p < 5; p++)
            {
                for (q = 1; q < 8; q++)
                {
                    if (q % 2 == 0)//q为奇偶数的判断；
                        Console.Write("*");
                    else
                        Console.Write("#"); //奇数位置是符号“#”，偶数位置是符号“*”；              
                }
                Console.Write("\n");//每行循环结束进行换行

            }
            Console.ReadKey();
        }
    }
}
