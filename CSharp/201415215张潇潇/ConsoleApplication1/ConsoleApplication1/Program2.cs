using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        //201415215张潇潇
        //第二周作业
        static void Main(string[] args)
        {
            //反序打印九九乘法表1
            int i, s;
            for (i = 9; i >= 1; i -= 1)
            {
                for (s = i; s >= 1; s -= 1)//双层循环
                {
                    Console.Write("{0}*{1}={2}", i, s, i * s);//使用占位符
                    Console.Write(" ");
                }
                Console.Write("\n");//内层循环结束一次后换行
            }

          
            //用循环画图2.5
            int a, b;//a是行数，b是列数
            for (a = 1; a <= 4; a += 1)
            {
                for (b = 1; b <= 3 * a - 2; b += 1)//双层循环
                {
                    if (a > b)
                        Console.Write(" ");
                    else
                        Console.Write("*");//条件语句进行判断后输出
                }
                Console.Write("\n");//内层循环结束一次后换行
            }



            //用循环画图3.5
            int m, n;//m代表行数，n代表列数
            for(m=1; m<=4; m+=1)
            {
                for (n=1; n<=8;n+=1)//双层循环
                {
                    if(n%2==0)
                        Console.Write("*");
                    else
                        Console.Write("#");//使用条件语句进行判断，奇数输出#，偶数输出*
                }
                Console.Write("\n");//内层循环结束一次后换行
            }
            Console.ReadKey();//等待用户输入
        }   
        }
    }

//第一次作业是自己完成的，没有抄袭，不再进行提交。通过本次作业体会到程序有一定的共通性，一种方法可以应用到不同的问题上。