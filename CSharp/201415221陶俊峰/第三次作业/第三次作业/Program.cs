using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 第三次作业
{
    class Program
    {
        //姓名：陶俊峰
        //学号：201415221
        //日期：2016.09.12
        //题目：读入文件中的股票文件找到当天的最高价最低价
        //      计算文件某一天的成交量的累积值
        //      读入股票文件找到当天的开盘价和收盘价（即第一个价格和最后一个价格）
        static void Main(string[] args)
        {
            string[] dir = Directory.GetFileSystemEntries(@"C:\Users\pc\Desktop\source2");  //读取文件路径
            foreach (string f in dir)
            {
                string[] fName = Directory.GetFiles(f , "*.csv" );  //读取文件夹中 csv 格式文件
                foreach (string f2 in fName)
                {
                    FileStream myFile = new FileStream(f2,FileMode.Open);  //打开文件
                    StreamReader sr = new StreamReader(myFile);   //读取内容
                    string[] stringArray;
                    char[] charArray = new char[] {','};   //csv默认分隔符‘,’
                    string line = sr.ReadLine();   //单次读取一行
                    double maxPrise = 0;
                    double minPrise = 1000;
                    double sumVolume = 0;
                    double openPrise = Convert.ToDouble(line.Split(charArray, StringSplitOptions.RemoveEmptyEntries)[2]);  //读取开盘价
                    double closePrise = 0;
                    while (line != null)
                    {
                        stringArray = line.Split(charArray, StringSplitOptions.RemoveEmptyEntries);  //按分隔符将一行分成字符串组
                        if (Convert.ToDouble(stringArray[3]) > maxPrise)
                        {
                            maxPrise = Convert.ToDouble(stringArray[3]);  //最大值
                        }
                        if (Convert.ToDouble(stringArray[4]) < minPrise)
                        {
                            if (Convert.ToDouble(stringArray[4]) != 0)
                            {
                                minPrise = Convert.ToDouble(stringArray[4]);    //最小值
                            }
                        }
                        sumVolume += Convert.ToDouble(stringArray[8]);     //求每天交易量累计值
                        closePrise = Convert.ToDouble(stringArray[2]);    //读取收盘价
                        line = sr.ReadLine();
                    }
                    sr.Close();   //每次读完 关闭文件
                    Console.WriteLine((Path.GetFileName(f2).Substring(7,8)) + "最高价:" + maxPrise + "最低价:" + minPrise + 
                                       "累计交易量:" + sumVolume + "开盘价:" + openPrise + "收盘价:" + closePrise);
                    StreamWriter sw = new StreamWriter(f + "/result.txt", true);
                    sw.WriteLine((Path.GetFileName(f2).Substring(7,8)) + "最高价:" + maxPrise + "最低价:" + minPrise + 
                                       "累计交易量:" + sumVolume + "开盘价:" + openPrise + "收盘价:" + closePrise);
                    sw.Close();   //每次写完 关闭文件
                }
            }
            Console.ReadKey();
        }
    }
}
