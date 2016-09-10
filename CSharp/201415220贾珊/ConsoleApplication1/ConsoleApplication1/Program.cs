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
            //姓名：贾珊  学号：201415220
            //日期：2016.09.02
            //作业要求：输出“我会学好C#”
            Console.WriteLine("我会学好C#");    //标准输出语句
            Console.ReadKey();     //等待用户输入

            //作业要求：输入一个100000以内的数字，判断其平方根是否为整数。输出数字不符合提示“输入不正确”
            int a;
            double b, t;
            Console.WriteLine("输入一个100000以内的数字 a=");   //提示用户输入一个100000以内的数字
            a = Convert.ToInt32(Console.ReadLine());   //为a赋值
            b = Math.Sqrt(a);   //将a的平方根赋值给b
            t = b * 10;
            if (t % 10 == 0)
                Console.WriteLine("输入数字开平方根后为整数");
            else
                Console.WriteLine("输入不正确");
            //判断b是否为整数，先将b乘10，再除10取余，为0则是整数
            Console.ReadKey();   //等待用户输入

            //作业要求：用while实现：求55:88的累加和，并打印循环变量的初值和终值。
            int i, sum1;
            i = 55;
            sum1 = 0;
            while (i <= 88)
            {
                sum1 += i;
                i++;
            }
            Console.WriteLine("{0}.", sum1);   //输出累加和
            Console.ReadKey();     //等待用户输入

            //作业要求：用for实现：求55:88的累加和，并打印循环变量的初值和终值。
            int m, sum2;
            sum2 = 0;
            for (m = 55; m <= 88; m++)
            {
                sum2 += m;
            }
            Console.WriteLine("{0}.", sum2);   //输出累加和
            Console.ReadKey();     //等待用户输入

            //作业要求：用switch实现：输入一个成绩（100以内）返回优秀（>=90）、及格（>=60）、不及格（<60）
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
