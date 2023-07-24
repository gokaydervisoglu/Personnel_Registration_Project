using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PersonelKayıtProjesi
{
    public partial class FormIst : Form
    {
        
        public event EventHandler FormClosedEvent;

        public Boolean key;
        public FormIst()
        {
            InitializeComponent();
        }

        SqlConnection sql = new SqlConnection("Data Source=DESKTOP-3HN2204\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void FormIst_Load(object sender, EventArgs e)
        {
            //Personel Sayisi
            #region
            sql.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from Tbl_Personel", sql);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            persayi.Text = reader[0].ToString();
            /*
            while (reader.Read())
            {
                persayi.Text = reader[0].ToString();
            }
            */

            sql.Close();
            #endregion

            //Evli Sayisi
            #region
            sql.Open();

            SqlCommand cmd2 = new SqlCommand("select count(*) from Tbl_Personel where PerDurum=1", sql);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            reader2.Read();
            evlisayi.Text = reader2[0].ToString();

            sql.Close();
            #endregion

            //Bekar Sayisi
            #region
            sql.Open();

            SqlCommand cmd3 = new SqlCommand("select count(*) from Tbl_Personel where PerDurum=0", sql);
            SqlDataReader reader3 = cmd3.ExecuteReader();
            reader3.Read();
            bekarsayi.Text = reader3[0].ToString();

            sql.Close();
            #endregion

            //Sehir Sayisi
            #region
            sql.Open();

            SqlCommand cmd4 = new SqlCommand("select count(DISTINCT PerSehir) from Tbl_Personel", sql);
            SqlDataReader reader4 = cmd4.ExecuteReader();
            reader4.Read();
            sehirsayi.Text = reader4[0].ToString();

            sql.Close();
            #endregion

            //Toplam Maas Sayisi
            #region
            sql.Open();

            SqlCommand cmd5 = new SqlCommand("select sum(PerMaas) from Tbl_Personel", sql);
            SqlDataReader reader5 = cmd5.ExecuteReader();
            reader5.Read();
            maassayi.Text = reader5[0].ToString();

            sql.Close();
            #endregion

            //Ortalama Maas Sayisi
            #region
            sql.Open();

            SqlCommand cmd6 = new SqlCommand("select Avg(PerMaas) from Tbl_Personel", sql);
            SqlDataReader reader6 = cmd6.ExecuteReader();
            reader6.Read();
            ortmaassayi.Text = reader6[0].ToString();

            sql.Close();
            #endregion

            //key = true;
        }

        private void FormIst_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosedEvent?.Invoke(this, EventArgs.Empty);
        }

        private void yenileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FormIst formIst = new FormIst();
            formIst.Show();
        }
    }
}
