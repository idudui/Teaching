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
            //作者：袁盼盼  
            //1 输出“让编程改变世界！”



            Console.WriteLine("让编程改变世界！");
            Console.ReadKey();


            //2 输入一个10000以内的整数，判断是否大于3000。输入数字不符合提示“输入不正确”

            int m;
            Console.WriteLine("一个10000以内的整数");
            m = Convert.ToInt32(Console.ReadLine());
            if (m > 3000&&m<10000)
                Console.WriteLine("大于3000");
            else
                Console.WriteLine("输入不正确");
            Console.ReadKey();


            //5输入一个月份（1:12）返回该月有几天。2月按28天。


            int n;
            Console.WriteLine("请输入一个月份");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("这个月份有31天");
                    break;
                case 2:
                    Console.WriteLine("这个月份有28天");
                    break;
                case 3:
                    Console.WriteLine("这个月份有31天");
                    break;
                case 4:
                    Console.WriteLine("这个月份有30天");
                    break;
                case 5:
                    Console.WriteLine("这个月份有31天");
                    break;
                case 6:
                    Console.WriteLine("这个月份有30天");
                    break;
                case 7:
                    Console.WriteLine("这个月份有31天");
                    break;
                case 8:
                    Console.WriteLine("这个月份有30天");
                    break;
                case 9:
                    Console.WriteLine("这个月份有30天");
                    break;
                case 10:
                    Console.WriteLine("这个月份有31天");
                    break;
                case 11:
                    Console.WriteLine("这个月份有30天");
                    break;
                case 12:
                    Console.WriteLine("这个月份有31天");
                    break;
            }
            Console.ReadKey();


            //3 求1: 50不能被3整除的数的和。并打印循环变量的初值和终值  用while循环


            int i = 1; 
            int sum = 0;
            Console.WriteLine("初值是{0}", i);
            while (i <= 100)
            {
                if (i <= 50)
                {
                    if ((i % 3) != 0)
                    {
                        sum += i;
                    }
                }
                i++;
                continue;
            }
            Console.WriteLine("终值是{0}",i-1);
            Console.WriteLine("sum={0}",sum);


            //4 求1: 50不能被3整除的数的和。并打印循环变量的初值和终值 用for循环

            int j = 1,s=0;
            Console.WriteLine("初值是{0}",j);
            for (j = 1; j <= 100; j++)
            {
                if (j <= 50)
                {
                    if ((j % 3) != 0)
                    {
                        s += j;
                    }
                }
                continue;
            }
            Console.WriteLine("终值是{0}",j-1);
            Console.WriteLine("s={0}",s);
            Console.ReadKey();
        }
    }
}
