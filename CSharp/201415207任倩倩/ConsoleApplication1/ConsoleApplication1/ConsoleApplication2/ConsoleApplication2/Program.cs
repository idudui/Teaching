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
         //姓名：任倩倩
            //学号：201415207
            //第二次作业
            //第一题：反序打印九九乘法表即
            //9*9=81  8*9=72  7*9=63  6*9=54      ............
            //8*8=64  7*8=56  6*8=48    ............
            //......       .......      .......
            //1*2=2  2*2=4
            //1*1=1

            int n, t, num;
            for (n = 9; n > 0; n--)//外部循环for
            {
                for (t = n; t > 0; t--)//内部循环for
                {
                    num = n * t;//num是n与t的乘积
                    Console.Write("{0}*{1}={2} ", n, t, num);//输出乘法表达式及结果
                }
                Console.Write("\n");
            }
                Console.ReadKey();
            //第二题：输出以下图形
            //*******
             //*****
             // ***
               //*
            //使用双层循环for
            int i, j;
            for (i=1;i<=4;i++)//i为行数
            {
                for (j=1;j<=i;j++)
                    Console.Write("  ");
                for (j=1;j<=9-2*i;j++)
                    Console.Write("* ");
                Console.Write("\n");
            }
            Console.ReadKey();
            //第三题：
            //输出以下图形
            //*#*#*#*#
            //#*#*#*#*
            //*#*#*#*#
            //#*#*#*#*
            //使用for循环且要加上if判断语句
            int a, b;
            for (a = 1; a < 5; a++)//a表示行数
            {
                if (a % 2 == 1)//如果a为奇数行
                {
                    for (b = 1; b <= 8; b++)//b表示每行元素的列数
                        if (b % 2 == 1)//如果元素位于奇数列
                        {
                            Console.Write("*");//则输出*

                        }
                        else//元素位于偶数列
                        {
                            Console.Write("#");//否则输出#
                        }
                    Console.WriteLine();
                }
                else
                {
                    if (a % 2 == 0)//元素位于偶数行
                        for (b = 1; b <= 8; b++)
                            if (b % 2 == 1)//如果元素位于奇数列
                            {
                                Console.Write("#");//则输出#

                            }
                            else//元素位于偶数列
                            {
                                Console.Write("*");//否则输出*
                            }

                    Console.WriteLine();
                }
            }
                    Console.ReadKey();
                }
            }
    }    

