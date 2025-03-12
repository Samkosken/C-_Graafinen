namespace Tehtava18
{
    partial class AvainhenkilotForm
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
            OppilaitoksetCB = new ComboBox();
            VastuuhloCB = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            KatuosoiteLB = new Label();
            PostinumeroLB = new Label();
            PostitoimipaikkaLB = new Label();
            PuhelinLB = new Label();
            titteliLB = new Label();
            sijaintiLB = new Label();
            emailLB = new Label();
            phoneLB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Reem Kufi", 26F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(699, 94);
            label1.TabIndex = 0;
            label1.Text = "Oppilaitksen avainhenkilot";
            // 
            // OppilaitoksetCB
            // 
            OppilaitoksetCB.FormattingEnabled = true;
            OppilaitoksetCB.Location = new Point(54, 158);
            OppilaitoksetCB.Name = "OppilaitoksetCB";
            OppilaitoksetCB.Size = new Size(182, 33);
            OppilaitoksetCB.TabIndex = 1;
            OppilaitoksetCB.SelectedIndexChanged += OppilaitoksetCB_SelectedIndexChanged;
            // 
            // VastuuhloCB
            // 
            VastuuhloCB.FormattingEnabled = true;
            VastuuhloCB.Location = new Point(344, 158);
            VastuuhloCB.Name = "VastuuhloCB";
            VastuuhloCB.Size = new Size(182, 33);
            VastuuhloCB.TabIndex = 2;
            VastuuhloCB.TextChanged += VastuuhloCB_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 111);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
            label2.TabIndex = 3;
            label2.Text = "Valitste oppilaitos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 111);
            label3.Name = "label3";
            label3.Size = new Size(180, 25);
            label3.TabIndex = 4;
            label3.Text = "Valitse vastuuhenkilo:";
            // 
            // KatuosoiteLB
            // 
            KatuosoiteLB.AutoSize = true;
            KatuosoiteLB.Location = new Point(54, 205);
            KatuosoiteLB.Name = "KatuosoiteLB";
            KatuosoiteLB.Size = new Size(0, 25);
            KatuosoiteLB.TabIndex = 5;
            // 
            // PostinumeroLB
            // 
            PostinumeroLB.AutoSize = true;
            PostinumeroLB.Location = new Point(54, 243);
            PostinumeroLB.Name = "PostinumeroLB";
            PostinumeroLB.Size = new Size(0, 25);
            PostinumeroLB.TabIndex = 6;
            // 
            // PostitoimipaikkaLB
            // 
            PostitoimipaikkaLB.AutoSize = true;
            PostitoimipaikkaLB.Location = new Point(54, 283);
            PostitoimipaikkaLB.Name = "PostitoimipaikkaLB";
            PostitoimipaikkaLB.Size = new Size(0, 25);
            PostitoimipaikkaLB.TabIndex = 7;
            // 
            // PuhelinLB
            // 
            PuhelinLB.AutoSize = true;
            PuhelinLB.Location = new Point(54, 323);
            PuhelinLB.Name = "PuhelinLB";
            PuhelinLB.Size = new Size(0, 25);
            PuhelinLB.TabIndex = 8;
            // 
            // titteliLB
            // 
            titteliLB.AutoSize = true;
            titteliLB.Location = new Point(344, 205);
            titteliLB.Name = "titteliLB";
            titteliLB.Size = new Size(0, 25);
            titteliLB.TabIndex = 9;
            // 
            // sijaintiLB
            // 
            sijaintiLB.AutoSize = true;
            sijaintiLB.Location = new Point(344, 243);
            sijaintiLB.Name = "sijaintiLB";
            sijaintiLB.Size = new Size(0, 25);
            sijaintiLB.TabIndex = 10;
            // 
            // emailLB
            // 
            emailLB.AutoSize = true;
            emailLB.Location = new Point(344, 283);
            emailLB.Name = "emailLB";
            emailLB.Size = new Size(0, 25);
            emailLB.TabIndex = 11;
            // 
            // phoneLB
            // 
            phoneLB.AutoSize = true;
            phoneLB.Location = new Point(344, 323);
            phoneLB.Name = "phoneLB";
            phoneLB.Size = new Size(0, 25);
            phoneLB.TabIndex = 12;
            // 
            // AvainhenkilotForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 424);
            Controls.Add(phoneLB);
            Controls.Add(emailLB);
            Controls.Add(sijaintiLB);
            Controls.Add(titteliLB);
            Controls.Add(PuhelinLB);
            Controls.Add(PostitoimipaikkaLB);
            Controls.Add(PostinumeroLB);
            Controls.Add(KatuosoiteLB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(VastuuhloCB);
            Controls.Add(OppilaitoksetCB);
            Controls.Add(label1);
            Name = "AvainhenkilotForm";
            Text = "Oppilaitoksen avainhenkilöt";
            Load += AvainhenkilotForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox OppilaitoksetCB;
        private ComboBox VastuuhloCB;
        private Label label2;
        private Label label3;
        private Label KatuosoiteLB;
        private Label PostinumeroLB;
        private Label PostitoimipaikkaLB;
        private Label PuhelinLB;
        private Label titteliLB;
        private Label sijaintiLB;
        private Label emailLB;
        private Label phoneLB;
    }
}
