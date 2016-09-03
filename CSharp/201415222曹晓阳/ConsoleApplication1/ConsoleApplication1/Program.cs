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

            //姓名  曹晓阳
            //学号  201415222
            //题目：输出“欢迎学习C#语言！”
            Console.WriteLine("欢迎学习C#语言!");
            Console.ReadKey();
            //题目：输入一个100以内的分数（含小数），判断是否及格。输入数字不符合提示“输入不正确”
        double x;
        Console.WriteLine( "输入一个100以内的分数（含小数）");
   x=Convert.ToDouble( Console.ReadLine());
   if(x>=0 && x<60)
     Console.WriteLine("不及格");
   else
   {    
     if(x>=60 && x<=100)
       Console.WriteLine("及格");
     else
       Console.WriteLine("输入不正确");
    }
    Console.ReadKey();
   //题目：用while语句求50:100奇数的累加和。并打印循环变量的初值和终值
   int i, sum;
    i=50;
   sum=0;
   while(i<=100)
   {
     if(i%2==1)
     {
       sum+=i;
      }
i++;
   }
   Console.WriteLine("50:100奇数的累加和"+sum);
   Console.WriteLine("初值"+51);
   Console.WriteLine("终值"+99);
   Console.ReadKey();
   //题目：用for语句求50:100奇数的累加和。并打印循环变量的初值和终值
   int a, sum1;
a=50;
   sum1=0;
   for(a=50;a<=100;a++)
   {
     if(a%2==1)
     {
     sum1+=a;
     }
 
   }
   Console.WriteLine("50:100奇数的累加和"+sum1);
   Console.WriteLine("初值"+51);
   Console.WriteLine("终值"+99);
   Console.ReadKey();
   //题目：输入1:7返回对应的星期数
   int m;
            m= Convert.ToInt32(Console.ReadLine());
            switch (m)
   {
      case 1:  Console.WriteLine("星期一");break;
      case 2:  Console.WriteLine("星期二");break;
      case 3:  Console.WriteLine("星期三");break;
      case 4:  Console.WriteLine("星期四");break;
      case 5:  Console.WriteLine("星期五");break;
      case 6:  Console.WriteLine("星期六");break;
      case 7:  Console.WriteLine("星期日");break;
   }
   Console.ReadKey();
        }
    }
}
