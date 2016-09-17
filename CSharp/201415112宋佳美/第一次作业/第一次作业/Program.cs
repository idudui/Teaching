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

            //姓名：宋佳美    学号：201415112  日期：16/9/8
            // 第一题：输出“欢迎学习c#语言！”
            Console.WriteLine("欢迎学习c#语言！");
            Console.ReadKey();

            //第二题:输入一个100以内的分数（含小数），判断是否及格。输入数字不符合提示“输入不正确”
            Console.WriteLine("输入一个100以内的分数");
            double i = Convert.ToDouble(Console.ReadLine());
            if (i < 0 || i > 100)
                Console.WriteLine("输入不正确");
            else if (i >= 60)
                Console.WriteLine("及格");
            else
                Console.WriteLine("不及格");
            Console.ReadKey();


            // 第三题:求50:100奇数的累加和。并打印循环变量的初值和终值
            //while循环
            int a = 50;
            int sum1 = 0;
            while (a <= 100)
            {
                if (a % 2 == 1)
                    sum1 = sum1 + a;
                a++;
            }
            Console.WriteLine("50:100奇数累加是{0}", sum1);
            Console.ReadKey();
            //第四题:求50:100奇数的累加和。并打印循环变量的初值和终值
            //for循环
            int b;
            int sum2 = 0;
            for (b = 50; b <= 100; b++)
            {
                if (b % 2 == 1)
                    sum2 = sum2 + b;
            }
            Console.WriteLine("50:100奇数累加是{0}", sum2);
            Console.ReadKey();



            //第五题:输入1:7返回对应的星期数
            Console.WriteLine("输入1:7任意一个数");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
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
                    Console.WriteLine("星期日");
                    break;
            }
            Console.ReadKey();

        }
    }
}
