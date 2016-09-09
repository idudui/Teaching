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

             //实验一:c#语法及流程控制基础
            //学号：201415204  姓名：王亚丽



            //1.题目:输出“好好学习 天天向上！”
            Console.WriteLine("好好学习，天天向上!");     //输出“好好学习，天天向上！”
            Console.ReadKey();



            //2.题目:输入一个10000以内的整数，判断其平方是否能被3整除。输入数字不符合提示“输入不正确”
            Console.WriteLine("输入一个10000以内的整数");
            int y = int.Parse(Console.ReadLine());       //定义一个整数y，并把输出的值赋值给y
            if (y >= 10000)            //if语句，判断y的值是否大于等于10000
            {
                Console.WriteLine("输入不正确");        //输出“输入不正确”
            }
            else if (y * y % 3 == 0)            //if语句,判断y的平方是否能被3整除
            {
                Console.WriteLine("输入正确");       //输出“输入正确”
            }
            else
            {
                Console.WriteLine("输入不正确");      //输出“输入不正确”
            }
            Console.ReadLine();






            //3.题目：求50:100能被7整除的数的和。并打印循环变量的初值和终值
            //while循环
            int r = 1;       //对r赋值
            int p = 50;      //对p赋初值
            int s = 0;       //对s赋初值
            while (true)        //执行while语句
            {
                if (p % 7 == 0)     //if语句，判断p是否能被7整除
                {
                    s += p;         //把s加p的值赋给s
                }
                if (p == 100)         //if语句，判断p是否等于100
                    break;        //结束
                p++;
            }
            Console.WriteLine("总和：{0}", s);      //输出“总和：”
            Console.WriteLine("初值：{0}", r);     //输出“初值：1”
            Console.WriteLine("终值：{0}", p);     //输出“终值：100”
            Console.ReadLine();




            //4.题目：求50:100能被7整除的数的和。并打印循环变量的初值和终值
            //for循环
            int x = 1;      //对x赋值
            int t = 50;     //对t赋初值
            int w = 0;      //对w赋初值
            for (t = 50; t < 100; t++)    //单层for循环
            {
                if (t % 7 == 0)           //if语句，判断t是否能被7整除
                {

                    w += t;        
                }
                continue;
            }
            Console.WriteLine("总和：{0}", w);     //输出“总和：”
            Console.WriteLine("初值：{0}", x);     //输出“初值：”
            Console.WriteLine("终值：{0}", t);     //输出“终值：”
            Console.ReadLine();



            //5.题目：用switch（case）实现以下功能
            //输入10以内整数返回是奇数还是偶数
            Console.WriteLine("输入一个10以内的整数");           //输出“输入一个10以内的整数”
            int z = Convert.ToInt32(Console.ReadLine());         //z的值等于输入的数的值
            switch (z)            //计算z的值
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:   
                    Console.WriteLine("奇数");     //若z的值与以上任意一个case常量的值相等，输出“奇数”
                    break;
                case 0:
                case 2:
                case 4:
                case 6:
                case 8:
                case 10:
                    Console.WriteLine("偶数");     //若z的值与以上任意一个case常量的值相等，输出“偶数”
                    break;
                default:
                    Console.WriteLine("出错");     //若z的值与以上所有case常量的值都不同，输出“出错”
                    break;
            }
            Console.ReadLine();





            //学号：201415204  姓名：王亚丽
            //第二周作业：实验二、c#流程控制深入
            //2016年9月9号




            //一、反序打印九九乘法表
            int a, b, c;
            for (a = 9; a >= 1; a--)        //双层for循环
            {
                for (b = a; b >= 1; b--)    //使用内层for循环
                {
                    c = a * b;
                    Console.Write("{0}*{1}={2}", a, b, c);   //使用占位符
                    Console.Write(" ");      //输入空格
                }
                Console.Write("\n");   //换行
            }
            Console.ReadKey();




            //二、用循环画图第4小题
            int i, j;
            for (i = 1; i <= 4; i++)             //外层for循环，控制行数
            {
                for (j = 1; j <= 2 * i - 2; j++)     //内层第一个for循环，控制输出“ ”
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 9 - 2 * i; j++)           //内层第二个for循环，控制输出“*”
                {
                    Console.Write("*");
                }
                Console.Write("\n");         //换行
            }
            Console.ReadKey();




            //三、用循环画图第4小题
            int m;
            for (m = 1; m <= 4; m++)        //for循环，确定行数
            {
                if (m % 2 == 1)           //if语句，判断行数的奇偶
                {
                    Console.Write("########");    //行数为奇数，输出########
                }
                else
                {
                    Console.Write("********");     //行数为偶数，输出********
                }
                Console.Write("\n");        //换行
            }
            Console.ReadKey();
        }
    }
}
