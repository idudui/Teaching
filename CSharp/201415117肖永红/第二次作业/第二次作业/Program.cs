using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二次作业
{
    class Program
    {
        static void Main(string[] args)
        {
            //201415117 肖永红 第二周作业
            //第一题 反序打印九九乘法表
            int i, j;//j为第一个乘数，i为第二个乘数
            for (i = 9; i >= 1; i--) //外层循环，第二个乘数从9递减至1
            {
                for (j = i; j >= 1; j--)//内层循环，第一个乘数从9递减至1
                {
                    Console.Write("{0} * {1}={2} ", j, i, j * i);//输出算式
                }
                Console.Write("\n");//外层循环结束一次后换行
            }
            Console.ReadKey();//使运行结果停留在控制台窗口
            {
                //第二题(1) 输出图形
                //*
                //***
                //*****
                //*******
                int m, n;//定义两个标量；
                for (m = 1; m <= 4; m++)//外层循环控制行数；
                {
                    for (n = 1; n <= m * 2 - 1; n++)//每行输出2m-1个*
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");//一行输出结束后换行
                }
                Console.ReadKey();
            }
            {
                //第二题(2) 输出图形
                //   *
                //  ***
                // ***** 
                //*******
                int a, b;
                for (a = 1; a < 5; a++)//控制行数为4
                {
                    for (b = 1; b < 4+a; b++)//从最左侧空白处起至最后一个*的间距为3+a
                    {
                        if (b < 5 -a)
                            Console.Write(" ");//输出空白
                        else
                            Console.Write("*");//输出*
                    }
                    Console.Write("\n");//输出一行结束后换行
                }
                    Console.ReadKey();
                }
            {
                //第三题 输出：
                //*#*#*#*#
                //#*#*#*#*
                //*#*#*#*#
                //#*#*#*#*
              int x,y;
                for(x=1;x<=4;x++)//x变量控制行数
                {
                  for(y=1;y<=4;y++)//y变量控制每一行的循环次数
                  {
                      if(x%2==1)
                    Console.Write ("*#");//奇数行输出*#
                    else
                        Console.Write("#*");//偶数行输出#*
                  }     
                Console.Write("\n");//输出一行结束后换行
            } 
              Console.ReadKey();
            }
        }
    }
}

