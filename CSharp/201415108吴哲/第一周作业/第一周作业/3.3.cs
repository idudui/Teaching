using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一周作业
{
    class _3
    {
        ////////////////////////////
        //用while实现:求1:50不能被3整除的数的和。并打印循环变量的初值和终值
        //////////////////////////////////////////////////////
        static void Main(string[] args)
        {
            //声明一个变量sum为0
            int sum=0;
            //声明一个变量i为1
            int i=1;
            //进行循环，从1：50
            Console.WriteLine("初值为" + i);
            while(i<100)
            {
                if (i == 1)
                    sum += i;
                i++;
                //判断是否能被3整除，不能的话进行迭加
                if (i % 3 != 0)
                {
                    if (i > 50)
                        continue;
                    sum += i;
                }
            }
            Console.WriteLine("终值为" + i);
            //进行输出
            Console.WriteLine("1：50中不能被3整除的数的和为" + sum);
            Console.ReadKey();
        }
    }
}
