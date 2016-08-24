using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1、写分析
             * 
             */
            
            /*2、写代码*/

            /*3、总结要点*/

            //Console.WriteLine("Hello World!");
            
            //string s1 = Console.ReadLine();


            //string s = Console.ReadLine();

            //switch (Convert.ToInt32(s))
            //{
            //    case 1:
            //        Console.WriteLine("春");
            //        break;
            //    case 2:
            //        Console.WriteLine("夏");
            //        break;
            //    case 3:
            //        Console.WriteLine("秋");
            //        break;
            //    case 4:
            //        Console.WriteLine("冬");
            //        break;
            //}

            

            //if (Convert.ToInt32(s)==1)
            //{
            //    Console.WriteLine("春");
            //}
            //else if (Convert.ToInt32(s) == 2)
            //{
            //    Console.WriteLine("夏");
            //}
            //else if (Convert.ToInt32(s) == 3)
            //{
            //    Console.WriteLine("秋");
            //}
            //else if (Convert.ToInt32(s) == 4)
            //{
            //    Console.WriteLine("冬");
            //}
            //else
            //{
            //    Console.WriteLine("输入错误");
 
            //}


            
            //int i = 8;
            //string s3 = i.ToString();
            //int j = Convert.ToInt32(i);
            //string   s4 = "123";


            //string s2 = "a\"\"bc";
            //string path = "C:\\Documents and Settings\\Administrator\\桌面\\2015-2016";
            //string path2 = @"C:\Documents and Settings\Administrator\桌面\2015-2016";

           

            //if (i > 9)
            //{
            //    Console.WriteLine("{0},字符串1{1}", i = 99, s4 = s4 + "abcde");
            //}
            //else if (i > 5)
            //{
            //    Console.WriteLine("{0},字符串1{1}", i = 99, s4 = s4 + "abcde");
            //}


            //int i = 0;
            int sum = 0;
            //while ( i < 100)
            //{
            //    i++;
            //    sum = sum + i;
                
            //}
            //for (int i= 0; i <= 100; i++)
            //{
                
            //    sum = sum + i;
            //    if (i == 50) break;
 
            //}
            //int maxValue = 0;
            //int[] a = {3,4,5};
            //foreach (int i in a)
            //{
            //    if ( i > maxValue)
            //        maxValue = i ;

            //}




            //for (int i = 0; i <= a.Length -1; i++)
            //{
                
            //    if (a[i] > maxValue)
            //        maxValue = a[i];

            //}

            //    Console.WriteLine();

            //int[] a1 = { 3, 4, 5, 6, 7, 8, 9 };
            //Console.WriteLine(MaxValue(a1));

            //string str1;
            //ReadInt(1,out str1);

            //1、测试ref参数
            //int i = 10;
            //string s1 = "abc def gh";
            //string[] s2 = s1.Split(' ');
            //String.IsNullOrEmpty(s1)
   
            //2、数组转换为char类型数组；处理之后再转换为字符串

            //string s1 = "abc";
            //char[] c1 = s1.ToCharArray();

            //Console.WriteLine(s1);
            //for (int i = 0; i < c1.Length; i++)
            //{
            //    if (c1[i] == 'a') c1[i] = 'A';
            //    if (c1[i] == 'b') c1[i] = 'B';
            //    if (c1[i] == 'c') c1[i] = 'C'; 

            //}
            //s1 = new string(c1);
            //Console.WriteLine(s1);
            //Console.ReadKey();


            //3、大小写转换
            //3.1 接收用户输入的字符串s“admin”
            //3.2 先把s转换为小写；然后和admin比较；
            //3.3 判断是否正确，进行输出；

            

            //3.1 接收用户输入的字符串s“admin”
            //Console.WriteLine("请输入用户名："); 
            //string s = Console.ReadLine();
            //3.2 先把s转换为小写；然后和admin比较；
            //bool b1 = (s.ToLower().Trim() == "admin");
            //3.3 判断是否正确，进行输出；
            //if (s.ToLower().Trim() == "admin")
            //if (s.Equals("admin", StringComparison.OrdinalIgnoreCase))
            //{
            //    Console.WriteLine("用户名输入正确");

            //}
            //else {
            //    Console.WriteLine("用户名输入错误");
            //}
            //Console.ReadLine();

            //4、Format
            //4.1 WriteLine()
            //4.2 用Format

            string s1 = "张三";
            s1 = string.Format("hello world {0}", s1);
            Console.WriteLine(s1);
            Console.ReadLine();






        }

        static int Test(ref int i)
        {
            return i = i * 2;
        }
        
        static int ReadInt(int result, out string str)
        {
            result =1;
            str = "abc";
            String s = Console.ReadLine();
            if (int.TryParse(s, out result))
            {                
                str = "输出正确";
                return Convert.ToInt32(s);
                
            }

            else 
            {
                
                str = "输出错误";
                return -1;
            }


            
        }


        static int MaxValue(int[] a)
        {
            int max = 0;
            foreach (int i in a)
            {
                if (i > max)
                    max = i;

            }
            return max+1;
 
        }

        

    }
}
