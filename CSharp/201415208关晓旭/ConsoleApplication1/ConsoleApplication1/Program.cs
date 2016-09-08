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
            //201415208关晓旭
            //输出“让编程改变世界！”
            Console.WriteLine("让编程改变世界!");
            Console.ReadKey();
            //输入一个1000以内的整数，判断是否大于3000.输入数字不符合提示“输入不正确”         
            int a;
            Console.WriteLine("输入一个10000以内的整数");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 10000)
            {
                if (a > 3000)
                    Console.WriteLine("输入不正确");
                Console.ReadKey();
            }
            //求1：50不能被3整数的数的和。并打印循环变量的初值和终值while
            {
                int sum = 0;
                int b = 1;
                while (b <= 50)
                {
                    if (b % 3 != 0)
                        sum += b;
                    b++;
                }
                Console.WriteLine("1:50中不能被3整除的数的和为" + sum);
                Console.ReadKey();
                {
                    //for
                    for (int i = 1; b <= 50; b++)
                    {
                        if (i % 3 != 0)
                            sum += b;
                    }
                    Console.WriteLine("1:50中不能被3整数的和为" + sum);
                    Console.ReadKey();
                   {
                        int month;
                        int day1 = 31, day2 = 30, day3 = 28;
                        Console.WriteLine("输入一个月份");
                        month = Convert.ToInt32(Console.ReadLine());
                        switch(month)
                       {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12:
                         Console.WriteLine("该月有{0}天.", day1);
                         break;
                        case 2:
                         Console.WriteLine("该月有{0}天.", day3);
                         break;
                        default:
                         Console.WriteLine("该月有{0}天.", day2);
                         break;
                         }
                          Console.ReadKey();
                    }
                }

                }
            }

        }
    }

