namespace SalasananTarkistus
{
    partial class SalasanaForm
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
            SalasanaPanel = new Panel();
            VirheviestiLB = new Label();
            TarkistaBT = new Button();
            SalasanaTB = new TextBox();
            KayttajaTB = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SalasanaOikeinPanel = new Panel();
            label3 = new Label();
            SalasanaPanel.SuspendLayout();
            SalasanaOikeinPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SalasanaPanel
            // 
            SalasanaPanel.BackColor = Color.MidnightBlue;
            SalasanaPanel.Controls.Add(VirheviestiLB);
            SalasanaPanel.Controls.Add(TarkistaBT);
            SalasanaPanel.Controls.Add(SalasanaTB);
            SalasanaPanel.Controls.Add(KayttajaTB);
            SalasanaPanel.Controls.Add(label2);
            SalasanaPanel.Controls.Add(label1);
            SalasanaPanel.Dock = DockStyle.Fill;
            SalasanaPanel.Font = new Font("Segoe Script", 18F, FontStyle.Bold, GraphicsUnit.Point);
            SalasanaPanel.ForeColor = Color.Gold;
            SalasanaPanel.Location = new Point(0, 0);
            SalasanaPanel.Name = "SalasanaPanel";
            SalasanaPanel.Size = new Size(800, 450);
            SalasanaPanel.TabIndex = 0;
            // 
            // VirheviestiLB
            // 
            VirheviestiLB.AutoSize = true;
            VirheviestiLB.Location = new Point(62, 338);
            VirheviestiLB.Name = "VirheviestiLB";
            VirheviestiLB.Size = new Size(0, 50);
            VirheviestiLB.TabIndex = 5;
            VirheviestiLB.Visible = false;
            // 
            // TarkistaBT
            // 
            TarkistaBT.ForeColor = SystemColors.ActiveCaptionText;
            TarkistaBT.Location = new Point(11, 164);
            TarkistaBT.Name = "TarkistaBT";
            TarkistaBT.Size = new Size(163, 56);
            TarkistaBT.TabIndex = 4;
            TarkistaBT.Text = "Tarkista";
            TarkistaBT.UseVisualStyleBackColor = true;
            TarkistaBT.Click += TarkistaBT_Click;
            // 
            // SalasanaTB
            // 
            SalasanaTB.Location = new Point(373, 164);
            SalasanaTB.Name = "SalasanaTB";
            SalasanaTB.Size = new Size(414, 56);
            SalasanaTB.TabIndex = 3;
            // 
            // KayttajaTB
            // 
            KayttajaTB.Location = new Point(373, 95);
            KayttajaTB.Name = "KayttajaTB";
            KayttajaTB.Size = new Size(414, 56);
            KayttajaTB.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 164);
            label2.Name = "label2";
            label2.Size = new Size(171, 50);
            label2.TabIndex = 1;
            label2.Text = "Salasana:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 95);
            label1.Name = "label1";
            label1.Size = new Size(275, 50);
            label1.TabIndex = 0;
            label1.Text = "Käyttäjätunnus:";
            // 
            // SalasanaOikeinPanel
            // 
            SalasanaOikeinPanel.BackColor = Color.DarkRed;
            SalasanaOikeinPanel.Controls.Add(label3);
            SalasanaOikeinPanel.Font = new Font("Segoe Script", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            SalasanaOikeinPanel.ForeColor = Color.Snow;
            SalasanaOikeinPanel.Location = new Point(0, 0);
            SalasanaOikeinPanel.Name = "SalasanaOikeinPanel";
            SalasanaOikeinPanel.Size = new Size(800, 450);
            SalasanaOikeinPanel.TabIndex = 1;
            SalasanaOikeinPanel.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 121);
            label3.Name = "label3";
            label3.Size = new Size(693, 99);
            label3.TabIndex = 0;
            label3.Text = "Tervetuloa sivulleni";
            // 
            // SalasanaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SalasanaOikeinPanel);
            Controls.Add(SalasanaPanel);
            Name = "SalasanaForm";
            Text = "Salasanan tarkistus";
            SalasanaPanel.ResumeLayout(false);
            SalasanaPanel.PerformLayout();
            SalasanaOikeinPanel.ResumeLayout(false);
            SalasanaOikeinPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SalasanaPanel;
        private Label label2;
        private Label label1;
        private TextBox SalasanaTB;
        private TextBox KayttajaTB;
        private Label VirheviestiLB;
        private Button TarkistaBT;
        private Panel SalasanaOikeinPanel;
        private Label label3;
    }
}
