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
        {   //姓名：杨福启//学号：201415217
            //日期：2014.9.2
            //题目：输出“欢迎学习c#语言！”
            Console.WriteLine("欢迎学习c#语言！");
            Console.ReadKey();
            //题目：输入一个100以内的分数（含小数），判断是否及格。输入数字不符合提示“输入不正确”
            Console.WriteLine("请输入一个100以内的分数");
            string s = Console.ReadLine();
            double i = Convert.ToDouble(s);
            if (i > 0 && i < 100)
            {
                if (i > 60 && i < 100 && i > 0)
                {
                    Console.WriteLine("及格");
                }
                else
                {
                    Console.WriteLine("不及格");
                }
            }
            else
            {
                Console.WriteLine("输入不正确");
            }
            Console.ReadKey();
            //求50:100奇数的累加和。并打印循环变量的初值和终值
            //while
            int a = 1;
            int num = 0;
            while (a <= 100)
            {
                if (a % 2 == 0)
                {
                    continue;
                }
                if (a >=50)
                {
                    num += a;
                }
                a++;
            }
            Console.WriteLine("50:100奇数的累加和" + num);
            //for
            int b = 1;
            int num1 = 0;
            for (b = 1; b <= 100; b++)
            {
                if (b%2==0)
                {
                    continue;
                }
                if (b>=50)
                {
                    num1 += b;
                }
            }
            Console.WriteLine("50:100奇数的累加和" + num1);
            //输入1:7返回对应的星期数。
            int day;
            Console.WriteLine("请输入1:7任意一个数字");
            string c = Console.ReadLine();
            if (int.TryParse(c, out day))
            {
                if (day > 0 && day <= 7)
                {
                    switch (day)
                    {
                        case 1:
                            Console.WriteLine("星期一");
                            break;
                        case 2:
                            Console.WriteLine("星期二");
                            break;
                        case 3:
                            Console.WriteLine("星期三");
                            break;
                        case 4:
                            Console.WriteLine("星期四");
                            break;
                        case 5:
                            Console.WriteLine("星期五");
                            break;
                        case 6:
                            Console.WriteLine("星期六");
                            break;
                        case 7:
                            Console.WriteLine("星期七");
                            break;
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
