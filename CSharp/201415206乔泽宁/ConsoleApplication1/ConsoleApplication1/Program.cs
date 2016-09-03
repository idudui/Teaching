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
            //201415206乔泽宁
            //9月3日
            //第一次作业
            //第1题：输出“hello word！”
            Console.WriteLine("Hello world！");
            //第2题：输入一个10以内整数，判断是否是能被2整除，输入数字不符合提示“输入不正确”
            int a;
            Console.WriteLine("请输入一个10以内的整数");
            a = Convert.ToInt32(Console.ReadLine());
            if (a >= 10)
            {
                Console.WriteLine("输入不正确");
            }
            else if (a % 2 == 0)
            {
                Console.WriteLine("可以被2整除");
            }
            else
            {
                Console.WriteLine("不可以被2整除");
                //第三题：用while求1:50偶数的累加和。并打印循环变量的初值和终值
                int m, sum1;
                m = 1;
                sum1 = 0;
                while (m <= 50)
                {
                    sum1 += m;
                    m++;
                }
                Console.WriteLine("{0}.", sum1);
                //第四题：用if求1:50偶数的累加和。并打印循环变量的初值和终值
                int n, sum2;
                n = 1;
                sum2 = 0;
                for (n = 1; n <= 50; n++)
                {
                    sum2 += n;
                }
                Console.WriteLine("{0}.", sum2);
                //第五题：用switch(case)输入一个月份(1:12)返回对应季节。
                int month;
                Console.WriteLine("请输入1-12任意1个数字");
                month = Convert.ToInt32(Console.ReadLine());
                if (month > 0 && month <= 12)
                    switch (month)
                    {
                        case 1:
                        case 2:
                        case 3:
                            Console.WriteLine("春季"); break;
                        case 4:
                        case 5:
                        case 6:
                            Console.WriteLine("夏季"); break;
                        case 7:
                        case 8:
                        case 9:
                            Console.WriteLine("秋季"); break;
                        case 10:
                        case 11:
                        case 12:
                            Console.WriteLine("冬季"); break;
                    }
                else
                {
                    Console.WriteLine("输入错误");
                }
                Console.ReadKey();
            }
        }

    }
}