using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework02_Loan
{
    public partial class Loan : Form
    {
        public Loan()
        {
            InitializeComponent();
        }

        private void butmonth_Click(object sender, EventArgs e)
        {
            this.txtmoney.Clear();
            double loan = double.Parse(txtloan.Text);
            int month = int.Parse(txtmonth.Text);
            double rate = 1.0 + double.Parse(txtrate.Text) / 100 / 12;
            double rpn = Math.Pow(rate, month);
            double pmt = loan * rpn * (rate - 1) / (rpn - 1);
            double totalpayment = pmt * month;
            double interest = (totalpayment - loan);
            double output = Math.Round(interest, 1);
            this.txtmoney.Text += output;
            MessageBox.Show("月付額約是" + pmt.ToString("0.0") + "元");

            
            
        }

        private void buttotal_Click(object sender, EventArgs e)
        {
            this.txtmoney.Clear();
            double loan = double.Parse(txtloan.Text);
            int month = int.Parse(txtmonth.Text);
            double rate = 1.0 + double.Parse(txtrate.Text) / 100 / 12;
            double rpn = Math.Pow(rate, month);
            double pmt = loan * rpn * (rate - 1) / (rpn - 1);
            double totalpayment = pmt * month;
            double interest = (totalpayment - loan);
            double output = Math.Round(interest, 1);
            this.txtmoney.Text += output;
            MessageBox.Show("總還款約等於" + totalpayment.ToString("0.0"));

            
            
        }

        private void butreport_Click(object sender, EventArgs e)
        {
            this.txtmoney.Clear();
            double loan = double.Parse(txtloan.Text);
            int month = int.Parse(txtmonth.Text);
            double rate = 1.0 + double.Parse(txtrate.Text) / 100 / 12;
            double rpn = Math.Pow(rate, month);
            double pmt = loan * rpn * (rate - 1) / (rpn - 1);
            double totalpayment = pmt * month;
            double interest = (totalpayment - loan);
            double output = Math.Round(interest, 1);
            this.txtmoney.Text += output;
            MessageBox.Show("總還款約等於" + totalpayment.ToString("0.0") + "\n月付額約是" + pmt.ToString("0.0") + "元");

            
            
        }
    }
}
