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

            //作者：吴小月 日期：2016.9.3
            //要求：输出“好好学习 天天向上！”
            string mystring;
            mystring = "好好学习，天天向上";
            Console.WriteLine("{0}", mystring);
            Console.ReadKey();

            //作者：吴小月 日期：2016.9.3
            //要求：输入一个10000以内的整数，判断其平方是否能被3整除。输入数字不符合提示“输入不正确”

            int n, m, i;
            Console.WriteLine("请输入一个10000以内的整数:");
            n = Convert.ToInt32(Console.ReadLine());
            m = n * n;
            i = m % 3;
            if (i != 0)
            {
                Console.WriteLine("输入不正确");

            }
            Console.WriteLine("The number is{0}.", n);
            Console.ReadKey();


            //作者：吴小月 日期：2016.9.3
            /*用while实现如下功能。（要求：打印的循环变量的初值必须为1，终值为100。提示：使用break和continue）
              求50:100能被7整除的数的和。并打印循环变量的初值和终值.  */

            int a, b;
            a = 50;
            b = 0;
            while (a > 100)
            {
                if (a % 7 == 0)
                    b = b + a;
                a++;
                Console.WriteLine("50：100中不能被3整除的数的和为:{0}", b);
                Console.ReadKey();
            }
            //作者：吴小月 日期：2016.9.3
            /*用for实现如下功能。（要求：打印的循环变量的初值必须为1，终值为100。提示：使用break和continue）
              求50:100能被7整除的数的和。并打印循环变量的初值和终值.  */


            for (a = 50; a <= 100; a++)
            {
                if (a % 7 == 0)
                    b = b + a;
            }
            Console.WriteLine("50：100中不能被3整除的数的和为:{0}", b);
            Console.ReadKey();

            //作者：吴小月 日期：2016.9.3
            //输入10以内整数返回是奇数还是偶数

            int x;
            Console.WriteLine("请输入一个10以内的整数:");
            x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("该数是偶数");

            }
            else
            {
                Console.WriteLine("该数是奇数");
            }

            Console.ReadKey();
        }
    }
}
