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
            //作业要求
            //作者：刘春玲201415106 日期：2016年9月2日
            //1 输出“hello word！”
            Console.WriteLine("Hello world");
            Console.ReadKey();

          
            //作者：刘春玲201415106 日期：2016年9月3日
            //2 输入一个10以内整数，判断是否是能被2整除。输入数字不符合提示“输入不正确”
            int m,n;
            Console.WriteLine("请输入一个10以内的整数");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("m={0}", m);
            if (m < 10)
            {
                n = m % 2;
                if (n = 0)
                    Console.WriteLine("m");
                Console.ReadKey();
            }
            else
                Console.WriteLine("输入不正确");
            Console.ReadKey();



            
            //作者：201415106刘春玲  日期：2016年9月3日
            //3用while实现如下功能。（要求：打印的循环变量的初值必须为1，终值为100。提示：使用break和continue）
            // 求1:50偶数的累加和。并打印循环变量的初值和终值
            int a = 1;
            Console.WriteLine("初值{0}", a);
            int sum = 0;
            do
            {
                if (a % 2 = 0)
                {
                    sum += a;
                }
                a++;
                if (a <= 50)
                    continue;
                else
                    break;
            } while (a <= 50);
            Console.WriteLine("终值是{0}", a-1);
            Console.WriteLine ("sum={0}",sum);
            Console.ReadKey ();

            //作者：201415106刘春玲 日期：2016年9月3日
            //4 用for实现如下功能。（要求：打印的循环变量的初值必须为1，终值为100。提示：使用break和continue）
            // 求1:50偶数的累加和。并打印循环变量的初值和终值
            int a = 1;
            Console.WriteLine("初值{0}", a);
            int sum = 0;
            for (a <= 50; a++; )
            {
                if (a % 2 = 0)
                {
                    sum += a;
                }
                if (a < 50)
                    continue;
                else
                    break;
            }
            Console.WriteLine("终值是{0}", a-1);
            Console.WriteLine ("sum={0}",sum);
            Console.ReadKey ();



            //作者：201415106刘春玲 日期：2016年9月3日
            //5 用switch（case）实现以下功能
            //输入一个月份(1:12)返回对应季节。
            int month;
            Console.WriteLine ("请输入月份");
                month=Convert.ToInt32 (Console.ReadLine ());
            switch(month)
            {
                case 1:
                case 2:
                case 3:
                Console.WriteLine ("{0}月是春季",month);
                break;
                case 4:
                case 5:
                case 6:
                Console.WriteLine ("{0}月是夏季",month);
                break;
                case 7:
                case 8:
                case 9:
                Console.WriteLine ("{0}月是秋季",month);
                break;
                case 10:
                case 11:
                case 12:
                Console.WriteLine ("{0}月是冬季",month);
                break;
            }
            Console.ReadKey();
        }
    }
}
