using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //作者：沙肯古丽  日期：2016.9.3
            //1 输出“让编程改变世界！”
            Console.WriteLine("1.让编程改变世界");
            Console.ReadKey();

            //2 输入一个10000以内的整数，判断是否大于3000。输入数字不符合提示“输入不正确”
            int a;
            Console.WriteLine("2.输入与一个10000以内的整数");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a={0}", a);
            if (a < 3000)
            {
                Console.ReadKey();
            }
            else
                Console.WriteLine("输入不正确");
            Console.ReadKey();

            //3 求1:50不能被3整除的数的和。并打印循环变量的初值和终值
            int w = 1;
            Console.WriteLine("初值是{0}.", a);
            int sum = 0;
            //while
            do
            {
                if (w % 3 != 0)
                {
                    sum += w;
                }
                w++;
                if (w <= 50)
                    continue;
                else
                    break;
            } while (w <= 50);
            Console.WriteLine("终值是{0}", w- 1);
            Console.WriteLine("sum={0}", sum);
            Console.ReadKey();

            //4 输入一个月份 （1:12）返回该月有几天。2月按28天。
            int mouth;
            int day1 = 31, day2 = 30, day3 = 28;
            Console.WriteLine("4.输入一个月份");
            mouth = Convert.ToInt32(Console.ReadLine());
            switch (mouth)
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
