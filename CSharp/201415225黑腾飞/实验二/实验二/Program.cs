using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验二
    //实验二：
    //姓名：黑腾飞
    //学号：201415225    
{
    class Program
    {
        static void Main(string[] args)
        {
            ////实验二：第一题、反序输出九九乘法表
            //for (int a = 9; a >= 1; --a)
            ////当内循环循环一次时，a的值减小1.
            //{
            //    for (int b = 1; b <= 9; ++b)
            //    {
            //        if (a >= b)
            //            Console.Write("{0}*{1}={2} ", a, b, a * b);
            //        //当a>=b时，内循环开始执行，最后输出a*b及结果
            //    }
            //    Console.Write("\n");
            //}
            //Console.ReadKey();          



            //实验二：二、5  用循环画图
            for (int x = 1; x <= 4; ++x)
            {
                for (int m =1;m<=3*x-2;++m )
                {
                    if ( m < x )
                        Console.Write(" ");
                    else
                        Console.Write("*");
                        
                }
                Console.Write("\n");
            }
            Console.ReadKey();




            ////实验二：三、5 用循环画图
            //for (int x = 1; x <= 4; ++x)
            //{
            //    for (int y = 1; y <= 8; ++y)

            //        switch (y)
            //        {
            //            case 1:
            //            case 3:
            //            case 5:
            //            case 7:
            //                Console.Write("#");
            //                break;
            //            case 2:
            //            case 4:
            //            case 6:
            //            case 8:
            //                Console.Write("*");
            //                break;
            //        }
            //    Console.Write("\n");
            //}
            //Console.ReadKey();
        }
    }
}
