namespace odev_2
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
            cmbOdemeYontemi = new ComboBox();
            txtTutar = new TextBox();
            btnOde = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // cmbOdemeYontemi
            // 
            cmbOdemeYontemi.FormattingEnabled = true;
            cmbOdemeYontemi.Location = new Point(156, 90);
            cmbOdemeYontemi.Name = "cmbOdemeYontemi";
            cmbOdemeYontemi.Size = new Size(298, 23);
            cmbOdemeYontemi.TabIndex = 0;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(194, 150);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(245, 23);
            txtTutar.TabIndex = 1;
            // 
            // btnOde
            // 
            btnOde.Location = new Point(208, 206);
            btnOde.Name = "btnOde";
            btnOde.Size = new Size(218, 52);
            btnOde.TabIndex = 2;
            btnOde.Text = "Öde";
            btnOde.UseVisualStyleBackColor = true;
            btnOde.Click += btnOde_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(289, 297);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(43, 15);
            lblSonuc.TabIndex = 3;
            lblSonuc.Text = "Sonuç:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSonuc);
            Controls.Add(btnOde);
            Controls.Add(txtTutar);
            Controls.Add(cmbOdemeYontemi);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbOdemeYontemi;
        private TextBox txtTutar;
        private Button btnOde;
        private Label lblSonuc;
    }
}
