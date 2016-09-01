using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一周作业
{
    class Class1
    {
        ///////////////////////////////////////////
        //输入一个10000以内的整数，判断是否大于3000。输入数字不符合提示“输入不正确”
        //////////////////////////////////////////////////
        static void Main(string[] args)
        {
            //提示用户输入一个10000内的数字
            Console.WriteLine("输入一个10000以内的整数");
            try//扑获异常
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

        }
    }
}
