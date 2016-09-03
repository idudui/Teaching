using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //实验一：c#语法及流程控制基础
        //姓名：孙帅斌  学号：201415211  日期：2016.09.02
        //4.输入一个月份(1:12)返回对应季节
       
        static void Main(string[] args)
        {
            //1.输出“Hello World”
            Console.WriteLine("Hello Worid");
            Console.ReadLine();


            //2.输入一个10以内整数，判断是否是能被2整除。输入数字不符合提示“输入不正确”
            Console.WriteLine("输入一个10以内的整数");
            int number = int.Parse(Console.ReadLine());
            if(number>10)
            {
                Console.WriteLine("输入不正确");
            }
            else if(number%2==0)
            {
                Console.WriteLine("能被2整除");
            }
            else
            {
                Console.WriteLine("输入不正确");
            }
            
            Console.ReadLine();


            //3.求1:50偶数的累加和。并打印循环变量的初值和终值
            //1.while循环
            int num = 0;
            int sum = 0;
            Console.WriteLine("firstnumber:{0}", num);
            while(num<=50)
            {
                sum = sum + num;
                num = num + 2;
            }
            Console.WriteLine("endnumber:{0}", num);
            Console.WriteLine("SUM:{0}", sum);
            Console.ReadLine();

            //2.for循环
            int num1 = 0;
            int sun1 = 0;
            Console.WriteLine("fiestnumber:{0}",num1)

        }
    }
}
