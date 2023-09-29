namespace SatisTakipFormu
{
    partial class frmÜrünListele
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
            dataGridView1 = new DataGridView();
            lblMiktar = new Label();
            btnGüncelle = new Button();
            Kategoritxt = new TextBox();
            SatışFiyattxt = new TextBox();
            label14 = new Label();
            AlışFiyattxt = new TextBox();
            label13 = new Label();
            Miktartxt = new TextBox();
            label12 = new Label();
            label11 = new Label();
            ÜrünAdıtxt = new TextBox();
            label10 = new Label();
            Markatxt = new TextBox();
            label9 = new Label();
            BarkodNotxt = new TextBox();
            label8 = new Label();
            btnSil = new Button();
            label1 = new Label();
            txtBarkodArama = new TextBox();
            cmbKategori = new ComboBox();
            cmbMarka = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btnMarkaGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(319, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(665, 345);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // lblMiktar
            // 
            lblMiktar.AutoSize = true;
            lblMiktar.Location = new Point(48, 411);
            lblMiktar.Name = "lblMiktar";
            lblMiktar.Size = new Size(0, 15);
            lblMiktar.TabIndex = 37;
            // 
            // btnGüncelle
            // 
            btnGüncelle.ForeColor = Color.Black;
            btnGüncelle.Location = new Point(168, 407);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(75, 23);
            btnGüncelle.TabIndex = 22;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // Kategoritxt
            // 
            Kategoritxt.Location = new Point(151, 179);
            Kategoritxt.Name = "Kategoritxt";
            Kategoritxt.ReadOnly = true;
            Kategoritxt.Size = new Size(121, 23);
            Kategoritxt.TabIndex = 36;
            // 
            // SatışFiyattxt
            // 
            SatışFiyattxt.Location = new Point(151, 359);
            SatışFiyattxt.Name = "SatışFiyattxt";
            SatışFiyattxt.Size = new Size(121, 23);
            SatışFiyattxt.TabIndex = 35;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.White;
            label14.Location = new Point(48, 362);
            label14.Name = "label14";
            label14.Size = new Size(62, 15);
            label14.TabIndex = 29;
            label14.Text = "Satış Fiyatı";
            // 
            // AlışFiyattxt
            // 
            AlışFiyattxt.Location = new Point(151, 323);
            AlışFiyattxt.Name = "AlışFiyattxt";
            AlışFiyattxt.Size = new Size(121, 23);
            AlışFiyattxt.TabIndex = 34;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.White;
            label13.Location = new Point(48, 326);
            label13.Name = "label13";
            label13.Size = new Size(57, 15);
            label13.TabIndex = 28;
            label13.Text = "Alış Fiyatı";
            // 
            // Miktartxt
            // 
            Miktartxt.Location = new Point(151, 287);
            Miktartxt.Name = "Miktartxt";
            Miktartxt.Size = new Size(121, 23);
            Miktartxt.TabIndex = 33;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(48, 290);
            label12.Name = "label12";
            label12.Size = new Size(41, 15);
            label12.TabIndex = 27;
            label12.Text = "Miktar";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(48, 254);
            label11.Name = "label11";
            label11.Size = new Size(54, 15);
            label11.TabIndex = 26;
            label11.Text = "Ürün Adı";
            // 
            // ÜrünAdıtxt
            // 
            ÜrünAdıtxt.Location = new Point(151, 251);
            ÜrünAdıtxt.Name = "ÜrünAdıtxt";
            ÜrünAdıtxt.Size = new Size(121, 23);
            ÜrünAdıtxt.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(48, 218);
            label10.Name = "label10";
            label10.Size = new Size(40, 15);
            label10.TabIndex = 25;
            label10.Text = "Marka";
            // 
            // Markatxt
            // 
            Markatxt.Location = new Point(151, 214);
            Markatxt.Name = "Markatxt";
            Markatxt.ReadOnly = true;
            Markatxt.Size = new Size(121, 23);
            Markatxt.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(48, 182);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 24;
            label9.Text = "Kategori";
            // 
            // BarkodNotxt
            // 
            BarkodNotxt.Location = new Point(151, 143);
            BarkodNotxt.Name = "BarkodNotxt";
            BarkodNotxt.Size = new Size(121, 23);
            BarkodNotxt.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(48, 146);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 23;
            label8.Text = "Barkod No";
            // 
            // btnSil
            // 
            btnSil.ForeColor = Color.Black;
            btnSil.Location = new Point(1010, 83);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 22;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(48, 83);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 38;
            label1.Text = "Barkod Arama";
            label1.Click += label1_Click;
            // 
            // txtBarkodArama
            // 
            txtBarkodArama.Location = new Point(151, 80);
            txtBarkodArama.Name = "txtBarkodArama";
            txtBarkodArama.Size = new Size(121, 23);
            txtBarkodArama.TabIndex = 39;
            txtBarkodArama.TextChanged += textBox1_TextChanged;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(479, 454);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(121, 23);
            cmbKategori.TabIndex = 40;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // cmbMarka
            // 
            cmbMarka.FormattingEnabled = true;
            cmbMarka.Location = new Point(479, 490);
            cmbMarka.Name = "cmbMarka";
            cmbMarka.Size = new Size(121, 23);
            cmbMarka.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(399, 457);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 24;
            label2.Text = "Kategori";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(399, 493);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 25;
            label3.Text = "Marka";
            // 
            // btnMarkaGuncelle
            // 
            btnMarkaGuncelle.ForeColor = Color.Black;
            btnMarkaGuncelle.Location = new Point(623, 474);
            btnMarkaGuncelle.Name = "btnMarkaGuncelle";
            btnMarkaGuncelle.Size = new Size(112, 23);
            btnMarkaGuncelle.TabIndex = 22;
            btnMarkaGuncelle.Text = "Marka Güncelle";
            btnMarkaGuncelle.UseVisualStyleBackColor = true;
            btnMarkaGuncelle.Click += btnMarkaGuncelle_Click;
            // 
            // frmÜrünListele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1109, 570);
            Controls.Add(cmbMarka);
            Controls.Add(cmbKategori);
            Controls.Add(txtBarkodArama);
            Controls.Add(label1);
            Controls.Add(lblMiktar);
            Controls.Add(btnSil);
            Controls.Add(btnMarkaGuncelle);
            Controls.Add(btnGüncelle);
            Controls.Add(Kategoritxt);
            Controls.Add(SatışFiyattxt);
            Controls.Add(label14);
            Controls.Add(AlışFiyattxt);
            Controls.Add(label13);
            Controls.Add(Miktartxt);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(ÜrünAdıtxt);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(Markatxt);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(BarkodNotxt);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Name = "frmÜrünListele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Listele";
            Load += frmÜrünListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblMiktar;
        private Button btnGüncelle;
        private TextBox Kategoritxt;
        private TextBox SatışFiyattxt;
        private Label label14;
        private TextBox AlışFiyattxt;
        private Label label13;
        private TextBox Miktartxt;
        private Label label12;
        private Label label11;
        private TextBox ÜrünAdıtxt;
        private Label label10;
        private TextBox Markatxt;
        private Label label9;
        private TextBox BarkodNotxt;
        private Label label8;
        private Button btnSil;
        private Label label1;
        private TextBox txtBarkodArama;
        private ComboBox cmbKategori;
        private ComboBox cmbMarka;
        private Label label2;
        private Label label3;
        private Button btnMarkaGuncelle;
    }
}