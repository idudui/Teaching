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
            //作者：古丽努尔  日期：2016年9月2日
            //一.简单入门
            //1.4 输出“好好学习 天天向上！” 
            Console.WriteLine("好好学习 天天向上!");
            Console.ReadKey();




            //二.if语句
            //2.4 输入一个10000以内的整数，判断其平方是否能被3整除。输入数字不符合提示“输入不正确"
            int a, b;
            Console.WriteLine("输入一个10000以内的整数:");
            a = Convert.ToInt32(Console.ReadLine());
            b = a * a;
            if (b % 3 == 0)
                Console.WriteLine("输入正确");
            else
                Console.WriteLine("输入不正确");
            Console.ReadKey();



            //三.用while实现如下功能。（要求：打印的循环变量的初值必须为1，终值为100。提示：使用break和continue)
            //3.4 1求50：100能被7整除的数的和，并打印循环变量的初值和终值。
            int i = 50;
            int sum = 0;
            Console.WriteLine("循环变量的初值:",i);
            while (i >= 50) ;
            {
                if (i % 7 == 0)
                    sum += i;
                i++;
                if (i <= 100)
                    continue;
                else
                    break;
            }
       
            Console.WriteLine("循环变量的终值是：", 100);
            Console.WriteLine("50：100中能被7整除的数的和为：",sum);
            Console.ReadKey();



            //四.用for实现如下功能。（要求：打印的循环变量的初值必须为1，终值为100。提示：使用break和continue)
            //4.4 1求50：100能被7整除的数的和，并打印循环变量的初值和终值。
            int sum = 0;
            int i = 50;
            Console.WriteLine("循环变量的初值:", i);
            for ( ; i >= 50 && i <=100; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
                if (i > 100)
                    break;
                else
                    continue;
            }
            Console.WriteLine("循环变量的终值是：",100);
            Console.WriteLine("50：100中能被7整除的数的和为：", sum);
            Console.ReadKey();



            //五.用switch(case)实现以下功能。
            //5.4 输入10以内的整数返回是奇数还是偶数。
            int i;
            Console.Write("输入10以内的整数：");
            i = Convert.ToInt32(Console.ReadLine());
            switch (i%2)
            {
                //O代表偶数
                //J代表奇数
                case 0: i=O; break;
                case 1: i=J; break;
                
            }
            Console.WriteLine("{0}为{1}数");
            Console.ReadKey();





        }
    }
}

