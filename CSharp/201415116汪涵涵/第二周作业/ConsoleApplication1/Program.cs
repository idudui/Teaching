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
          /*
           作者：汪涵涵201415116

            一、反序打印九九乘法表，即
           9 * 9 = 81  8 * 9 = 72  7 * 9 = 63  6 * 9 = 54............
           8 * 8 = 64  7 * 8 = 56  6 * 8 = 48............
           ......       .......      .......
           1 * 2 = 2  2 * 2 = 4
           1 * 1 = 1
           */
            Console.WriteLine("反序九九乘法表：");
            for (int i = 9; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write("{0}*{1}={2} ", i, j, i * j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
       /* 二、用循环画图
   *
  ***
 *****
*******
*/
Console.WriteLine("请输入你要打印的行数：");
            int rows = int.Parse(Console.ReadLine());  
for (int i = 0; i<rows; i++)  
{
for (int j1 = 0; j1<rows-i-1; j1++)  
{
Console.Write(" ");  
}
for (int j2 = 0; j2<2 * i + 1; j2++)  
{
 Console.Write("*");  
}
Console.WriteLine();  
}
Console.ReadKey();

            /*三、用循环画图
                  #*#*#*#*
                  *#*#*#*#
                  #*#*#*#*
                  *#*#*#*#
          */
            int a, b;
            for (a = 1; a <= 4; a++)
            {
                for (b = 1; b <= 8; b++)
                {
                    if (a % 2 != 0)
                    {
                        if (b % 2 != 0)
                            Console.Write("#");
                        else
                            Console.Write("*");
                    }
                    else
                    {
                        if (b % 2 != 0)
                            Console.Write("*");
                        else
                            Console.Write("#");
                    }
                }
                Console.Write("\n");
            }
            Console.ReadKey();
            }
    }
}
