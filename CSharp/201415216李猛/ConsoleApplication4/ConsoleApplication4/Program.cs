using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t九九乘法表");
            for (int i = 9; i >0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}*{1}={2}\t", i, j, i * j);
                }
                Console.WriteLine();


                
                    for(int i=0;i <=7;i ++)
                    {
                        for( int j=4;j >=i+1;j--)
                        {
                            Console.Write ("");
                        }
                        for (int k=1;k<(i +1)*2;k++)
                        {
                            Console.Write ("*");
                        }
                       Console .WriteLine();



                        for (int i=0;i <=4;i ++)
                        {for (int  j=8;j>=i +1;j--)
                        {Console .Write ("");
                        }
                            for (int  k=1;k <(i +1)*2;k ++)
                            {
                                Console .Write ("*");
                            }
                            Console.WriteLine();

                    }
        }
    }
}
