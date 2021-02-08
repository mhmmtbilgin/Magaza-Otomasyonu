namespace GiyimMagazaOtomasyon
{
    partial class Admin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdminSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdminAdres = new System.Windows.Forms.TextBox();
            this.txtadminTel = new System.Windows.Forms.TextBox();
            this.txtAdminSoyAd = new System.Windows.Forms.TextBox();
            this.txtAdminAd = new System.Windows.Forms.TextBox();
            this.txtAdminid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(475, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(428, 243);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick_1);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.Location = new System.Drawing.Point(352, 400);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(163, 59);
            this.btnGüncelle.TabIndex = 8;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click_1);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Plum;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(195, 400);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(151, 59);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(26, 400);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(163, 59);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(137, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Şifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(125, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(111, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(120, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(152, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ad";
            // 
            // txtAdminSifre
            // 
            this.txtAdminSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminSifre.Location = new System.Drawing.Point(195, 335);
            this.txtAdminSifre.Name = "txtAdminSifre";
            this.txtAdminSifre.Size = new System.Drawing.Size(158, 30);
            this.txtAdminSifre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(161, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Id";
            // 
            // txtAdminAdres
            // 
            this.txtAdminAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminAdres.Location = new System.Drawing.Point(195, 299);
            this.txtAdminAdres.Name = "txtAdminAdres";
            this.txtAdminAdres.Size = new System.Drawing.Size(158, 30);
            this.txtAdminAdres.TabIndex = 4;
            // 
            // txtadminTel
            // 
            this.txtadminTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadminTel.Location = new System.Drawing.Point(195, 263);
            this.txtadminTel.Name = "txtadminTel";
            this.txtadminTel.Size = new System.Drawing.Size(158, 30);
            this.txtadminTel.TabIndex = 3;
            // 
            // txtAdminSoyAd
            // 
            this.txtAdminSoyAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminSoyAd.Location = new System.Drawing.Point(195, 227);
            this.txtAdminSoyAd.Name = "txtAdminSoyAd";
            this.txtAdminSoyAd.Size = new System.Drawing.Size(158, 30);
            this.txtAdminSoyAd.TabIndex = 2;
            // 
            // txtAdminAd
            // 
            this.txtAdminAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminAd.Location = new System.Drawing.Point(195, 191);
            this.txtAdminAd.Name = "txtAdminAd";
            this.txtAdminAd.Size = new System.Drawing.Size(158, 30);
            this.txtAdminAd.TabIndex = 1;
            // 
            // txtAdminid
            // 
            this.txtAdminid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminid.Location = new System.Drawing.Point(195, 153);
            this.txtAdminid.Name = "txtAdminid";
            this.txtAdminid.Size = new System.Drawing.Size(158, 30);
            this.txtAdminid.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(150, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(582, 39);
            this.label7.TabIndex = 36;
            this.label7.Text = "ADMİN EKRANINA HOŞGELDİNİZ";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(987, 547);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdminSifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdminAdres);
            this.Controls.Add(this.txtadminTel);
            this.Controls.Add(this.txtAdminSoyAd);
            this.Controls.Add(this.txtAdminAd);
            this.Controls.Add(this.txtAdminid);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdminSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdminAdres;
        private System.Windows.Forms.TextBox txtadminTel;
        private System.Windows.Forms.TextBox txtAdminSoyAd;
        private System.Windows.Forms.TextBox txtAdminAd;
        private System.Windows.Forms.TextBox txtAdminid;
        private System.Windows.Forms.Label label7;

    }
}