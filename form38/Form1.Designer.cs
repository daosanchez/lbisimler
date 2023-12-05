namespace form38
{
    partial class Form1
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
            this.lbİsimler = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtİsim = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnSira = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnRemoveSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnAzalan = new System.Windows.Forms.Button();
            this.btnArtan = new System.Windows.Forms.Button();
            this.btnKarakter = new System.Windows.Forms.Button();
            this.btnHarf = new System.Windows.Forms.Button();
            this.btnSil2 = new System.Windows.Forms.Button();
            this.btnHarf2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbİsimler
            // 
            this.lbİsimler.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbİsimler.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbİsimler.FormattingEnabled = true;
            this.lbİsimler.ItemHeight = 18;
            this.lbİsimler.Location = new System.Drawing.Point(12, 69);
            this.lbİsimler.Name = "lbİsimler";
            this.lbİsimler.Size = new System.Drawing.Size(120, 256);
            this.lbİsimler.TabIndex = 0;
            this.lbİsimler.SelectedIndexChanged += new System.EventHandler(this.lbİsimler_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEkle.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(163, 19);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(104, 47);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtİsim
            // 
            this.txtİsim.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtİsim.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtİsim.Location = new System.Drawing.Point(12, 19);
            this.txtİsim.Multiline = true;
            this.txtİsim.Name = "txtİsim";
            this.txtİsim.Size = new System.Drawing.Size(120, 29);
            this.txtİsim.TabIndex = 2;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAra.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAra.Location = new System.Drawing.Point(273, 19);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(104, 47);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnSira
            // 
            this.btnSira.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSira.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSira.Location = new System.Drawing.Point(163, 85);
            this.btnSira.Name = "btnSira";
            this.btnSira.Size = new System.Drawing.Size(104, 47);
            this.btnSira.TabIndex = 4;
            this.btnSira.Text = "Sıra";
            this.btnSira.UseVisualStyleBackColor = false;
            this.btnSira.Click += new System.EventHandler(this.btnSira_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSil.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(273, 85);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(104, 47);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnRemoveSil
            // 
            this.btnRemoveSil.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRemoveSil.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSil.Location = new System.Drawing.Point(163, 147);
            this.btnRemoveSil.Name = "btnRemoveSil";
            this.btnRemoveSil.Size = new System.Drawing.Size(104, 47);
            this.btnRemoveSil.TabIndex = 6;
            this.btnRemoveSil.Text = "Remove İle Sil";
            this.btnRemoveSil.UseVisualStyleBackColor = false;
            this.btnRemoveSil.Click += new System.EventHandler(this.btnRemoveSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKaydet.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(273, 147);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(104, 47);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnAzalan
            // 
            this.btnAzalan.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAzalan.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzalan.Location = new System.Drawing.Point(273, 209);
            this.btnAzalan.Name = "btnAzalan";
            this.btnAzalan.Size = new System.Drawing.Size(104, 47);
            this.btnAzalan.TabIndex = 8;
            this.btnAzalan.Text = "Azalan Sıralama";
            this.btnAzalan.UseVisualStyleBackColor = false;
            this.btnAzalan.Click += new System.EventHandler(this.btnAzalan_Click);
            // 
            // btnArtan
            // 
            this.btnArtan.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnArtan.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtan.Location = new System.Drawing.Point(163, 209);
            this.btnArtan.Name = "btnArtan";
            this.btnArtan.Size = new System.Drawing.Size(104, 47);
            this.btnArtan.TabIndex = 9;
            this.btnArtan.Text = "Artan Sıralama";
            this.btnArtan.UseVisualStyleBackColor = false;
            this.btnArtan.Click += new System.EventHandler(this.btnArtan_Click);
            // 
            // btnKarakter
            // 
            this.btnKarakter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKarakter.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKarakter.Location = new System.Drawing.Point(163, 273);
            this.btnKarakter.Name = "btnKarakter";
            this.btnKarakter.Size = new System.Drawing.Size(104, 47);
            this.btnKarakter.TabIndex = 10;
            this.btnKarakter.Text = "5 Karakterli Öğrenci Sayısı";
            this.btnKarakter.UseVisualStyleBackColor = false;
            this.btnKarakter.Click += new System.EventHandler(this.btnKarakter_Click);
            // 
            // btnHarf
            // 
            this.btnHarf.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnHarf.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHarf.Location = new System.Drawing.Point(273, 273);
            this.btnHarf.Name = "btnHarf";
            this.btnHarf.Size = new System.Drawing.Size(104, 47);
            this.btnHarf.TabIndex = 11;
            this.btnHarf.Text = "M ile Baslayan Öğrenci Sayısı";
            this.btnHarf.UseVisualStyleBackColor = false;
            this.btnHarf.Click += new System.EventHandler(this.btnHarf_Click);
            // 
            // btnSil2
            // 
            this.btnSil2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSil2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil2.Location = new System.Drawing.Point(163, 326);
            this.btnSil2.Name = "btnSil2";
            this.btnSil2.Size = new System.Drawing.Size(104, 47);
            this.btnSil2.TabIndex = 12;
            this.btnSil2.Text = "Sil";
            this.btnSil2.UseVisualStyleBackColor = false;
            this.btnSil2.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHarf2
            // 
            this.btnHarf2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnHarf2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHarf2.Location = new System.Drawing.Point(273, 326);
            this.btnHarf2.Name = "btnHarf2";
            this.btnHarf2.Size = new System.Drawing.Size(104, 47);
            this.btnHarf2.TabIndex = 13;
            this.btnHarf2.Text = "A ile Baslayan Öğrenci Sayısı";
            this.btnHarf2.UseVisualStyleBackColor = false;
            this.btnHarf2.Click += new System.EventHandler(this.btnHarf2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(390, 387);
            this.Controls.Add(this.btnHarf2);
            this.Controls.Add(this.btnSil2);
            this.Controls.Add(this.btnHarf);
            this.Controls.Add(this.btnKarakter);
            this.Controls.Add(this.btnArtan);
            this.Controls.Add(this.btnAzalan);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnRemoveSil);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSira);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtİsim);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lbİsimler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbİsimler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtİsim;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnSira;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnRemoveSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnAzalan;
        private System.Windows.Forms.Button btnArtan;
        private System.Windows.Forms.Button btnKarakter;
        private System.Windows.Forms.Button btnHarf;
        private System.Windows.Forms.Button btnSil2;
        private System.Windows.Forms.Button btnHarf2;
    }
}

