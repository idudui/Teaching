using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //1、实现小猫叫；

        private void button1_Click(object sender, EventArgs e)
        {
            Cat mycat = new Cat("小黑");

            mycat.ShoutNum = 20;
            MessageBox.Show(mycat.Shout());
        }

        Animal[] arrayAnimal;

        private void button1_Click_1(object sender, EventArgs e)
        {
            //定义一个Animal类型的数组；
            arrayAnimal = new Animal[2];
            arrayAnimal[0] = new Cat("小花");
            arrayAnimal[1] = new Dog("阿毛");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //1、遍历Animal数组，调用Shout方法
            //foreach (int i in i数组)
            foreach (Animal i in arrayAnimal)
            {
 
                //2、调用父类虚方法，实际执行的是子类重写过的方法
                MessageBox.Show(i.Shout());
            }
        }

        //用函数实现小猫叫
        

    }

    

}
