using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    201415118 陈伟class Program
    {
        static void Main(string[] args)
        {//输出结果
            Console.WriteLine("让编程改变世界！");
            //让程序停在显示界面
            Console.ReadKey();
        }
    //提示用户输入一个10000内的数字
            Console.WriteLine("输入一个10000以内的整数");
            
           {
                            //将输入数字付给a

                int a = Convert.ToInt32(Console.ReadLine());
                //进行判断并进行输出
                if (a < 3000)
                    Console.WriteLine("输入数字小于3000");
                else
                    Console.WriteLine("输入大于等于3000");
            }
            catch
            {
                Console.WriteLine("输入不正确");
            }
            Console.ReadKey();
    //声明一个变量sum为0
            int sum = 0;
            //进行1：50的循环
            for(int i=1;i<=50;i++)
            {
                //判断是否能被3整除
                if (i % 3 != 0)
                    sum += i;
            }
            //进行输出
            Console.WriteLine("1：50中不能被3整除的数的和为" + sum);
            Console.ReadKey();
    //提示输入月份
            Console.Write("请输入月份：");
            //将输入的月份进行判断
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
            //输出结果
            Console.WriteLine("{0}月有{1}天", mouth,day);
            Console.ReadKey();
}
