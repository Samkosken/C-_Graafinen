﻿namespace Tehtava01
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
            TekstiLB = new Label();
            VaihdaBT = new Button();
            SuspendLayout();
            // 
            // TekstiLB
            // 
            TekstiLB.AutoSize = true;
            TekstiLB.Location = new Point(214, 48);
            TekstiLB.Name = "TekstiLB";
            TekstiLB.Size = new Size(109, 23);
            TekstiLB.TabIndex = 0;
            TekstiLB.Text = "Jotain tekstiä";
            // 
            // VaihdaBT
            // 
            VaihdaBT.Location = new Point(214, 90);
            VaihdaBT.Name = "VaihdaBT";
            VaihdaBT.Size = new Size(117, 29);
            VaihdaBT.TabIndex = 1;
            VaihdaBT.Text = "Vaihda teksti";
            VaihdaBT.UseVisualStyleBackColor = true;
            VaihdaBT.Click += VaihdaBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(VaihdaBT);
            Controls.Add(TekstiLB);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TekstiLB;
        private Button VaihdaBT;
    }
}
