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
            //姓名：蒋红运  学号：201415126
            //日期：2016年9月3日

            //1.1输出hello world!
            Console.WriteLine("hello world!");
            Console.ReadKey();


            // 2.1输入一个10以内整数，判断是否是能被2整除。输入数字不符合提示“输入不正确”。  
            Console.WriteLine("请输入一个10以内的整数：");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0 || n > 10)
            {
                Console.WriteLine("输入不正确");
            }
            else if (n % 2 == 0)
            {
                Console.WriteLine(n + "能被2整除");
            }
            else
            {
                Console.WriteLine(n + "不能被2整除");
            }
            Console.ReadLine();


            //3.1求1:50偶数的累加和。并打印循环变量的初值和终值

            //for循环
            int i;
            int sum1 = 0;
            for (i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                    sum1 = sum1 + i;
            }
            Console.WriteLine("1-50偶数的累加和为" + sum1);
            Console.ReadLine();

            //while循环
            int j = 1;
            int sum2 = 0;
            while (j <= 50)
            {
                if (j % 2 == 0)
                    sum2 = sum2 + j;
                j++;
            }
            Console.WriteLine("1-50偶数的累加和为" + sum2);
            Console.ReadLine();


            //5.1输入一个月份(1:12)返回对应季节。
            Console.WriteLine("请输入月份:");
            int m = Convert.ToInt32(Console.ReadLine());
            switch (m)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine(m + "月份是春季");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine(m + "月份是夏季");
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine(m + "月份是秋季");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine(m + "月份是冬季");
                    break;
            }
            Console.ReadLine();
        }
    }
}
   