﻿namespace reflection_prs
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
            btnKlasorSec = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btnKlasorSec
            // 
            btnKlasorSec.Location = new Point(91, 12);
            btnKlasorSec.Name = "btnKlasorSec";
            btnKlasorSec.Size = new Size(158, 53);
            btnKlasorSec.TabIndex = 0;
            btnKlasorSec.Text = "button1";
            btnKlasorSec.UseVisualStyleBackColor = true;
            btnKlasorSec.Click += btnKlasorSec_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(24, 71);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(341, 439);
            listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(411, 513);
            Controls.Add(listBox1);
            Controls.Add(btnKlasorSec);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnKlasorSec;
        private ListBox listBox1;
    }
}
