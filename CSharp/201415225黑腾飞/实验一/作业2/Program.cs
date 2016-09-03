using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业2//实验一：二.5 输入一个100000以内的数，判断其平方根是否为整数
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入一个100000以内的数");
            String s = Console.ReadLine();
            Double i1 = Convert.ToDouble(s);
            Double i2 = Convert.ToDouble(s);
            if (i1 > 0 && i1 <= 100000)
            {
                i2 = Math.Sqrt(i1);
                {
                    int i3 = Convert.ToInt32(Convert.ToDouble(i2));
                    if (i2 == i3)
                        Console.WriteLine("平方根为整数");

                    else
                    {
                        Console.WriteLine("平方根不为整数");
                    }
                }
            }
            else
            {
                Console.WriteLine("输入错误");
            }
        }       
    }
}