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
using System.Diagnostics;//開啟本機郵件api

namespace Influncer_marketing
{
    public partial class Form2 : Form
    {
        string myDBconnectionString = "";//類別變數 建立好的資料庫連線字串
        SqlConnectionStringBuilder scsb;//類別變數 資料庫連線字串建立器
        List<int> searchIDs = new List<int>();//類別變數 存入進階搜尋得到的多筆資料
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();//是物件，需要初始化(new)
            scsb.DataSource = @".";//本機資料庫來源，@就是不處理特殊自元
            scsb.InitialCatalog = "myProject";//資料庫名稱
            scsb.IntegratedSecurity = true;//整合驗證
            
            //決定搜尋欄位
            cmbgender.Items.Add("Male");
            cmbgender.Items.Add("Female");
            cmbcate.Items.Add("3C");
            cmbcate.Items.Add("Apparel");
            cmbcate.Items.Add("Toys");
            cmbcate.Items.Add("Beauty");
            cmbcate.Items.Add("Gaming");
            cmbcate.Items.Add("Home_Living");
            cmbcate.Items.Add("Baby_Mother");

            myDBconnectionString = scsb.ToString();//連接產生器產生的字串指定到這
        }
        void datagridviewitem()
        {
            SqlConnection con = new SqlConnection(myDBconnectionString);
            con.Open();
            string strSQL = "select * from Influencer";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)//bool=true表示有資料
            {
                DataTable dt = new DataTable();//datareader跟datagridview的中介物件
                dt.Load(reader);
                dataGridView1.DataSource = dt;
            }
            else
            {

            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//有兩個參數，第一個是觸發物件的事件，也就是cell，第二個
            //是觸發這個事件的事件本身
        {
            string strSelectId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();//datagridview每一列會成為一個集合，這個集合裡面，可以透過
            //列的索引值，取得當列的集合，這個集合裡面，又含有儲存格的集合
                                                   //e含有列的索引值
            //e是處存格資訊 找到第幾個列的第一個儲存格
            
            int intselectid = Convert.ToInt32(strSelectId);//UI呈現的都是字串，再轉成INT
            SqlConnection con = new SqlConnection(myDBconnectionString);
            con.Open();//後開先關 
            string strSQL = "select * from Influencer where id= @searchID";
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
                txtls.Text = $"{reader["LS_Experience"]}";
                txtcat.Text = $"{reader["Main_Cate"]}";
                txtcommission.Text = $"{reader["Commission_Rate"]}";
                txtfixfee.Text = $"{reader["Fixed_fee$"]}";
                txtemail.Text = $"{reader["Contact_Email"]}";

            }
            else
            {
                MessageBox.Show("查無此人");
            }

            reader.Close();
            con.Close();
        }

        private void but筆數_Click(object sender, EventArgs e)
        {
            datagridviewitem();
        }

        private void but搜尋_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "")
            {
                //只讀姓名搜尋到的第一筆
                SqlConnection con = new SqlConnection(myDBconnectionString);//使用資料庫連線字串來建立資料庫連線
                con.Open();//開啟連線 後開先關 先開後關
                string strSQL = "select * from Influencer where Influencer_Name like @searchName";//建立SQL語法
                SqlCommand cmd = new SqlCommand(strSQL, con);//執行SQL語法，有兩個參數，一個是資料查詢(SQL命令)，一個是資料庫連線物件
                cmd.Parameters.AddWithValue("@searchName", "%" + txtname.Text + "%");//參數一般化
                SqlDataReader reader = cmd.ExecuteReader();//資料庫查詢，使用EXECTUE來取得讀取的物件
                

                if (reader.Read())
                {
                    txtid.Text = $"{reader["Id"]}";//reader結果是一個集合
                    txtname.Text = $"{reader["Influencer_Name"]}";
                    txtgender.Text = $"{reader["Influencer_Gender"]}";
                    txtage.Text = $"{reader["Influencer_Age"]}";
                    txtfans.Text = $"{reader["Influencer_Followers"]}";
                    txtfansage.Text = $"{reader["Followers_Main_age"]}";
                    txtfansgender.Text = $"{reader["Followers_Main_Gender"]}";
                    txtls.Text = $"{reader["LS_Experience"]}";
                    txtcat.Text = $"{reader["Main_Cate"]}";
                    txtcommission.Text = $"{reader["Commission_Rate"]}";
                    txtfixfee.Text = $"{reader["Fixed_fee$"]}";
                    txtemail.Text = $"{reader["Contact_Email"]}";


                }
                else
                {
                    MessageBox.Show("查無此人");
                }

                reader.Close();//READER會占用CON資源，所以要先關
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入姓名搜尋");
            }
        }

        private void but修改_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txtid.Text, out intID);

            if (intID > 0)
            {
                if (txtname.Text != "")
                {
                    SqlConnection con = new SqlConnection(myDBconnectionString);
                    con.Open();
                    string strSQL = "update Influencer set " +
                        "Influencer_Name=@Newname, Influencer_Gender=@Newgender, Influencer_Age=@Newage," +
                        "Influencer_Followers=@Newf, Followers_Main_age=@Newfage," +
                        "Followers_Main_Gender=@Newfg, LS_Experience=@Newls, Main_Cate=@Newcat," +
                        "Commission_Rate=@Newcr, Fixed_fee$=@Newfix, Contact_Email=@Newemail " +
                        "where id =@SearchID";
                    
                    SqlCommand cmd = new SqlCommand(strSQL, con);

                    cmd.Parameters.AddWithValue("@Newname", txtname.Text);
                    cmd.Parameters.AddWithValue("@Newgender", txtgender.Text);
                    cmd.Parameters.AddWithValue("@Newage", txtage.Text);
                    cmd.Parameters.AddWithValue("@Newf", txtfans.Text);
                    cmd.Parameters.AddWithValue("@Newfage", txtfansage.Text);
                    cmd.Parameters.AddWithValue("@Newfg", txtfansgender.Text);
                    cmd.Parameters.AddWithValue("@Newls", txtls.Text);
                    cmd.Parameters.AddWithValue("@Newcat", txtcat.Text);
                    cmd.Parameters.AddWithValue("@Newcr", txtcommission.Text);
                    cmd.Parameters.AddWithValue("@Newfix", txtfixfee.Text);
                    cmd.Parameters.AddWithValue("@Newemail", txtemail.Text);
                    cmd.Parameters.AddWithValue("@SearchID", intID);

                    int rows = cmd.ExecuteNonQuery();//執行不查詢，查詢會回傳資料但修改不會，因此查詢資料用的是executereader 修改用的是execurenonquery
                    con.Close();

                    txtid.Text = "";
                    txtname.Text = "";
                    txtgender.Text = "";
                    txtage.Text = "";
                    txtfans.Text = "";
                    txtfansage.Text = "";
                    txtfansgender.Text = "";
                    txtls.Text = "";
                    txtcat.Text = "";
                    txtcommission.Text = "";
                    txtfixfee.Text = "";
                    txtemail.Text = "";
                    MessageBox.Show($"{rows}筆資料修改成功");
                    
                }
                else
                {
                    MessageBox.Show("姓名必填");
                }
            }
            else
            {
                MessageBox.Show("資料不存在");
            }
        }

        private void but新增_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "")
            {
                SqlConnection con = new SqlConnection(myDBconnectionString);
                con.Open();
                string strSQL = "insert into  Influencer " +
                    "values (@Newname,@Newgender,@Newage,@Newf,@Newfage,@Newfg,@Newls,@Newcat,@Newcr,@Newfix,@Newemail)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                
                cmd.Parameters.AddWithValue("@Newname", txtname.Text);
                cmd.Parameters.AddWithValue("@Newgender", txtgender.Text);
                cmd.Parameters.AddWithValue("@Newage", txtage.Text);
                cmd.Parameters.AddWithValue("@Newf", txtfans.Text);
                cmd.Parameters.AddWithValue("@Newfage", txtfansage.Text);
                cmd.Parameters.AddWithValue("@Newfg", txtfansgender.Text);
                cmd.Parameters.AddWithValue("@Newls", txtls.Text);
                cmd.Parameters.AddWithValue("@Newcat", txtcat.Text);
                cmd.Parameters.AddWithValue("@Newcr", txtcommission.Text);
                cmd.Parameters.AddWithValue("@Newfix", txtfixfee.Text);
                cmd.Parameters.AddWithValue("@Newemail", txtemail.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                txtid.Text = "";
                txtname.Text = "";
                txtgender.Text = "";
                txtage.Text = "";
                txtfans.Text = "";
                txtfansage.Text = "";
                txtfansgender.Text = "";
                txtls.Text = "";
                txtcat.Text = "";
                txtcommission.Text = "";
                txtfixfee.Text = "";
                txtemail.Text = "";
                MessageBox.Show($"{rows}筆資料新增成功");
            }
            else
            {
                MessageBox.Show("姓名必填");
            }
        }

        private void but刪除_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txtid.Text, out intID);
            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(myDBconnectionString);
                con.Open();
                string strSQL = "delete from Influencer where Id=@SearchID";

                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                txtid.Text = "";
                txtname.Text = "";
                txtgender.Text = "";
                txtage.Text = "";
                txtfans.Text = "";
                txtfansage.Text = "";
                txtfansgender.Text = "";
                txtls.Text = "";
                txtcat.Text = "";
                txtcommission.Text = "";
                txtfixfee.Text = "";
                txtemail.Text = "";

                MessageBox.Show($"{rows}筆資料刪除成功");
            }
            else
            {
                MessageBox.Show("請填寫想刪除之序號");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emailaddress = txtemail.Text;
            string mailInfo = string.Format("mailto:{0}?Subject={1}&Body={2}", emailaddress, "直播帶貨合作", "您好");
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = mailInfo.ToString();
            myProcess.Start(); //執行
            myProcess.Dispose();
        }

        private void butsearch2_Click(object sender, EventArgs e)
        {
            lboxresult.Items.Clear();
            searchIDs.Clear();//list也會先清空
            
            int age1 = int.Parse(agefrom.Text);
            int age2 = int.Parse(ageend.Text);
            int fan1 = int.Parse(fansfrom.Text);
            int fan2 = int.Parse(fansend.Text);
            string gender = cmbgender.SelectedItem.ToString();
            string cate = cmbcate.SelectedItem.ToString();



            if (gender != "")
            {

                string strSQL = "select* from Influencer " +
                    "where(Influencer_Age >= @age1 and Influencer_Age<= @age2) " +
                    "and(Influencer_Followers  >= @fans1 and Influencer_Followers<= @fans2) " +
                    "and (Influencer_Gender=@SearchGender) and(Main_Cate=@Searchcat)";

                SqlConnection con = new SqlConnection(myDBconnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                
                cmd.Parameters.AddWithValue("@age1", age1);
                cmd.Parameters.AddWithValue("@age2", age2);
                cmd.Parameters.AddWithValue("@fans1", fan1);
                cmd.Parameters.AddWithValue("@fans2", fan2);
                cmd.Parameters.AddWithValue("@SearchGender", gender);
                cmd.Parameters.AddWithValue("@Searchcat", cate);


                SqlDataReader reader = cmd.ExecuteReader();//有查詢結果 因此用這個
                int i = 0;
                while (reader.Read())
                {
                    lboxresult.Items.Add($"{reader["Influencer_Name"]}");//listbox儲存資料就是items
                    searchIDs.Add(Convert.ToInt32(reader["id"]));//處理資料用id 因此id也要存進去 才能對起來
                    i += 1;
                }
                if (i <= 0)
                {
                    MessageBox.Show("查無此人");
                }
                else
                {
                    MessageBox.Show($"總共有{i}筆資料符合條件");
                }

                reader.Close();
                con.Close();

            }
            else
            {
                MessageBox.Show("請輸入關鍵字");
            }
        }

        private void lboxresult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxresult.SelectedIndex >= 0)
            {
                int intID = searchIDs[lboxresult.SelectedIndex];
                SqlConnection con = new SqlConnection(myDBconnectionString);
                con.Open();
                string strSQL = "select * from Influencer where id= @searchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@searchID", intID);
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
                    txtls.Text = $"{reader["LS_Experience"]}";
                    txtcat.Text = $"{reader["Main_Cate"]}";
                    txtcommission.Text = $"{reader["Commission_Rate"]}";
                    txtfixfee.Text = $"{reader["Fixed_fee$"]}";
                    txtemail.Text = $"{reader["Contact_Email"]}";

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
                MessageBox.Show("無此資料");
            }
        }
    }
}
