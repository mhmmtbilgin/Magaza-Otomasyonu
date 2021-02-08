namespace GiyimMagazaOtomasyon
{
    partial class AnaModul
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
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.txtCinsiyet = new System.Windows.Forms.TextBox();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.mskBeden = new System.Windows.Forms.MaskedTextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnIstatistik = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dTime = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(317, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(727, 577);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(1052, 77);
            this.btnListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(139, 75);
            this.btnListele.TabIndex = 8;
            this.btnListele.Text = "Urun LİSTELE";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(1052, 325);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(139, 78);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Urun GUNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Barkod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cinsiyet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Beden";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(19, 285);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Renk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(19, 330);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Adet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(19, 382);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Fiyat";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkod.Location = new System.Drawing.Point(104, 99);
            this.txtBarkod.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(175, 30);
            this.txtBarkod.TabIndex = 0;
            // 
            // txtCinsiyet
            // 
            this.txtCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCinsiyet.Location = new System.Drawing.Point(104, 144);
            this.txtCinsiyet.Margin = new System.Windows.Forms.Padding(4);
            this.txtCinsiyet.Name = "txtCinsiyet";
            this.txtCinsiyet.Size = new System.Drawing.Size(175, 30);
            this.txtCinsiyet.TabIndex = 1;
            // 
            // txtTur
            // 
            this.txtTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTur.Location = new System.Drawing.Point(104, 190);
            this.txtTur.Margin = new System.Windows.Forms.Padding(4);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(175, 30);
            this.txtTur.TabIndex = 2;
            // 
            // txtAdet
            // 
            this.txtAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdet.Location = new System.Drawing.Point(104, 329);
            this.txtAdet.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(175, 30);
            this.txtAdet.TabIndex = 5;
            // 
            // txtRenk
            // 
            this.txtRenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRenk.Location = new System.Drawing.Point(104, 283);
            this.txtRenk.Margin = new System.Windows.Forms.Padding(4);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(175, 30);
            this.txtRenk.TabIndex = 4;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(104, 381);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(175, 30);
            this.txtFiyat.TabIndex = 6;
            // 
            // mskBeden
            // 
            this.mskBeden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskBeden.Location = new System.Drawing.Point(104, 237);
            this.mskBeden.Margin = new System.Windows.Forms.Padding(4);
            this.mskBeden.Name = "mskBeden";
            this.mskBeden.Size = new System.Drawing.Size(175, 30);
            this.mskBeden.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(1052, 160);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(139, 74);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Urun EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(1052, 242);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(139, 75);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Urun SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnIstatistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIstatistik.Location = new System.Drawing.Point(1052, 411);
            this.btnIstatistik.Margin = new System.Windows.Forms.Padding(4);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(139, 72);
            this.btnIstatistik.TabIndex = 12;
            this.btnIstatistik.Text = "Urun İSTATİSTİK";
            this.btnIstatistik.UseVisualStyleBackColor = false;
            this.btnIstatistik.Click += new System.EventHandler(this.btnIstatistik_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(19, 434);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 25);
            this.label8.TabIndex = 36;
            this.label8.Text = "Tarih";
            // 
            // dTime
            // 
            this.dTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTime.Location = new System.Drawing.Point(104, 434);
            this.dTime.Margin = new System.Windows.Forms.Padding(4);
            this.dTime.Name = "dTime";
            this.dTime.Size = new System.Drawing.Size(175, 22);
            this.dTime.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(12, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(281, 24);
            this.label9.TabIndex = 52;
            this.label9.Text = "ANAMODÜLE HOŞGELDİNİZ";
            // 
            // AnaModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1204, 603);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnIstatistik);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.mskBeden);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.txtTur);
            this.Controls.Add(this.txtCinsiyet);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnaModul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaModul";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnaModul_FormClosed);
            this.Load += new System.EventHandler(this.AnaModul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.TextBox txtCinsiyet;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.MaskedTextBox mskBeden;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnIstatistik;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dTime;
        private System.Windows.Forms.Label label9;
    }
}