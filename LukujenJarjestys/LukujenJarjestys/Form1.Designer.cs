namespace LukujenJarjestys
{
    partial class LukujenJarjestys
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
            UusiLukuTB = new TextBox();
            VastausLB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 95);
            label1.Name = "label1";
            label1.Size = new Size(178, 20);
            label1.TabIndex = 0;
            label1.Text = "Anna luku (-999 lopetus): ";
            // 
            // UusiLukuTB
            // 
            UusiLukuTB.Location = new Point(352, 95);
            UusiLukuTB.Name = "UusiLukuTB";
            UusiLukuTB.Size = new Size(125, 27);
            UusiLukuTB.TabIndex = 1;
            UusiLukuTB.KeyPress += UusiLukuTB_KeyPress;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(144, 166);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(50, 20);
            VastausLB.TabIndex = 2;
            VastausLB.Text = "label2";
            VastausLB.Visible = false;
            // 
            // LukujenJarjestys
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(VastausLB);
            Controls.Add(UusiLukuTB);
            Controls.Add(label1);
            Name = "LukujenJarjestys";
            Text = "Lukujen järjestys";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox UusiLukuTB;
        private Label VastausLB;
    }
}
