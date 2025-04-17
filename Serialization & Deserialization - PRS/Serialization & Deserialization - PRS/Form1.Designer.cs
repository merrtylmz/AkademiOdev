namespace Serialization___Deserialization___PRS
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
            jsonOlustur = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // jsonOlustur
            // 
            jsonOlustur.BackColor = SystemColors.ActiveCaption;
            jsonOlustur.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            jsonOlustur.Location = new Point(221, 277);
            jsonOlustur.Name = "jsonOlustur";
            jsonOlustur.Size = new Size(225, 63);
            jsonOlustur.TabIndex = 0;
            jsonOlustur.Text = "JSON OLUŞTUR";
            jsonOlustur.UseVisualStyleBackColor = false;
            jsonOlustur.Click += jsonOlustur_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(221, 43);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(225, 214);
            listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(jsonOlustur);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button jsonOlustur;
        private ListBox listBox1;
    }
}
