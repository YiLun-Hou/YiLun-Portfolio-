using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework08_OXgame
{
    public partial class XOgame : Form
    {
        bool isX = true;
        public XOgame()
        {
            InitializeComponent();
        }
        public void clear1()
        {
            but1.Text = "";
            but2.Text = "";
            but3.Text = "";
            but4.Text = "";
            but5.Text = "";
            but6.Text = "";
            but7.Text = "";
            but8.Text = "";
            but9.Text = "";
        }
        public void itisWin()
        {
            if (but1.Text == "X" && but2.Text == "X" && but3.Text == "X")
            {
                if(MessageBox.Show("X獲勝", "比賽結果",
                  MessageBoxButtons.OK) == DialogResult.OK)
                {
                    but1.Text = "";but2.Text = "";but3.Text = "";
                    but4.Text = "";but5.Text = "";but6.Text = "";
                    but7.Text = "";but8.Text = "";but9.Text = "";
                }
            }
                
            if (but4.Text == "X" && but5.Text == "X" && but6.Text == "X")
            {
                if (MessageBox.Show("X獲勝", "比賽結果",
                  MessageBoxButtons.OK) == DialogResult.OK)
                {
                    but1.Text = ""; but2.Text = ""; but3.Text = "";
                    but4.Text = ""; but5.Text = ""; but6.Text = "";
                    but7.Text = ""; but8.Text = ""; but9.Text = "";
                }
            }
            if (but7.Text == "X" && but8.Text == "X" && but9.Text == "X")
            {
                if (MessageBox.Show("X獲勝", "比賽結果",
                  MessageBoxButtons.OK) == DialogResult.OK)
                {
                    but1.Text = ""; but2.Text = ""; but3.Text = "";
                    but4.Text = ""; but5.Text = ""; but6.Text = "";
                    but7.Text = ""; but8.Text = ""; but9.Text = "";
                }
            }
            if (but1.Text == "X" && but4.Text == "X" && but7.Text == "X")
            {
                if (MessageBox.Show("X獲勝", "比賽結果",
                  MessageBoxButtons.OK) == DialogResult.OK)
                {
                    but1.Text = ""; but2.Text = ""; but3.Text = "";
                    but4.Text = ""; but5.Text = ""; but6.Text = "";
                    but7.Text = ""; but8.Text = ""; but9.Text = "";
                }
            }
            if (but2.Text == "X" && but5.Text == "X" && but8.Text == "X")
            {
                if (MessageBox.Show("X獲勝", "比賽結果",
                  MessageBoxButtons.OK) == DialogResult.OK)
                {
                    but1.Text = ""; but2.Text = ""; but3.Text = "";
                    but4.Text = ""; but5.Text = ""; but6.Text = "";
                    but7.Text = ""; but8.Text = ""; but9.Text = "";
                }
            }
            if (but3.Text == "X" && but6.Text == "X" && but9.Text == "X")
            {
                if (MessageBox.Show("X獲勝", "比賽結果",
                  MessageBoxButtons.OK) == DialogResult.OK)
                {
                    but1.Text = ""; but2.Text = ""; but3.Text = "";
                    but4.Text = ""; but5.Text = ""; but6.Text = "";
                    but7.Text = ""; but8.Text = ""; but9.Text = "";
                }
            }
            if (but1.Text == "X" && but5.Text == "X" && but9.Text == "X")
            {
                if (MessageBox.Show("X獲勝", "比賽結果",
                  MessageBoxButtons.OK) == DialogResult.OK)
                {
                    but1.Text = ""; but2.Text = ""; but3.Text = "";
                    but4.Text = ""; but5.Text = ""; but6.Text = "";
                    but7.Text = ""; but8.Text = ""; but9.Text = "";
                }
            }
            if (but3.Text == "X" && but5.Text == "X" && but7.Text == "X")
            {
                if (MessageBox.Show("X獲勝", "比賽結果",
                  MessageBoxButtons.OK) == DialogResult.OK)
                {
                    but1.Text = ""; but2.Text = ""; but3.Text = "";
                    but4.Text = ""; but5.Text = ""; but6.Text = "";
                    but7.Text = ""; but8.Text = ""; but9.Text = "";
                }
            }

            if (but1.Text == "O" && but2.Text == "O" && but3.Text == "O")
            {
                if (MessageBox.Show("O獲勝", "比賽結果",
                  MessageBoxButtons.OK) == DialogResult.OK)
                {
                    but1.Text = ""; but2.Text = ""; but3.Text = "";
                    but4.Text = ""; but5.Text = ""; but6.Text = "";
                    but7.Text = ""; but8.Text = ""; but9.Text = "";
                }
            }
            if (but4.Text == "O" && but5.Text == "O" && but6.Text == "O")
            {
                if (MessageBox.Show("O獲勝", "比賽結果",
                  MessageBoxButtons.OK) == DialogResult.OK)
                {
                    but1.Text = ""; but2.Text = ""; but3.Text = "";
                    but4.Text = ""; but5.Text = ""; but6.Text = "";
                    but7.Text = ""; but8.Text = ""; but9.Text = "";
                }
            }
            if (but7.Text == "O" && but8.Text == "O" && but9.Text == "O")
            {
                if (MessageBox.Show("O獲勝", "比賽結果",
                  MessageBoxButtons.OK) == DialogResult.OK)
                {
                    but1.Text = ""; but2.Text = ""; but3.Text = "";
                    but4.Text = ""; but5.Text = ""; but6.Text = "";
                    but7.Text = ""; but8.Text = ""; but9.Text = "";
                }
            }
            if (but1.Text == "O" && but4.Text == "O" && but7.Text == "O")
            {
                if (MessageBox.Show("O獲勝", "比賽結果",
                  MessageBoxButtons.OK) == DialogResult.OK)
                {
                    but1.Text = ""; but2.Text = ""; but3.Text = "";
                    but4.Text = ""; but5.Text = ""; but6.Text = "";
                    but7.Text = ""; but8.Text = ""; but9.Text = "";
                }
            }
            if (but2.Text == "O" && but5.Text == "O" && but8.Text == "O")
            {
                if (MessageBox.Show("O獲勝", "比賽結果",
                  MessageBoxButtons.OK) == DialogResult.OK)
                {
                    but1.Text = ""; but2.Text = ""; but3.Text = "";
                    but4.Text = ""; but5.Text = ""; but6.Text = "";
                    but7.Text = ""; but8.Text = ""; but9.Text = "";
                }
            }
            if (but3.Text == "O" && but6.Text == "O" && but9.Text == "O")
            {
                if (MessageBox.Show("O獲勝", "比賽結果",
                  MessageBoxButtons.OK) == DialogResult.OK)
                {
                    but1.Text = ""; but2.Text = ""; but3.Text = "";
                    but4.Text = ""; but5.Text = ""; but6.Text = "";
                    but7.Text = ""; but8.Text = ""; but9.Text = "";
                }
            }
            if (but1.Text == "O" && but5.Text == "O" && but9.Text == "O")
            {
                if (MessageBox.Show("O獲勝", "比賽結果",
                  MessageBoxButtons.OK) == DialogResult.OK)
                {
                    but1.Text = ""; but2.Text = ""; but3.Text = "";
                    but4.Text = ""; but5.Text = ""; but6.Text = "";
                    but7.Text = ""; but8.Text = ""; but9.Text = "";
                }
            }
            if (but3.Text == "O" && but5.Text == "O" && but7.Text == "O")
            {
                if (MessageBox.Show("O獲勝", "比賽結果",
                  MessageBoxButtons.OK) == DialogResult.OK)
                {
                    but1.Text = ""; but2.Text = ""; but3.Text = "";
                    but4.Text = ""; but5.Text = ""; but6.Text = "";
                    but7.Text = ""; but8.Text = ""; but9.Text = "";
                }
            }

            if (but1.Text != string.Empty && but2.Text != string.Empty &&
                but3.Text != string.Empty && but4.Text != string.Empty &&
                but5.Text != string.Empty && but6.Text != string.Empty &&
                but7.Text != string.Empty && but8.Text != string.Empty &&
                but9.Text != string.Empty)
            {
                if (MessageBox.Show("平手，再來一局", "比賽結果",
                  MessageBoxButtons.OK) == DialogResult.OK)
                {
                    but1.Text = ""; but2.Text = ""; but3.Text = "";
                    but4.Text = ""; but5.Text = ""; but6.Text = "";
                    but7.Text = ""; but8.Text = ""; but9.Text = "";
                }
            }



        }
         
        

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtbox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void butrestart_Click(object sender, EventArgs e)
        {
            clear1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(isX==true)
            {
                but1.Text = "X";
                isX = false;
            }
            else
            {
                but1.Text = "O";
                isX = true;
            }
            itisWin();
            
            
        }

        private void but2_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                but2.Text = "X";
                isX = false;
            }
            else
            {
                but2.Text = "O";
                isX = true;
            }
            itisWin();
        }

        private void but3_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                but3.Text = "X";
                isX = false;
            }
            else
            {
                but3.Text = "O";
                isX = true;
            }
            itisWin();
        }

        private void but4_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                but4.Text = "X";
                isX = false;
            }
            else
            {
                but4.Text = "O";
                isX = true;
            }
            itisWin();
        }

        private void but5_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                but5.Text = "X";
                isX = false;
            }
            else
            {
                but5.Text = "O";
                isX = true;
            }
            itisWin();
        }

        private void but6_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                but6.Text = "X";
                isX = false;
            }
            else
            {
                but6.Text = "O";
                isX = true;
            }
            itisWin();
        }

        private void but7_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                but7.Text = "X";
                isX = false;
            }
            else
            {
                but7.Text = "O";
                isX = true;
            }
            itisWin();
        }

        private void but8_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                but8.Text = "X";
                isX = false;
            }
            else
            {
                but8.Text = "O";
                isX = true;
            }
            itisWin();
        }

        private void but9_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                but9.Text = "X";
                isX = false;
            }
            else
            {
                but9.Text = "O";
                isX = true;
            }
            itisWin();
        }
    }
}
