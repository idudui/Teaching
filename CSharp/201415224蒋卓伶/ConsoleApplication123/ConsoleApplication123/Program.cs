using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {   //201415224 蒋卓伶 第三次作业
        //第一题函数，其题目为：给定初始数据如：a（11，12，13，14，15，16，17，18，19，20），写一个函数求数组中的乘积。
        static int Fun(int[] s)
        {
            int i = 0, j = 1;
            for (; i < 10; i++)
            {
                if (s[i] % 2 == 1)
                    j *= s[i];
            }
            return j;
        }
        /*第二题函数，题目为：写一个函数能求一元二次方程的实根，（并能提示两个实根是否相等）如果没有实根则做出相应提示。
         方程系数abc手动输入。*/
        static void RealisticRoot(double a, double b, double c)
        {
            double d, e, f, x1, x2;
            d = Math.Pow(b, 2);
            e = d - 4 * a * c;
            f = Math.Sqrt(e);
            if (e > 0)
            {
                x1 = (-b + f) / (2 * a);
                x2 = (-b - f) / (2 * a);
                Console.WriteLine("{0}x^2+{1}x+{2}=0有两个不同的实根，为{3}，{4}", a, b, c, x1, x2);
            }
            if (e == 0)
            {
                x1 = (-b + f) / (2 * a);
                Console.WriteLine("{0}x^2+{1}x+{2}=0有两个相同的实根，为{3}", a, b, c, x1);
            }
            if (e < 0)
            {
                Console.WriteLine("{0}x^2+{1}x+{2}=0没有实根", a, b, c);
            }
        }
        //第三题函数，题目为：将一个字符串序列中的数字替换成“？”，如输入"3a8haha"返回“？a？haha”。
        static char CharCon(char a)
        {
            if (a >= '0' && a <= '9')
                a = '?';
            return a;
        }

        static void Main(string[] args)
        {
            //第一题主函数题目为：给定初始数据如：a（11，12，13，14，15，16，17，18，19，20），写一个函数求数组中的乘积。
            int[] a = { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int b = Fun(a);
            Console.WriteLine("a[]中奇数乘积为{0}", b);
            Console.ReadKey();

            /*第二题主函数，题目为：写一个函数能求一元二次方程的实根，（并能提示两个实根是否相等）如果没有实根则做出相应提示。
            方程系数abc手动输入。*/
            double a1, b1, c1;
            Console.WriteLine("a1的值为：");
            a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b1的值为：");
            b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c1的值为：");
            c1 = Convert.ToDouble(Console.ReadLine());
            RealisticRoot(a1, b1, c1);
            Console.ReadKey();

            //第三题主函数，题目为：将一个字符串序列中的数字替换成“？”，如输入"3a8haha"返回“？a？haha”。
            char[] c = { '3', 'a', '8', 'h', 'a', 'h', 'a' };

            for (int i1 = 0; i1 < 7; i1++)
            {
                c[i1] = CharCon(c[i1]);
                Console.Write("{0}", c[i1]);
            }

            Console.ReadKey();

        }
    }
}

