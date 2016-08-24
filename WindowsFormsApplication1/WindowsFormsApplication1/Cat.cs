using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{

    class Animal
    {
 
        //1、父类字段定义protected
        protected  int  shoutNum = 0;
        protected string name = "";

        //2、显示的定义一个构造方法
        public Animal()
        {
            this.name = "无名";

        }
        public Animal(string param1)
        {
            this.name = param1;
        }
        //3、定义shoutNum的属性
        public int  ShoutNum
        {
            get
            {
                return shoutNum;
            }
            set
            {
                shoutNum = value;
            }

        }
        //父类定义一个虚方法
        public virtual string Shout()
        {
            return "";
        }
 

        
        
    }

    
    
    
    class Cat:Animal
    {

        //1、构造方法
        public Cat():base()
        {
        }
        public Cat(string param1):base(param1)
        {
        }

        //2、子类个性化的方法
        public override string Shout()
        {
            string result = "";
            for (int i = 0; i < shoutNum; i++)
            {
                result = result  +"喵";
                 
            }
            return "我的名字叫：" + name + result;
        }
    }

    class Dog : Animal
    {

        //1、构造方法
        public Dog()
            : base()
        {
        }
        public Dog(string param1)
            : base(param1)
        {
        }

        //2、子类个性化的方法
        public override string Shout()
        {
            string result = "";
            for (int i = 0; i < shoutNum; i++)
            {
                result = result + "汪";

            }
            return "我的名字叫：" + name + result;
        }
    }
}
