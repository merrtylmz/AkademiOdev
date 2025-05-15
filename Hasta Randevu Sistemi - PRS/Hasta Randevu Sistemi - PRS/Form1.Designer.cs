namespace Hasta_Randevu_Sistemi___PRS
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
            cmbBrans = new ComboBox();
            btnKaydet = new Button();
            dtpTarih = new DateTimePicker();
            label1 = new Label();
            cmbSaat = new ComboBox();
            txtSoyad = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cmbDoktor = new ComboBox();
            label4 = new Label();
            txtAD = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // cmbBrans
            // 
            cmbBrans.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(271, 108);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(205, 23);
            cmbBrans.TabIndex = 0;
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnKaydet.Location = new Point(309, 297);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(131, 77);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Randevu Oluştur";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // dtpTarih
            // 
            dtpTarih.Format = DateTimePickerFormat.Short;
            dtpTarih.Location = new Point(274, 189);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(111, 23);
            dtpTarih.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 25);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 3;
            label1.Text = "AD :";
            // 
            // cmbSaat
            // 
            cmbSaat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSaat.FormattingEnabled = true;
            cmbSaat.Location = new Point(391, 189);
            cmbSaat.Name = "cmbSaat";
            cmbSaat.Size = new Size(85, 23);
            cmbSaat.TabIndex = 4;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(271, 61);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(205, 23);
            txtSoyad.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 111);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 6;
            label2.Text = "BRANŞLAR:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 192);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "SAAT:";
            // 
            // cmbDoktor
            // 
            cmbDoktor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDoktor.FormattingEnabled = true;
            cmbDoktor.Location = new Point(271, 148);
            cmbDoktor.Name = "cmbDoktor";
            cmbDoktor.Size = new Size(205, 23);
            cmbDoktor.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 151);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 9;
            label4.Text = "DOKTOR:";
            // 
            // txtAD
            // 
            txtAD.Location = new Point(271, 22);
            txtAD.Name = "txtAD";
            txtAD.Size = new Size(205, 23);
            txtAD.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(218, 64);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 11;
            label5.Text = "SOYAD:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(181, 192);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 12;
            label6.Text = "TARİH:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(820, 515);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtAD);
            Controls.Add(label4);
            Controls.Add(cmbDoktor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSoyad);
            Controls.Add(cmbSaat);
            Controls.Add(label1);
            Controls.Add(dtpTarih);
            Controls.Add(btnKaydet);
            Controls.Add(cmbBrans);
            Name = "Form1";
            Text = "HASTENE RANDEVU KAYIT SİSTEMİ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBrans;
        private Button btnKaydet;
        private DateTimePicker dtpTarih;
        private Label label1;
        private ComboBox cmbSaat;
        private TextBox txtSoyad;
        private Label label2;
        private Label label3;
        private ComboBox cmbDoktor;
        private Label label4;
        private TextBox txtAD;
        private Label label5;
        private Label label6;
    }
}
