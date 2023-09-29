namespace SatisTakipFormu
{
    partial class frmMüşteriListeleme
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
            btnGüncelle = new Button();
            txtEMail = new TextBox();
            txtAdres = new TextBox();
            txtTelefon = new TextBox();
            txtAdSoyad = new TextBox();
            txtTC = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSil = new Button();
            txtTCAra = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(340, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(700, 398);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(180, 380);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(75, 23);
            btnGüncelle.TabIndex = 13;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // txtEMail
            // 
            txtEMail.Location = new Point(153, 325);
            txtEMail.Name = "txtEMail";
            txtEMail.Size = new Size(150, 23);
            txtEMail.TabIndex = 8;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(153, 281);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(150, 23);
            txtAdres.TabIndex = 9;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(153, 237);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(150, 23);
            txtTelefon.TabIndex = 10;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(153, 193);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(150, 23);
            txtAdSoyad.TabIndex = 11;
            // 
            // txtTC
            // 
            txtTC.Location = new Point(153, 149);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(150, 23);
            txtTC.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(48, 331);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 3;
            label5.Text = "E-Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(48, 285);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 4;
            label4.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(48, 239);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 5;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(48, 193);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 6;
            label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(48, 147);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 7;
            label1.Text = "TC";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(180, 420);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 14;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtTCAra
            // 
            txtTCAra.Location = new Point(153, 85);
            txtTCAra.Name = "txtTCAra";
            txtTCAra.Size = new Size(100, 23);
            txtTCAra.TabIndex = 15;
            txtTCAra.TextChanged += txtTCAra_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(48, 88);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 16;
            label6.Text = "TC Ara";
            // 
            // frmMüşteriListeleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1109, 570);
            Controls.Add(label6);
            Controls.Add(txtTCAra);
            Controls.Add(btnSil);
            Controls.Add(btnGüncelle);
            Controls.Add(txtEMail);
            Controls.Add(txtAdres);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtTC);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "frmMüşteriListeleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += frmMüşteriListeleme_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnGüncelle;
        private TextBox txtEMail;
        private TextBox txtAdres;
        private TextBox txtTelefon;
        private TextBox txtAdSoyad;
        private TextBox txtTC;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSil;
        private TextBox txtTCAra;
        private Label label6;
    }
}