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

namespace PersonelKayıtProjesi
{
    public partial class FormAnaPer : Form
    {
        public event EventHandler FormClosedEvent;

        public Boolean key = false;
        public Boolean key2 = false;

        private FormIst formIst;
        private FormGrafikler formGrf;

        SqlConnection sql = new SqlConnection("Data Source=DESKTOP-3HN2204\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        public FormAnaPer()
        {
            InitializeComponent();
            formIst = new FormIst();
            formIst.FormClosed += FormIst_FormClosedEvent;

            formGrf = new FormGrafikler();
            formGrf.FormClosed += FormGrf_FormClosedEvent;
        }

        private void FormAnaPer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet3.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet3.Tbl_Personel);

        }

        private void FormIst_FormClosedEvent(object sender, EventArgs e)
        {
            key = false;
        }
        private void FormGrf_FormClosedEvent(object sender, EventArgs e)
        {
            key2 = false;
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

        private void btnlistele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet3.Tbl_Personel);
        }

        private void btnist_Click(object sender, EventArgs e)
        {
            FormIst formIst = Application.OpenForms["FormIst"] as FormIst;


            if (formIst != null)
            {
                formIst.Focus();
            }

            FormGrafikler formGrf = Application.OpenForms["FormGrafikler"] as FormGrafikler;

            if (formGrf != null)
            {
                formGrf.Close();
            }

            //FormIst Acık degilse tetiklenir
            if (formIst == null || formIst.IsDisposed)
            {
                formIst = new FormIst();
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
            FormGrafikler formGrf = Application.OpenForms["FormGrafikler"] as FormGrafikler;

            if (formGrf != null)
            {
                formGrf.Focus();
            }

            FormIst formIst = Application.OpenForms["FormIst"] as FormIst;

            if (formIst != null)
            {
                formIst.Close();
            }

            //FormGrafik Acık degilse tetiklenir
            if (formGrf == null || formGrf.IsDisposed)
            {
                key2 = false;
                formGrf = new FormGrafikler();
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

        private void FormAnaPer_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosedEvent?.Invoke(this, EventArgs.Empty);
        }

        private void FormAnaPer_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormPersonel formPersonel = Application.OpenForms["FormPersonel"] as FormPersonel;
            if (formPersonel != null)
            {
                formPersonel.Focus();
                formPersonel.Show();
            }
        }

        
    }
}
