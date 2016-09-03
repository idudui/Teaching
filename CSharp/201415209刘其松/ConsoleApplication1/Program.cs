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
            //姓名：刘其松   学号：201415209
            //日期:2016年9月2日

            //////////////////////////////////////////////////////////////
            //题目：输出“好好学习 天天向上！”
            Console.WriteLine("好好学习 天天向上！");
            Console.ReadKey();



            //////////////////////////////////////////////////////////////
            //输入一个10000以内的整数，判断其平方是否能被3整除。
            // 输入数字不符合提示“输入不正确”
            //日期：2016年9月2日

            //输入数字
            Console.WriteLine("输入一个10000以内的整数");
            int number = Convert.ToInt32(Console.ReadLine());

            //判断是否超过范围
            if (number > 10000 || number < 0)
            {
                Console.WriteLine("输入的数不符合范围");
            }
            //判断是否能被3整除
            else if (number * number % 3 == 0)
            {
                Console.WriteLine("输入正确");
            }
            else
            {
                Console.WriteLine("输入不正确");
            }
            Console.ReadLine();



            /////////////////////////////////////////////////////////////
            //求50:100能被7整除的数的和。并打印循环变量的初值和终值
            //while循环

            //修改：循环从1到100，并把1到50过滤掉
            //修改日期：2016年9月3日

            int num1 = 1;
            int sum1 = 0;
            Console.WriteLine("初值：{0}", num1);//打印初值
            //循环找符合条件的值
            while (true)
            {
                if (num1 % 7 == 0&&num1>49)  //小于50过滤掉
                {
                    sum1 = sum1 + num1;
                }

                if (num1 == 100)
                    break;
                num1++;
            }
            Console.WriteLine("终值：{0}", num1);//终值
            Console.WriteLine("和：{0}", sum1);//和
            Console.ReadLine();


            ///////////////////////////////////////////////////////
            //求50:100能被7整除的数的和。并打印循环变量的初值和终值
            //for循环


            int sum2 = 0;
            int num2 = 1;
            Console.WriteLine("初值：{0}", num2);
            for (num2 = 1; num2 < 100; num2++)
            {
                if (num2 % 7 == 0&&num2>49)
                {

                    sum2 = sum2 + num2;
                }
                continue;
            }
            Console.WriteLine("终值：{0}", num2);
            Console.WriteLine("和：{0}", sum2);
            Console.ReadLine();



            /////////////////////////////////////////////////////
            //输入10以内整数返回是奇数还是偶数
            Console.WriteLine("输入一个10以内的整数");
            int num3 = Convert.ToInt32(Console.ReadLine());//转换为整形

            switch (num3)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                    Console.WriteLine("您输入的是奇数");
                    break;
                case 2:
                case 4:
                case 6:
                case 8:
                case 10:
                    Console.WriteLine("您输入的是偶数");
                    break;
                default:
                    Console.WriteLine("输入错误");
                    break;
            }
            Console.ReadLine();
        }
    }
}
