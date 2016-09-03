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
            //201415224蒋卓伶
            //9月3日
            //第一次作业
            //作业要求：输出“好好学习 天天向上！”
            Console.WriteLine("好好学习 天天向上！");
            //作业要求：输入一个10000以内的整数，判断其平方能否被3整除。输入数字不符合提示“输入不正确”
            int a; double b;
            Console.WriteLine("输入一个10000以内的整数");
            a = Convert.ToInt32(Console.ReadLine());
            b = Math.Pow(a, 2);
            if (a < 0 || a > 10000)
                Console.WriteLine("输入不正确");
            else {
                if (b % 3 == 0)
                    Console.WriteLine("能被3整除");
                else
                    Console.WriteLine("不能被3整除");
                }
            //作业要求：求50：100能被7整除的数的和。并打印循环变量的初值和终值。
            int i = 50, sum = 0;
            while (i <= 100)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                    i++;
                }
                else
                {
                    i++; continue;
                }
            }
            Console.WriteLine(" 50：100能被7整除的数的和为：{0}.",sum);
            //作业要求：求50：100能被7整除的数的和。并打印循环变量的初值和终值。
            int x, y=0;
            for (x = 50; x<= 100; x++)
            {
                if (x% 7 == 0)
                    y+= x;
                else
                    continue;
            }
            Console.WriteLine(" 50：100能被7整除的数的和为：{0}.", y);
            //输入10以内的整数，返回是奇数还是偶数。
            int j;
            Console.WriteLine("输入10以内的整数");
            j= Convert.ToInt32(Console.ReadLine());
            switch (j)
            {
                case 0: case 2: case 4: case 6: case 8: case 10:
                    Console.WriteLine("偶数");
                    break;
                case 1: case 3: case 5: case 7: case 9:
                    Console.WriteLine("奇数");
                    break;
            }
            Console.ReadKey();
        }
    }
}
