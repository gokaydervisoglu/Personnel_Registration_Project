namespace PersonelKayıtProjesi
{
    partial class FormPersonel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.goster = new System.Windows.Forms.CheckBox();
            this.btnhatirla = new System.Windows.Forms.CheckBox();
            this.btngiris = new System.Windows.Forms.Button();
            this.txtsifre = new System.Windows.Forms.MaskedTextBox();
            this.lblsifre = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Personel Giriş Paneli";
            // 
            // goster
            // 
            this.goster.AutoSize = true;
            this.goster.Location = new System.Drawing.Point(232, 200);
            this.goster.Name = "goster";
            this.goster.Size = new System.Drawing.Size(112, 20);
            this.goster.TabIndex = 15;
            this.goster.Text = "Parola Göster";
            this.goster.UseVisualStyleBackColor = true;
            this.goster.CheckedChanged += new System.EventHandler(this.goster_CheckedChanged);
            // 
            // btnhatirla
            // 
            this.btnhatirla.AutoSize = true;
            this.btnhatirla.Location = new System.Drawing.Point(232, 226);
            this.btnhatirla.Name = "btnhatirla";
            this.btnhatirla.Size = new System.Drawing.Size(98, 20);
            this.btnhatirla.TabIndex = 14;
            this.btnhatirla.Text = "Beni Hatirla";
            this.btnhatirla.UseVisualStyleBackColor = true;
            this.btnhatirla.CheckedChanged += new System.EventHandler(this.btnhatirla_CheckedChanged);
            // 
            // btngiris
            // 
            this.btngiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngiris.Location = new System.Drawing.Point(232, 165);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(136, 29);
            this.btngiris.TabIndex = 13;
            this.btngiris.Text = "Giriş";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsifre.Location = new System.Drawing.Point(232, 122);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(136, 28);
            this.txtsifre.TabIndex = 12;
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsifre.Location = new System.Drawing.Point(129, 120);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(75, 29);
            this.lblsifre.TabIndex = 11;
            this.lblsifre.Text = "Şifre:";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblad.Location = new System.Drawing.Point(39, 81);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(165, 29);
            this.lblad.TabIndex = 10;
            this.lblad.Text = "Kullanici Adi:";
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtad.Location = new System.Drawing.Point(232, 83);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(136, 28);
            this.txtad.TabIndex = 9;
            // 
            // FormPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 278);
            this.Controls.Add(this.goster);
            this.Controls.Add(this.btnhatirla);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label1);
            this.Name = "FormPersonel";
            this.Text = "FormPersonel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPersonel_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox goster;
        private System.Windows.Forms.CheckBox btnhatirla;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.MaskedTextBox txtsifre;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.MaskedTextBox txtad;
    }
}