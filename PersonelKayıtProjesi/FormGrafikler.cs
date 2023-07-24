using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace PersonelKayıtProjesi
{
    public partial class FormGrafikler : Form
    {
        public event EventHandler FormClosedEvent;
        public Boolean key;

        SqlConnection sql = new SqlConnection("Data Source=DESKTOP-3HN2204\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        public FormGrafikler()
        {
            InitializeComponent();
        }

        private void FormGrafikler_Load(object sender, EventArgs e)
        {
            //Sehir Sayi Grafigi
            #region
            sql.Open();

            SqlCommand cmd = new SqlCommand("Select PerSehir,COUNT(*) from Tbl_Personel group by PerSehir", sql);
            SqlDataReader reader = cmd.ExecuteReader();
         

            while (reader.Read())
            {
                grfsehir.Series["Sehir"].Points.AddXY(reader[0], reader[1]);
            }

            sql.Close();
            #endregion

            //Durum Grafigi
            #region
            sql.Open();

            SqlCommand cmd2 = new SqlCommand("Select PerDurum,COUNT(*) from Tbl_Personel group by PerDurum", sql);
            SqlDataReader reader2 = cmd2.ExecuteReader();


            while (reader2.Read())
            {
                grfdurum.Series["Durum"].Points.AddXY(reader2[0], reader2[1]);
            }

            grfdurum.Series[0].Points[0].AxisLabel = "Bekar";
            grfdurum.Series[0].Points[1].AxisLabel = "Evli";


            sql.Close();
            #endregion

            //Ortalama Maas Grafigi
            #region
            sql.Open();

            SqlCommand cmd3 = new SqlCommand("Select PerMeslek,Avg(PerMaas) from Tbl_Personel group by PerMeslek", sql);
            SqlDataReader reader3 = cmd3.ExecuteReader();


            while (reader3.Read())
            {
                grfortmaas.Series["OrtalamaMaas"].Points.AddXY(reader3[0], reader3[1]);
            }

            sql.Close();
            #endregion

            //Meslek Grafigi
            #region
            sql.Open();

            SqlCommand cmd4 = new SqlCommand("Select PerMeslek,Count(*) from Tbl_Personel group by PerMeslek", sql);
            SqlDataReader reader4 = cmd4.ExecuteReader();


            while (reader4.Read())
            {
                grfmeslek.Series["Meslek"].Points.AddXY(reader4[0], reader4[1]);
            }

            sql.Close();
            #endregion
        }

        private void FormGrafikler_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosedEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
