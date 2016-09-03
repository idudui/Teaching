using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 肖杭__201415219
{
    class Program
    {
        static void Main(string[] args)
        {
            //肖杭  201415219
            //2016年9月2日
            //作业  输出“好好学习，天天向上！”
            Console.WriteLine("好好学习，天天向上！");
            //作业2 输入一个10000以内的整数，判断其平方是否能被3整除。输入文字不符合输出“输入不正确”。
            Console.WriteLine("输入一个10000以内整数：");
            int number = Convert.ToInt32(Console.ReadLine());
            int x = number ^ 2;
            if (x % 3 != 0) ;
            {
                Console.WriteLine("输入不正确");
            }
            Console.ReadKey();
            //作业3 用While实现：求50：100能被7整除的数的和。并打印循环变量的初值和终值。
            int i = 50;
            int sum = 0;
            while (i <= 100) 
            {
                if (i % 7 == 0) 
                {
                     Console.WriteLine(i);
                     sum += i;
                }
                i++;
             }
            Console.WriteLine(sum);
            Console.ReadKey();
            //作业4 用For实现：求50：100能被7整除的数的和。并打印循环变量的初值和终值。
            int sum = 0;
            for (int i = 50; i <= 100; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
            //作业5 输入10以内整数返回是奇数还是偶数。
            Console.WriteLine("请输入一个10以内的数");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 2: Console.WriteLine("偶数"); break;
                case 4:
                case 6:
                case 8:
                    Console.WriteLine("偶数"); break;
                default: Console.WriteLine("奇数"); break;
            }
            Console.ReadKey();
        }
    }
}
