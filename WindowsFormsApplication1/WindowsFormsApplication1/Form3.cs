using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//添加命名空间
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //批处理拷贝文件：拷贝文件夹下所有文件
            string[] files = Directory.GetFiles("D:\\信息系统分析与设计\\2015-2016\\拷贝文件夹");
            

            //拷贝
            //for (int i = 0; i < files.Length; i++)
            //{
            //    //取文件名
            //    string fileName = Path.GetFileName(files[i]);
            //    //File.Copy("D:\\信息系统分析与设计\\2015-2016\\拷贝文件测试.txt", "D:\\拷贝文件测试.txt", true);
            //    File.Copy(files[i], "D:\\拷贝目标文件夹\\" + fileName);
        

 
            //}

            //删除
            //for (int i = 0; i < files.Length; i++)
            //foreach(string s in files)

            //{
            //    //取文件名
            //    string fileName = Path.GetFileName(files[i]);
            //    //File.Copy("D:\\信息系统分析与设计\\2015-2016\\拷贝文件测试.txt", "D:\\拷贝文件测试.txt", true);
            //    //File.Copy(files[i], "D:\\拷贝目标文件夹\\" + fileName);
            //    File.Delete("D:\\信息系统分析与设计\\2015-2016\\拷贝文件夹\\" + fileName);
        

 
            //}
            //按行读取读取文件
            StreamReader sr = new StreamReader("D:\\信息系统分析与设计\\2015-2016\\拷贝文件夹\\1.txt");
            string sLine = "";

            while ((sLine = sr.ReadLine()) != null) //关键代码：遍历
            {
                MessageBox.Show(sLine);
            }

 


            //File.Copy("D:\\信息系统分析与设计\\2015-2016\\拷贝文件测试.txt", "D:\\拷贝文件测试.txt",true);
        }
    }
}