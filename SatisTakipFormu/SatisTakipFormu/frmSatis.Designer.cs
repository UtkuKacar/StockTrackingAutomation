namespace SatisTakipFormu
{
    partial class frmSatış
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTelefon = new TextBox();
            txtAdSoyad = new TextBox();
            txtTC = new TextBox();
            groupBox2 = new GroupBox();
            txtSatışFiyatı = new TextBox();
            txtMiktar = new TextBox();
            txtBarkodNo = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtÜrünAdı = new TextBox();
            btnSil = new Button();
            btnSatışYap = new Button();
            btnSatışİptal = new Button();
            label9 = new Label();
            lblGenelToplam = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            btnEkle = new Button();
            txtToplamFiyatı = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(267, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(721, 298);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTelefon);
            groupBox1.Controls.Add(txtAdSoyad);
            groupBox1.Controls.Add(txtTC);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(38, 163);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 142);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri İşlemleri";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 105);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 3;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 66);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 26);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 1;
            label1.Text = "TC";
            label1.Click += label1_Click;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(88, 102);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 23);
            txtTelefon.TabIndex = 0;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(88, 63);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(100, 23);
            txtAdSoyad.TabIndex = 0;
            // 
            // txtTC
            // 
            txtTC.Location = new Point(88, 23);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(100, 23);
            txtTC.TabIndex = 0;
            txtTC.TextChanged += txtTC_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtToplamFiyatı);
            groupBox2.Controls.Add(txtSatışFiyatı);
            groupBox2.Controls.Add(txtMiktar);
            groupBox2.Controls.Add(txtBarkodNo);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtÜrünAdı);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(38, 329);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 174);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ürün İşlemleri";
            // 
            // txtSatışFiyatı
            // 
            txtSatışFiyatı.Location = new Point(88, 109);
            txtSatışFiyatı.Name = "txtSatışFiyatı";
            txtSatışFiyatı.Size = new Size(100, 23);
            txtSatışFiyatı.TabIndex = 8;
            txtSatışFiyatı.TextChanged += txtSatışFiyatı_TextChanged;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(88, 80);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(100, 23);
            txtMiktar.TabIndex = 7;
            txtMiktar.Text = "1";
            txtMiktar.TextAlign = HorizontalAlignment.Center;
            txtMiktar.TextChanged += txtMiktar_TextChanged;
            // 
            // txtBarkodNo
            // 
            txtBarkodNo.Location = new Point(88, 22);
            txtBarkodNo.Name = "txtBarkodNo";
            txtBarkodNo.Size = new Size(100, 23);
            txtBarkodNo.TabIndex = 6;
            txtBarkodNo.TextChanged += txtBarkodNo_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 141);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 5;
            label8.Text = "Toplam Fiyat";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 112);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 4;
            label7.Text = "Satış Fiyatı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 83);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 3;
            label6.Text = "Miktar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 54);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 2;
            label5.Text = "Ürün Adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 25);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 1;
            label4.Text = "Barkod No";
            label4.Click += label4_Click;
            // 
            // txtÜrünAdı
            // 
            txtÜrünAdı.Location = new Point(88, 51);
            txtÜrünAdı.Name = "txtÜrünAdı";
            txtÜrünAdı.Size = new Size(100, 23);
            txtÜrünAdı.TabIndex = 0;
            txtÜrünAdı.TextChanged += textBox3_TextChanged;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(1013, 181);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 4;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnSatışYap
            // 
            btnSatışYap.Location = new Point(850, 480);
            btnSatışYap.Name = "btnSatışYap";
            btnSatışYap.Size = new Size(75, 23);
            btnSatışYap.TabIndex = 5;
            btnSatışYap.Text = "Satış Yap";
            btnSatışYap.UseVisualStyleBackColor = true;
            btnSatışYap.Click += btnSatışYap_Click;
            // 
            // btnSatışİptal
            // 
            btnSatışİptal.Location = new Point(1013, 229);
            btnSatışİptal.Name = "btnSatışİptal";
            btnSatışİptal.Size = new Size(75, 23);
            btnSatışİptal.TabIndex = 6;
            btnSatışİptal.Text = "Satış İptal";
            btnSatışİptal.UseVisualStyleBackColor = true;
            btnSatışİptal.Click += btnSatışİptal_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(603, 488);
            label9.Name = "label9";
            label9.Size = new Size(79, 15);
            label9.TabIndex = 7;
            label9.Text = "Genel Toplam";
            label9.Click += label9_Click;
            // 
            // lblGenelToplam
            // 
            lblGenelToplam.AutoSize = true;
            lblGenelToplam.Location = new Point(714, 488);
            lblGenelToplam.Name = "lblGenelToplam";
            lblGenelToplam.Size = new Size(0, 15);
            lblGenelToplam.TabIndex = 7;
            lblGenelToplam.Click += label9_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1109, 129);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.Location = new Point(784, 46);
            button2.Name = "button2";
            button2.Size = new Size(130, 42);
            button2.TabIndex = 5;
            button2.Text = "Marka";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(638, 46);
            button1.Name = "button1";
            button1.Size = new Size(130, 42);
            button1.TabIndex = 5;
            button1.Text = "Kategori";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button9
            // 
            button9.Location = new Point(958, 46);
            button9.Name = "button9";
            button9.Size = new Size(130, 42);
            button9.TabIndex = 4;
            button9.Text = "Satış Listeleme";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(468, 46);
            button8.Name = "button8";
            button8.Size = new Size(130, 42);
            button8.TabIndex = 3;
            button8.Text = "Ürün Listeleme";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(321, 46);
            button7.Name = "button7";
            button7.Size = new Size(130, 42);
            button7.TabIndex = 2;
            button7.Text = "Ürün Ekleme";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(157, 46);
            button6.Name = "button6";
            button6.Size = new Size(130, 42);
            button6.TabIndex = 1;
            button6.Text = "Müşteri Listeleme";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 46);
            button5.Name = "button5";
            button5.Size = new Size(130, 42);
            button5.TabIndex = 0;
            button5.Text = "Müşteri Ekleme";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(267, 480);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click_1;
            // 
            // txtToplamFiyatı
            // 
            txtToplamFiyatı.Location = new Point(88, 138);
            txtToplamFiyatı.Name = "txtToplamFiyatı";
            txtToplamFiyatı.Size = new Size(100, 23);
            txtToplamFiyatı.TabIndex = 9;
            txtToplamFiyatı.TextChanged += txtToplamFiyatı_TextChanged;
            // 
            // frmSatış
            // 
            AcceptButton = btnEkle;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1109, 570);
            Controls.Add(btnEkle);
            Controls.Add(panel1);
            Controls.Add(lblGenelToplam);
            Controls.Add(label9);
            Controls.Add(btnSatışİptal);
            Controls.Add(btnSatışYap);
            Controls.Add(btnSil);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "frmSatış";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Satış Sayfası";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox txtAdSoyad;
        private TextBox txtTC;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTelefon;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtÜrünAdı;
        private Button btnSil;
        private Button btnSatışYap;
        private Button btnSatışİptal;
        private Label label9;
        private Label lblGenelToplam;
        private Panel panel1;
        private Button button5;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button2;
        private Button button1;
        private TextBox txtBarkodNo;
        private TextBox txtMiktar;
        private TextBox txtSatışFiyatı;
        private Button btnEkle;
        private TextBox txtToplamFiyatı;
    }
}