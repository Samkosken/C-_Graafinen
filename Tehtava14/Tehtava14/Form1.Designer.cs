namespace Tehtava14
{
    partial class Diaryform
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
            TekstiTB = new TextBox();
            TallennaBT = new Button();
            SuspendLayout();
            // 
            // TekstiTB
            // 
            TekstiTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TekstiTB.Location = new Point(12, 0);
            TekstiTB.Multiline = true;
            TekstiTB.Name = "TekstiTB";
            TekstiTB.Size = new Size(776, 349);
            TekstiTB.TabIndex = 0;
            // 
            // TallennaBT
            // 
            TallennaBT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TallennaBT.Location = new Point(12, 367);
            TallennaBT.Name = "TallennaBT";
            TallennaBT.Size = new Size(776, 71);
            TallennaBT.TabIndex = 1;
            TallennaBT.Text = "Tallenna päiväkirjaan";
            TallennaBT.UseVisualStyleBackColor = true;
            TallennaBT.Click += TallennaBT_Click;
            // 
            // Diaryform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TallennaBT);
            Controls.Add(TekstiTB);
            Name = "Diaryform";
            Text = "Päiväkirja";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TekstiTB;
        private Button TallennaBT;
    }
}
