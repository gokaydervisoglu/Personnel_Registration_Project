﻿namespace personnel_registration_project
{
    partial class FormAdmin
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
            this.txtad = new System.Windows.Forms.MaskedTextBox();
            this.lblad = new System.Windows.Forms.Label();
            this.lblsifre = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.MaskedTextBox();
            this.btngiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnhatirla = new System.Windows.Forms.CheckBox();
            this.goster = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtad.Location = new System.Drawing.Point(205, 92);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(136, 28);
            this.txtad.TabIndex = 0;
            this.txtad.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtad_MaskInputRejected);
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblad.Location = new System.Drawing.Point(26, 92);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(151, 29);
            this.lblad.TabIndex = 1;
            this.lblad.Text = "User Name:";
            this.lblad.Click += new System.EventHandler(this.lblad_Click);
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsifre.Location = new System.Drawing.Point(42, 131);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(135, 29);
            this.lblsifre.TabIndex = 2;
            this.lblsifre.Text = "Password:";
            this.lblsifre.Click += new System.EventHandler(this.lblsifre_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsifre.Location = new System.Drawing.Point(205, 131);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(136, 28);
            this.txtsifre.TabIndex = 3;
            this.txtsifre.UseSystemPasswordChar = true;
            this.txtsifre.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtsifre_MaskInputRejected);
            // 
            // btngiris
            // 
            this.btngiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngiris.Location = new System.Drawing.Point(205, 174);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(136, 44);
            this.btngiris.TabIndex = 4;
            this.btngiris.Text = "Login";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Admin Login Panel";
            // 
            // btnhatirla
            // 
            this.btnhatirla.AutoSize = true;
            this.btnhatirla.Location = new System.Drawing.Point(205, 250);
            this.btnhatirla.Name = "btnhatirla";
            this.btnhatirla.Size = new System.Drawing.Size(119, 20);
            this.btnhatirla.TabIndex = 7;
            this.btnhatirla.Text = "Remember me";
            this.btnhatirla.UseVisualStyleBackColor = true;
            this.btnhatirla.CheckedChanged += new System.EventHandler(this.btnhatirla_CheckedChanged);
            // 
            // goster
            // 
            this.goster.AutoSize = true;
            this.goster.Location = new System.Drawing.Point(205, 224);
            this.goster.Name = "goster";
            this.goster.Size = new System.Drawing.Size(125, 20);
            this.goster.TabIndex = 8;
            this.goster.Text = "Password Show";
            this.goster.UseVisualStyleBackColor = true;
            this.goster.CheckedChanged += new System.EventHandler(this.goster_CheckedChanged);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(408, 278);
            this.Controls.Add(this.goster);
            this.Controls.Add(this.btnhatirla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.txtad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdmin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtad;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.MaskedTextBox txtsifre;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox btnhatirla;
        private System.Windows.Forms.CheckBox goster;
    }
}