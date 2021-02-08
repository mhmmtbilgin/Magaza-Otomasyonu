namespace GiyimMagazaOtomasyon
{
    partial class AdminIslem
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
            this.btnSatis = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnKullanici = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSatis
            // 
            this.btnSatis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatis.Location = new System.Drawing.Point(171, 203);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(375, 72);
            this.btnSatis.TabIndex = 0;
            this.btnSatis.Text = "Satis - Stok Modul";
            this.btnSatis.UseVisualStyleBackColor = false;
            this.btnSatis.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(171, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(375, 72);
            this.button2.TabIndex = 2;
            this.button2.Text = "Admin İşlemleri";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnKullanici
            // 
            this.btnKullanici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullanici.Location = new System.Drawing.Point(171, 396);
            this.btnKullanici.Name = "btnKullanici";
            this.btnKullanici.Size = new System.Drawing.Size(375, 72);
            this.btnKullanici.TabIndex = 3;
            this.btnKullanici.Text = "Kullanıcı İşlemleri";
            this.btnKullanici.UseVisualStyleBackColor = false;
            this.btnKullanici.Click += new System.EventHandler(this.btnKullanici_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "ADMİN İŞLEMLERİ MODÜLÜNE HOŞGELDİNİZ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AdminIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(739, 563);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKullanici);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSatis);
            this.Name = "AdminIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminIslem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnKullanici;
        private System.Windows.Forms.Label label1;
    }
}