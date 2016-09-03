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

            //实验一:c#语法及流程控制基础
            //学号：201415204  姓名：王亚丽



            //1.题目:输出“好好学习 天天向上！”
            Console.WriteLine("好好学习，天天向上");
            Console.ReadKey();



            //2.题目:输入一个10000以内的整数，判断其平方是否能被3整除。输入数字不符合提示“输入不正确”
            Console.WriteLine("输入一个10000以内的整数");
            int number = int.Parse(Console.ReadLine());
            if (number >= 10000)
            {
                Console.WriteLine("输入不正确");
            }
            else if (number * number % 3 == 0)
            {
                Console.WriteLine("输入正确");
            }
            else
            {
                Console.WriteLine("输入不正确");
            }
            Console.ReadLine();






            //3.题目：求50:100能被7整除的数的和。并打印循环变量的初值和终值
            //while循环
            int num1 = 50;
            int sum1 = 0;
            Console.WriteLine("初值：{0}", num1);
            while (true)
            {
                if (num1 % 7 == 0)
                {
                    sum1 += num1;
                }
                if (num1 == 100)
                    break;
                num1++;
            }
            Console.WriteLine("终值：{0}", num1);
            Console.WriteLine("和：{0}", sum1);
            Console.ReadLine();



            //4.题目：求50:100能被7整除的数的和。并打印循环变量的初值和终值
            //for循环
            int num2 = 50;
            int sum2 = 0;
            Console.WriteLine("初值：{0}", num2);
            for (num2 = 50; num2 < 100; num2++)
            {
                if (num2 % 7 == 0)
                {

                    sum2 += num2;
                }
                continue;
            }
            Console.WriteLine("终值：{0}", num2);
            Console.WriteLine("和：{0}", sum2);
            Console.ReadLine();



            //5.题目：用switch（case）实现以下功能
            //输入10以内整数返回是奇数还是偶数
            Console.WriteLine("输入一个10以内的整数");
            int num3 = Convert.ToInt32(Console.ReadLine());
            switch (num3)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                    Console.WriteLine("奇数");
                    break;
                case 0:
                case 2:
                case 4:
                case 6:
                case 8:
                case 10:
                    Console.WriteLine("偶数");
                    break;
                default:
                    Console.WriteLine("输入错误");
                    break;
            }
            Console.ReadLine();
        }
    }
}
