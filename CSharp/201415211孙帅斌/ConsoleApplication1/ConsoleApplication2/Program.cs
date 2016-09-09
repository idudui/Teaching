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
            //1.输出“Hello World”
            Console.WriteLine("Hello Worid");
            Console.ReadLine();


            //2.输入一个10以内整数，判断是否是能被2整除。输入数字不符合提示“输入不正确”
            Console.WriteLine("输入一个10以内的整数");
            int number = int.Parse(Console.ReadLine());
            if (number > 10)
            {
                Console.WriteLine("输入不正确");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine("能被2整除");
            }
            else
            {
                Console.WriteLine("输入不正确");
            }

            Console.ReadLine();


            //3.求1:50偶数的累加和。并打印循环变量的初值和终值.(打印的循环变量的初值必须为1，终值为100。提示：使用break和continue）)
            //1.while循环
            int num = 1;
            int sum = 0;
            Console.WriteLine("firstnumber:{0}", num);
            while (num <= 50)
                while (num <= 50)
                {
                    sum = sum + num;
                    num = num + 2;
                    if (num % 2 == 0)
                    {
                        sum = sum + num;
                    }
                    if (num == 50)
                        break;
                    num++;
                }
            Console.WriteLine("endnumber:{0}", num);
            Console.WriteLine("SUM:{0}", sum);
            Console.ReadLine();

            //2.for循环
            int num1 = 1;
            int sum1 = 0;
            Console.WriteLine("fiestnumber:{0}", num1);
            for (num1 = 0; num1 <= 50; num1++)
            {
                if (num1 % 2 == 0)
                {
                    sum1 = sum1 + num1;
                }
                continue;
            }
            num1--;
            Console.WriteLine("endnumber:{0}", num1);
            Console.WriteLine("SUM1:{0}", sum1);
            Console.ReadLine();


            //五、用switch（case）实现以下功能,输入一个月份(1:12)返回对应季节。
            Console.WriteLine("请输入月份：");
            int month = int.Parse(Console.ReadLine());//
            switch (month)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("{0} is spring", month);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("{0} is summer", month);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("{0} is autumn", month);
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("{0} is winter", month);
                    break;
            }
            Console.ReadLine();
        }
    }
}
