namespace Tehtava11
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
            noppa01PB = new PictureBox();
            noppa02PB = new PictureBox();
            HeitaBT = new Button();
            ((System.ComponentModel.ISupportInitialize)noppa01PB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)noppa02PB).BeginInit();
            SuspendLayout();
            // 
            // noppa01PB
            // 
            noppa01PB.Image = Properties.Resources.dice01;
            noppa01PB.Location = new Point(251, 115);
            noppa01PB.Name = "noppa01PB";
            noppa01PB.Size = new Size(125, 107);
            noppa01PB.SizeMode = PictureBoxSizeMode.Zoom;
            noppa01PB.TabIndex = 0;
            noppa01PB.TabStop = false;
            // 
            // noppa02PB
            // 
            noppa02PB.Image = Properties.Resources.dice01;
            noppa02PB.Location = new Point(437, 115);
            noppa02PB.Name = "noppa02PB";
            noppa02PB.Size = new Size(125, 107);
            noppa02PB.SizeMode = PictureBoxSizeMode.Zoom;
            noppa02PB.TabIndex = 1;
            noppa02PB.TabStop = false;
            // 
            // HeitaBT
            // 
            HeitaBT.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            HeitaBT.Location = new Point(339, 248);
            HeitaBT.Name = "HeitaBT";
            HeitaBT.Size = new Size(135, 50);
            HeitaBT.TabIndex = 2;
            HeitaBT.Text = "Heitä";
            HeitaBT.UseVisualStyleBackColor = true;
            HeitaBT.Click += HeitaBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(HeitaBT);
            Controls.Add(noppa02PB);
            Controls.Add(noppa01PB);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)noppa01PB).EndInit();
            ((System.ComponentModel.ISupportInitialize)noppa02PB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox noppa01PB;
        private PictureBox noppa02PB;
        private Button HeitaBT;
    }
}
