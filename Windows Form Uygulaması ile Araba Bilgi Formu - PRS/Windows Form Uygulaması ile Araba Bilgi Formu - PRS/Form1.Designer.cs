namespace Windows_Form_Uygulaması_ile_Araba_Bilgi_Formu___PRS
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTotal = new Label();
            button1 = new Button();
            cmbMarka = new ComboBox();
            cmbModel = new ComboBox();
            cmbRenk = new ComboBox();
            cmbKapiSayisi = new ComboBox();
            cmbPencereSayisi = new ComboBox();
            mtbtotal = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 89);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Marka:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 119);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Model:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 149);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Renk:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 177);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 6;
            label4.Text = "Kapı Sayısı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 209);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 8;
            label5.Text = "Pencere Sayısı:";
            // 
            // txtTotal
            // 
            txtTotal.AutoSize = true;
            txtTotal.Location = new Point(65, 246);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(57, 15);
            txtTotal.TabIndex = 10;
            txtTotal.Text = "100km/lt:";
            // 
            // button1
            // 
            button1.Location = new Point(57, 302);
            button1.Name = "button1";
            button1.Size = new Size(192, 53);
            button1.TabIndex = 12;
            button1.Text = "BİLGİLERİ GÖSTER";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // cmbMarka
            // 
            cmbMarka.FormattingEnabled = true;
            cmbMarka.Items.AddRange(new object[] { "BMW", "MERCEDES", "TOYOTA" });
            cmbMarka.Location = new Point(129, 101);
            cmbMarka.Name = "cmbMarka";
            cmbMarka.Size = new Size(121, 23);
            cmbMarka.TabIndex = 13;
            cmbMarka.SelectedIndexChanged += cmbMarka_SelectedIndexChanged;
            cmbMarka.MouseHover += Form1_Load;
            // 
            // cmbModel
            // 
            cmbModel.Enabled = false;
            cmbModel.FormattingEnabled = true;
            cmbModel.Location = new Point(129, 120);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(121, 23);
            cmbModel.TabIndex = 14;
            cmbModel.SelectedIndexChanged += cmbModel_SelectedIndexChanged;
            // 
            // cmbRenk
            // 
            cmbRenk.FormattingEnabled = true;
            cmbRenk.Location = new Point(129, 149);
            cmbRenk.Name = "cmbRenk";
            cmbRenk.Size = new Size(121, 23);
            cmbRenk.TabIndex = 15;
            cmbRenk.SelectedIndexChanged += cmbRenk_SelectedIndexChanged;
            // 
            // cmbKapiSayisi
            // 
            cmbKapiSayisi.FormattingEnabled = true;
            cmbKapiSayisi.Location = new Point(129, 181);
            cmbKapiSayisi.Name = "cmbKapiSayisi";
            cmbKapiSayisi.Size = new Size(121, 23);
            cmbKapiSayisi.TabIndex = 16;
            cmbKapiSayisi.SelectedIndexChanged += cmbKapiSayisi_SelectedIndexChanged;
            // 
            // cmbPencereSayisi
            // 
            cmbPencereSayisi.FormattingEnabled = true;
            cmbPencereSayisi.Location = new Point(129, 209);
            cmbPencereSayisi.Name = "cmbPencereSayisi";
            cmbPencereSayisi.Size = new Size(121, 23);
            cmbPencereSayisi.TabIndex = 17;
            cmbPencereSayisi.SelectedIndexChanged += cmbPencereSayisi_SelectedIndexChanged;
            // 
            // mtbtotal
            // 
            mtbtotal.Location = new Point(128, 246);
            mtbtotal.Name = "mtbtotal";
            mtbtotal.Size = new Size(121, 23);
            mtbtotal.TabIndex = 19;
            mtbtotal.MaskInputRejected += mtbtotal_MaskInputRejected;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 499);
            Controls.Add(mtbtotal);
            Controls.Add(cmbPencereSayisi);
            Controls.Add(cmbKapiSayisi);
            Controls.Add(cmbRenk);
            Controls.Add(cmbModel);
            Controls.Add(cmbMarka);
            Controls.Add(button1);
            Controls.Add(txtTotal);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label txtTotal;
        private Button button1;
        private ComboBox cmbMarka;
        private ComboBox cmbModel;
        private ComboBox cmbRenk;
        private ComboBox cmbKapiSayisi;
        private ComboBox cmbPencereSayisi;
        private ComboBox cmbTotal;
        private MaskedTextBox mtbtotal;
    }
}
