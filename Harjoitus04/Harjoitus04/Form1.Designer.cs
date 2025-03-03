namespace Harjoitus04
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
            SynttariDT = new DateTimePicker();
            LaskeBT = new Button();
            VuosissaLB = new Label();
            KuukausissaLB = new Label();
            PaivissaLB = new Label();
            TunnissaLB = new Label();
            MinuuteissaLB = new Label();
            SekunneissaLB = new Label();
            SuspendLayout();
            // 
            // SynttariDT
            // 
            SynttariDT.Location = new Point(190, 58);
            SynttariDT.Name = "SynttariDT";
            SynttariDT.Size = new Size(264, 27);
            SynttariDT.TabIndex = 0;
            // 
            // LaskeBT
            // 
            LaskeBT.Location = new Point(492, 58);
            LaskeBT.Name = "LaskeBT";
            LaskeBT.Size = new Size(84, 25);
            LaskeBT.TabIndex = 1;
            LaskeBT.Text = "Laske";
            LaskeBT.UseVisualStyleBackColor = true;
            LaskeBT.Click += LaskeBT_Click;
            // 
            // VuosissaLB
            // 
            VuosissaLB.AutoSize = true;
            VuosissaLB.Location = new Point(190, 106);
            VuosissaLB.Name = "VuosissaLB";
            VuosissaLB.Size = new Size(0, 20);
            VuosissaLB.TabIndex = 2;
            // 
            // KuukausissaLB
            // 
            KuukausissaLB.AutoSize = true;
            KuukausissaLB.Location = new Point(190, 141);
            KuukausissaLB.Name = "KuukausissaLB";
            KuukausissaLB.Size = new Size(0, 20);
            KuukausissaLB.TabIndex = 3;
            // 
            // PaivissaLB
            // 
            PaivissaLB.AutoSize = true;
            PaivissaLB.Location = new Point(190, 172);
            PaivissaLB.Name = "PaivissaLB";
            PaivissaLB.Size = new Size(0, 20);
            PaivissaLB.TabIndex = 4;
            // 
            // TunnissaLB
            // 
            TunnissaLB.AutoSize = true;
            TunnissaLB.Location = new Point(312, 106);
            TunnissaLB.Name = "TunnissaLB";
            TunnissaLB.Size = new Size(0, 20);
            TunnissaLB.TabIndex = 5;
            // 
            // MinuuteissaLB
            // 
            MinuuteissaLB.AutoSize = true;
            MinuuteissaLB.Location = new Point(312, 141);
            MinuuteissaLB.Name = "MinuuteissaLB";
            MinuuteissaLB.Size = new Size(0, 20);
            MinuuteissaLB.TabIndex = 6;
            // 
            // SekunneissaLB
            // 
            SekunneissaLB.AutoSize = true;
            SekunneissaLB.Location = new Point(312, 172);
            SekunneissaLB.Name = "SekunneissaLB";
            SekunneissaLB.Size = new Size(0, 20);
            SekunneissaLB.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 391);
            Controls.Add(SekunneissaLB);
            Controls.Add(MinuuteissaLB);
            Controls.Add(TunnissaLB);
            Controls.Add(PaivissaLB);
            Controls.Add(KuukausissaLB);
            Controls.Add(VuosissaLB);
            Controls.Add(LaskeBT);
            Controls.Add(SynttariDT);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker SynttariDT;
        private Button LaskeBT;
        private Label VuosissaLB;
        private Label KuukausissaLB;
        private Label PaivissaLB;
        private Label TunnissaLB;
        private Label MinuuteissaLB;
        private Label SekunneissaLB;
    }
}
