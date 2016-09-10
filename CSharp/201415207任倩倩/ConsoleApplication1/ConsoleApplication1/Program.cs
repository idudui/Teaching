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
        {   //姓名：任倩倩
            //学号：201415207
            //第一题：输出“欢迎学习c#语言！”
            Console.WriteLine("欢迎学习c#语言！");
            Console.ReadKey();
            //第二题:输入一个100以内的分数(含小数），判断是否及格。输入数字不符合提示“输入不正确”
            //利用if判断语句
            Console.WriteLine("请输入一个100以内的分数（含小数）");
            string s = Console.ReadLine();//定义字符串s
            double i = Convert.ToDouble(s);//强制转换成double
            if (i > 0 && i < 100)
            {
                if (i > 60 && i < 100 && i > 0)
                {
                    Console.WriteLine("及格");
            }
                else
                {
                    Console.WriteLine("不及格");
                }//内部if语句
            }
            Console.ReadKey();
            //第三题：求50:100奇数的累加和。并打印循环变量的初值和终值
            //使用while
            int c = 1;
            int sum1 = 0;//总和初值为0
            while (c <= 100)
            {
                if (c>=50 && c % 2 == 1)
                    {
                        sum1 += c;
                    }
                    c++;
                
            }
            Console.WriteLine("50:100奇数的累加和"+sum1);
            Console.WriteLine("初值" + 1);
            Console.WriteLine("终值" + 100);
            //使用for
            int sum2 = 0;//总和初值为0
            for (int a2 = 1; a2 <= 100; a2++)
            {
                if (a2 >= 50 && a2 % 2 == 1)
                {
                    sum2 += a2;
              }
            }
            Console.WriteLine("50：100奇数的累加和" + sum2);
            Console.WriteLine("初值" + 1);
            Console.WriteLine("终值" + 1);
            //第五题：输入1:7返回对应的星期数
            int num;//定义一个数字
            Console.WriteLine("请输入1：7任意一个数字");
            string n = Console.ReadLine();
            if (int.TryParse(n, out num))
            {
                if (num > 0 && num <= 7)
                {
                    switch (num)
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
            }
            Console.ReadKey();
            }


    }
}
}
