using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //输出结果
            Console.WriteLine("我会学好C#");
            Console.ReadKey();


            //输入一个100000以内的数字，判断其平方根是否为整数。输入数字不符合提示“输入不正确”
            int a; double b;
            //输入一个小于100000的数字
            Console.WriteLine("输入一个100000以内的整数");
            a = Convert.ToInt32(Console.ReadLine());
            b = Math.Sqrt(a);
            if ((b * 10) % 10 == 0)
                Console.WriteLine("此数为整数");
            else
                Console.WriteLine("不是整数");
            if (a < 0 || a > 100000)
                Console.WriteLine("输入不正确");



            //用while实现如下功能（要求：打印的循环变量的初值必须为1，终值为100。提示：使用break和continue）求55:88的累加和。并打印循环变量的初值和终值
            int sum = 0;
            //声明一个变量i为1
            int i = 1;
            while (i <= 88)
            {
                if (i >= 55)
                    sum += i;
                i++;
            }
            Console.WriteLine("55:88的累加和为" + sum);
            Console.ReadKey();


            //用for实现如下功能（要求：打印的循环变量的初值必须为1，终值为100。提示：使用break和continue）求55:88的累加和。并打印循环变量的初值和终值
            int sum1 = 0;
            for (int j = 1; j <= 88; j++)
            {
                if (j >= 55)
                    sum1 += j;
            }
            Console.WriteLine("55:88的累加和为{0}.", sum1);
            Console.ReadKey();


            //输入一个成绩(100以内)返回优秀（>=90）、及格（>=60）、不及格（<60）（提示成绩可以对10求余后再操作）
            Console.WriteLine("请输入成绩");
            int Score = int.Parse(Console.ReadLine());
            switch (Score / 10)
            {
                case 10:
                case 9:
                    Console.WriteLine("优秀");
                    break;
                case 8:
                case 7:
                case 6:
                    Console.WriteLine("及格");
                    break;
                default:
                    Console.WriteLine("不及格");
                    break;
            }
            Console.ReadKey();
        }
    }
}
