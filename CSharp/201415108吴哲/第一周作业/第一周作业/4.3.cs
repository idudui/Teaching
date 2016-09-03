using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一周作业
{
    class _4
    {
        ////////////////////////////
        //用for实现:求1:50不能被3整除的数的和。并打印循环变量的初值和终值
        //////////////////////////////////////////////////////

        static void Main(string[] args)
        {
            //声明一个变量sum为0
            int sum = 0;
            //进行1：50的循环
            for(int i=1;i<=50;i++)
            {
                //判断是否能被3整除，不能的话进行迭加
                if (i % 3 != 0)
                    sum += i;
            }
            //进行输出
            Console.WriteLine("1：50中不能被3整除的数的和为" + sum);
            Console.ReadKey();
        }
    }
}
