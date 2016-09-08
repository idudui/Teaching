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
            //201415205 申淼
            //日期：2016.09.03
            Console.WriteLine("我会学好c#");  //第一大题第五小题
            Console.ReadKey();

            //第二大题第五小题

            double k, m;
            Console.WriteLine("请输入小于100000的数k=");
            k = Convert.ToInt32(Console.ReadLine());
            m = Math.Sqrt(k);
            if (m % 10 == 0)
                Console.WriteLine("输入数字开平方跟后为整数");

            else
                Console.WriteLine("输入不正确");
            Console.ReadKey();

            //第三、四大题第五小题 for实现
            int a, sum1 = 0;
            for (a = 55; a <= 88; ++a)
            {
                sum1 += a;
            }
            Console.WriteLine("{0}", sum1);
            Console.WriteLine("初值是0，终值是100");
            Console.ReadKey();

            //while实现
            int b, sum2 = 0;
            b = 55;
            while (b <= 88)
            {
                sum2 += b;
                b++;
            }
            Console.WriteLine("{0}", sum2);
            Console.WriteLine("初值是0，终值是100");
            Console.ReadKey();

            int score;         //第五大题第五小题
            Console.WriteLine("请输入一个小于100的成绩:");
            score = Convert.ToInt32(Console.ReadLine());
            switch (score / 10)
            {
                case 10:
                case 9: Console.WriteLine("优秀"); break;
                case 8:
                case 7:
                case 6: Console.WriteLine("及格"); break;
                default:
                    Console.WriteLine("不及格"); break;
                   
            }
            Console.ReadKey();
        }
    }
}

