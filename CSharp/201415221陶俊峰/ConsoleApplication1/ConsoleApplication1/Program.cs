using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //第一次作业C#
        //姓名：陶俊峰，学号：201415221，
        //日期：2016.9.2
        static void Main(string[] args)
        {
            //题目1：输出“hello word！”
            Console.WriteLine("Hello world！");
            //题目2：输入一个10以内整数，判断是否是能被2整除。输入数字不符合提示“输入不正确”
            int int10;
            while (true)
            {
                Console.WriteLine("请输入一个10以内整数");
                string b = Console.ReadLine();
                if (int.TryParse(b, out int10))
                {
                    if (int10 > 0 && int10 < 10)
                    {
                        if (int10 % 2 == 0)
                        {
                            Console.WriteLine(int10 + "能被2整除");
                            break;
                        }
                        else
                        {
                            Console.WriteLine(int10 + "不能被2整除");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("输入错误");
                    }
                }
                else
                {
                    Console.WriteLine("输入错误");
                }
            }
            //3、4:求1:50偶数的累加和。并打印循环变量的初值和终值,分别用while和for实现.
            //while
            int a1 = 1;
            int sum1 = 0;
            while(a1 <= 100)
            {
                if (a1 % 2 == 0)
                {
                    sum1 += a1;
                }
                a1++;
                if(a1==51)
                {
                    break;
                }
            }
            Console.WriteLine("1:50偶数的累加和为" + sum1);
            //for
            int sum2 = 0;
            for (int a2 = 1; a2 <= 100; a2++)
            {
                if (a2 % 2 == 0)
                {
                    sum2 += a2;
                }
                if (a2 == 51)
                {
                    break;
                }
            }
            Console.WriteLine("1:50偶数的累加和为" + sum2);
            //5:输入一个月份(1:12)返回对应季节。五、用switch（case）实现.
            int month;
            while (true)
            {
                Console.WriteLine("请输入一个月份");
                string b = Console.ReadLine();
                if (int.TryParse(b, out month))
                {
                    if (month > 0 && month <= 12)
                    {
                        switch (month)
                        {
                            case 1:
                            case 2:
                            case 3:
                                Console.WriteLine("春季");
                                break;
                            case 4:
                            case 5:
                            case 6:
                                Console.WriteLine("夏季");
                                break;
                            case 7:
                            case 8:
                            case 9:
                                Console.WriteLine("秋季");
                                break;
                            case 10:
                            case 11:
                            case 12:
                                Console.WriteLine("冬季");
                                break;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("输入错误");
                    }
                }
                else
                {
                    Console.WriteLine("输入错误");
                }
            }
            
        Console.ReadKey();
        }
    }
}
