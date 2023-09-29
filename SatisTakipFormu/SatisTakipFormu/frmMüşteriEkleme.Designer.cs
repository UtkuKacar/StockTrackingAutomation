namespace SatisTakipFormu
{
    partial class frmMüşteriEkleme
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTC = new TextBox();
            txtAdSoyad = new TextBox();
            txtTelefon = new TextBox();
            txtAdres = new TextBox();
            txtEMail = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 70);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "TC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(59, 116);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 0;
            label2.Text = "Ad Soyad";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(59, 162);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 0;
            label3.Text = "Telefon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(59, 208);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 0;
            label4.Text = "Adres";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(59, 254);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 0;
            label5.Text = "E-Mail";
            // 
            // txtTC
            // 
            txtTC.Location = new Point(164, 72);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(150, 23);
            txtTC.TabIndex = 1;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(164, 116);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(150, 23);
            txtAdSoyad.TabIndex = 1;
            txtAdSoyad.TextChanged += txtAdSoyad_TextChanged;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(164, 160);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(150, 23);
            txtTelefon.TabIndex = 1;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(164, 204);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(150, 23);
            txtAdres.TabIndex = 1;
            // 
            // txtEMail
            // 
            txtEMail.Location = new Point(164, 248);
            txtEMail.Name = "txtEMail";
            txtEMail.Size = new Size(150, 23);
            txtEMail.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(191, 303);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmMüşteriEkleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(413, 426);
            Controls.Add(button1);
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
            Name = "frmMüşteriEkleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri Ekleme";
            Load += frmMüşteriEkleme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTC;
        private TextBox txtAdSoyad;
        private TextBox txtTelefon;
        private TextBox txtAdres;
        private TextBox txtEMail;
        private Button button1;
    }
}