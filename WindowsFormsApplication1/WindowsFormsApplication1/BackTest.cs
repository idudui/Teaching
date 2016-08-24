using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class BackTest : Form
    {
        //目标：只对一只股票的信号进行处理
        //1、读入文件：result\config
        //2、把config存到字符串里
        //3、取result文件，进行遍历；
        //4、把相应的信号取出来,进行相应的赋值；价格、时间；
        //5、对每个信号进行分类判断




        public BackTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //0、在这个位置加所有股票遍历
            string[] stocks = Directory.GetDirectories(@"D:\信息系统分析与设计\2015-2016\作业\第五周作业");

            //新开一个线程
            //Task t = Task.Factory.StartNew(new Action(() =>
            //{
            foreach(string stockpath in stocks) //stock是每个文件夹的路径
            {
                //1、读入文件：result\config
                //"D:\信息系统分析与设计\2015-2016\作业\第五周作业\600958\600958_result.txt"
                // stock + "\\" + 股票代码 + _result.txt 
                string stockName = stockpath.Substring(32, 6);//获得股票代码，方法可以进一步优化；
                StreamReader sr1 = new StreamReader(stockpath + "\\" + stockName + "_result.txt");//sr1：result
                StreamReader sr2 = new StreamReader(stockpath + "\\" + stockName + "_config.txt");//sr1：config
                StreamReader sr3;
                
                //2、把config存到字符串里
                string config = sr2.ReadLine();
                double timespan, profit, entryPrice, exitPrice, exitPrice2;
                timespan = double.Parse(config.Split(',')[1]);
                profit = double.Parse(config.Split(',')[0]);
                //3、取result文件，进行遍历；
                string str1 = "", str2 = "", temp;
                DateTime dtEntry, dtExit, dtMorning, dtExit2, dtExit3;
                bool b1;

                //把信号文件读取出来，逐行遍历
                while ((str1 = sr1.ReadLine()) != null)
                {
                    //temp = str1.Split(',')[0];//20160225141151.00
                    //信号对应入场时间 强平时间，出入场价格等；
                    dtEntry = DateTime.ParseExact(str1.Split(',')[0], "yyyyMMddHHmmss.ff", System.Globalization.CultureInfo.InvariantCulture);
                    dtExit = dtEntry.AddMinutes(timespan);
                    dtExit2 = dtEntry.AddMinutes(timespan + 90); //针对11点到11点半的信号的出场时间
                    dtExit3 = dtEntry.AddMinutes(timespan + 1110); //针对11点到11点半的信号的出场时间
                    entryPrice = double.Parse(str1.Split(',')[2]);
                    exitPrice = entryPrice + profit;
                    exitPrice2 = entryPrice - 2 * profit;

                    //行情文件日期
                    string strHQDate = str1.Split(',')[0].Substring(0, 8);

                    int intEntry = int.Parse(dtEntry.ToString("HHmmss"));

                    //1、9点到11点的信号回测
                    if (intEntry > int.Parse("093000") && intEntry < int.Parse("110000"))
                    {
                        BTest1(dtEntry, dtExit, dtExit2, entryPrice, exitPrice, exitPrice2, strHQDate);
                    }
                    //2、11点到11点半的信号回测
                    if (intEntry > int.Parse("110000") && intEntry < int.Parse("113000"))
                    {
                        BTest2(dtEntry, dtExit, dtExit2, entryPrice, exitPrice, exitPrice2, strHQDate);
                    }
                    //3、13点到14点半的信号回测
                    if (intEntry > int.Parse("130000") && intEntry < int.Parse("143000"))
                    {
                        BTest1(dtEntry, dtExit, dtExit2, entryPrice, exitPrice, exitPrice2, strHQDate);
                    }
                    //4、14点半到15点的信号回测
                    if (intEntry > int.Parse("143000") && intEntry < int.Parse("150000"))
                    {
                        BTest3(dtEntry, dtExit, dtExit3, entryPrice, exitPrice, exitPrice2, strHQDate,stockpath,stockName);

                    }

                }
                 
            }
            

            

            

        }












        //定义一个方法，目的：对跨天信号进行回测
        //输入：信号的相关内容：入场时间 入场价格 强平时间 止盈价格 止损价格；  
        //      行情的相关内容：行情的日期（可以用来拼行情路径）；
        //输出：直接在函数进行文件打印；
        public static void BTest3(
            DateTime dtEntry, DateTime dtExit, DateTime dtExit3,
            double entryPrice, double exitPrice, double exitPrice2,
            string strHQDate,string stockpath,string stockName
            )
        {
            StreamWriter sw1 = new StreamWriter(stockpath + "_backtest.txt");
            StreamReader sr3 = new StreamReader(stockpath +"\\"+ stockName + "_"+ strHQDate + ".csv");
            string str2;  //记录每一行行情信息
            DateTime strHQTime; //记录每一行行情时间
            Double dbHQPrice;//记录每一行行情价格
            bool b1 = false;

            //信号时间大于9点，小于11点，进行相应处理

            //一、当天文件处理
            while ((str2 = sr3.ReadLine()) != null)//对行情文件进行逐一遍历
            {
                //记录行情的时间
                strHQTime = DateTime.ParseExact(str2.Split(',')[1], "yyyyMMddHHmmss.ff", System.Globalization.CultureInfo.InvariantCulture);
                //记录行情的价格
                dbHQPrice = double.Parse(str2.Split(',')[2]);
                //6.1.1 如果当前时间大于dtExit,停止循环；

                if (strHQTime <= dtEntry) //行情小于进场时间；
                {
                    continue;
                }



                //1、止盈
                if (dbHQPrice > exitPrice)  //行情价格>止盈价格；
                {
                    //记录出场信息；
                    sw1.WriteLine("出场时间:" + strHQTime + "出场价格：" + dbHQPrice + "止盈出场");
                    b1 = true;
                    break;

                }
                //2、止损
                if (dbHQPrice < exitPrice2)  //行情价格<止损价格；
                {
                    //记录出场信息；
                    sw1.WriteLine("出场时间:" + strHQTime + "出场价格：" + dbHQPrice + "止损出场");
                    b1 = true; 
                    break;
                }
                




            }

            strHQDate = (int.Parse(strHQDate) + 1).ToString();
            sr3 = new StreamReader(stockpath + "\\" + stockName+ "_" + strHQDate + ".csv");
            

            //二、处理第二天的行情!!!注意第二天是否需要判断
            if(b1==false)
            {
                while ((str2 = sr3.ReadLine()) != null)//对行情文件进行逐一遍历
            {
                //记录行情的时间
                strHQTime = DateTime.ParseExact(str2.Split(',')[1], "yyyyMMddHHmmss.ff", System.Globalization.CultureInfo.InvariantCulture);
                //记录行情的价格
                dbHQPrice = double.Parse(str2.Split(',')[2]);
                //6.1.1 如果当前时间大于dtExit,停止循环；

                if (strHQTime <= dtEntry) //行情小于进场时间；
                {
                    continue;
                }



                //1、止盈
                if (dbHQPrice > exitPrice)  //行情价格>止盈价格；
                {
                    //记录出场信息；
                    sw1.WriteLine("出场时间:" + strHQTime + "出场价格：" + dbHQPrice + "止盈出场");
                    b1 = true;
                    break;

                }
                //2、止损
                if (dbHQPrice < exitPrice2)  //行情价格<止损价格；
                {
                    //记录出场信息；
                    sw1.WriteLine("出场时间:" + strHQTime + "出场价格：" + dbHQPrice + "止损出场");
                    b1 = true;
                    break;
                }
                //3、按时间平仓,
                if (strHQTime >= dtExit3)  //行情时间大于出场时间；
                {
                    //记录按时间出场的相关内容
                    sw1.WriteLine("出场时间:" + strHQTime + "出场价格：" + dbHQPrice + "按时间强平");
                    b1 = true; 
                    break;
                }





            }

            }
            

            sw1.Close();

        }




        //定义一个方法，目的：输入信号，对信号在行情中进行回测，输出相应的结果；
        //输入：信号的相关内容：入场时间 入场价格 强平时间 止盈价格 止损价格；  
        //      行情的相关内容：行情的日期（可以用来拼行情路径）；
        //输出：直接在函数进行文件打印；
        public static void BTest1(
            DateTime dtEntry, DateTime dtExit, DateTime dtExit2,
            double entryPrice, double exitPrice,double exitPrice2,
            string strHQDate
            )
        {
            StreamWriter sw1 = new StreamWriter(@"D:\信息系统分析与设计\2015-2016\作业\第五周作业\600958_backtest.txt");
            StreamReader sr3 = new StreamReader(@"D:\信息系统分析与设计\2015-2016\作业\第五周作业\600958_" + strHQDate + ".csv");
            string str2;  //记录每一行行情信息
            DateTime strHQTime; //记录每一行行情时间
            Double dbHQPrice;//记录每一行行情价格
            

            //信号时间大于9点，小于11点，进行相应处理
            

                while ((str2 = sr3.ReadLine()) != null)//对行情文件进行逐一遍历
                {
                    //记录行情的时间
                    strHQTime = DateTime.ParseExact(str2.Split(',')[1], "yyyyMMddHHmmss.ff", System.Globalization.CultureInfo.InvariantCulture);
                    //记录行情的价格
                    dbHQPrice = double.Parse(str2.Split(',')[2]);
                    //6.1.1 如果当前时间大于dtExit,停止循环；

                    if (strHQTime <= dtEntry) //行情小于进场时间；
                    {
                        continue;
                    }



                    //1、止盈
                    if (dbHQPrice > exitPrice)  //行情价格>止盈价格；
                    {
                        //记录出场信息；
                        sw1.WriteLine("出场时间:" + strHQTime + "出场价格：" + dbHQPrice + "止盈出场");
                        break;
                    }
                    //2、止损
                    if (dbHQPrice < exitPrice2)  //行情价格<止损价格；
                    {
                        //记录出场信息；
                        sw1.WriteLine("出场时间:" + strHQTime + "出场价格：" + dbHQPrice + "止损出场");
                        break;
                    }
                    //3、按时间平仓,判断时间是否属于11点到11点半
                    if (strHQTime >= dtExit )  //行情时间大于出场时间；
                    {
                        //记录按时间出场的相关内容
                        sw1.WriteLine("出场时间:" + strHQTime + "出场价格：" + dbHQPrice + "按时间强平");
                        break;
                    }



                
            }

            sw1.Close();
 
        }

        public static void BTest2(
            DateTime dtEntry, DateTime dtExit, DateTime dtExit2,
            double entryPrice, double exitPrice, double exitPrice2,
            string strHQDate
            )
        {
            StreamWriter sw1 = new StreamWriter(@"D:\信息系统分析与设计\2015-2016\作业\第五周作业\600958_backtest.txt");
            StreamReader sr3 = new StreamReader(@"D:\信息系统分析与设计\2015-2016\作业\第五周作业\600958_" + strHQDate + ".csv");
            string str2;  //记录每一行行情信息
            DateTime strHQTime; //记录每一行行情时间
            Double dbHQPrice;//记录每一行行情价格


            //信号时间大于9点，小于11点，进行相应处理


            while ((str2 = sr3.ReadLine()) != null)//对行情文件进行逐一遍历
            {
                //记录行情的时间
                strHQTime = DateTime.ParseExact(str2.Split(',')[1], "yyyyMMddHHmmss.ff", System.Globalization.CultureInfo.InvariantCulture);
                //记录行情的价格
                dbHQPrice = double.Parse(str2.Split(',')[2]);
                //6.1.1 如果当前时间大于dtExit,停止循环；

                if (strHQTime <= dtEntry) //行情小于进场时间；
                {
                    continue;
                }



                //1、止盈
                if (dbHQPrice > exitPrice)  //行情价格>止盈价格；
                {
                    //记录出场信息；
                    sw1.WriteLine("出场时间:" + strHQTime + "出场价格：" + dbHQPrice + "止盈出场");
                    break;
                }
                //2、止损
                if (dbHQPrice < exitPrice2)  //行情价格<止损价格；
                {
                    //记录出场信息；
                    sw1.WriteLine("出场时间:" + strHQTime + "出场价格：" + dbHQPrice + "止损出场");
                    break;
                }
                //3、按时间平仓,判断时间是否属于11点到11点半
                if (strHQTime >= dtExit2)  //行情时间大于出场时间；
                {
                    //记录按时间出场的相关内容
                    sw1.WriteLine("出场时间:" + strHQTime + "出场价格：" + dbHQPrice + "按时间强平");
                    break;
                }




            }

            sw1.Close();

        }
        public static void BTest4(){}




    }
}
