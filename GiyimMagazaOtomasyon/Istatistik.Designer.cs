namespace GiyimMagazaOtomasyon
{
    partial class Istatistik
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
            this.btnEnAzSatilan = new System.Windows.Forms.Button();
            this.btnEnCokSatilan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEnCokKar = new System.Windows.Forms.Button();
            this.btnEnCokZarar = new System.Windows.Forms.Button();
            this.btnStokMiktar = new System.Windows.Forms.Button();
            this.Başlangıç = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dTimeBas = new System.Windows.Forms.DateTimePicker();
            this.dTimeSon = new System.Windows.Forms.DateTimePicker();
            this.btnKasiyer = new System.Windows.Forms.Button();
            this.cmbKasiyer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kasiyerAdi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKasa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnAzSatilan
            // 
            this.btnEnAzSatilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEnAzSatilan.Location = new System.Drawing.Point(17, 210);
            this.btnEnAzSatilan.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnAzSatilan.Name = "btnEnAzSatilan";
            this.btnEnAzSatilan.Size = new System.Drawing.Size(400, 62);
            this.btnEnAzSatilan.TabIndex = 3;
            this.btnEnAzSatilan.Text = "En Az Satılan Ürünler";
            this.btnEnAzSatilan.UseVisualStyleBackColor = true;
            this.btnEnAzSatilan.Click += new System.EventHandler(this.btnEnAzSatilan_Click);
            // 
            // btnEnCokSatilan
            // 
            this.btnEnCokSatilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEnCokSatilan.Location = new System.Drawing.Point(17, 147);
            this.btnEnCokSatilan.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnCokSatilan.Name = "btnEnCokSatilan";
            this.btnEnCokSatilan.Size = new System.Drawing.Size(400, 62);
            this.btnEnCokSatilan.TabIndex = 2;
            this.btnEnCokSatilan.Text = "En Çok Satılan Ürünler";
            this.btnEnCokSatilan.UseVisualStyleBackColor = true;
            this.btnEnCokSatilan.Click += new System.EventHandler(this.btnEnCokSatilan_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(451, 89);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(725, 552);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnEnCokKar
            // 
            this.btnEnCokKar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEnCokKar.Location = new System.Drawing.Point(17, 273);
            this.btnEnCokKar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnCokKar.Name = "btnEnCokKar";
            this.btnEnCokKar.Size = new System.Drawing.Size(400, 62);
            this.btnEnCokKar.TabIndex = 4;
            this.btnEnCokKar.Text = "En Çok Kar Edilen Ürünler";
            this.btnEnCokKar.UseVisualStyleBackColor = true;
            this.btnEnCokKar.Click += new System.EventHandler(this.btnEnCokKar_Click);
            // 
            // btnEnCokZarar
            // 
            this.btnEnCokZarar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEnCokZarar.Location = new System.Drawing.Point(17, 336);
            this.btnEnCokZarar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnCokZarar.Name = "btnEnCokZarar";
            this.btnEnCokZarar.Size = new System.Drawing.Size(400, 62);
            this.btnEnCokZarar.TabIndex = 5;
            this.btnEnCokZarar.Text = "En Az Kar Edilen Ürünler";
            this.btnEnCokZarar.UseVisualStyleBackColor = true;
            this.btnEnCokZarar.Click += new System.EventHandler(this.btnEnCokZarar_Click);
            // 
            // btnStokMiktar
            // 
            this.btnStokMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokMiktar.Location = new System.Drawing.Point(17, 399);
            this.btnStokMiktar.Margin = new System.Windows.Forms.Padding(4);
            this.btnStokMiktar.Name = "btnStokMiktar";
            this.btnStokMiktar.Size = new System.Drawing.Size(400, 62);
            this.btnStokMiktar.TabIndex = 6;
            this.btnStokMiktar.Text = "Stoktaki Ürün Miktarları";
            this.btnStokMiktar.UseVisualStyleBackColor = true;
            this.btnStokMiktar.Click += new System.EventHandler(this.btnStokMiktar_Click);
            // 
            // Başlangıç
            // 
            this.Başlangıç.AutoSize = true;
            this.Başlangıç.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Başlangıç.Location = new System.Drawing.Point(18, 88);
            this.Başlangıç.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Başlangıç.Name = "Başlangıç";
            this.Başlangıç.Size = new System.Drawing.Size(151, 25);
            this.Başlangıç.TabIndex = 16;
            this.Başlangıç.Text = "Başlangıç Tarihi";
            this.Başlangıç.Click += new System.EventHandler(this.Başlangıç_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(220, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(636, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 36);
            this.label1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(892, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 36);
            this.label5.TabIndex = 8;
            // 
            // dTimeBas
            // 
            this.dTimeBas.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dTimeBas.CustomFormat = "12.12.2012";
            this.dTimeBas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTimeBas.Location = new System.Drawing.Point(23, 121);
            this.dTimeBas.Margin = new System.Windows.Forms.Padding(4);
            this.dTimeBas.Name = "dTimeBas";
            this.dTimeBas.Size = new System.Drawing.Size(153, 22);
            this.dTimeBas.TabIndex = 19;
            this.dTimeBas.Value = new System.DateTime(2019, 12, 2, 0, 0, 0, 0);
            this.dTimeBas.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dTimeSon
            // 
            this.dTimeSon.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dTimeSon.CustomFormat = "12.12.2012";
            this.dTimeSon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTimeSon.Location = new System.Drawing.Point(194, 121);
            this.dTimeSon.Margin = new System.Windows.Forms.Padding(4);
            this.dTimeSon.Name = "dTimeSon";
            this.dTimeSon.Size = new System.Drawing.Size(160, 22);
            this.dTimeSon.TabIndex = 21;
            this.dTimeSon.Value = new System.DateTime(2019, 12, 2, 0, 0, 0, 0);
            // 
            // btnKasiyer
            // 
            this.btnKasiyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasiyer.Location = new System.Drawing.Point(17, 565);
            this.btnKasiyer.Margin = new System.Windows.Forms.Padding(4);
            this.btnKasiyer.Name = "btnKasiyer";
            this.btnKasiyer.Size = new System.Drawing.Size(400, 62);
            this.btnKasiyer.TabIndex = 22;
            this.btnKasiyer.Text = "Satış Yapan Kasiyer";
            this.btnKasiyer.UseVisualStyleBackColor = true;
            this.btnKasiyer.Click += new System.EventHandler(this.btnKasiyer_Click);
            // 
            // cmbKasiyer
            // 
            this.cmbKasiyer.FormattingEnabled = true;
            this.cmbKasiyer.Location = new System.Drawing.Point(257, 529);
            this.cmbKasiyer.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKasiyer.Name = "cmbKasiyer";
            this.cmbKasiyer.Size = new System.Drawing.Size(160, 24);
            this.cmbKasiyer.TabIndex = 24;
            this.cmbKasiyer.SelectedIndexChanged += new System.EventHandler(this.cmbKasiyer_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 529);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Kasiyer Adı: ";
            // 
            // kasiyerAdi
            // 
            this.kasiyerAdi.AutoSize = true;
            this.kasiyerAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kasiyerAdi.Location = new System.Drawing.Point(95, 571);
            this.kasiyerAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kasiyerAdi.Name = "kasiyerAdi";
            this.kasiyerAdi.Size = new System.Drawing.Size(0, 25);
            this.kasiyerAdi.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(482, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "İSTATİSTİK MODÜLÜNE HOŞGELDİNİZ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(135, 631);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 25);
            this.label8.TabIndex = 28;
            this.label8.Click += new System.EventHandler(this.label6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(135, 659);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 25);
            this.label9.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(31, 663);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Adres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(31, 635);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Tel";
            // 
            // btnKasa
            // 
            this.btnKasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasa.Location = new System.Drawing.Point(17, 462);
            this.btnKasa.Margin = new System.Windows.Forms.Padding(4);
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.Size = new System.Drawing.Size(400, 62);
            this.btnKasa.TabIndex = 32;
            this.btnKasa.Text = "Kasa Toplamı";
            this.btnKasa.UseVisualStyleBackColor = true;
            this.btnKasa.Click += new System.EventHandler(this.btnKasa_Click);
            // 
            // Istatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1189, 690);
            this.Controls.Add(this.btnKasa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kasiyerAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbKasiyer);
            this.Controls.Add(this.btnKasiyer);
            this.Controls.Add(this.dTimeSon);
            this.Controls.Add(this.dTimeBas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Başlangıç);
            this.Controls.Add(this.btnStokMiktar);
            this.Controls.Add(this.btnEnCokZarar);
            this.Controls.Add(this.btnEnCokKar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEnCokSatilan);
            this.Controls.Add(this.btnEnAzSatilan);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Istatistik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Istatistik";
            this.Load += new System.EventHandler(this.Istatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnAzSatilan;
        private System.Windows.Forms.Button btnEnCokSatilan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEnCokKar;
        private System.Windows.Forms.Button btnEnCokZarar;
        private System.Windows.Forms.Button btnStokMiktar;
        private System.Windows.Forms.Label Başlangıç;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dTimeBas;
        private System.Windows.Forms.DateTimePicker dTimeSon;
        private System.Windows.Forms.Button btnKasiyer;
        private System.Windows.Forms.ComboBox cmbKasiyer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label kasiyerAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKasa;
    }
}