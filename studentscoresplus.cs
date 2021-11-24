using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework06_studentscores2
{
    public partial class studentscoresplus : Form
    {
        public studentscoresplus()
        {
            InitializeComponent();
        }
        

        static List<int> ChPlus = new List<int>();
        static List<int> EnPlus = new List<int>();
        static List<int> MaPlus = new List<int>();
        Random ran = new Random();

        struct IsSg
        {
            public string Name;
            public int CH;
            public int EN;
            public int MA;
            public int total;
            public int avg;
            public string min;
            public string max;

        }

        List<IsSg> Stg = new List<IsSg>();

        void showstg()
        {
            labname.Text = "姓名\r\n";
            labch.Text = "國文\r\n";
            laben.Text = "英文\r\n";
            labma.Text = "數學\r\n";
            labtotal.Text = "總分\r\n";
            labavg.Text = "平均\r\n";
            labmin.Text = "最低\r\n";
            labmax.Text = "最高\r\n";

            for (int i=0;i<Stg.Count;i++)
            {
                labname.Text += $"{Stg[i].Name}\r\n";
                labch.Text += $"{Stg[i].CH}\r\n";
                laben.Text+= $"{Stg[i].EN}\r\n";
                labma.Text+= $"{Stg[i].MA}\r\n";
                labtotal.Text+=$"{Stg[i].total}\r\n";
                labavg.Text += $"{Stg[i].avg}\r\n";
                labmin.Text += $"{Stg[i].min}\r\n";
                labmax.Text += $"{Stg[i].max}\r\n";
            }
            labname.Text += "\r\n";
            labch.Text += "\r\n";
            laben.Text += "\r\n";
            labma.Text += "\r\n";
            labtotal.Text += "\r\n";
            labavg.Text += "\r\n";
            labmin.Text += "\r\n";
            labmax.Text += "\r\n";



        }

        

        private void butadd_Click(object sender, EventArgs e)
        {
            string a = txtname.Text; //姓名
            int b = int.Parse(txtch.Text);//國文
            int c = int.Parse(txten.Text);//英文
            int d = int.Parse(txtma.Text);//數學
            int z=b+c+d;//總分
            int f=z/3;//平均

            //大小//
            string[] Name = new string[] { "國文", "英文", "數學" };
            int[] Grade = new int[] { b, c, d };

            int min = Grade[0];
            int p = 0;
            for (int i = 0; i < 3; i++)//最小值
            {
                if (min > Grade[i])
                {
                    min = Grade[i];
                    p = i;
                }
            }

            int max = Grade[0];
            int j = 0;
            for (int i = 0; i < 3; i++)//最大值
            {
                if (max < Grade[i])
                {
                    max = Grade[i];
                    j = i;
                }
            }
            string g = $"{Name[p]}{min}分";//最小
            string o = $"{Name[j]}{max}分";//最大

            Stg.Add(new IsSg
            {
                Name = a,
                CH = b,
                EN = c,
                MA = d,
                total = z,
                avg = f,
                min=g,
                max=o
            }
            ) ;
            showstg();
            ChPlus.Add(int.Parse(txtch.Text));
            EnPlus.Add(int.Parse(txten.Text));
            MaPlus.Add(int.Parse(txtma.Text));
        }

        private void butinsert_Click(object sender, EventArgs e)
        {
            string a = txtname.Text; //姓名
            int b = int.Parse(txtch.Text);//國文
            int c = int.Parse(txten.Text);//英文
            int d = int.Parse(txtma.Text);//數學
            int z = b + c + d;//總分
            int f = z / 3;//平均

            //大小//
            string[] Name = new string[] { "國文", "英文", "數學" };
            int[] Grade = new int[] { b, c, d };

            int min = Grade[0];
            int p = 0;
            for (int i = 0; i < 3; i++)//最小值
            {
                if (min > Grade[i])
                {
                    min = Grade[i];
                    p = i;
                }
            }

            int max = Grade[0];
            int j = 0;
            for (int i = 0; i < 3; i++)//最大值
            {
                if (max < Grade[i])
                {
                    max = Grade[i];
                    j = i;
                }
            }
            string g = $"{Name[p]}{min}分";//最小
            string o = $"{Name[j]}{max}分";//最大

            Stg.Insert(0, new IsSg
            {
                Name = a,
                CH = b,
                EN = c,
                MA = d,
                total = z,
                avg = f,
                min = g,
                max = o
            }
            );
            
            showstg();
            ChPlus.Add(int.Parse(txtch.Text));
            EnPlus.Add(int.Parse(txten.Text));
            MaPlus.Add(int.Parse(txtma.Text));
        }

        private void butclear_Click(object sender, EventArgs e)
        {
            Stg.Clear();
            ChPlus.Clear();
            EnPlus.Clear();
            MaPlus.Clear();
            showstg();
        }

        private void butremove_Click(object sender, EventArgs e)
        {
            Stg.RemoveAt(0);
            showstg();
            ChPlus.Add(int.Parse(txtch.Text));
            EnPlus.Add(int.Parse(txten.Text));
            MaPlus.Add(int.Parse(txtma.Text));
        }

        //國文//
        

        private void buttotal_Click(object sender, EventArgs e)
        {

            //國文//
            
            int chsum = ChPlus.Sum();
            double chavg = chsum * 1.0 / ChPlus.Count;
            int chmax = ChPlus.Max();
            int chmin = ChPlus.Min();
            labchavg.Text = chavg.ToString("0.00");
            labchtotal.Text = chsum.ToString();
            labchmax.Text = chmax.ToString();
            labchmin.Text = chmin.ToString();

            //英文//

            int ensum = EnPlus.Sum();
            double enavg = ensum * 1.0 / EnPlus.Count;
            int enmax = EnPlus.Max();
            int enmin = EnPlus.Min();
            labenavg.Text = ensum.ToString();
            labentotal.Text = enavg.ToString("0.00");
            labenmax.Text = enmax.ToString();
            labenmin.Text = enmin.ToString();

            //數學//

            int masum = MaPlus.Sum();
            double maavg = ensum * 1.0 / MaPlus.Count;
            int mamax = MaPlus.Max();
            int mamin = MaPlus.Min();
            labmaavg.Text = maavg.ToString("0.00");
            labmatotal.Text = masum.ToString();
            labmamax.Text = mamax.ToString();
            labmamin.Text = mamin.ToString();



        }

        private void butadd20_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 21; i++)
            {
                string a = ran.Next(0, 100).ToString(); //姓名
                int b = ran.Next(0, 100);//國文
                int c = ran.Next(0, 100);//英文
                int d = ran.Next(0, 100);//數學
                int z = b + c + d;//總分
                int f = z / 3;//平均

                //大小//
                string[] Name = new string[] { "國文", "英文", "數學" };
                int[] Grade = new int[] { b, c, d };

                int min = Grade[0];
                int p = 0;
                for (int k = 0; k < 3; k++)//最小值
                {
                    if (min > Grade[k])
                    {
                        min = Grade[k];
                        p = k;
                    }
                }

                int max = Grade[0];
                int j = 0;
                for (int k = 0; k < 3; k++)//最大值
                {
                    if (max < Grade[k])
                    {
                        max = Grade[k];
                        j = k;
                    }
                }
                string g = $"{Name[p]}{min}分";//最小
                string o = $"{Name[j]}{max}分";//最大

                Stg.Insert(0, new IsSg
                {
                    Name = a,
                    CH = b,
                    EN = c,
                    MA = d,
                    total = z,
                    avg = f,
                    min = g,
                    max = o
                }
                );
                ChPlus.Add(b);
                EnPlus.Add(c);
                MaPlus.Add(d);

            }
            

            showstg();
            
        }

        private void butsave_Click(object sender, EventArgs e)
        {
            string a = ran.Next(0, 100).ToString(); //姓名
            int b = ran.Next(0, 100);//國文
            int c = ran.Next(0, 100);//英文
            int d = ran.Next(0, 100);//數學
            int z = b + c + d;//總分
            int f = z / 3;//平均

            //大小//
            string[] Name = new string[] { "國文", "英文", "數學" };
            int[] Grade = new int[] { b, c, d };

            int min = Grade[0];
            int p = 0;
            for (int k = 0; k < 3; k++)//最小值
            {
                if (min > Grade[k])
                {
                    min = Grade[k];
                    p = k;
                }
            }

            int max = Grade[0];
            int j = 0;
            for (int k = 0; k < 3; k++)//最大值
            {
                if (max < Grade[k])
                {
                    max = Grade[k];
                    j = k;
                }
            }
            string g = $"{Name[p]}{min}分";//最小
            string o = $"{Name[j]}{max}分";//最大

            Stg.Insert(0, new IsSg
            {
                Name = a,
                CH = b,
                EN = c,
                MA = d,
                total = z,
                avg = f,
                min = g,
                max = o
            }
            );
            showstg();
            ChPlus.Add(b);
            EnPlus.Add(c);
            MaPlus.Add(d);
        }
    }
}
