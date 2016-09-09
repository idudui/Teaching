using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class program
    {
        static void Main(string[] args)
        {
            //输出
            Console.WriteLine("让编程改变世界！");



            //提示输入一个10000内的数字
            Console.WriteLine("输入一个10000以内的整数");
            //声明变量并赋值
            int a = Convert.ToInt32(Console.ReadLine());
            //进行判断和输出
            if (a < 3000)
                Console.WriteLine("输入数字小于3000");
            else if (a >= 3000 && a < 10000)
                Console.WriteLine("输入大于等于3000");
            else
                Console.WriteLine("输入不正确");
            //声明变量sum为0
            int sum = 0;
            //建立一个1：50的循环
            for (int i = 1; i <= 50; i++)
            {
                if (i == 1)
                    Console.WriteLine("初值为"+i);
                //判断是否能被3整除
                if (i % 3 != 0)
                    sum += i;
                if (i == 50)
                    Console.WriteLine("终值为" + i);
            }
            //进行输出
            Console.WriteLine("1：50中不能被3整除的数的和为" + sum);

            //提示用户输入月份
            Console.Write("请输入月份：");
            //将月份进行判断
            int mouth = Convert.ToInt32(Console.ReadLine());
            //声明变量day
            int day = 0;
            //选择
            switch (mouth)
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
            //输出结果
            Console.WriteLine(mouth + "月有" + day + "天");
            Console.ReadKey();
        }
    }
}