using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework01_Name
{
    public partial class HelloWorld : Form
    {
        public HelloWorld()
        {
            InitializeComponent();
        }

        

            

        private void buthi_Click(object sender, EventArgs e)
        {

            string name = txtname.Text;
            string englishanme = txtenglish.Text;
            string gender = cbgender.Text;
            string star = txtstar.Text;
            MessageBox.Show("Hi\n我是 "+name+"\n"+"你也可以稱呼我為"+englishanme+"\n"+"我是 "+gender+" "+star+"\n很高興認識你");
        }

        private void buthello_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string englishanme = txtenglish.Text;
            string gender = cbgender.Text;
            string star = txtstar.Text;
            MessageBox.Show("Hello\n我是 " + name + "\n" + "你也可以稱呼我為 " + englishanme + "\n" + "我是 " + gender + " "+star + "\n很高興認識你");
        }
    }
}
