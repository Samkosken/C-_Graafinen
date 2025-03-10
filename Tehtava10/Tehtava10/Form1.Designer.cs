namespace Tehtava10
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
            PainoTB = new TextBox();
            PituusTB = new TextBox();
            LaskeBT = new Button();
            VastausLB = new Label();
            KuvausLB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(121, 28);
            label1.TabIndex = 0;
            label1.Text = "Anna paino:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(127, 28);
            label2.TabIndex = 1;
            label2.Text = "Anna pituus:";
            // 
            // PainoTB
            // 
            PainoTB.Location = new Point(153, 43);
            PainoTB.Name = "PainoTB";
            PainoTB.Size = new Size(125, 34);
            PainoTB.TabIndex = 2;
            // 
            // PituusTB
            // 
            PituusTB.Location = new Point(153, 93);
            PituusTB.Name = "PituusTB";
            PituusTB.Size = new Size(125, 34);
            PituusTB.TabIndex = 3;
            // 
            // LaskeBT
            // 
            LaskeBT.Location = new Point(12, 157);
            LaskeBT.Name = "LaskeBT";
            LaskeBT.Size = new Size(266, 38);
            LaskeBT.TabIndex = 4;
            LaskeBT.Text = "Laske painoindeksi";
            LaskeBT.UseVisualStyleBackColor = true;
            LaskeBT.Click += LaskeBT_Click;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(25, 217);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(0, 28);
            VastausLB.TabIndex = 5;
            VastausLB.Visible = false;
            // 
            // KuvausLB
            // 
            KuvausLB.AutoSize = true;
            KuvausLB.Location = new Point(25, 256);
            KuvausLB.Name = "KuvausLB";
            KuvausLB.Size = new Size(0, 28);
            KuvausLB.TabIndex = 6;
            KuvausLB.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 293);
            Controls.Add(KuvausLB);
            Controls.Add(VastausLB);
            Controls.Add(LaskeBT);
            Controls.Add(PituusTB);
            Controls.Add(PainoTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "BMI laskuri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox PainoTB;
        private TextBox PituusTB;
        private Button LaskeBT;
        private Label VastausLB;
        private Label KuvausLB;
    }
}
