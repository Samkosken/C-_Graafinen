namespace Tehtava13
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
            VastausLB = new Label();
            NimiTB = new TextBox();
            EtsiBT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(670, 25);
            label1.TabIndex = 0;
            label1.Text = "Anna nimesi, niin tarkastan, onko se 50 suosituimman joukussa:";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(12, 98);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(0, 25);
            VastausLB.TabIndex = 1;
            VastausLB.Visible = false;
            // 
            // NimiTB
            // 
            NimiTB.Location = new Point(751, 45);
            NimiTB.Name = "NimiTB";
            NimiTB.Size = new Size(232, 32);
            NimiTB.TabIndex = 2;
            // 
            // EtsiBT
            // 
            EtsiBT.Location = new Point(751, 98);
            EtsiBT.Name = "EtsiBT";
            EtsiBT.Size = new Size(232, 36);
            EtsiBT.TabIndex = 3;
            EtsiBT.Text = "Tarkasta";
            EtsiBT.UseVisualStyleBackColor = true;
            EtsiBT.Click += EtsiBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 243);
            Controls.Add(EtsiBT);
            Controls.Add(NimiTB);
            Controls.Add(VastausLB);
            Controls.Add(label1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Onko nimesi suosittujen joukossa?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label VastausLB;
        private TextBox NimiTB;
        private Button EtsiBT;
    }
}
