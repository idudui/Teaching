using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业5//实验一：五.5 输入一个成绩，返回优秀、及格、不及格
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("请输入成绩（0-100）");
            string s = Console.ReadLine();
            int score = Convert.ToInt32(s);
            if (score >= 0 && score <= 100)
            {
                i = score / 10;
                switch (i)
                {
                    case 10:
                    case 9:
                        Console.WriteLine("优秀");
                        break;
                    case 8:
                    case 7:
                    case 6:
                        Console.WriteLine("及格");
                        break;
                    case 5:
                    case 4:

                    case 3:
                    case 2:
                    case 1:
                    case 0:
                        Console.WriteLine("不及格");
                        break;
                }
            }
            else
            {
                Console.WriteLine("输入错误");
            }
            Console.ReadKey();
        }
    }
}