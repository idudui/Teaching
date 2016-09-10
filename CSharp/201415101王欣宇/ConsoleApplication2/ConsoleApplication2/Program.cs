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
            ////一、简单入门
            //    Console.WriteLine("hello world");

            ////二、if语句
            //    int i;
            //    i = Convert.ToInt32(Console.ReadLine());
            //        if(i%2!=0&&i<=10)                
            //        Console.WriteLine("输入不正确");

            ////三、for
            //    int sum = 0;
            //    for(int j=1;j<=50;j++)
            //    {
            //        if (j % 2 == 0)
            //            sum += j;
            //        if (j == 1)
            //            Console.WriteLine("初值为" + j);
            //        if (j == 50)
            //            Console.WriteLine("终值为" + j);
            //    }
            //    Console.WriteLine("1到50的偶数累加和为" + sum);

            ////四、while
            //    sum = 0;
            //    int k = 1;
            //    while(k<=50)
            //    {
            //        if (k % 2 == 0)
            //            sum += k;
            //        if (k == 1)
            //            Console.WriteLine("初值为" + k);
            //        if (k == 50)
            //            Console.WriteLine("终值为" + k);
            //        k++;
            //    }
            //    Console.WriteLine("1到50的偶数累加和为" + sum);

            ////五、switch
            //    int month;
            //    Console.WriteLine("请输入月份(整数)");
            //    month = Convert.ToInt32(Console.ReadLine());
            //    switch(month)
            //    {
            //        case 1:
            //        case 2:
            //        case 3: Console.WriteLine("春季"); break;
            //        case 4:
            //        case 5:
            //        case 6:Console.WriteLine("夏季");break;
            //        case 7:
            //        case 8:
            //        case 9:Console.WriteLine("秋季");break;
            //        case 10:
            //        case 11:
            //        case 12:Console.WriteLine("冬季");break ;
            //        default:Console.WriteLine("输入错误");break;            
            //    }

            //第二周 一、反序打印九九乘法表
            int i = 9, j = 9;
            for (i = 9; i >= 1; i--)
            {
                for (j = i; j >= 1; j--)
                    Console.Write("{0}*{1}={2} ", j, i, i * j);
                Console.WriteLine();
            }

            //二、用循环画图
            int a, k;
            for (a = 1; a <= 4; a++)                      //运用for循环定义层数
            {
                for (k = 1; k <= 4 - a; k++)              //运用for循环定义列数与层数关系
                {
                    Console.Write("\0");
                }
                for (k = 1; k <= 2 * a - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //三、用循环画图
            int b, l;
            for (b = 1; b <= 4; b++)                      //运用for循环定义层数
            {
                if (b % 2 == 1)                           //运用if条件定义奇数层
                {
                    for (l = 1; l <= 8; l++)              //运用for循环定义列数与层数关系
                    {
                        if (l % 2 == 0)                   //偶数列
                            Console.Write("*");           
                        if (l % 2 == 1)                   //奇数列
                            Console.Write("#");
                    }
                }
                if (b % 2 == 0)                           //运用if条件定义偶数层
                {
                    for (l = 1; l <= 8; l++)
                    {
                        if (l % 2 == 0)
                            Console.Write("#");
                        if (l % 2 == 1)
                            Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}


