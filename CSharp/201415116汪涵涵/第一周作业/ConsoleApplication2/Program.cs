using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  一、简单入门
1输出“hello word！”
*/
                Console.WriteLine("hello word");
                Console.ReadLine();

            /*  二、if语句
  1 输入一个10以内整数，判断是否是能被2整除。输入数字不符合提示“输入不正确”
  */
            int i = 0;
for ( i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i.ToString() + "可以被10整除");
else
Console.WriteLine("输入不正确");
            }
            Console.ReadLine();
            /*  三、分别用while和for实现如下功能。（要求：打印的循环变量的初值必须为1，终值为100。提示：使用break和continue）
  1 求1: 50偶数的累加和。并打印循环变量的初值和终值
  while
  */
            int a = 0, b = 0;
            Console.WriteLine("初值是{0}", a + 1);
            while (a <= 50)
            {
                b += a;
                a += 2;
            }
            Console.WriteLine("终值是{0}", a-2 );
            Console.WriteLine("1-50之间的偶数和为{0}", b);
                Console.ReadLine();

            /*  for循环
             */
            int sum = 0;
            int j = 1;
            Console.WriteLine("初值是{0}", j);
            for ( j = 1; j <= 50; j++)
                    {
                        if (j % 2 == 0)
                        {
                            sum += j;
                        }
                    }
            Console.WriteLine("终值是{0}", j-1);
            Console.WriteLine("1-50之间的偶数和为{0}", sum);
                Console.ReadLine();

                /*  五、用switch（case）实现以下功能
  1输入一个月份(1:12)返回对应季节。
  */
                int month;
                Console.WriteLine("输入一个月份:");
                month = Convert.ToInt32(Console.ReadLine());
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Winter");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Autumn");
                    break;
                   }  
           Console.ReadKey();
                }
            }
}
