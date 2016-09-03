using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static string myString;
        private static int n;
        private static bool program;

        static void Main(string[] args)
        {
            //作业要求：输出“我会学好C#”
            //作者：201415110 吴钥  日期：2016.09.03
            //1、指定输出字符串“我会学好C#”
            //2、保持运行框持续出现在页面上
            Console.WriteLine("我会学好C#");//输出“我会学好C#”
            Console.ReadLine();


            //作业要求：用if语句，输入一个100000以内的数字，判断其平方根是否为整数。输入数字不符合提示“输入不正确”
            //作者：201415110 吴钥  日期：2016.09.03
            //1、输入一个整型变量，判断是否符合条件要求。不符合输出“输入不正确”，符合则继续进行
            //2、若符合条件要求，定义一个double变量，使double变量等于整型变量的开方
            //3、若开方为整数，则输出“平方根是整数”；否则输出“平方根不是整数”
            {
                Console.WriteLine("输入一个数n");
                int n;
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 100000)
                    Console.WriteLine("输入不正确");
                else
                {
                   double a;
                    a = Math.Sqrt(n);
                    if (a == (int)a)
                        Console.WriteLine("平方根是整数");
                    else
                        Console.WriteLine("平方根不是整数");   
                }
                Console.ReadLine();


                /*作业要求：分别用whlie和for实现如下功能。
                 * （要求：打印的循环变量的初值必须为1，终值为100.提示：使用break和continue）
                 * 求55:88的累加和。并打印循环变量的初值和终值*/
                //作者：201415110 吴钥  日期：2016.09.03
                /*1、输出初值55，定义和；
                 * 2、whlie或for循环，和从55累计加到88，当i大于88时跳出循环；
                 * 3、打印循环变量地初值和终值，以及最终的和*/
                int i = 55;
                int sum = 0;
                Console.WriteLine("初值为{0}", i);
                //whlie
                while (i <= 88)
                {
                    sum += i;
                    i++;
                    if (i > 88)
                        break;
                    else
                        continue;
                }
                Console.WriteLine("终值为{0}", i - 1);
                Console.WriteLine("sum={0}",sum);
                Console.ReadLine();

            
               //for
                for (; i <= 88;i++)
                {
                    sum += i;
                    if (i >= 88)
                        break;
                    else
                        continue;
                }
                Console.WriteLine("终值为{0}", i - 1);
                Console.WriteLine("sum={0}", sum);
                Console.ReadLine();


                /*作业要求：用switch（case）实现以下功能：
                 * 输入一个成绩（100）以内，返回优秀（>=90）、及格（>=60）、不及格（<60)*/
                //作者：201415110 吴钥  时间：2016.09.03
                /*1、定义m、s，并对m赋值；
                 * 2、使用for循环，对成绩情况进行分类，用s表示；
                 * 3、使用switch（case）进行循环判断；
                 * 4、输出判定结果*/
               
                int m;
                int s=0;
                Console.WriteLine("输入成绩");
                m = Convert.ToInt32(Console.ReadLine());
                
                if (m > 100)
                    s = 1;
                else if (m >= 90)
                    s = 2;
                else if (m >= 60)
                    s = 3;
                else
                    s = 4;
                switch (s) 
                { case 1:
                        Console.WriteLine("分数错误");
                        break;
                    case 2:
                        Console.WriteLine("优秀");
                        break;
                    case 3:
                        Console.WriteLine("及格");
                        break;
                    case 4:
                        Console.WriteLine("不及格");
                        break;
                        
                }
                Console.ReadLine();


            }
        }
    }
}
  

