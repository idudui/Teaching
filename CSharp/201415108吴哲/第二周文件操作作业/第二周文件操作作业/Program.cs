using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 第二周文件操作作业
{
    class Program
    {
        //1、把文件中的按日期存储的文件转换为按股票文件存储（一个股票一个文件夹）
        static void Main(string[] args)
        {
            //指定文件夹路径和结果文件夹路径
            string zpath = @"G:\C#作业\C#提高\source";
            string jgpath = zpath + "\\结果";
            string jgpath1 = jgpath + "\\600958";
            string jgpath2 = jgpath + "\\601088";
            string jgpath3 = jgpath + "\\001";
            string jgpath4 = jgpath + "\\002";
            Console.WriteLine(jgpath);
            //判断路径是否存在，存在后进行一系列操作
            if (Directory.Exists(zpath))
            {
                //判断结果文件夹是否存在，创建后进行子文件夹的创建
                if (!Directory.Exists(jgpath))
                {
                    Directory.CreateDirectory(jgpath);
                    Directory.CreateDirectory(jgpath1);
                    Directory.CreateDirectory(jgpath2);
                    Directory.CreateDirectory(jgpath3);
                    Directory.CreateDirectory(jgpath4);

                }
                //遍历读取所有文件夹及其中的文件
                string[] path = Directory.GetDirectories(zpath);
                foreach (string path1 in path)
                {
                    string[] fileName = Directory.GetFiles(path1);
                    foreach (string item in fileName)
                    {
                        //进行判断，把股票安股票号分别复制到相应的文件夹中
                        string itemName = "\\" + Path.GetFileNameWithoutExtension(item) + ".csv";
                        if (item.Contains("600958"))
                            File.Copy(item, jgpath1 + itemName);
                        if (item.Contains("601088"))
                            File.Copy(item, jgpath2 + itemName);
                        if (item.Contains("001"))
                            File.Copy(item, jgpath3 + itemName);
                        if (item.Contains("002"))
                            File.Copy(item, jgpath4 + itemName);
                        Console.WriteLine(itemName.Substring(1) + "处理成功");
                    }
                }
            }
            else
                Console.WriteLine("文件夹不存在！请输入正确文件夹地址");
            Console.ReadKey();
        }
    }
}
