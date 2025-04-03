namespace CRUD20
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OidTB = new System.Windows.Forms.TextBox();
            this.SnimiTB = new System.Windows.Forms.TextBox();
            this.EnimiTB = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.ONroTB = new System.Windows.Forms.TextBox();
            this.PuhTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.tallennaBT = new System.Windows.Forms.Button();
            this.paivitaBT = new System.Windows.Forms.Button();
            this.poistaBT = new System.Windows.Forms.Button();
            this.tietotauluDG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tietotauluDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "ETUNIMI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "SUKUNIMI:";
            // 
            // OidTB
            // 
            this.OidTB.Location = new System.Drawing.Point(146, 23);
            this.OidTB.Name = "OidTB";
            this.OidTB.Size = new System.Drawing.Size(200, 29);
            this.OidTB.TabIndex = 3;
            // 
            // SnimiTB
            // 
            this.SnimiTB.Location = new System.Drawing.Point(146, 109);
            this.SnimiTB.Name = "SnimiTB";
            this.SnimiTB.Size = new System.Drawing.Size(200, 29);
            this.SnimiTB.TabIndex = 4;
            // 
            // EnimiTB
            // 
            this.EnimiTB.Location = new System.Drawing.Point(146, 68);
            this.EnimiTB.Name = "EnimiTB";
            this.EnimiTB.Size = new System.Drawing.Size(200, 29);
            this.EnimiTB.TabIndex = 5;
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(559, 71);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(200, 29);
            this.EmailTB.TabIndex = 11;
            // 
            // ONroTB
            // 
            this.ONroTB.Location = new System.Drawing.Point(559, 112);
            this.ONroTB.Name = "ONroTB";
            this.ONroTB.Size = new System.Drawing.Size(200, 29);
            this.ONroTB.TabIndex = 10;
            // 
            // PuhTB
            // 
            this.PuhTB.Location = new System.Drawing.Point(559, 26);
            this.PuhTB.Name = "PuhTB";
            this.PuhTB.Size = new System.Drawing.Size(200, 29);
            this.PuhTB.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "OPISKELIJANRO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "SÄHKÖPOSTI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "PUHELIN:";
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Location = new System.Drawing.Point(16, 164);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(161, 42);
            this.tyhjennaBT.TabIndex = 12;
            this.tyhjennaBT.Text = "TYHJENNÄ";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            this.tyhjennaBT.Click += new System.EventHandler(this.tyhjennaBT_Click);
            // 
            // tallennaBT
            // 
            this.tallennaBT.Location = new System.Drawing.Point(201, 164);
            this.tallennaBT.Name = "tallennaBT";
            this.tallennaBT.Size = new System.Drawing.Size(157, 42);
            this.tallennaBT.TabIndex = 13;
            this.tallennaBT.Text = "TALLENNA";
            this.tallennaBT.UseVisualStyleBackColor = true;
            this.tallennaBT.Click += new System.EventHandler(this.tallennaBT_Click);
            // 
            // paivitaBT
            // 
            this.paivitaBT.Location = new System.Drawing.Point(394, 164);
            this.paivitaBT.Name = "paivitaBT";
            this.paivitaBT.Size = new System.Drawing.Size(157, 42);
            this.paivitaBT.TabIndex = 14;
            this.paivitaBT.Text = "PÄIVITÄ";
            this.paivitaBT.UseVisualStyleBackColor = true;
            this.paivitaBT.Click += new System.EventHandler(this.paivitaBT_Click);
            // 
            // poistaBT
            // 
            this.poistaBT.Location = new System.Drawing.Point(589, 164);
            this.poistaBT.Name = "poistaBT";
            this.poistaBT.Size = new System.Drawing.Size(157, 42);
            this.poistaBT.TabIndex = 15;
            this.poistaBT.Text = "POISTA";
            this.poistaBT.UseVisualStyleBackColor = true;
            this.poistaBT.Click += new System.EventHandler(this.poistaBT_Click);
            // 
            // tietotauluDG
            // 
            this.tietotauluDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tietotauluDG.Location = new System.Drawing.Point(12, 212);
            this.tietotauluDG.Name = "tietotauluDG";
            this.tietotauluDG.RowHeadersWidth = 51;
            this.tietotauluDG.RowTemplate.Height = 24;
            this.tietotauluDG.Size = new System.Drawing.Size(797, 395);
            this.tietotauluDG.TabIndex = 16;
            this.tietotauluDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tietotauluDG_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 619);
            this.Controls.Add(this.tietotauluDG);
            this.Controls.Add(this.poistaBT);
            this.Controls.Add(this.paivitaBT);
            this.Controls.Add(this.tallennaBT);
            this.Controls.Add(this.tyhjennaBT);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.ONroTB);
            this.Controls.Add(this.PuhTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EnimiTB);
            this.Controls.Add(this.SnimiTB);
            this.Controls.Add(this.OidTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "TYHJENNA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tietotauluDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OidTB;
        private System.Windows.Forms.TextBox SnimiTB;
        private System.Windows.Forms.TextBox EnimiTB;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox ONroTB;
        private System.Windows.Forms.TextBox PuhTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button tyhjennaBT;
        private System.Windows.Forms.Button tallennaBT;
        private System.Windows.Forms.Button paivitaBT;
        private System.Windows.Forms.Button poistaBT;
        private System.Windows.Forms.DataGridView tietotauluDG;
    }
}

