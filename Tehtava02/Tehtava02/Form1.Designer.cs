namespace Tehtava02
{
    partial class Harjoitus02
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
            OtsikkoLB = new Label();
            TulostusLB = new Label();
            ViestiTB = new TextBox();
            TulostaTB = new Button();
            SuspendLayout();
            // 
            // OtsikkoLB
            // 
            OtsikkoLB.AutoSize = true;
            OtsikkoLB.Font = new Font("Segoe Script", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            OtsikkoLB.Location = new Point(27, 33);
            OtsikkoLB.Name = "OtsikkoLB";
            OtsikkoLB.Size = new Size(375, 44);
            OtsikkoLB.TabIndex = 0;
            OtsikkoLB.Text = "anna tulostettava teksti:";
            OtsikkoLB.Click += OtsikkoLB_Click;
            // 
            // TulostusLB
            // 
            TulostusLB.AutoSize = true;
            TulostusLB.Font = new Font("Segoe Script", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            TulostusLB.Location = new Point(27, 112);
            TulostusLB.Name = "TulostusLB";
            TulostusLB.Size = new Size(96, 44);
            TulostusLB.TabIndex = 1;
            TulostusLB.Text = "xxxx";
            TulostusLB.Visible = false;
            // 
            // ViestiTB
            // 
            ViestiTB.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ViestiTB.Location = new Point(421, 29);
            ViestiTB.Name = "ViestiTB";
            ViestiTB.Size = new Size(353, 43);
            ViestiTB.TabIndex = 2;
            // 
            // TulostaTB
            // 
            TulostaTB.FlatStyle = FlatStyle.System;
            TulostaTB.Location = new Point(542, 120);
            TulostaTB.Name = "TulostaTB";
            TulostaTB.Size = new Size(131, 29);
            TulostaTB.TabIndex = 3;
            TulostaTB.Text = "Tulosta teksti";
            TulostaTB.UseVisualStyleBackColor = true;
            TulostaTB.Click += TulostaTB_Click;
            // 
            // Harjoitus02
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(800, 450);
            Controls.Add(TulostaTB);
            Controls.Add(ViestiTB);
            Controls.Add(TulostusLB);
            Controls.Add(OtsikkoLB);
            ForeColor = Color.MintCream;
            Name = "Harjoitus02";
            Text = "Harjoitus02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OtsikkoLB;
        private Label TulostusLB;
        private TextBox ViestiTB;
        private Button TulostaTB;
    }
}
