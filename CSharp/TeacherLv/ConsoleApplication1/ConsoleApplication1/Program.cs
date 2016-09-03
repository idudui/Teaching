using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //第二章 Hello World!
            //Console.WriteLine("Hello world!");
            
            
            //第三章 变量表达式
            //3.2 变量
            //3.2.1 简单类型

            //例3.1 在命令行窗口进行输出
            //知识点：转义字符、占位符；
            int myInteger;
            string myString, myString1,myPath1,myPath2;
            myInteger = 177777;

            //转义字符
            myString = "\"myInteger1\" is";
            myString = @"myInteger2";
            myString = "D:\\1 教学相关2016-2017-1\\1 教学相关-2016-2017（1）\\面向对象程序设计";
            myString = @"D:\1 教学相关2016-2017-1\1 教学相关-2016-2017（1）\面向对象程序设计";
            
            //占位符
            //Console.WriteLine(myInteger);
            //Console.WriteLine("{0} {1}.", myString, myInteger);
            //Console.ReadKey();


            //3.2.2 变量命名
            int a ;
            
            //命名约定
            //3.2.4 变量  声明  赋值
            int a1 = 10,a2,a3,a4;
            bool b1;
            a1 = 11;
            a1++;
            //3.3表达式
            a1 = 1 + (2 * 3 / 4);
            b1 = a1 > 10;
            a1 = 10 + 1;

            //例3.2
            double firstNumber, secondNumber;
            string userName;
            Console.WriteLine("aaaaaaaa:");

            //接收数据，同时把接收到的数据赋值给userName
            userName = Console.ReadLine();

            Console.WriteLine("Welcome {0}!", userName);


            Console.WriteLine("Now give me a number:");

            //接收数据,数据转换，赋值
            firstNumber = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Now give me another number:");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The sum of {0} and {1} is {2}.", firstNumber,
                        secondNumber, firstNumber + secondNumber);
            Console.WriteLine("The result of subtracting {0} from {1} is {2}.",
                        secondNumber, firstNumber, firstNumber - secondNumber);
            Console.WriteLine("The product of {0} and {1} is {2}.", firstNumber,
                        secondNumber, firstNumber * secondNumber);
            Console.WriteLine("The result of dividing {0} by {1} is {2}.",
                        firstNumber, secondNumber, firstNumber / secondNumber);
            Console.WriteLine("The remainder after dividing {0} by {1} is {2}.",
                        firstNumber, secondNumber, firstNumber % secondNumber);
            Console.ReadKey();

        }
    }
}
