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
            //作者：201415120孟凡越   日期：2016.9.3
            //1输出“我要学好c#”
        Console .WriteLine("我会学好c#");
            Console.ReadKey ();
            



            //2输入一个100000以内的数字，判断其平方根 是否为整数。输入数字不符合提示“输入不正确”
            int m;
            double n, t;
            Console.WriteLine("输入一个100000以内的数字m=");   //提示用户输入一个100000以内的数字
            m = Convert.ToInt32(Console.ReadLine());   //为m赋值
            n = Math.Sqrt(m);   //将m的平方根赋值给n
            t =n * 10;
            if (t % 10 == 0)
                Console.WriteLine("输入数字开平方根后为整数");
            else
                Console.WriteLine("输入不正确");
            //判断n
           //是否为整数，先将n乘10，再除10取余，为0则是整数
            Console.ReadKey();   //等待用户输入




            //3求55:88的累加和。并打印循环变量的初值和终值
            int i, sum;
            i = 55;
            sum = 0;
            while (i <= 88)
            {
                sum += i;
                i++;
            }
            Console.WriteLine("{0}.", sum);   //输出累加和
            Console.ReadKey();     //等待用户输入



            


         //4输入一个成绩(100以内)返回优秀（>=90）、及格（>=60）、不及格（<60）（提示成绩可以对10求余后再操作）
             Console.WriteLine("请输入一个100以内的成绩");
            int Score = Convert.ToInt32(Console.ReadLine());
            switch (Score / 10)
            {
                case 10:
                case 9: Console.WriteLine("优秀"); break;
                case 8:
                case 7:
                case 6: Console.WriteLine("及格"); break;
                default:
                    Console.WriteLine("不及格"); break;
                    Console.ReadKey();
            }


            
        }
    }
}
