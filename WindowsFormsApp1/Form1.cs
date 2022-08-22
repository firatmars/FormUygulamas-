using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           string[] datas=new string[] { "samandıra","esenyurt -1-","nilüfer","trakya - çorlu","kemalpaşa","sakarya","güzelhisar","esenyurt -3-","samsun","kocayatak","adana","trabzon","konya","şanlıurfa","aydın","kayseri","gebze -1-","balıkesir","akyurt -1-","gebze -2-","erzurum","çorum","haramidere","esenyurt -2-","gaziantep","ulukent","eskişehir","sancaktepe","yenikent","düzce","diyarbakır","muğla","kestel","van","mersin","aksaray","döşemealtı","ayrancılar","esenkent 1","ömerli","afyon","malatya","sivas","lüleburgaz","tuzla","gaziantep 2","iskenderun","kemalpaşa 2","hasanoğlan1","esenkent2","adana2","hasanoğlan2","","çumra","piraziz","kastamonu","denizli","izmit","batman","ığdır","arnavutköy 1","arnavutköy 2","döşemealtı 2","ısparta","osb ankara","akhisar","mersin 2","elazıg" };
           int[] datas2 = new int[] {154,130,142,175,150,160,155,128,191,155,220,160,160,173,160,190,172,120,164,142,166,154,150,150,161,143,83,159,125,236,180,159,180,152,140,184,150,150,167,180,159,200,160,164,165,164,75,100,143,173,160,100,167,172,145,145,180,148,61,220,136,150,135,140,180,150,10 };

            for (int i = 0; i < datas.Length -1; i++)
            {
                dataGridView1.Rows.Add(datas[i], datas2[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sehir = txtSehir.Text;
            int plaka =Convert.ToInt32(txtPlaka.Text);


            if(string.IsNullOrEmpty(sehir) || plaka==0)
            {
                MessageBox.Show("Hiçbir alanı boş bırakmayınız.");
            }
            else
            {
                dataGridView1.Rows.Add(sehir, plaka);
                MessageBox.Show("Satır eklendi.");
            }

            
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
        }
    }
}
