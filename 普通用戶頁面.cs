using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 期中專題_02_Influncer_marketing
{
    public partial class Form3 : Form
    {
        string myDBconnectionString = "";
        SqlConnectionStringBuilder scsb;
        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myProject";
            scsb.IntegratedSecurity = true;

            myDBconnectionString = scsb.ToString();
        }

        void datagridviewitem()
        {
            SqlConnection con = new SqlConnection(myDBconnectionString);
            con.Open();
            string strSQL = "select Id, Influencer_Name, Influencer_Gender, Influencer_Age, Influencer_Followers, " +
                "Followers_Main_age, Followers_Main_Gender from Influencer";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
            }
            else
            {

            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string strSelectId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //e式處存格資訊 找到第幾個列的第一個儲存格
            int intselectid = Convert.ToInt32(strSelectId);
            SqlConnection con = new SqlConnection(myDBconnectionString);
            con.Open();//後開先關 
            string strSQL = "select Id, Influencer_Name, Influencer_Gender, Influencer_Age, Influencer_Followers, " +
                "Followers_Main_age, Followers_Main_Gender from Influencer where id= @searchID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@searchID", intselectid);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txtid.Text = $"{reader["Id"]}";
                txtname.Text = $"{reader["Influencer_Name"]}";
                txtgender.Text = $"{reader["Influencer_Gender"]}";
                txtage.Text = $"{reader["Influencer_Age"]}";
                txtfans.Text = $"{reader["Influencer_Followers"]}";
                txtfansage.Text = $"{reader["Followers_Main_age"]}";
                txtfansgender.Text = $"{reader["Followers_Main_Gender"]}";
                

            }
            else
            {
                MessageBox.Show("查無此人");
            }

            reader.Close();
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            datagridviewitem();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "")
            {
                //只讀姓名搜尋到的第一筆
                SqlConnection con = new SqlConnection(myDBconnectionString);
                con.Open();//後開先關 
                string strSQL = "select Id, Influencer_Name, Influencer_Gender, Influencer_Age, Influencer_Followers, " +
                "Followers_Main_age, Followers_Main_Gender from Influencer where Influencer_Name like @searchName";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@searchName", "%" + txtname.Text + "%");
                SqlDataReader reader = cmd.ExecuteReader();


                if (reader.Read())
                {
                    txtid.Text = $"{reader["Id"]}";
                    txtname.Text = $"{reader["Influencer_Name"]}";
                    txtgender.Text = $"{reader["Influencer_Gender"]}";
                    txtage.Text = $"{reader["Influencer_Age"]}";
                    txtfans.Text = $"{reader["Influencer_Followers"]}";
                    txtfansage.Text = $"{reader["Followers_Main_age"]}";
                    txtfansgender.Text = $"{reader["Followers_Main_Gender"]}";
                    


                }
                else
                {
                    MessageBox.Show("查無此人");
                }

                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入姓名搜尋");
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
