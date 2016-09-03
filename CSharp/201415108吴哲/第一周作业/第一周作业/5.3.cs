using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一周作业
{
    class _5
    {
        ////////////////////////////////////
        //输入一个月份（1:12）返回该月有几天。2月按28天
        ////////////////////////////////////////
        static void Main(string[] args)
        {
            //提示输入月份
            Console.Write("请输入月份：");
            //将输入的月份变成数值进行判断
            int mouth = Convert.ToInt32(Console.ReadLine());
            //定义变量day
            int day = 0;
            //进行选择
            switch(mouth)
            {
                case 1: day = 31; break;
                case 2: day = 28; break;
                case 3: day = 31; break;
                case 4: day = 30; break;
                case 5: day = 31; break;
                case 6: day = 30; break;
                case 7: day = 31; break;
                case 8: day = 31; break;
                case 9: day = 30; break;
                case 10: day = 31; break;
                case 11: day = 30; break;
                case 12: day = 31; break;
            }
            //输出
            Console.WriteLine("{0}月有{1}天", mouth,day);
            Console.ReadKey();
        }
    }
}
