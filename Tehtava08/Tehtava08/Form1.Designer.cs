namespace Tehtava08
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
            VastausLB = new Label();
            TekstiTB = new TextBox();
            MuutaBT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(48, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(648, 97);
            label1.TabIndex = 0;
            label1.Text = "Roomalaiset numerot";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Viner Hand ITC", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(48, 169);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(651, 32);
            label2.TabIndex = 1;
            label2.Text = "Anna numero välillä 1-3999, niin muunnan sen roomalaiseksi";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Viner Hand ITC", 24F, FontStyle.Bold, GraphicsUnit.Point);
            VastausLB.Location = new Point(48, 305);
            VastausLB.Margin = new Padding(4, 0, 4, 0);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(0, 65);
            VastausLB.TabIndex = 2;
            VastausLB.Visible = false;
            // 
            // TekstiTB
            // 
            TekstiTB.Location = new Point(747, 168);
            TekstiTB.Name = "TekstiTB";
            TekstiTB.Size = new Size(125, 30);
            TekstiTB.TabIndex = 3;
            // 
            // MuutaBT
            // 
            MuutaBT.Font = new Font("Viner Hand ITC", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MuutaBT.Location = new Point(723, 317);
            MuutaBT.Name = "MuutaBT";
            MuutaBT.Size = new Size(133, 41);
            MuutaBT.TabIndex = 4;
            MuutaBT.Text = "Muunna";
            MuutaBT.UseVisualStyleBackColor = true;
            MuutaBT.Click += MuutaBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(900, 517);
            Controls.Add(MuutaBT);
            Controls.Add(TekstiTB);
            Controls.Add(VastausLB);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Numero muunnin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label VastausLB;
        private TextBox TekstiTB;
        private Button MuutaBT;
    }
}
