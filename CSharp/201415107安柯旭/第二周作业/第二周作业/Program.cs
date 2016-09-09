using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二周作业
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一周作业还是上次已交的
            //姓名：安柯旭  学号：201415107  //日期：2016.9.9
            //第二周作业

            //一、反序打印九九乘法表
            //9*9=81  8*9=72  7*9=63  6*9=54      ............
            //8*8=64  7*8=56  6*8=48    ............
            //......       .......      .......
            //2*2=2  1*2=4
            //1*1=1

            int a, b;                                       //声明变量a，b，作为乘法表中的两个乘数，并注释一前一后，a为前，b为后
            for (b = 9; b >= 1; --b)                        //两层for循环
            {
                for (a = b; a >= 1; --a)
                {
                    int j;
                    j = a * b;
                    Console.Write("{0}*{1}={2} ", a, b, j);//在这懂得如何运用占位符
                }
                Console.Write("\n");//换行，注意所在位置             //Console.Write语句不会自动换行
            }                                                       //Console.WriteLine语句会自动换行
            Console.ReadKey();

            //2.2 
                    //*******
                    // *****
                    //  ***
                    //   *                          //空位 居中  空位由 空格键 占据

            for (int i = 1; i <= 4; ++i)            //声明变量i，代表行，for循环
            {

                switch (i % 4)                      //switch语句
                {
                    case 1:
                        Console.Write("*******");
                        break;
                    case 2:
                        Console.Write(" ***** ");
                        break;
                    case 3:
                        Console.Write("  ***  ");
                        break;
                    case 0:
                        Console.Write("   *   ");   //空位 居中  空位由 空格 占据
                        break;
                }
                Console.Write("\n");                //换行
            }
            Console.ReadKey();


            //3.2   //*#*#*#*#
                    //#*#*#*#*
                    //*#*#*#*#
                    //#*#*#*#*

            for (int i = 1; i <= 4; ++i)            //声明变量i，代表行，for循环
            {
                //判断奇数行和偶数行
                if (i % 2 == 1)                     //奇数行
                    for (int j = 1; j <= 8; ++j)        //声明变量及，代表列，for循环
                    {
                        if (j % 2 == 1)             //奇数列
                            Console.Write("*");
                        if (j % 2 == 0)             //偶数列
                            Console.Write("#");
                    }
                if (i % 2 == 0)                     //偶数行
                    for (int j = 1; j <= 8; ++j)
                    {
                        if (j % 2 == 1)             //奇数列
                            Console.Write("#");
                        if (j % 2 == 0)             //偶数列
                            Console.Write("*");
                    }
                Console.Write("\n");                //换行，注意其所在位置，在第一个for语句的最后一句
            }
            Console.ReadKey();
            //做本题是应找对方法，先行在列，先选择行->判断行->奇数行->在判断列，分奇数列和偶数列
                                                          //->偶数行，和奇数行相同
           //最主要是找到合适的方法


            //总结：懂得Console.WriteLine语句和Console.Write语句区别，学会换行（注意位置）和两层for循环，空位由 空格键 占据
                  //更重要是找到合适的操作循序，思路会更加清晰，也会更易编写  
        }

    }
}
