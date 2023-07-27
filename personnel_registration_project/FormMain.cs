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
using System.Diagnostics;

namespace personnel_registration_project
{
    public partial class FormMain : Form
    {
        public event EventHandler FormClosedEvent;

        public Boolean key = false;
        public Boolean key2 = false;

        private FormSta formIst;
        private FormGraphic formGrf;
        private FormAdmin formadmin;
        private FormStaff formpersonel;

        public FormMain()
        {
            InitializeComponent();
            formIst = new FormSta();
            formIst.FormClosed += FormIst_FormClosedEvent;

            formGrf = new FormGraphic();
            formGrf.FormClosed += FormGrf_FormClosedEvent;

        }

        //FormIst Kapatildiginda tetiklenir
        private void FormIst_FormClosedEvent(object sender, EventArgs e)
        {
            key = false;
        }
        private void FormGrf_FormClosedEvent(object sender, EventArgs e)
        {
            key2 = false;
        }

        SqlConnection sql = new SqlConnection("Data Source=DESKTOP-3HN2204\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet2.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet2.Tbl_Personel);
        }

        #region
        private void btnlistele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet2.Tbl_Personel);
        }

        private void btntemizlik_Click(object sender, EventArgs e)
        {
            txtad.Clear();
            txtmaas.Clear();
            txtsoyad.Clear();
            txtmeslek.Clear();
            comboBoxsehir.Text = "";
            radioButton1.Checked = false; radioButton2.Checked = false;
           
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            sql.Open();
            SqlCommand cmd = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)",sql);

            if(txtad.Text == "" || txtsoyad.Text == "" || comboBoxsehir.Text == "" || txtmaas.Text == "" || txtmeslek.Text == "")
            {
                MessageBox.Show("Lütfen Bilgilerin Tamamını Giriniz");
            }
            else
            {
                cmd.Parameters.AddWithValue("@p1", txtad.Text);
                cmd.Parameters.AddWithValue("@p2", txtsoyad.Text);
                cmd.Parameters.AddWithValue("@p3", comboBoxsehir.Text);
                cmd.Parameters.AddWithValue("@p4", txtmaas.Text);
                cmd.Parameters.AddWithValue("@p5", txtmeslek.Text);

                if (radioButton1.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@p6", 1);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@p6", 0);
                }

                cmd.ExecuteNonQuery();

                MessageBox.Show("Personel Eklendi!");

                this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet2.Tbl_Personel);
            }

            sql.Close();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();

            txtad.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            comboBoxsehir.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            txtmaas.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();

            

            string check = dataGridView1.Rows[selected].Cells[5].Value.ToString();
            if(check == "True")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            if(check == "False") 
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }

            txtmeslek.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            sql.Open();
            if (txtid.Text == "")
            {
                MessageBox.Show("Lütfen Geçerli Id Giriniz");
            }
            else
            {
                SqlCommand delete = new SqlCommand("Delete from Tbl_Personel Where PerId = @k1", sql);
                delete.Parameters.AddWithValue("@k1", txtid.Text);
                delete.ExecuteNonQuery();


                MessageBox.Show("Kayıt Silindi!");

                this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet2.Tbl_Personel);
            }

            sql.Close();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            sql.Open();

            if (txtid.Text == "")
            {
                MessageBox.Show("Lütfen Geçerli Id Giriniz");
            }
            else
            {
                SqlCommand update = new SqlCommand("Update Tbl_Personel Set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerMaas=@a4,PerDurum=@a5,PerMeslek=@a7 where Perid=@a6",sql);
                update.Parameters.AddWithValue("@a1", txtad.Text);
                update.Parameters.AddWithValue("@a2", txtsoyad.Text);
                update.Parameters.AddWithValue("@a3", comboBoxsehir.Text);
                update.Parameters.AddWithValue("@a4", txtmaas.Text);
                update.Parameters.AddWithValue("@a7", txtmeslek.Text);
                
                update.Parameters.AddWithValue("@a6", txtid.Text);


                if (radioButton1.Checked == true)
                {
                    update.Parameters.AddWithValue("@a5", 1);
                }
                else
                {
                    update.Parameters.AddWithValue("@a5", 0);
                }

                update.ExecuteNonQuery();


                MessageBox.Show("Kayıt Güncellendi!");

                this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet2.Tbl_Personel);
            }


            sql.Close();
        }

        private void btnist_Click(object sender, EventArgs e)
        {
            FormSta formIst = Application.OpenForms["FormIst"] as FormSta;
            

            if (formIst != null)
            {
                formIst.Focus();
            }

            FormGraphic formGrf = Application.OpenForms["FormGrafikler"] as FormGraphic;

            if (formGrf != null)
            {
                formGrf.Close();
            }

            //FormIst Acık degilse tetiklenir
            if (formIst == null || formIst.IsDisposed)
            {
                formIst = new FormSta();
                formIst.FormClosed += FormIst_FormClosedEvent;
            }

            if (key == true)
            {

            }
            else if (key == false) 
            {

                formIst.Show();
                key = true;
            }
        
  
        }

        private void btngrafik_Click(object sender, EventArgs e)
        {
           
            FormGraphic formGrf = Application.OpenForms["FormGrafikler"] as FormGraphic;

            if (formGrf != null)
            {
                formGrf.Focus();
            }

            FormSta formIst = Application.OpenForms["FormIst"] as FormSta;

            if (formIst != null)
            {
                formIst.Close();
            }

            //FormGrafik Acık degilse tetiklenir
            if (formGrf == null || formGrf.IsDisposed)
            {
                key2 = false;
                formGrf = new FormGraphic();
                formGrf.FormClosed += FormIst_FormClosedEvent;
            }
            if (key2 == true)
            {

            }
            else if (key2 == false)
            {

                formGrf.Show();
                key2 = true;
            }

        }
        #endregion

        private void FormAna_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosedEvent?.Invoke(this, EventArgs.Empty);
        }

        private void FormAna_FormClosing(object sender, FormClosingEventArgs e)
        {

            FormAdmin formGrs = Application.OpenForms["formadmin"] as FormAdmin;
            if (formGrs != null)
            {
                formGrs.Focus();
                formGrs.Show();
            }

            FormStaff formPersonel = Application.OpenForms["FormPersonel"] as FormStaff;
            if (formPersonel != null)
            {
                formPersonel.Focus();
                formPersonel.Show();
            }

        }
    }
}
