
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework09_Test //初始頁面，頁面包含遊戲介紹以及開始/公布答案兩個按鈕，點選開始按鈕會跳轉至遊戲頁面
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Visible = true; //顯示遊戲頁面
        }
        static public Random ran = new Random();

        static public int a = ran.Next(100);//隨機答案
        private void button2_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(a.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework09_Test//遊戲主頁，包含數字輸入框，以及取消按鈕。
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Test andg = new Test();
        public int a = Test.a;
        int max=100;
        int min=0;
        int g;

        private void butenter_Click(object sender, EventArgs e)
        {

            
                g = int.Parse(txtanswer.Text);//玩家輸入數字
                if(g>0 && g<101)//數字超出遊戲範圍
                {
                    if (g > a)
                    {
                        max = g;
                        label1.Text = "Too Large!!!\r\nBetween" + min + " and " + max;
                    }
                    else if(g<a)
                    {
                        min = g;
                        label1.Text = "Too Small!!!\r\nBetween" + min + " and " + max;
                    }
                    else
                    {
                        label1.Text = "You Got It!";
                        MessageBox.Show("You Got It!");
                    }

                }
                else
                {
                    label1.Text = "請輸入提示範圍內的數字唷!!";
                }
            
        }

        private void butcancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;//關閉遊戲頁面
        }
    }
}
