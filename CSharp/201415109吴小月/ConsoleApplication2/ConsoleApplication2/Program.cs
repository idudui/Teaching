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
            //作者：201415109 吴小月 日期：2015.9.9
            /*一、反序打印九九乘法表，即
              9*9=81  8*9=72  7*9=63  6*9=54      ............
              8*8=64  7*8=56  6*8=48    ............
              ......       .......      .......
              1*2=2  2*2=4
              1*1=1  */

            int i, j;
            int m;
            for (j = 9; j >= 1; j--)
            {
                for (i = j; i >= 1; i--)
                {
                    m = j * i ;
                    Console.Write("{0}*{1}={2}", j , i , m);
                    Console.Write("\0");
                }
                Console.Write("\n");
            }
            Console.ReadKey();



            //作者：201415109 吴小月 日期：2015.9.9
            /*二、用循环画图
               4.   *******
                     *****
                       ***
                         *   */

            
            int x,y;
            
            for (x = 7; x > 0; x -= 2)
            {   
                for (y=7;y >=1; y--)
                {
                    if (y > x)

                        Console.Write("\0");
                    else

                        Console.Write("*");
                     
                 }
         
                Console.Write("\n");
            }
            Console.ReadKey();


            //作者：201415109 吴小月 日期：2015.9.9
            /*三、用循环画图  
              4.  ########
                  ********
                  ########
                  ********    */


             int a, b;
            
            for (a = 1; a <= 4; a++)
            {
                for (b = 1; b <= 8; b++)
                {
                    if (a % 2 != 0)
                    
                        
                        Console.Write("#");
                    else
                        
                        Console.Write("*");
                    
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}


