using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一周作业
{
    class Program
    {
        static void Main(string[] args)
        {
            //姓名：安柯旭  学号：201415107  日期：2016.9.2
            //第一周作业


            //第一题1.2 输出“欢迎学习c#语言！”
            Console.WriteLine("欢迎学习c#语言!");
            //输出结果
            Console.ReadKey();
            //程序显示在显示界面


            //第二题2.2 输入一个100以内的分数（含小数），判断是否及格。输入数字不符合提示“输入不正确”
            double number;
            //声明变量number
            Console.WriteLine("请输入一个100以内的分数式（含小数）");
            //接收数据，同时将将接受的数据赋值给number，提醒输入数据
            number = Convert.ToDouble(Console.ReadLine());
            //接收数据，数据转换，赋值
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
            //声明变量初值为1
            int sum = 0;
            //声明变量和sum初值为0
            //while循环语句
            while (i <= 100)
            {
                //条件语句  判断为奇数并叠加
                if (i >= 50 && i % 2 == 1)
                    sum = sum + i;
                if (i == 1)
                    Console.WriteLine("初值" + i);
                if (i==100)
                    Console.WriteLine("终值" + i);
                i++;
                //加1循环
            }
            //输出
            Console.WriteLine("50:100奇数累加和" + sum);
            Console.ReadKey();
           
            
            //4.2 求50:100奇数的累加和。并打印循环变量的初值和终值
            int a = 1;
            //声明变量a=1
            int sum1 = 0;
            //声明累加和sum初值为0
            //for循环
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
            
            
            //5.2  输入1:7返回对应的星期数
            int b;
            //声明变量b
            Console.WriteLine("请输入b");
            //提醒输入b
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
            //输出
            Console.WriteLine("输入1：7返回对应星期数" + b);
            Console.ReadKey();

            //总结：在此之前，许多内容都已经模糊了，操作很生疏，需要重新返回查找；
            //for循环，while循环，switch语句，还有的是不同与java的输入输出语句等需要重新拾取和调整；
            //同时还有许多的符号如&，和一些与语句操作需要回顾，此次作业也在找回以前的东西；
            //更重要的是认清自己的不足，赶紧补足，熟练这些内容

        }
    }
}
