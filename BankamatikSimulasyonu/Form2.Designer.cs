namespace BankamatikSimulasyonu
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblHesapNo = new System.Windows.Forms.Label();
            this.lblTcKimlikNo = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mskHesapNo = new System.Windows.Forms.MaskedTextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hesap No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC Kimlik No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(126, 9);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(25, 13);
            this.lblAdSoyad.TabIndex = 4;
            this.lblAdSoyad.Text = "Null";
            // 
            // lblHesapNo
            // 
            this.lblHesapNo.AutoSize = true;
            this.lblHesapNo.Location = new System.Drawing.Point(126, 44);
            this.lblHesapNo.Name = "lblHesapNo";
            this.lblHesapNo.Size = new System.Drawing.Size(25, 13);
            this.lblHesapNo.TabIndex = 5;
            this.lblHesapNo.Text = "Null";
            this.lblHesapNo.Click += new System.EventHandler(this.LblHesapNo_Click);
            // 
            // lblTcKimlikNo
            // 
            this.lblTcKimlikNo.AutoSize = true;
            this.lblTcKimlikNo.Location = new System.Drawing.Point(126, 79);
            this.lblTcKimlikNo.Name = "lblTcKimlikNo";
            this.lblTcKimlikNo.Size = new System.Drawing.Size(25, 13);
            this.lblTcKimlikNo.TabIndex = 6;
            this.lblTcKimlikNo.Text = "Null";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(126, 114);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(25, 13);
            this.lblTelefon.TabIndex = 7;
            this.lblTelefon.Text = "Null";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.mskHesapNo);
            this.groupBox1.Controls.Add(this.txtTutar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(12, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 138);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Havale";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // mskHesapNo
            // 
            this.mskHesapNo.Location = new System.Drawing.Point(134, 22);
            this.mskHesapNo.Mask = "000000";
            this.mskHesapNo.Name = "mskHesapNo";
            this.mskHesapNo.Size = new System.Drawing.Size(100, 20);
            this.mskHesapNo.TabIndex = 8;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(134, 67);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(100, 20);
            this.txtTutar.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tutar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Hesap No";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 292);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblTcKimlikNo);
            this.Controls.Add(this.lblHesapNo);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblHesapNo;
        private System.Windows.Forms.Label lblTcKimlikNo;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mskHesapNo;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}