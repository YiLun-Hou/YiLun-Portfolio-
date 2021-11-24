using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework05_cal
{
    public partial class cal : Form
    {
        public cal()
        {
            InitializeComponent();
        }

        private void butadd_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            bool a = int.TryParse(txtnum1.Text, out num1);
            bool b = int.TryParse(txtnum2.Text, out num2);
            if (a && b)
            {
                txtanswer.Text = (num1 + num2).ToString();
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void butminus_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            bool a = int.TryParse(txtnum1.Text, out num1);
            bool b = int.TryParse(txtnum2.Text, out num2);
            if (a && b)
            {
                txtanswer.Text = (num1 - num2).ToString();
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void butx_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            bool a = int.TryParse(txtnum1.Text, out num1);
            bool b = int.TryParse(txtnum2.Text, out num2);
            if (a && b)
            {
                txtanswer.Text = (num1 * num2).ToString();
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void butdevide_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            bool a = int.TryParse(txtnum1.Text, out num1);
            bool b = int.TryParse(txtnum2.Text, out num2);
            if (a && b)
            {
                double a1 = num1;
                double a2 = num2;

                txtanswer.Text = (a1 / a2).ToString();
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }
    }
}
