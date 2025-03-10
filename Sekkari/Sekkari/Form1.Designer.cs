namespace Sekkari
{
    partial class sekkariFM
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
            StartBT = new Button();
            StopBT = new Button();
            ResetBT = new Button();
            KelloLB = new Label();
            AjastinTM = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // StartBT
            // 
            StartBT.Location = new Point(63, 328);
            StartBT.Name = "StartBT";
            StartBT.Size = new Size(94, 29);
            StartBT.TabIndex = 0;
            StartBT.Text = "Start";
            StartBT.UseVisualStyleBackColor = true;
            StartBT.Click += StartBT_Click;
            // 
            // StopBT
            // 
            StopBT.Location = new Point(325, 328);
            StopBT.Name = "StopBT";
            StopBT.Size = new Size(94, 29);
            StopBT.TabIndex = 1;
            StopBT.Text = "Stop";
            StopBT.UseVisualStyleBackColor = true;
            StopBT.Click += StopBT_Click;
            // 
            // ResetBT
            // 
            ResetBT.Location = new Point(592, 328);
            ResetBT.Name = "ResetBT";
            ResetBT.Size = new Size(94, 29);
            ResetBT.TabIndex = 2;
            ResetBT.Text = "Reset";
            ResetBT.UseVisualStyleBackColor = true;
            ResetBT.Click += ResetBT_Click;
            // 
            // KelloLB
            // 
            KelloLB.AutoSize = true;
            KelloLB.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            KelloLB.Location = new Point(134, 93);
            KelloLB.Name = "KelloLB";
            KelloLB.Size = new Size(0, 106);
            KelloLB.TabIndex = 3;
            // 
            // AjastinTM
            // 
            AjastinTM.Enabled = true;
            AjastinTM.Tick += AjastinTM_Tick;
            // 
            // sekkariFM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(KelloLB);
            Controls.Add(ResetBT);
            Controls.Add(StopBT);
            Controls.Add(StartBT);
            Name = "sekkariFM";
            Text = "Stopwatch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartBT;
        private Button StopBT;
        private Button ResetBT;
        private Label KelloLB;
        private System.Windows.Forms.Timer AjastinTM;
    }
}
