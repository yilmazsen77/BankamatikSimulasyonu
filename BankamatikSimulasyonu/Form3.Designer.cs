namespace BankamatikSimulasyonu
{
    partial class Form3
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
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mskHesapNo = new System.Windows.Forms.MaskedTextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.mskTcKimlik = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnHesap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "ŞİFRE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "HESAP NO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "TELEFON:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "TC KİMLİK NO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "SOYAD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "AD:";
            // 
            // mskHesapNo
            // 
            this.mskHesapNo.Enabled = false;
            this.mskHesapNo.Location = new System.Drawing.Point(123, 130);
            this.mskHesapNo.Mask = "000000";
            this.mskHesapNo.Name = "mskHesapNo";
            this.mskHesapNo.Size = new System.Drawing.Size(100, 20);
            this.mskHesapNo.TabIndex = 5;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(123, 6);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 1;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(123, 163);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSifre.TabIndex = 6;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(123, 36);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 2;
            // 
            // mskTcKimlik
            // 
            this.mskTcKimlik.Location = new System.Drawing.Point(123, 67);
            this.mskTcKimlik.Mask = "00000000000";
            this.mskTcKimlik.Name = "mskTcKimlik";
            this.mskTcKimlik.Size = new System.Drawing.Size(100, 20);
            this.mskTcKimlik.TabIndex = 3;
            this.mskTcKimlik.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MskTcKimlik_MaskInputRejected);
            // 
            // mskTelefon
            // 
            this.mskTelefon.Location = new System.Drawing.Point(123, 97);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(100, 20);
            this.mskTelefon.TabIndex = 4;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(137, 189);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 23;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // btnHesap
            // 
            this.btnHesap.Location = new System.Drawing.Point(229, 130);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(30, 21);
            this.btnHesap.TabIndex = 24;
            this.btnHesap.Text = "...";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.BtnHesap_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 227);
            this.Controls.Add(this.btnHesap);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.mskTelefon);
            this.Controls.Add(this.mskTcKimlik);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.mskHesapNo);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskHesapNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.MaskedTextBox mskTcKimlik;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnHesap;
    }
}