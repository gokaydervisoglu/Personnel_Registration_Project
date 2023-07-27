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
using System.IO;

namespace personnel_registration_project
{
    public partial class FormStaff : Form
    {
        public bool key;

        private FormMain formana;

        SqlConnection sql = new SqlConnection("Data Source=DESKTOP-3HN2204\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        public FormStaff()
        {
            InitializeComponent();
            this.Load += FormGiris_Load;

            formana = new FormMain();
            formana.FormClosedEvent += FormAna_FormClosedEvent;
        }
        private void FormAna_FormClosedEvent(object sender, EventArgs e)
        {
            this.Show();
        }
        private void FormGiris_Load(object sender, EventArgs e)
        {
            keyrd();

            if (key)
            {
                btnhatirla.Checked = true;
                personelrd();
            }
            else
            {
                txtad.Text = string.Empty;
                txtsifre.Text = string.Empty;
                btnhatirla.Checked = false;
            }
        }
        private void personelwr()
        {
            string ad, sifre;
            string path = "personel.txt";
            string path2 = "key_p.txt";

            ad = txtad.Text;
            sifre = txtsifre.Text;

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(ad);
                sw.WriteLine(sifre);
            }
            using (StreamWriter swr = new StreamWriter(path2))
            {
                swr.WriteLine(key.ToString());
            }
        }
        private void keywr()
        {
            string path = "key_p.txt";

            using (StreamWriter swr = new StreamWriter(path))
            {
                swr.WriteLine(key.ToString());
            }
        }
        private void personelrd()
        {
            string ad, sifre;
            string path = "personel.txt";

            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    ad = sr.ReadLine();
                    sifre = sr.ReadLine();
                }
                txtad.Text = ad;
                txtsifre.Text = sifre;
            }
        }
        private void keyrd()
        {
            string path2 = "key_p.txt";

            if (File.Exists(path2))
            {
                using (StreamReader sr = new StreamReader(path2))
                {
                    key = Convert.ToBoolean(sr.ReadLine());
                }
            }
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            if (txtad.Text == "" || txtsifre.Text == "")
            {
                MessageBox.Show("Lütfen Kullanici adi ve Şifre Giriniz");
            }
            else
            {
                sql.Open();

                SqlCommand cmd = new SqlCommand("Select * From Tbl_Kullanici where kullaniciadi=@p1 and sifre=@p2", sql);

                cmd.Parameters.AddWithValue("@p1", txtad.Text);
                cmd.Parameters.AddWithValue("@p2", txtsifre.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    FormMainStaff formAnaper = new FormMainStaff();

                    formAnaper.Show();
                    this.Hide();

                    //ozel
                    FormMainStaff formana = Application.OpenForms["FormAnaPer"] as FormMainStaff;
                    FormLogin formgiris = Application.OpenForms["FormGiris"] as FormLogin;

                    if (formana != null)
                    {
                        formgiris.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Hatali Kullanici Adi ya da Sifre");
                }

                sql.Close();
            }
        }

        private void btnhatirla_CheckedChanged(object sender, EventArgs e)
        {
            if (btnhatirla.Checked == true)
            {
                key = true;
                if (txtad.Text != "" || txtsifre.Text != "")
                {
                    personelwr();
                }
                else
                {

                }
            }
            else
            {
                key = false;
                File.Delete("personel.txt");
                keywr();
            }
        }

        private void goster_CheckedChanged(object sender, EventArgs e)
        {
            if (goster.Checked == true)
            {
                txtsifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtsifre.UseSystemPasswordChar = true;
            }
        }

        private void FormPersonel_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormLogin formGrs = Application.OpenForms["FormGiris"] as FormLogin;
            if (formGrs != null)
            {
                formGrs.Focus();
                formGrs.Show();
            }
        }
    }
}
