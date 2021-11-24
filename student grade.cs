using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework04_student_struct_form
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        bool a=false;
        private void butsave_Click(object sender, EventArgs e)
        {
            a = true;
        }

        private void butshow_Click(object sender, EventArgs e)
        {
            if (a == true)
            {
                txtscore.Text = $"姓名:{txtname.Text}\r\n" +
                    $"國文:{txtch.Text}分\r\n英文:{txten.Text}分\r\n數學:{txtma.Text}分";
            }
            else
            {
                txtscore.Clear();
            }
        }

        private void butcompare_Click(object sender, EventArgs e)
        {
            string[] name1 = new string[] { "國文", "英文", "數學" };
            int[] scores = new int[] { int.Parse(txtch.Text), int.Parse(txten.Text), int.Parse(txtma.Text) };
            int max = scores[0];
            int j = 0;
            for(int i=0;i<3;i++)
            {
                if(max<scores[i])
                {
                    max = scores[i];
                    j = i;
                }
            }

            int min = scores[0];
            int z = 0;
            for(int i=0;i<3;i++)
            {
                if (min > scores[i])
                {
                    min = scores[i];
                    z = i;
                }
            }
            txtcompare.Text = $"最高分: {name1[j]} {max}分\r\n最低分: {name1[z]} {min}分";
                
                
        }
    }
}
