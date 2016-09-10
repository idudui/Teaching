using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 第二次作业
{
    class Program
    {
        //姓名：陶俊峰
        //学号：201415221
        //日期：2016.9.9
        //题目：把文件中的按日期存储的文件转换为按股票文件存储（一个股票一个文件夹）
        static void Main(string[] args)
        {
            string[] dir = Directory.GetFileSystemEntries(@"C:\Users\pc\Desktop\source");   //读取指定路径下路径名
            string d1 = "600958";
            string d2 = "601088";
            Directory.CreateDirectory(@"C:\Users\pc\Desktop\source2\600958");
            Directory.CreateDirectory(@"C:\Users\pc\Desktop\source2\601088");
            foreach (string f in dir)          //依次处理文件
            {
                string[] fname = Directory.GetFiles(f);              //读取指定路径下文件名
                for (int i = 0; i < fname.Length; i++)
                {
                    if (fname[i].IndexOf(d1) > -1)     //判断文件名中是否包括股票名
                    {
                        File.Copy(fname[i], @"C:\Users\pc\Desktop\source2\600958\" + Path.GetFileName(fname[i]), true);  //复制文件到新路径
                        Console.WriteLine("复制" + fname[i] + "\n到" + @"C:\Users\pc\Desktop\source2\600958\" + Path.GetFileName(fname[i]));
                    }
                    if (fname[i].IndexOf(d2) > -1)
                    {
                        File.Copy(fname[i], @"C:\Users\pc\Desktop\source2\601088\" + Path.GetFileName(fname[i]), true);
                        Console.WriteLine("复制" + fname[i] + "\n到" + @"C:\Users\pc\Desktop\source2\601088\" + Path.GetFileName(fname[i]));
                    }
                }

            }
            Console.WriteLine("\n操作完成");
            Console.ReadKey();
        }
    }
}
