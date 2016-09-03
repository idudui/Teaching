using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一周作业
{
    class Program
    {
        static void Main(string[] args)
        {
            //Output text to the screen. 
            Console.WriteLine("\"欢迎学习c#语言！\"");
                Console.ReadKey();
            //输入一个100以内的分数（含小数）.
                double x;
                Console.WriteLine("请输入一个100以内的分数");
                x = Convert.ToDouble(Console.ReadLine());
            //判断是否及格.
                if (x <60)
                    Console.WriteLine("输入不正确");
                Console.ReadLine();
            //用while实现如下功能.
                int m1 = 50,i=1,sum1=0;
                Console.WriteLine("初值：{0}", m1);
            do
            {
                m1+=i;
                if(m1%2==1)//判断m是否为奇数
                    sum1+=m1;
            }
                    while(m1<=100);
            Console.WriteLine("终值:{0}",m1);
            Console.WriteLine("和:{0}",sum1);
            //用for实现如下功能.
           int m2 = 50, sum2 = 0;
           Console.WriteLine("初值:{0}",m2);
           for (i = 1; m2 <= 100; m2 += i)
           {
               if (m2 % 2 == 1)
               {
                   sum2 += m2;
               }
               continue;
           }
           Console.WriteLine("终值:{0}", m2);
           Console.WriteLine("和:{0}", m2);
           Console.ReadLine();
            //输入1：7返回对应的星期数.
           Console.WriteLine("输入一个1到7的数字");
           int num;
            num=Convert.ToInt32(Console.ReadLine());
            switch(num)
           {
             case 1:
                   Console.WriteLine("星期一");
                break;
             case 2:
                Console.WriteLine("星期二");
                break;
             case 3:
            Console.WriteLine("星期三");
            break;
             case 4:
            Console.WriteLine("星期四");
            break;
             case 5:
            Console.WriteLine("星期五");
            break;
             case 6:
            Console.WriteLine("星期六");
            break;
             case 7:
            Console.WriteLine("星期日");
            break;
           }
            Console.ReadKey();









        }

    }
}
