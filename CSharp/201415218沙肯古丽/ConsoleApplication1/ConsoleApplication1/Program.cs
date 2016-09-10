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
            //作者：沙肯古丽  日期：2016.9.9
            //第二周作业
            //1 反序打印九九乘法表
            int i, b, z;//定义变量
            for (i = 9; i >= 1; i--)//用双层for循环实现算法
            {
                for (b = i; b >= 1; b--)//用内层for循环给出每行需要输出的内容
                {
                    z = i * b;
                    Console.Write("{0}*{1}={2}", i, b, z);//用占位符表示九九乘法表的每一项内容
                    Console.Write(" ");//输出完不换行，以“ ”隔开
                }
                Console.Write("\n");//输出空格
            }
            Console.ReadKey();//等待用户输入

            //2.用循环画图
            int c, d;
            for (c = 1; c <= 4; c += 1)//用双层for循环实现算法
            {
                for (d = 1; d <= 7; d += 1)   //内层for循环给出每行需要输出的内容
                {
                    if (d >= 9 - 2 * c)
                        Console.Write("*");    //第d行第（9-2*c）列前打“*”
                    else
                        Console.Write(" ");    //第d行第（9-2*c）列前打“ ”
                }
                Console.Write("\n");     //打印完每行输出空格
            }
            Console.ReadKey();      //等待用户输入

            //3.用循环画图
            int e,f;
            for (e=1;e<=4;e+=1)        //用双层for循环实现算法
            {
                for(f= 1; f<=8; )      //内层for循环给出每行需要输出的内容
                {
                    if (e % 2 == 1)    //判断行数的奇偶性
                    {
                        if (f <= 8)
                        {
                            Console.Write("*");    //行数为奇数则输出8个“*”
                            f++;
                        }
                    }
                    else
                    {
                        if (f <= 8)
                        {
                            Console.Write("#");    //行数为偶数则输出8个“#”
                            f++;
                        }
                    }
                }
                Console.Write("\n");    //每执行完一次内层循环换行
            }Console.ReadKey();   //等待用户输入
        }
    }
}
