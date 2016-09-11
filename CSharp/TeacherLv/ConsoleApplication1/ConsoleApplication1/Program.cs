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
            string myString, myString1, myPath1, myPath2;
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
            int a;

            //命名约定
            //3.2.4 变量  声明  赋值
            int a1 = 10, a2, a3, a4;
            bool b1;
            a1 = 11;
            a1++;
            //3.3表达式
            a1 = 1 + (2 * 3 / 4);
            b1 = a1 > 10;
            a1 = 10 + 1;

            //例3.2
            //double firstNumber, secondNumber;
            //string userName;
            //Console.WriteLine("aaaaaaaa:");

            ////接收数据，同时把接收到的数据赋值给userName
            //userName = Console.ReadLine();
            //Console.WriteLine("Welcome {0}!", userName);
            //Console.WriteLine("Now give me a number:");

            ////接收数据,数据转换，赋值
            //firstNumber = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Now give me another number:");
            //secondNumber = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("The sum of {0} and {1} is {2}.", firstNumber,
            //            secondNumber, firstNumber + secondNumber);
            //Console.WriteLine("The result of subtracting {0} from {1} is {2}.",
            //            secondNumber, firstNumber, firstNumber - secondNumber);
            //Console.WriteLine("The product of {0} and {1} is {2}.", firstNumber,
            //            secondNumber, firstNumber * secondNumber);
            //Console.WriteLine("The result of dividing {0} by {1} is {2}.",
            //            firstNumber, secondNumber, firstNumber / secondNumber);
            //Console.WriteLine("The remainder after dividing {0} by {1} is {2}.",
            //            firstNumber, secondNumber, firstNumber % secondNumber);
            ////屏幕停在当前位置
            //Console.ReadKey();


            //3.3.3 运算符的优先级
            //A加括号即可  B、赋值运算符优先级是最低的

            //3.3.4 命名空间：按层级和顺序组织的类库



            //第四章 流程控制：分支和循环

            //4.1布尔逻辑
            bool isLessThan10;
            isLessThan10 = myInteger < 10;

            myString = "karli";

            bool isKarli;
            isKarli = myString == "karli";

            //&和&&  |和|| 区别：&&优于&； &可以用于位运算；
            //&&：false  && (一大堆运算)  

            //4.1.1 位运算符
            int result, op1, op2;
            op1 = 4;// 1 0 0 
            op2 = 5;// 1 0 1
            // 0 0 1
            result = op1 & op2;
            result = op1 | op2;
            result = op1 ^ op2;

            //位运算的应用: 颜色的记录和配色；
            //几个基本颜色 红色100-4；绿色010-2；蓝色001-1；黑色000；白色111；
            int myColor = 0;
            bool containsRed;
            myColor = myColor | 2;//增加一点绿色
            myColor = myColor | 4;//增加一点红色
            containsRed = (myColor & 4) == 4; // 检查红色位是否为1
            //位移运算 >>  <<


            //4.1.2 布尔赋值运算符
            //例4.1
            //Console.WriteLine("Enter an integer:");
            //int myInt = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Integer less than 10? {0}", myInt < 10);
            //Console.WriteLine("Integer between 0 and 5? {0}",
            //                  (0 <= myInt) && (myInt <= 5));
            //Console.WriteLine("Bitwise AND of Integer and 10 = {0}", myInt & 10);
            //Console.ReadKey();

            //4.1.3 运算符的优先级更新
            //4.1.4 goto语句--！！！不要用该语句

            //4.2分支：三元运算符  if语句  switch 
            //4.2.1 三元运算符
            //string resultString = (myInteger < 10) ? "小于10 " : "大于或等于10";

            //4.2.2 if语句
            //string resultString;
            //if (myInteger < 10)
            //{
            //    resultString = "小于10";
            //}
            //else
            //{
            //    resultString = "大于等于10";
            //}

            //例4.2 if语句
            //string comparison;
            //Console.WriteLine("Enter a number:");
            //double var1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter another number:");
            //double var2 = Convert.ToDouble(Console.ReadLine());
            ////if (var1 < var2)
            ////    comparison = "less than";
            ////else
            ////{
            ////    if (var1 == var2)
            ////        comparison = "equal to";
            ////    else
            ////        comparison = "greater than";
            ////}
            //if (var1 < var2)
            //    comparison = "less than";
            //else if (var1 == var2) { comparison = "equal to"; }
            //else { comparison = "greater than"; }

            //Console.WriteLine("The first number is {0} the second number.",
            //                  comparison);
            //Console.ReadKey();

            //if else 的逻辑顺序

            //4.2.3 switch语句--对应多个if else

            //例4.3 switch 的例子
            //const string myName = "karli";
            //const string sexyName = "angelina";
            //const string sillyName = "ploppy";
            //string name;
            //Console.WriteLine("What is your name?");
            //name = Console.ReadLine();
            //switch (name.ToLower())
            //{
            //    case myName:
            //        Console.WriteLine("You have the same name as me!");
            //        break;
            //    case sexyName:
            //        Console.WriteLine("My, what a sexy name you have!");
            //        break;
            //    case sillyName:
            //        Console.WriteLine("That's a very silly name.");
            //        break;
            //}
            //Console.WriteLine("Hello {0}!", name);
            //Console.ReadKey();



            //4.3 循环
            //4.3.1 do循环
            //例4.4 do循环
            //double balance, interestRate, targetBalance;
            //Console.WriteLine("What is your current balance?");
            //balance = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("What is your current annual interest rate (in %)?");
            //interestRate = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;
            //Console.WriteLine("What balance would you like to have?");
            //targetBalance = Convert.ToDouble(Console.ReadLine());

            //int totalYears = 0;
            //do
            //{
            //    balance *= interestRate;
            //    ++totalYears;
            //}
            //while (balance < targetBalance);
            //Console.WriteLine("In {0} year{1} you'll have a balance of {2}.",
            //                  totalYears, totalYears == 1 ? "" : "s", balance);
            //Console.ReadKey();



            //4.3.2 while循环
            //例4.5 使用while
            //double balance, interestRate, targetBalance;
            //Console.WriteLine("What is your current balance?");
            //balance = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("What is your current annual interest rate (in %)?");
            //interestRate = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;
            //Console.WriteLine("What balance would you like to have?");

            ////// Uncomment the commented code to look at the How It Works modification
            ////do
            ////{
            //targetBalance = Convert.ToDouble(Console.ReadLine());
            ////    if (targetBalance <= balance)
            ////        Console.WriteLine("You must enter an amount greater than " +
            ////                  "your current balance!\nPlease enter another value.");
            ////} while (targetBalance <= balance);

            //int totalYears = 0;
            //while (balance < targetBalance)
            //{
            //    //balance *= interestRate;
            //    balance = balance*interestRate;
            //    ++totalYears;
            //}
            //Console.WriteLine("In {0} year{1} you'll have a balance of {2}.",
            //                  totalYears, totalYears == 1 ? "" : "s", balance);
            //Console.ReadKey();


            //4.3.3 for循环
            //例4.6 for循环
            //double realCoord, imagCoord; //实部X 虚部Y
            //double realTemp, imagTemp, realTemp2, arg;//临时参数
            //int iterations;//N的迭代次数

            ////两层循环：根据两个变量做一个嵌套循环
            //for (imagCoord = 1.2; imagCoord >= -1.2; imagCoord -= 0.05)
            //{
            //    for (realCoord = -0.6; realCoord <= 1.77; realCoord += 0.03)
            //    {
            //        //给中间变量赋值
            //        iterations = 0;
            //        realTemp = realCoord;
            //        imagTemp = imagCoord;
            //        arg = (realCoord * realCoord) + (imagCoord * imagCoord);

            //        //根据中间变量arg、iterations进行判断，同时循环计算：对中间变量重新赋值
            //        while ((arg < 4) && (iterations < 40))
            //        {
            //            realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
            //                        - realCoord;
            //            imagTemp = (2 * realTemp * imagTemp) - imagCoord;
            //            realTemp = realTemp2;
            //            arg = (realTemp * realTemp) + (imagTemp * imagTemp);
            //            iterations += 1;
            //        }

            //        //根据参数iterations画点
            //        switch (iterations % 4)
            //        {
            //            case 0:
            //                Console.Write(".");
            //                break;
            //            case 1:
            //                Console.Write("o");
            //                break;
            //            case 2:
            //                Console.Write("O");
            //                break;
            //            case 3:
            //                Console.Write("@");
            //                break;
            //        }
            //    }

            //    Console.Write("\n");//换行
            //}
            //Console.ReadKey();


            //4.3.4 循环的中断 break；continue；goto； return；
            //4.3.5 无限的循环while(true){}
            //int i = 1;
            //while(i<=10)
            //{
            //    if ((i % 2) == 0) continue;
            //    Console.WriteLine("{0}",i++);
            //}

            //复习题
            //1.函数类型；
            int i = 10;
            //Console.WriteLine("iiiii");//"i"是字符串，不是变量; i才是变量
            //Console.WriteLine(i);
            //Console.ReadKey();

            string s1 = "abc";
            char char1 = 'a';//char类型是单引号括起来的单个字符；
            s1 = "\"abc\"";s1 = "\\";
            s1 = @"C:\Documents and Settings\Administrator\桌面\实验一";
            

            //s1 = "\""; // 转义字符\：紧挨着后面的字符按照普通字符输出
            
            Console.WriteLine(s1);
            Console.ReadKey();
            

        }
    }
}
