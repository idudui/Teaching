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
        {//第一周作业
            //输出让编程改变世界
          // Console.WriteLine("让编程改变世界！");
          //  Console.ReadKey();


            //作业二：if语句
            //输入一个1000内的整数
           // Console.WriteLine("输入一个1000内的整数");
            //将数值赋给x
           // int x = Convert.ToInt32(Console.ReadLine());
            //判断
            //if (x < 3000)
                //输出
            //    Console.WriteLine("输入不正确");
           // Console.ReadKey();


            //作业三：分别用while和for实现如下功能。（要求：打印的循环变量的初值必须为1，终值为100。提示：使用break和continue）
            //3.1
            //声明一个变量sum并赋值为0
           // int sum = 0;
            //声明一个变量i并赋值为1
           // int i = 1;
            //从1：50进行循环
           // while (i <= 50)
            //判断1:50能不能被3整除
          //  {
            ///    if (i % 3 != 0)
             //       sum += i;
                //
             //   if (i == 1)
             //       Console.WriteLine(1);

             //   i++;

          //  }
            //输出
           // Console.WriteLine("1：50中不能被3整除的数的和为" + sum);
           // Console.ReadKey();



            //3.2
            //声明一个变量n并赋值为0
           // int n = 0;
            //从1：50进行循环
           // for (i = 1; i <= 50; i++)
          //  {
             //   if (i == 1)
             //       Console.WriteLine(1);
                //判断
             //   if (i % 3 != 0)
              //      n += i;
          //  }

            //输出
           // Console.WriteLine("1：50中不能被3整除的数的和为" + sum);
           // Console.ReadKey();



            //作业四：五、用switch（case）实现以下功能
            //输入一个月份
          //  Console.WriteLine("输入月份");
          //  int m = Convert.ToInt32(Console.ReadLine());
         //   if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
             //   i = 31;
          //  if (m == 4 || m == 6 || m == 9 || m == 11)
            //    i = 30;
          //  if (m == 2)
           //     i = 28;
            //输出i
           // Console.WriteLine(i);
          //  Console.ReadKey();



            //第二周作业
            //1、反序打印九九乘法表
            int i, k;//定义两个变量
            //两个循环
            for (i=9;i>=1;i--)
            {
                for (k=1;k<=i;k++)
                {
                    Console.Write("{0}*{1}={2}\t", k, i, k * i);//用占位符表示等式
                }
                Console.WriteLine();
            }
            Console.ReadKey();





            //2、用循环画图
            int x, y, j;//定义三个变量
            for (x=1;x<=4;x++)//外循环定义行数
            {
                for (y=8-2*x;y>=0;y--)//打印空格
                {
                    Console.Write(" ");
                }
                for (j=1;j<=2*x-1;j++)//打印星号
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();




            //3、用循环画图
            int m, n;//定义两个变量
            for (n=1;n<=4;n++)//限定行数
            {
                for (m=1;m<=8;m++)//限定列数
                {
                    if (n % 2 != 0)//判断是奇数行还是偶数行
                        Console.Write("*");//奇数行打印*
                    else
                        Console.Write("#");//偶数行打印#
                }
                Console.WriteLine();
            }
            Console.ReadKey();





            //第三周作业

        }
    }
}
