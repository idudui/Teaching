using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 文件操作
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"G:\600958");
            Directory.CreateDirectory(@"G:\601088");
           // FileStream file1 = File.Create(@"G:\600958\");
           // FileStream file2 = File.Create(@"G:\601088\");
            string path = @"G:\source";
            foreach(string folders in Directory.GetDirectories(path))
            {
                foreach(string files in Directory.GetFiles(folders))
                {
                    if(files.Contains("600958"))
                    {
                        //FileInfo fi = new FileInfo(files);
                        File.Copy(files,@"G:\600958\"+Path.GetFileName(files),true);
                    }
                     if(files.Contains("601088"))
                    {
                        //FileInfo fi = new FileInfo(files);
                        File.Copy(files, @"G:\601088\" + Path.GetFileName(files),true);
                    }
                }
            }
            Console.WriteLine("文件复制成功");
            Console.Read();
        }
    }
}
