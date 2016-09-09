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
            //姓名：宋佳美  学号：201415112 


            //1 输出“欢迎学习c#语言！”
            Console.WriteLine("欢迎学习c#语言!");
            Console.ReadKey();


            //2 输入一个100以内的分数（含小数），判断是否及格。输入数字不符合提示“输入不正确”
            double number;
            Console.WriteLine("请输入一个100以内的分数式（含小数）");
            number = Convert.ToDouble(Console.ReadLine());
            if (number < 60)
            //if语句
            {
                Console.WriteLine("不及格");
            }
            else if (number <= 100 && number >= 60)
            {
                Console.WriteLine("及格");
            }
            else
                Console.WriteLine("输入不正确");
            Console.ReadKey();


            //3.2  求50:100奇数的累加和。并打印循环变量的初值和终值
            int i = 1;
            int sum = 0;
            while (i <= 100)
            {
                if (i >= 50 && i % 2 == 1)
                    sum = sum + i;
                if (i == 1)
                    Console.WriteLine("初值" + i);
                if (i == 100)
                    Console.WriteLine("终值" + i);
                i++;
            }
            //输出
            Console.WriteLine("50:100奇数累加和" + sum);
            Console.ReadKey();


            //4 求50:100奇数的累加和。并打印循环变量的初值和终值
            int a = 1;
            int sum1 = 0;
            for (a = 1; a <= 100; a++)
            {
                if (a > 50 && a % 2 == 1)
                    sum1 = sum1 + a;
                if (a == 1)
                    Console.WriteLine("初值" + a);
                if (a == 100)
                    Console.WriteLine("终值" + a);
            }
            Console.WriteLine("50:100奇数累加和" + sum1);
            Console.ReadKey();


            //5输入1:7返回对应的星期数
            int b;
            Console.WriteLine("请输入b");
            b = Convert.ToInt32(Console.ReadLine());
            //switch语句
            switch (b)
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
            Console.WriteLine("输入1：7返回对应星期数" + b);
            Console.ReadKey();

            
        }
    }
}

        }
    }
}
