namespace Tehtava09
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
            MuunnaBT = new Button();
            AsteetTB = new TextBox();
            CelsiusRB = new RadioButton();
            FahrenheitRB = new RadioButton();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(65, 120);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 0;
            label1.Text = "Anna asteet";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            VastausLB.Location = new Point(80, 289);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(0, 28);
            VastausLB.TabIndex = 2;
            VastausLB.Visible = false;
            // 
            // MuunnaBT
            // 
            MuunnaBT.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MuunnaBT.Location = new Point(552, 120);
            MuunnaBT.Name = "MuunnaBT";
            MuunnaBT.Size = new Size(117, 43);
            MuunnaBT.TabIndex = 3;
            MuunnaBT.Text = "Muunna";
            MuunnaBT.UseVisualStyleBackColor = true;
            MuunnaBT.Click += MuunnaBT_Click;
            // 
            // AsteetTB
            // 
            AsteetTB.Location = new Point(221, 120);
            AsteetTB.Name = "AsteetTB";
            AsteetTB.Size = new Size(86, 27);
            AsteetTB.TabIndex = 4;
            // 
            // CelsiusRB
            // 
            CelsiusRB.AutoSize = true;
            CelsiusRB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CelsiusRB.Location = new Point(367, 115);
            CelsiusRB.Name = "CelsiusRB";
            CelsiusRB.Size = new Size(96, 32);
            CelsiusRB.TabIndex = 5;
            CelsiusRB.TabStop = true;
            CelsiusRB.Text = "Celsius";
            CelsiusRB.UseVisualStyleBackColor = true;
            // 
            // FahrenheitRB
            // 
            FahrenheitRB.AutoSize = true;
            FahrenheitRB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FahrenheitRB.Location = new Point(367, 153);
            FahrenheitRB.Name = "FahrenheitRB";
            FahrenheitRB.Size = new Size(129, 32);
            FahrenheitRB.TabIndex = 6;
            FahrenheitRB.TabStop = true;
            FahrenheitRB.Text = "Fahrenheit";
            FahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(367, 84);
            label2.Name = "label2";
            label2.Size = new Size(162, 28);
            label2.TabIndex = 7;
            label2.Text = "Miten muunnat?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 353);
            Controls.Add(label2);
            Controls.Add(FahrenheitRB);
            Controls.Add(CelsiusRB);
            Controls.Add(AsteetTB);
            Controls.Add(MuunnaBT);
            Controls.Add(VastausLB);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label VastausLB;
        private Button MuunnaBT;
        private TextBox AsteetTB;
        private RadioButton CelsiusRB;
        private RadioButton FahrenheitRB;
        private Label label2;
    }
}
