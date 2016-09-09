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
            //作业要求
            //作者：袁盼盼    日期：2016.9.9

          
            
            
            /*一、反序打印九九乘法表，即
                              9*9=81  8*9=72  7*9=63  6*9=54      ............
                              8*8=64  7*8=56  6*8=48    ............
                              ......       .......      .......
                              1*2=2  2*2=4
                              1*1=1
               */
            int i, j, k;
            for (i = 9; i >= 1; i--)
            {
                for (j = i; j >= 1; j--)
                {
                    k = i * j;
                    Console.Write("{0}*{1}={2}", i, j, k);
                }
              Console.Write("\n");
            }
            Console.ReadKey();



            /*二、用循环画图 
                                    *
                                  ***
                                *****
                              *******
              */
            int a;
            int n = 4;
            for (i = 1; i <= 4; i++)
            {
                for (a =1 ; a <=2*n-2*i; a++)
                {
                    Console.Write(" ");
                }
                for (a = 1; a<=2*i-1; a++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadKey();





            /*三、用循环画图
                             ********
                             ########
                             ********
                             ########
             */
            int p, q;
            int m = 4;
            for (p = 1; p <= m; p++)
            {
                for (q = 1; q <= 2 * m; q++)
                {
                    if (p % 2 != 0)
                        Console.Write("*");
                    else
                        Console.Write("#");
                }
                Console.Write("\n");
            }
            Console.ReadKey();

        }
    }
}
