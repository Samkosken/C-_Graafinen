namespace Ajastin
{
    partial class LaskuriForm
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
            components = new System.ComponentModel.Container();
            MinuuttiCB = new ComboBox();
            SekunttiCB = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            StartBT = new Button();
            StopBT = new Button();
            AikaLB = new Label();
            AjastinTM = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // MinuuttiCB
            // 
            MinuuttiCB.FormattingEnabled = true;
            MinuuttiCB.Location = new Point(116, 113);
            MinuuttiCB.Name = "MinuuttiCB";
            MinuuttiCB.Size = new Size(96, 28);
            MinuuttiCB.TabIndex = 0;
            // 
            // SekunttiCB
            // 
            SekunttiCB.FormattingEnabled = true;
            SekunttiCB.Location = new Point(268, 113);
            SekunttiCB.Name = "SekunttiCB";
            SekunttiCB.Size = new Size(103, 28);
            SekunttiCB.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(116, 68);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 2;
            label1.Text = "Minuutit:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(268, 68);
            label2.Name = "label2";
            label2.Size = new Size(92, 28);
            label2.TabIndex = 3;
            label2.Text = "Sekunnit:";
            // 
            // StartBT
            // 
            StartBT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StartBT.Location = new Point(116, 225);
            StartBT.Name = "StartBT";
            StartBT.Size = new Size(94, 40);
            StartBT.TabIndex = 4;
            StartBT.Text = "Start";
            StartBT.UseVisualStyleBackColor = true;
            StartBT.Click += StartBT_Click;
            // 
            // StopBT
            // 
            StopBT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StopBT.Location = new Point(268, 225);
            StopBT.Name = "StopBT";
            StopBT.Size = new Size(94, 40);
            StopBT.TabIndex = 5;
            StopBT.Text = "Stop";
            StopBT.UseVisualStyleBackColor = true;
            StopBT.Click += StopBT_Click;
            // 
            // AikaLB
            // 
            AikaLB.AutoSize = true;
            AikaLB.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            AikaLB.Location = new Point(156, 160);
            AikaLB.Name = "AikaLB";
            AikaLB.Size = new Size(0, 62);
            AikaLB.TabIndex = 6;
            // 
            // AjastinTM
            // 
            AjastinTM.Enabled = true;
            AjastinTM.Interval = 1000;
            AjastinTM.Tick += AjastinTM_Tick;
            // 
            // LaskuriForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 407);
            Controls.Add(AikaLB);
            Controls.Add(StopBT);
            Controls.Add(StartBT);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SekunttiCB);
            Controls.Add(MinuuttiCB);
            Name = "LaskuriForm";
            Text = "Laskuri";
            Load += LaskuriForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox MinuuttiCB;
        private ComboBox SekunttiCB;
        private Label label1;
        private Label label2;
        private Button StartBT;
        private Button StopBT;
        private Label AikaLB;
        private System.Windows.Forms.Timer AjastinTM;
    }
}
