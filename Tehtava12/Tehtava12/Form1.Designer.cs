namespace Tehtava12
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
            KysymysLB = new Label();
            VastausLB = new Label();
            ARB = new RadioButton();
            BRB = new RadioButton();
            CRB = new RadioButton();
            DRB = new RadioButton();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // KysymysLB
            // 
            KysymysLB.AutoSize = true;
            KysymysLB.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            KysymysLB.Location = new Point(147, 59);
            KysymysLB.Name = "KysymysLB";
            KysymysLB.Size = new Size(0, 38);
            KysymysLB.TabIndex = 0;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            VastausLB.Location = new Point(147, 365);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(109, 38);
            VastausLB.TabIndex = 1;
            VastausLB.Text = "Vastaus";
            // 
            // ARB
            // 
            ARB.AutoSize = true;
            ARB.Location = new Point(46, 26);
            ARB.Name = "ARB";
            ARB.Size = new Size(46, 32);
            ARB.TabIndex = 2;
            ARB.TabStop = true;
            ARB.Text = "A";
            ARB.UseVisualStyleBackColor = true;
            // 
            // BRB
            // 
            BRB.AutoSize = true;
            BRB.Location = new Point(46, 56);
            BRB.Name = "BRB";
            BRB.Size = new Size(44, 32);
            BRB.TabIndex = 3;
            BRB.TabStop = true;
            BRB.Text = "B";
            BRB.UseVisualStyleBackColor = true;
            // 
            // CRB
            // 
            CRB.AutoSize = true;
            CRB.Location = new Point(46, 86);
            CRB.Name = "CRB";
            CRB.Size = new Size(45, 32);
            CRB.TabIndex = 4;
            CRB.TabStop = true;
            CRB.Text = "C";
            CRB.UseVisualStyleBackColor = true;
            // 
            // DRB
            // 
            DRB.AutoSize = true;
            DRB.Location = new Point(46, 116);
            DRB.Name = "DRB";
            DRB.Size = new Size(47, 32);
            DRB.TabIndex = 5;
            DRB.TabStop = true;
            DRB.Text = "D";
            DRB.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(ARB);
            groupBox1.Controls.Add(DRB);
            groupBox1.Controls.Add(BRB);
            groupBox1.Controls.Add(CRB);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(566, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(207, 200);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vastaus";
            // 
            // radioButton1
            // 
            radioButton1.AutoCheck = false;
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(46, 154);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(17, 16);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(VastausLB);
            Controls.Add(KysymysLB);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label KysymysLB;
        private Label VastausLB;
        private RadioButton ARB;
        private RadioButton BRB;
        private RadioButton CRB;
        private RadioButton DRB;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
    }
}
