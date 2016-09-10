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
            //201415206乔泽宁
            //9月9日
            //第二次作业
            //第一题：反序打印九九乘法表.
            int a, b, s;
            for (a = 9; a > 0; a--)
            {
                for (b = a; b > 0; b--)
                {
                    s = a * b;
                    Console.Write("{0}*{1}={2}", a, b, s);//使用占位符输出变量。
                    Console.Write("\0");//输入空格。
                }
                Console.Write("\n");//输入换行。
            }
            //第二题：用循环画图1.
            int m, n;//定义m为行数，n为列数。
            for (m = 1; m <= 4;m++)//行数循环。
            {
                for(n=1;n<=7;n++)//列数循环。
                {
                    if (n <= 4 - m || n >= 4 + m)
                        Console.Write(" ");
                    else
                        Console.Write("*"); 
                }
                Console.Write("\n");//换行。
            }
           //第三题：用循环画图1.
            int p, q;//p为行数，q为列数。
            for (p = 1; p <= 4;p++)//行数循环。
            {
                for (q=1;q<=8;q++)//列数循环。
                {
                    if ((p + q) % 2 == 0)//判断p、q和是否为偶数。
                        Console.Write("#");
                    else 
                        Console.Write("*");
                }
                Console.Write("\n");//换行。
            }
                Console.ReadKey();
        }
    }
}
