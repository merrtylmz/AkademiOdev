namespace REFLECTION_PRS
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
            btnklasorsec = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btnklasorsec
            // 
            btnklasorsec.BackColor = Color.DarkGray;
            btnklasorsec.Location = new Point(313, 280);
            btnklasorsec.Name = "btnklasorsec";
            btnklasorsec.Size = new Size(186, 66);
            btnklasorsec.TabIndex = 0;
            btnklasorsec.Text = "KLASÖR SEÇ";
            btnklasorsec.UseVisualStyleBackColor = false;
            btnklasorsec.Click += btnklasorsec_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(300, 30);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(222, 214);
            listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(btnklasorsec);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnklasorsec;
        private FolderBrowserDialog folderBrowserDialog1;
        private ListBox listBox1;
    }
}
