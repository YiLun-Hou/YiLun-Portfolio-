using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework07_method
{
    public partial class Form1 : Form
    {
        

        
        public Form1()
        {
            InitializeComponent();
        }

        private void but13_Click(object sender, EventArgs e)
        {
            string result = "";
            int j = int.Parse(txtrow.Text);
            for(int i=1;i<=j;i++)
            {
                for(int k=0;k<i; k++)
                {
                    result += "*";
                }
                result += "\r\n";
            }
            labresult.Text = result;
        }

        private void but1_Click(object sender, EventArgs e)
        {
            int t = int.Parse(txtnum.Text);
            if(t%2==0)
            {
                labresult.Text = "偶數";
            }
            else
            {
                labresult.Text = "奇數";
            }
        }

        private void but14_Click(object sender, EventArgs e)
        {
            labresult.Text = "";
            for(int i=2;i<=9;i++)
            {
                for(int j=2;j<=9;j++)
                {
                    labresult.Text += $"  {i}*{j}={i*j}  ||";
                }
                labresult.Text += "\r\n";
            }
        }

        private void butclear_Click(object sender, EventArgs e)
        {
            labresult.Text = "結果欄";
        }

        void swap(ref int n1, ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }
        private void but9_Click(object sender, EventArgs e)
        {
            int n1 = 100;
            int n2 = 200;
            string result1 = "換位前n1=" + n1.ToString() + " n2=" + n2.ToString();
            swap(ref n1, ref n2);
            string result2 = "\n換位後n1=" + n1.ToString() + " n2=" + n2.ToString();
            labresult.Text = result1 + result2;

        }

        private void but11_Click(object sender, EventArgs e)
        {
            int[] Y = new int[] { 2, 65, 89, 34, 380, 33, 97, 78, 103 };
            int max = Y[0];
            for (int i = 0; i < Y.Length; i++)
            {
                if (max < Y[i])
                    max = Y[i];
            }
            labresult.Text = "陣列Y[2, 65, 89, 34, 380, 33, 97, 78, 103]" + "\r\n最大值為:" + max.ToString();
        }

        private void but12_Click(object sender, EventArgs e)
        {
            int[] Y = new int[] { 2, 65, 89, 34, 380, 33, 97, 78, 103 };
            int min = Y[0];
            for (int i = 0; i < Y.Length; i++)
            {
                if (min > Y[i])
                    min = Y[i];
            }
            labresult.Text = "陣列Y[2, 65, 89, 34, 380, 33, 97, 78, 103]" + "\r\n最小值為:" + min.ToString();
        }

        private void but10_Click(object sender, EventArgs e)
        {
            labresult.Text = "";
            int sum = 0;
            int[] Y = new int[] { 2, 65, 89, 34, 380, 33, 97, 78, 103 };
            for(int i=0;i<Y.Length;i++)
            {
                sum += Y[i];
            }
            labresult.Text = "陣列Y[2, 65, 89, 34, 380, 33, 97, 78, 103]" + "\r\n總和為:" + sum.ToString();
        }

        private void but2_Click(object sender, EventArgs e)
        {
            int[] Y = new int[] { 2, 65, 89, 34, 380, 33, 97, 78, 103 };
            int max = Y[0];
            for (int i = 0; i < Y.Length; i++)
            {
                if (max < Y[i])
                {
                    max = Y[i];
                }
            }
            int min = Y[0];
            for (int i = 0; i < Y.Length; i++)
            {
                if (min > Y[i])
                {
                    min = Y[i];
                }
            }

            string result1 = "陣列Y[2, 65, 89, 34, 380, 33, 97, 78, 103]" + "\r\n最大值為" + max.ToString() + "\r\n最小值為" + min.ToString();
            labresult.Text = result1;
        }

        private void but6_Click(object sender, EventArgs e)
        {
            //邊1內0//

            int[,] Z = new int[10, 10]
            {
                { 1,1,1,1,1,1,1,1,1,1},
                { 1,0,0,0,0,0,0,0,0,1},
                { 1,0,0,0,0,0,0,0,0,1},
                { 1,0,0,0,0,0,0,0,0,1},
                { 1,0,0,0,0,0,0,0,0,1},
                { 1,0,0,0,0,0,0,0,0,1},
                { 1,0,0,0,0,0,0,0,0,1},
                { 1,0,0,0,0,0,0,0,0,1},
                { 1,0,0,0,0,0,0,0,0,1},
                { 1,1,1,1,1,1,1,1,1,1}
            };
            int rowlength = Z.GetLength(0);
            int colLength = Z.GetLength(1);
            string arrayString = "";

            for (int i = 0; i < rowlength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    arrayString += Z[i, j];
                }
                arrayString += "\r\n";
            }
            labresult.Text = arrayString;
        }

        private void but7_Click(object sender, EventArgs e)
        {
            //邊0內1//

            int[,] Z = new int[10, 10]
            {
                { 0,0,0,0,0,0,0,0,0,0},
                { 0,1,1,1,1,1,1,1,1,0},
                { 0,1,1,1,1,1,1,1,1,0},
                { 0,1,1,1,1,1,1,1,1,0},
                { 0,1,1,1,1,1,1,1,1,0},
                { 0,1,1,1,1,1,1,1,1,0},
                { 0,1,1,1,1,1,1,1,1,0},
                { 0,1,1,1,1,1,1,1,1,0},
                { 0,1,1,1,1,1,1,1,1,0},
                { 0,0,0,0,0,0,0,0,0,0}
            };
            int rowlength = Z.GetLength(0);
            int colLength = Z.GetLength(1);
            string arrayString = "";

            for (int i = 0; i < rowlength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    arrayString += Z[i, j];
                }
                arrayString += "\r\n";
            }
            labresult.Text = arrayString;
        }

        private void but8_Click(object sender, EventArgs e)
        {
            int[,] Z = new int[10, 10]
            {
                { 1,0,1,0,1,0,1,0,1,0},
                { 0,1,0,1,0,1,0,1,0,1},
                { 1,0,1,0,1,0,1,0,1,0},
                { 0,1,0,1,0,1,0,1,0,1},
                { 1,0,1,0,1,0,1,0,1,0},
                { 0,1,0,1,0,1,0,1,0,1},
                { 1,0,1,0,1,0,1,0,1,0},
                { 0,1,0,1,0,1,0,1,0,1},
                { 1,0,1,0,1,0,1,0,1,0},
                { 0,1,0,1,0,1,0,1,0,1}
            };
            int rowlength = Z.GetLength(0);
            int colLength = Z.GetLength(1);
            string arrayString = "";

            for (int i = 0; i < rowlength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    arrayString += Z[i, j];
                }
                arrayString += "\r\n";
            }
            labresult.Text = arrayString;
        }

        private void but4_Click(object sender, EventArgs e)
        {
            int[] Y = new int[] { 2, 65, 89, 34, 380, 33, 97, 78, 103 };
            int count = 0;
            for(int i=0;i<Y.Length;i++)
            {
                if(Y[i]%2==0)
                {
                    count++;
                }
                labresult.Text = "陣列Y[2, 65, 89, 34, 380, 33, 97, 78, 103]\r\n"+"偶數有" + count.ToString() + "個" + "\n奇數有" + (Y.Length - count).ToString() + "個";
            }
        }

        private void but5_Click(object sender, EventArgs e)
        {
            string[] g = { "Alice", "Fred", "Emma", "Karen", "Erebus", "Arrow",
                "Sally", "Yuki","JasonYuYao","Roy" };
            int maxcounter = 0;
            string maxword = "";
           

            for(int i=0;i<g.Length;i++)
            {
                if(g[i].Length>maxcounter)
                {
                    maxcounter = g[i].Length;
                    maxword = g[i];
                }
                
            }
            
            labresult.Text = "陣列 K 為 Alice, Fred, Emma, Karen, Erebus, Arrow, Sally, Yuki, JasonYuYao, Roy \r\n最長的名字是:"+
               maxword ;
            
        }

        private void labresult_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void but3_Click(object sender, EventArgs e)
        {
            string[] g = { "Alice", "Fred", "Emma", "Karen", "Erebus", "Arrow",
                "Sally", "Yuki","JasonYuYao","Roy" };
            int a = 0;
            List<string> rwords = new List<string>();

            for (int i = 0; i < g.Length; i++)
            {
                
                if (g[i].IndexOf('S') != -1 || g[i].IndexOf('s') != -1)
                {
                    rwords.Add(g[i]);
                }
            }
            string[] newone = rwords.ToArray();
            a = newone.Length;
            labresult.Text = "陣列 K 為 Alice, Fred, Emma, Karen, Erebus, Arrow, Sally, Yuki, JasonYuYao, Roy \r\nS OR s 字樣有"
               +a.ToString() +"個";
        }
    }
}
