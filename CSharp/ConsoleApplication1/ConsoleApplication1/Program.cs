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
            //1.反序打印九九乘法表
            int m, n;
            for (m = 9; m >= 1; m--)
            {
                for (n = m; n >= 1; n--)//双层for循环
                {
                    Console.Write("{0}*{1}={2}", m, n, m * n);
                }
                Console.Write("\n");
            }
            Console.ReadKey();
            ////2(3).用循环画图 
            int t, i;
            for (t = 1; t < 5; t++)              //控制行
            {
                for (i = 1; i < 8; i++)          //控制列
                {
                    if (i < 9 - 2 * t)
                        Console.Write(" ");      //控制空白符
                    else
                        Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
            //3（3）.用循环画图
            int s;
            for (s = 1; s < 5; s++)                              //控制行
            {
                switch (s)
                {
                    case 1:
                        Console.Write("********"); break;
                    case 2:
                        Console.Write("########"); break;
                    case 3:
                        Console.Write("********"); break;
                    case 4:
                        Console.Write("########"); break;        //打印图片
                } Console.Write("\n");

            }     Console.ReadKey();
        }
    }
}
