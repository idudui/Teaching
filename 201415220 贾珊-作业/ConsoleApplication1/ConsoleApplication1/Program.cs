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
            //学号：201415220  姓名：贾珊
            //日期：2016年9月8日
            //作业要求：反序打印九九乘法表
            int i, j;
            for (i = 9; i >= 1; i--)  //用双层for循环嵌套实现算法
            {
                for (j = i; j >= 1; j--)    //内层for循环打印每行需要输出的内容
                {
                    Console.Write("{0}*{1}={2}", j, i, i * j);  //用占位符输出九九乘法表每一项的格式
                    Console.Write(" ");  //每行等式不换行，中间用“ ”隔开
                }
                Console.Write("\n");  //打印完每行输出一次空格
            }
            Console.ReadKey();  //等待用户输入

            //作业要求：打印图形5
            int a, b;
            for (a = 1; a <= 4; a++)  //用双层for循环实现打印图形算法
            {
                for (b = 1; b <= 3 * a - 2; b++)  //经计算，第a行从第a列开始打印“*”，到第（3*a-2)列停止打印
                {
                    if (b < a)
                        Console.Write(" ");  //第b行第b列前的位置打印" "
                    else
                        Console.Write("*");  //第b行从第b列开始打印“*”至停止打印
                }
                Console.Write("\n");  //第b行打印结束后换行
            }
            Console.ReadKey();  //等待用户输入

            //作业要求：打印图形5
            int m, n;
            for (m = 1; m <= 4; m++)
            {
                for (n = 1; n <= 4; n++)
                {
                    Console.Write("#*");  //将“#*”组合一起打印
                }
                Console.Write("\n");
            }
            Console.ReadKey();

            int x, y,p;
            for(x=1;x<=4;x++)
            {
                for (y = 1; y <= 8; y++)  //分别输出“#”，“*”
                {
                    p = y % 2;
                    if (p == 1)
                        Console.Write("#");
                    else
                        Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
