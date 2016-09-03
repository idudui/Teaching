using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业4//实验一：四.5 求55：88的累加和
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum2 = 0;
            for (int a2 = 55;
                a2 > 54 && a2 <= 88;a2++)
            {
                sum2 += a2;
            }
        }
        Console.WriteLine("55:88的累加和为" sum2 );
    }
}
