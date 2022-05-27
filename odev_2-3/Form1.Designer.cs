namespace odev_2_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMetinYukle = new System.Windows.Forms.Button();
            this.btnStackeOku = new System.Windows.Forms.Button();
            this.btnAgacaAktar = new System.Windows.Forms.Button();
            this.btnKelimeGetir = new System.Windows.Forms.Button();
            this.btnHashTabloOlustur = new System.Windows.Forms.Button();
            this.txtMetinYukle = new System.Windows.Forms.TextBox();
            this.txtStackeOku = new System.Windows.Forms.TextBox();
            this.lblKelimeGetir = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnMetinYukle
            // 
            this.btnMetinYukle.Location = new System.Drawing.Point(52, 30);
            this.btnMetinYukle.Name = "btnMetinYukle";
            this.btnMetinYukle.Size = new System.Drawing.Size(94, 29);
            this.btnMetinYukle.TabIndex = 0;
            this.btnMetinYukle.Text = "Metin Yükle";
            this.btnMetinYukle.UseVisualStyleBackColor = true;
            this.btnMetinYukle.Click += new System.EventHandler(this.btnMetinYukle_Click);
            // 
            // btnStackeOku
            // 
            this.btnStackeOku.Location = new System.Drawing.Point(354, 31);
            this.btnStackeOku.Name = "btnStackeOku";
            this.btnStackeOku.Size = new System.Drawing.Size(94, 26);
            this.btnStackeOku.TabIndex = 1;
            this.btnStackeOku.Text = "Stack\'e Oku";
            this.btnStackeOku.UseVisualStyleBackColor = true;
            this.btnStackeOku.Click += new System.EventHandler(this.btnStackeOku_Click);
            // 
            // btnAgacaAktar
            // 
            this.btnAgacaAktar.Location = new System.Drawing.Point(52, 176);
            this.btnAgacaAktar.Name = "btnAgacaAktar";
            this.btnAgacaAktar.Size = new System.Drawing.Size(119, 29);
            this.btnAgacaAktar.TabIndex = 2;
            this.btnAgacaAktar.Text = "Ağaca Aktar";
            this.btnAgacaAktar.UseVisualStyleBackColor = true;
            this.btnAgacaAktar.Click += new System.EventHandler(this.btnAgacaAktar_Click);
            // 
            // btnKelimeGetir
            // 
            this.btnKelimeGetir.Location = new System.Drawing.Point(53, 266);
            this.btnKelimeGetir.Name = "btnKelimeGetir";
            this.btnKelimeGetir.Size = new System.Drawing.Size(253, 29);
            this.btnKelimeGetir.TabIndex = 3;
            this.btnKelimeGetir.Text = "En Sık Kullanılan Kelimeleri Getir";
            this.btnKelimeGetir.UseVisualStyleBackColor = true;
            this.btnKelimeGetir.Click += new System.EventHandler(this.btnKelimeGetir_Click);
            // 
            // btnHashTabloOlustur
            // 
            this.btnHashTabloOlustur.Location = new System.Drawing.Point(387, 266);
            this.btnHashTabloOlustur.Name = "btnHashTabloOlustur";
            this.btnHashTabloOlustur.Size = new System.Drawing.Size(164, 29);
            this.btnHashTabloOlustur.TabIndex = 5;
            this.btnHashTabloOlustur.Text = "Hash Tablo Oluştur";
            this.btnHashTabloOlustur.UseVisualStyleBackColor = true;
            this.btnHashTabloOlustur.Click += new System.EventHandler(this.btnHashTabloOlustur_Click);
            // 
            // txtMetinYukle
            // 
            this.txtMetinYukle.Location = new System.Drawing.Point(53, 56);
            this.txtMetinYukle.Multiline = true;
            this.txtMetinYukle.Name = "txtMetinYukle";
            this.txtMetinYukle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMetinYukle.Size = new System.Drawing.Size(193, 71);
            this.txtMetinYukle.TabIndex = 6;
            // 
            // txtStackeOku
            // 
            this.txtStackeOku.Location = new System.Drawing.Point(355, 56);
            this.txtStackeOku.Multiline = true;
            this.txtStackeOku.Name = "txtStackeOku";
            this.txtStackeOku.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStackeOku.Size = new System.Drawing.Size(247, 71);
            this.txtStackeOku.TabIndex = 7;
            // 
            // lblKelimeGetir
            // 
            this.lblKelimeGetir.Font = new System.Drawing.Font("Sitka Small", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblKelimeGetir.FormattingEnabled = true;
            this.lblKelimeGetir.HorizontalScrollbar = true;
            this.lblKelimeGetir.ItemHeight = 19;
            this.lblKelimeGetir.Location = new System.Drawing.Point(53, 309);
            this.lblKelimeGetir.Name = "lblKelimeGetir";
            this.lblKelimeGetir.Size = new System.Drawing.Size(259, 99);
            this.lblKelimeGetir.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKelimeGetir);
            this.Controls.Add(this.txtStackeOku);
            this.Controls.Add(this.txtMetinYukle);
            this.Controls.Add(this.btnHashTabloOlustur);
            this.Controls.Add(this.btnKelimeGetir);
            this.Controls.Add(this.btnAgacaAktar);
            this.Controls.Add(this.btnStackeOku);
            this.Controls.Add(this.btnMetinYukle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMetinYukle;
        private Button btnStackeOku;
        private Button btnAgacaAktar;
        private Button btnKelimeGetir;
        private Button btnHashTabloOlustur;
        private TextBox txtMetinYukle;
        private TextBox txtStackeOku;
        private ListBox lblKelimeGetir;
    }
}