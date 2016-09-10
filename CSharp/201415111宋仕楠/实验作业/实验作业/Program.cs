using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验作业
{
    class Program
    {
        static void Main(string[] args)
        {
            ////实验一：c#语法及流程控制基础
            ////宋仕楠   201415111
            ////一、简单入门      1.输出“hello word！”。 
            //Console.WriteLine("hello world");
            //Console.ReadKey();



            ////二、if语句       1.输入一个10以内整数，判断是否是能被2整除。输入数字不符合提示“输入不正确”。
            //int N, n;
            //Console.WriteLine("请输入一个10以内的整数：");
            //N = Convert.ToInt32(Console.ReadLine());
            //n = N % 2;
            //if (n > 0)
            //    Console.WriteLine("输入不正确");
            //Console.ReadKey();



            ////三、用while实现如下功能。（要求：打印的循环变量的初值必须为1，终值为100。提示：使用break）
            ////1.求1:50偶数的累加和。并打印循环变量的初值和终值。
            //int sum1 = 0;
            //int i1 = 1;
            //Console.WriteLine("循环变量初值为：{0}", i1);
            //while (i1 <= 50)
            //{
            //    if (i1 % 2 == 0)
            //    {
            //        sum1 = sum1 + i1;
            //    }
            //    i1++;
            //}
            //Console.WriteLine("循环变量终值为：{0}", i1 - 1);
            //Console.WriteLine("1:50偶数的累加和sum1={0}", sum1);
            //Console.ReadKey();




            ////四、用for实现如下功能。（要求：打印的循环变量的初值必须为1，终值为100。提示：使用continue）
            ////1.求1:50偶数的累加和。并打印循环变量的初值和终值。
            //int sum2 = 0;
            //int i2 = 1;
            //Console.WriteLine("循环变量初值为：{0}", i2);
            //for (i2 = 1; i2 <= 50; i2++)
            //{
            //    if (i2 % 2 == 0)
            //        sum2 = sum2 + i2;
            //}
            //Console.WriteLine("循环变量终值为：{0}", i2 - 1);
            //Console.WriteLine("1:50偶数的累加和sum2={0}", sum2);
            //Console.ReadKey();




            ////五、用switch（case）实现以下功能。
            ////1.输入一个月份(1:12)返回对应季节。
            //int month;
            //Console.WriteLine("请输入月份：");
            //month = Convert.ToInt32(Console.ReadLine());
            //switch (month)
            //{
            //    case 1:
            //    case 2:
            //    case 3:
            //        Console.WriteLine("{0}月是春季", month);
            //        break;
            //    case 4:
            //    case 5:
            //    case 6:
            //        Console.WriteLine("{0}月是夏季", month);
            //        break;
            //    case 7:
            //    case 8:
            //    case 9:
            //        Console.WriteLine("{0}月是秋季", month);
            //        break;
            //    case 10:
            //    case 11:
            //    case 12:
            //        Console.WriteLine("{0}月是冬季", month);
            //        break;
            //}
            //Console.ReadKey();





            //实验二：c#流程控制深入
            //宋仕楠  201415111
            //一、反序打印九九乘法表。
            Console.WriteLine("一、反序打印九九乘法表");
            int i, j, n;
            for (j = 9; j >= 1; j--)
            {
                for (i = j; i >= 1; i--)
                {
                    n = i * j;
                    Console.Write("{0}*{1}={2}\t", i, j, n);
                }
                Console.Write("\n");
            }
            Console.ReadKey();




            //二、用循环画图
            //1、用*打印正金字塔。
            Console.WriteLine("二、1.用*打印正金字塔");
            int a, b, m;
            for (a = 1; a <= 4; a++)
            {
                for (b = 1; b <= 4 - a; b++)
                {
                    Console.Write(" ");
                }
                for (m = 1; m <= 2 * a - 1; m++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadKey();



            //三、用循环画图
            //1、用#和*打印交替矩形，首个字符为#。
            Console.WriteLine("三、1.用#和*打印交替矩形，首个字符为#");
            int x, y, z;
            for (x = 1; x <= 4; x++)
            {
                if (x % 2 == 1)
                {
                    for (y = 1; y <= 8; y++)
                    {
                        if (y % 2 == 0)
                            Console.Write("*");
                        else
                            Console.Write("#");
                    }
                    Console.Write("\n");
                }
                else
                {
                    for (y = 1; y <= 8; y++)
                    {
                        if (y % 2 == 0)
                            Console.Write("#");
                        else
                            Console.Write("*");
                    }
                    Console.Write("\n");
                }
            }
            Console.ReadKey();
        }
    }
}
