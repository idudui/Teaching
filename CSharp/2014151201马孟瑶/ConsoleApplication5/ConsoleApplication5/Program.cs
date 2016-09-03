using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        //姓名：马孟瑶  学号：201415201  
        //2016年9月3号    
        //第一题： hello world!
        {
            Console.WriteLine("hello world!");
            Console.ReadKey();
            //第二题： 输入一个10以内整数，判断是否是能被2整除。输入数字不符合提示“输入不正确”
            Console.WriteLine("输入一个十以内的整数");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 10 || number < 0)
            {
                Console.WriteLine("输入错误");
            }
            //判断其是否能被2整除
            else if (number % 2 == 0)
            {
                Console.WriteLine("输入正确");
            }
            else
            {
                Console.WriteLine("输入不正确");
            }
            Console.ReadLine();

            //第三题： 用while求1:50偶数的累加和。并打印循环变量的初值和终值
            int i = 1, sum = 0;
            while (i <= 50)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    i++; continue;
                }
                else
                {
                    i++;
                    continue;
                }

            }

            Console.WriteLine("1-50偶数的累加和为{0}.", sum);
            Console.ReadKey();
            //第四题：用for求1：50偶数的累加和。
            int h; int sum2 = 0;
            for (h = 1; h <= 50; h++)
            {
                if (h%2==0)
                sum2 += h ;
                continue;
            }
            Console.WriteLine("1-50偶数的累加和为{0}.", sum2);
            Console.ReadKey();
            //第五题：用switch（case）输入一个月份(1:12)返回对应季节
             Console.WriteLine("请输入月份：");
             int m = Convert.ToInt32(Console.ReadLine());
             switch (m  )
                {
                 case 1:
                 case 2:
                 case 3:
                      Console.WriteLine(m +"月份是春季");
                     break ;
                 case 4:
                 case 5:
                 case 6:
                     Console.WriteLine(m +"月份是夏季");
                     break;
                 case 7:
                 case 8:
                 case 9:
                     Console.WriteLine(m +"月份是秋季");
                     break;
                 case 10:
                 case 11:
                 case 12:
                     Console.WriteLine(m +"月份是冬季");
                     break;
             } 
            Console.ReadKey();







        }


    }
}













