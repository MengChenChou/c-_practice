using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cat cat = new Cat("咪咪");
            cat.ShoutNum = 11;
            MessageBox.Show(cat.Shout());

        }
        class Cat
        {
            //替貓咪命名，屬性
            private string name = "";
            public Cat(string name)
            {
                this.name = name;
            }
            public Cat()
            {
                this.name = "未取名";
            }
            //叫聲設定，屬性
            private int shoutNum = 3;
            public int ShoutNum
            {
                get
                {
                    return shoutNum; 
                }
                set
                {
                    if (value <= 10)
                        shoutNum = value;
                    else
                        shoutNum = 10;
                }
            }
            //叫，方法
            public string Shout()
            {
                string result = "";
                for (int i = 0; i < shoutNum; i++)
                {
                    result += "喵 ";
                }

                return "我的名字"+name+" "+result;
            }
        }

    }
}
