﻿
namespace Öğrenci_Not_Kayıt
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnOgretmenGiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtOgretmenSifre = new System.Windows.Forms.TextBox();
            this.MskOgretmenNumara = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnOgrenciGiris = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtOgrenciSifre = new System.Windows.Forms.TextBox();
            this.MskOgrenciNumara = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnOgretmenGiris);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtOgretmenSifre);
            this.groupBox1.Controls.Add(this.MskOgretmenNumara);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(45, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğretmen";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnOgretmenGiris
            // 
            this.BtnOgretmenGiris.Location = new System.Drawing.Point(486, 174);
            this.BtnOgretmenGiris.Name = "BtnOgretmenGiris";
            this.BtnOgretmenGiris.Size = new System.Drawing.Size(100, 23);
            this.BtnOgretmenGiris.TabIndex = 5;
            this.BtnOgretmenGiris.Text = "Giriş Yap";
            this.BtnOgretmenGiris.UseVisualStyleBackColor = true;
            this.BtnOgretmenGiris.Click += new System.EventHandler(this.BtnOgretmenGiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numara:";
            // 
            // TxtOgretmenSifre
            // 
            this.TxtOgretmenSifre.Location = new System.Drawing.Point(486, 105);
            this.TxtOgretmenSifre.Name = "TxtOgretmenSifre";
            this.TxtOgretmenSifre.Size = new System.Drawing.Size(100, 20);
            this.TxtOgretmenSifre.TabIndex = 2;
            this.TxtOgretmenSifre.UseSystemPasswordChar = true;
            // 
            // MskOgretmenNumara
            // 
            this.MskOgretmenNumara.Location = new System.Drawing.Point(486, 58);
            this.MskOgretmenNumara.Name = "MskOgretmenNumara";
            this.MskOgretmenNumara.Size = new System.Drawing.Size(100, 20);
            this.MskOgretmenNumara.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnOgrenciGiris);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxtOgrenciSifre);
            this.groupBox2.Controls.Add(this.MskOgrenciNumara);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Location = new System.Drawing.Point(45, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 218);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci";
            // 
            // BtnOgrenciGiris
            // 
            this.BtnOgrenciGiris.Location = new System.Drawing.Point(486, 160);
            this.BtnOgrenciGiris.Name = "BtnOgrenciGiris";
            this.BtnOgrenciGiris.Size = new System.Drawing.Size(100, 23);
            this.BtnOgrenciGiris.TabIndex = 6;
            this.BtnOgrenciGiris.Text = "Giriş Yap";
            this.BtnOgrenciGiris.UseVisualStyleBackColor = true;
            this.BtnOgrenciGiris.Click += new System.EventHandler(this.BtnOgrenciGiris_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numara:";
            // 
            // TxtOgrenciSifre
            // 
            this.TxtOgrenciSifre.Location = new System.Drawing.Point(486, 98);
            this.TxtOgrenciSifre.Name = "TxtOgrenciSifre";
            this.TxtOgrenciSifre.Size = new System.Drawing.Size(100, 20);
            this.TxtOgrenciSifre.TabIndex = 2;
            this.TxtOgrenciSifre.UseSystemPasswordChar = true;
            // 
            // MskOgrenciNumara
            // 
            this.MskOgrenciNumara.Location = new System.Drawing.Point(486, 47);
            this.MskOgrenciNumara.Name = "MskOgrenciNumara";
            this.MskOgrenciNumara.Size = new System.Drawing.Size(100, 20);
            this.MskOgrenciNumara.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(270, 164);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 603);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmGiris";
            this.Text = "FrmGiris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtOgretmenSifre;
        private System.Windows.Forms.MaskedTextBox MskOgretmenNumara;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtOgrenciSifre;
        private System.Windows.Forms.MaskedTextBox MskOgrenciNumara;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnOgretmenGiris;
        private System.Windows.Forms.Button BtnOgrenciGiris;
    }
}

