﻿namespace SatisTakipFormu
{
    partial class frmMarka
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(143, 59);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(64, 62);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Kategori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(64, 115);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Marka";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(143, 165);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmMarka
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(382, 291);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            ForeColor = SystemColors.ControlText;
            Name = "frmMarka";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Marka";
            Load += frmMarka_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
    }
}