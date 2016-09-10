using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        //姓名：孙帅斌  学号：201415211  日期：2016.9.8
        //实验二：c#流程控制深入
        static void Main(string[] args)
        {
            //一、反序打印九九乘法表，即
            //9*9=81  8*9=72  7*9=63  6*9=54      ............
            //8*8=64  7*8=56  6*8=48    ............
            //......       .......      .......
            //1*2=2  2*2=4
            //1*1=1
            {
                Console .Write("1.反序打印九九乘法表\n");
                for(int i=9;i>0;i--)
                {
                    for(int k=9;k>0;k--)
                    {
                        if(k<=i)
                        { 
                            int s = k * i;
                            Console.Write(""+k+"*"+i+"="+s+"  ");//控制台输出k*i=m，亦可表示成Console.Write(" {0}*{1}={2}", k, i, s)
                        }
                        if(k==1) 
                        {
                            Console.Write("\n");
                        }  
                    }
                }
                Console.ReadKey();
            }
           //总结：运用双重for循环，外层循环确定第一个数，内层循环确定第二个数，内层循环结束换行。可以根据正序的表格进行改变。

            //2.用循环画图
            //   *
            //  ***
            // *****
            //*******
            Console.Write("2.1\n");
            int a, j;
            for (a = 1; a <= 4; a++)
            {
                for (j = 0; j < 4 - a; j++)//确定每行空格*号前空格的数目
                {
                    Console.Write(" ");
                }
                for (j = 0; j < 2 * a - 1; j++)//1-4行 分别有1，3，5，7个*，
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadKey();

            Console.Write("2.4\n");
            int p,q;
            for(p=1;p<=4;p++)
            {
                for(q=1;q<=2*p-2;q++)
                {
                    Console.Write(" ");
                }
                for (q=1;q<=9-2*p;q++)
                {
                    Console .Write("*");
                }
                Console .Write("\n");
            }
            Console.ReadKey();


            //3.用循环画图：
            //#*#*#*#*
            //*#*#*#*#
            //#*#*#*#*
            //*#*#*#*#
            //方法一：
            Console.Write("用循环画图3.1  方法一\n");
            int b,c;
            int m = 4;
            for (b = 1; b <= m; b++)
            {
                if (b % 2 == 0)
                {
                    for (c = 0; c <= 8; c++)
                    {
                        if (c % 2 == 0)
                            Console.Write("*");
                        else
                            Console.Write("#");
                    }
                }
                else
                {
                    for (c = 0; c <= 8; c++)
                    {
                        if (c % 2 == 0)
                            Console.Write("#");
                        else
                            Console.Write("*");
                    }
                }
                Console.Write("\n");
            }
            Console.ReadKey();
           //总结： 根据条件第一，第三行循环一样，第二第四循环一样，则可先设定一个if语句，判断奇偶数行，而内层循环体也有相同的规律。一行结束后进行换行即可。

            //方法二：
            Console.Write("用循环画图3.1  方法二\n");
            int e, f;
            for (f = 1; f <= 4; f++)
            {
                for (e = 1; e <= 9; e++)
                {
                    if ((e + f) % 2 == 0)
                        Console.Write("#");
                    else
                        Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
            //总结：
        }
    }
}
//总结：循环流程，可以先构造好思路，确定好内外层循环，然后再根据条件，找出对应的循环体即可。