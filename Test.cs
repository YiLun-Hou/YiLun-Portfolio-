using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework09_Test
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
            f.Visible = true;
        }
        static public Random ran = new Random();

        static public int a = ran.Next(100);
        private void button2_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(a.ToString());
        }
    }
}
