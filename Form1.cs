using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//ado.net元件


namespace 期中專題_02_Influncer_marketing
{
    public partial class Form1 : Form
    {
        string myDBconnectionstring = ""; 

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string account = txtaccount.Text;
            string password = txtpassword.Text;
            if((account!="")&&(password !=""))
            {
                
                SqlConnection con = new SqlConnection(myDBconnectionstring);
                con.Open();
                string strSQL = "select * from Account where Account = @searchaccount and Password=@searchpassword";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@searchaccount", account);
                cmd.Parameters.AddWithValue("@searchpassword", password);
                SqlDataReader reader = cmd.ExecuteReader();//有查詢到回傳資料

                if (reader.Read())
                {
                    MessageBox.Show("歡迎回來");
                    Form2 f2 = new Form2();
                    f2.Visible = true;

                }
                else
                {
                    MessageBox.Show("請輸入正確帳號密碼或以訪客身分進入平台");
                }

                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入帳號密碼或以訪客身分進入平台");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = ".";
            scsb.InitialCatalog = "myProject";
            scsb.IntegratedSecurity = true;

            myDBconnectionstring = scsb.ToString();

        }

        private void butguest_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Visible = true;
        }
    }
}
