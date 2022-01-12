using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework03_POS
{
    public partial class POS : Form
    {

        static public int beer, tequlia, whisky, redwine;//餐點內容物
        

        void price()
        {
            int total1 = beer * 120 + tequlia * 180 + whisky * 350 + redwine * 320;//總價
            txtpayment.Text = "$NT"+total1.ToString();
        }

        void list()//點餐列表
        {
            int beertotal = beer * 120;
            int tequliatotal = tequlia * 180;
            int whiskytotal = whisky * 350;
            int winetotal = redwine * 320;
            int total1 = beer * 120 + tequlia * 180 + whisky * 350 + redwine * 320;
            txtlist.Text = ("啤酒Beer x" + beer + " 共NT$ " + (beertotal) + "元" + "\r\n"
                + "龍舌蘭Tequlia x" + tequlia + " 共NT$ " + (tequliatotal) + "元" + "\r\n"
                + "威士忌Whisky x" + whisky + " 共NT$ " + (whiskytotal) + "元" + "\r\n"
                + "紅酒Redwine x" + redwine + " 共NT$ " + (winetotal) + "元" + "\r\n");
        }

        private void butclear_Click(object sender, EventArgs e)
        {
            txtlist.Clear();
            txtpayment.Clear();
        }

        private void butcash_Click(object sender, EventArgs e)//現金付款，無特殊優惠
        {
            int total1 = beer * 120 + tequlia * 180 + whisky * 350 + redwine * 320;
            MessageBox.Show("今日消費金額為: " + total1.ToString(), "今日消費帳單", MessageBoxButtons.OKCancel);
            MessageBox.Show("感謝確認，請至櫃台結帳", "歡迎下次光臨");
        }

        private void buttequlia_Click(object sender, EventArgs e)
        {
            tequlia += 1;
            price();
            list();
        }

        private void butwhisky_Click(object sender, EventArgs e)
        {
            whisky += 1;
            price();
            list();
        }

        private void butwine_Click(object sender, EventArgs e)
        {
            redwine += 1;
            price();
            list();
        }

        private void butcard_Click(object sender, EventArgs e)//信用卡付款，85折優惠
        {
            int total1 = beer * 120 + tequlia * 180 + whisky * 350 + redwine * 320;
            int total2 = total1 * 85 / 100;
            MessageBox.Show("今日消費金額為(已打85折): " + total2.ToString(), "今日消費帳單", MessageBoxButtons.OKCancel);
            MessageBox.Show("感謝確認，請至櫃台結帳", "歡迎下次光臨");
        }

        

        public POS()
        {
            InitializeComponent();
        }



        private void butbeer_Click(object sender, EventArgs e)
        {
            beer += 1;
            price();
            list();
        }
    }
}
