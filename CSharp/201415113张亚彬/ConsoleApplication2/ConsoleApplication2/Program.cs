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
        {//第二周作业
            //1、反序打印九九乘法表
            int i, k;//定义两个变量
            //两个循环
            for (i = 9; i >= 1; i -= 1)
            {
                for (k = 1; k <= i; k++)
                {
                    Console.Write("{0}*{1}={2}\t", k, i, k * i);//占位符表示等式
                }
                Console.WriteLine();
            }
            Console.ReadKey();


            //2、用循环画图

            int x, y, j;//定义3个变量
            for (x = 1; x <= 4; x++)//限定行数
            {
                for (y = 8 - 2 * x; y >= 0; y--)//打印空格
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * x - 1; j++)//打印星号
                {
                    Console.Write("*");
                }


                Console.WriteLine();
            }
            Console.ReadKey();




            //3、用循环画图
            int m, n;//定义两个变量

            for (n = 1; n <= 4; n++)//限定行数
            {
                for (m = 1; m <= 8; m++)//限定列数
                {
                    if (n % 2 != 0)//判断奇数行  偶数行

                        Console.Write("*");
                    else
                        Console.Write("#");
                }
                   
                Console.WriteLine();//每进行一次内循环换行

            }
            Console.ReadKey();
        }
    }
}
