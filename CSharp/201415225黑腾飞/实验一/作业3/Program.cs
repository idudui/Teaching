using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业3//实验一：三.5 求55：88的累加和
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = 55;
            int sum1 = 0;
            while(a1>54 && a1<=88)
            {
                sum1 += a1;
            a1++;
            }
        }
        Console.Writeline("55:88的累加和为"  sum1);
    }
}
