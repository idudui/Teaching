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
            //姓名：宋佳美    学号：201415112   日期：16/9/10
            //一、反序打印九九乘法表，即
            //9 * 9 = 81  8 * 9 = 72  7 * 9 = 63  6 * 9 = 54............
            //8 * 8 = 64  7 * 8 = 56  6 * 8 = 48............
            //......       .......      .......
            //1 * 2 = 2  2 * 2 = 4
            //1 * 1
            int a, b, s;
            for (a = 9; a >= 1; a--)    //应该使用双层for循环的嵌套格式来实现算法
            {
                for (b = a; b >= 1; b--)    //定义b=a限制每行开头第一个式子开始的数字
                {
                    s = a * b;
                    Console.Write("{0}*{1}={2}", a, b, s);   //使用占位符实现每个小公式的格式输出
                    Console.Write("\0");     //输出完每个小公式后再输出一个空格
                }
                Console.Write("\n");    //执行完一次内层循环后换行
            }
            Console.ReadKey();

            //二、用循环画图

            int c, d;
            for (c = 1; c <= 4; c++)
            {
                for (d = 7; d>=1; d--)    
                {
                    if (d>c-1&&d<9-c)           //用公式限制每行空格位置
                        Console.Write("*");     
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");    //循环执行完一次后换行
            }
            Console.ReadKey();


            //三、用循环画图   
            // *#*#*#*#
            // #*#*#*#*
            //*#*#*#*#
            //#*#*#*#*
            int o, p, q;
            for (o = 1; o <= 4; o++)
            {
                for (p = 1; p <= 4; p++)
                {
                    q = o % 2;
                    if (q == 1)
                        Console.Write("*#");    //将“#*”组合一起输出
                    else
                        Console.Write("#*");
                }
                Console.Write("\n");   //程序内层循环执行完一次后换行
            }
            Console.ReadKey();
        }
    }
}
