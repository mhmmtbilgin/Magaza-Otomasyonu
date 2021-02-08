namespace GiyimMagazaOtomasyon
{
    partial class Islemler
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
            this.btnStok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSatis
            // 
            this.btnSatis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatis.Location = new System.Drawing.Point(245, 154);
            this.btnSatis.Margin = new System.Windows.Forms.Padding(4);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(267, 62);
            this.btnSatis.TabIndex = 0;
            this.btnSatis.Text = "Satış Modul";
            this.btnSatis.UseVisualStyleBackColor = false;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // btnStok
            // 
            this.btnStok.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStok.Location = new System.Drawing.Point(245, 238);
            this.btnStok.Margin = new System.Windows.Forms.Padding(4);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(267, 62);
            this.btnStok.TabIndex = 1;
            this.btnStok.Text = "Stok Modul";
            this.btnStok.UseVisualStyleBackColor = false;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(79, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "İŞLEMLER MODÜLÜNE HOŞGELDİNİZ";
            // 
            // Islemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(783, 408);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStok);
            this.Controls.Add(this.btnSatis);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Islemler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Islemler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.Label label1;
    }
}