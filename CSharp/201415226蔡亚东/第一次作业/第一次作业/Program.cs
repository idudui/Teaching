using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一次作业
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1.1输出“hello word！”
            Console.WriteLine("hello world!");////输出"hello world!"
            Console.ReadKey();///使项目停留在控制台
            ////2.1输入一个10以内整数，判断是否是能被2整除。输入数字不符合提示“输入不正确”
            {
                Console.WriteLine("请输入一个10以内的数（不包含10）");
                string s = Console.ReadLine();
                Double i1 = Convert.ToDouble(s);
                if (i1 % 2 == 0 && i1 < 10 && i1 >= 0)
                {
                    Console.WriteLine("可以被整除");
                }
                else
                {
                    Console.WriteLine("输入不正确");
                }

                Console.ReadKey();
            }
            ///////////////3.1求1:50偶数的累加和。并打印循环变量的初值和终值
            ///////////////for循环
            {
                int s = 0;
                for (int i2 = 1; i2 <= 50; i2++)
                    if (i2 % 2 == 0)
                    {
                        s = s + i2;
                    }
                Console.WriteLine(s);
                Console.ReadKey();
            }
            ///////////////while
        {
            int i3=1;
            int sum=0;
            while(i3<=50)
            {
                if(i3%2==0)
            {
                sum+=i3;
            }
            }
            Console.WriteLine(sum);
            Console.ReadKey();

         }
        ////////////////5.1输入一个月份(1:12)返回对应季节。
        Console.WriteLine("请输入月份");
        string s3 = Console.ReadLine();
        int i4 = Convert.ToInt32(s3);
        if (i4 > 0 && i4 <= 12)
        {
            switch (i4)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("春季");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("夏季");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("秋季");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("冬季");
                    break;
            }
        }
        else
        {
            Console.WriteLine("输入错误");
        }
        Console.ReadKey();
        }
    }
}
