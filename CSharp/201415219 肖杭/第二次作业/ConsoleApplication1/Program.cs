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
            //肖杭  201415219
            //第二周作业  9月9日
            //作业题1
            int i,n,t;
            for(i=9;i>=1;i--)
            {
                for (n = i; n >= 1; n--)
                {
                    t = n * i;
                    Console.Write("{0}*{1}={2} ", i, n, t);
                 }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
            //作业题第二题第四个
            int i, n, t;
            for (i = 7; i > 0; i -= 2)
            {
                for (t = 0; t < 7 - i; t += 2)
                {
                    Console.Write("  ");
                }
                for (n = 0; n < i; n++)
                {
                    Console.Write("*");
                }

                Console.Write("\n\n");
            }
            Console.ReadKey();
            //作业题第三题4
            int i, n, t;
            for (i = 5; i > 0; i--)
            {
                if (i % 2 != 0)
                {
                    Console.Write("########");
                }
                if (i % 2 == 0)
                {
                    Console.Write("********");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
