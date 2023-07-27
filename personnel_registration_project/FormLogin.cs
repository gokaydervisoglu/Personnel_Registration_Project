using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personnel_registration_project
{
    public partial class FormLogin : Form
    {
        public Boolean key = false;
        public Boolean key2 = false;

        private FormAdmin formadmin;
        private FormStaff formpersonel;
        
        public FormLogin()
        {
            InitializeComponent();
            formadmin = new FormAdmin();
            formadmin.FormClosed += FormAdmin_FormClosedEvent;

            formpersonel = new FormStaff();
            formpersonel.FormClosed += FormPersonel_FormClosedEvent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdmin formadmin = Application.OpenForms["FormAdmin"] as FormAdmin;

            if (formadmin != null)
            {
                formadmin.Focus();
            }

            FormStaff formPersonel = Application.OpenForms["FormPersonel"] as FormStaff;

            if (formPersonel != null)
            {
                formPersonel.Close();
            }


            if (formadmin == null || formadmin.IsDisposed)
            {
                formadmin = new FormAdmin();
                formadmin.FormClosed += FormAdmin_FormClosedEvent;
                //key = false;
            }

            if (key == true)
            {

            }
            else if (key == false)
            {

                formadmin.Show();
                key = true;

            }
        }

        private void FormAdmin_FormClosedEvent(object sender, EventArgs e)
        {
            key = false;
        }
        private void FormPersonel_FormClosedEvent(object sender, EventArgs e)
        {
            key2 = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMainStaff formanaper = Application.OpenForms["FormAnaPer"] as FormMainStaff;

            if (formanaper != null)
            {
                this.Hide();
            }

            FormStaff formPersonel = Application.OpenForms["FormPersonel"] as FormStaff;

            if (formPersonel != null)
            {
                formPersonel.Focus();
            }

            FormAdmin formadmin = Application.OpenForms["FormAdmin"] as FormAdmin;

            if (formadmin != null)
            {
                formadmin.Close();
            }


            if (formPersonel == null || formPersonel.IsDisposed)
            {
                formPersonel = new FormStaff();
                formPersonel.FormClosed += FormPersonel_FormClosedEvent;
                //key = false;
            }

            if (key2 == true)
            {

            }
            else if (key2 == false)
            {

                formPersonel.Show();
                key2 = true;
            }
        }
    }
}
