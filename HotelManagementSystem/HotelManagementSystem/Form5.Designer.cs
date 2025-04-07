namespace HotelManagementSystem
{
    partial class Huoneikkuna
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.muokkaaBT = new System.Windows.Forms.Button();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.poistaBT = new System.Windows.Forms.Button();
            this.lisaaUusiHuoneBT = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.eiRB = new System.Windows.Forms.RadioButton();
            this.kyllaRB = new System.Windows.Forms.RadioButton();
            this.puhelinTB = new System.Windows.Forms.TextBox();
            this.huonetyyppiTB = new System.Windows.Forms.TextBox();
            this.huoneNroTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 113);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(363, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(525, 69);
            this.label5.TabIndex = 0;
            this.label5.Text = "Huoneiden hallinta";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.muokkaaBT);
            this.panel2.Controls.Add(this.tyhjennaBT);
            this.panel2.Controls.Add(this.poistaBT);
            this.panel2.Controls.Add(this.lisaaUusiHuoneBT);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.puhelinTB);
            this.panel2.Controls.Add(this.huonetyyppiTB);
            this.panel2.Controls.Add(this.huoneNroTB);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1181, 448);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(535, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(634, 332);
            this.dataGridView1.TabIndex = 12;
            // 
            // muokkaaBT
            // 
            this.muokkaaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muokkaaBT.Location = new System.Drawing.Point(375, 308);
            this.muokkaaBT.Name = "muokkaaBT";
            this.muokkaaBT.Size = new System.Drawing.Size(129, 37);
            this.muokkaaBT.TabIndex = 11;
            this.muokkaaBT.Text = "Muokkaa";
            this.muokkaaBT.UseVisualStyleBackColor = true;
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyhjennaBT.Location = new System.Drawing.Point(307, 366);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(197, 37);
            this.tyhjennaBT.TabIndex = 10;
            this.tyhjennaBT.Text = "Tyhjennä kentät";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            // 
            // poistaBT
            // 
            this.poistaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poistaBT.Location = new System.Drawing.Point(119, 366);
            this.poistaBT.Name = "poistaBT";
            this.poistaBT.Size = new System.Drawing.Size(107, 37);
            this.poistaBT.TabIndex = 9;
            this.poistaBT.Text = "Poista";
            this.poistaBT.UseVisualStyleBackColor = true;
            // 
            // lisaaUusiHuoneBT
            // 
            this.lisaaUusiHuoneBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lisaaUusiHuoneBT.Location = new System.Drawing.Point(119, 308);
            this.lisaaUusiHuoneBT.Name = "lisaaUusiHuoneBT";
            this.lisaaUusiHuoneBT.Size = new System.Drawing.Size(213, 37);
            this.lisaaUusiHuoneBT.TabIndex = 8;
            this.lisaaUusiHuoneBT.Text = "Lisää uusi huone";
            this.lisaaUusiHuoneBT.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.eiRB);
            this.panel3.Controls.Add(this.kyllaRB);
            this.panel3.Location = new System.Drawing.Point(297, 223);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 47);
            this.panel3.TabIndex = 7;
            // 
            // eiRB
            // 
            this.eiRB.AutoSize = true;
            this.eiRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eiRB.Location = new System.Drawing.Point(126, 9);
            this.eiRB.Name = "eiRB";
            this.eiRB.Size = new System.Drawing.Size(50, 29);
            this.eiRB.TabIndex = 1;
            this.eiRB.TabStop = true;
            this.eiRB.Text = "Ei";
            this.eiRB.UseVisualStyleBackColor = true;
            // 
            // kyllaRB
            // 
            this.kyllaRB.AutoSize = true;
            this.kyllaRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kyllaRB.Location = new System.Drawing.Point(19, 9);
            this.kyllaRB.Name = "kyllaRB";
            this.kyllaRB.Size = new System.Drawing.Size(76, 29);
            this.kyllaRB.TabIndex = 0;
            this.kyllaRB.TabStop = true;
            this.kyllaRB.Text = "Kyllä";
            this.kyllaRB.UseVisualStyleBackColor = true;
            // 
            // puhelinTB
            // 
            this.puhelinTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puhelinTB.Location = new System.Drawing.Point(297, 183);
            this.puhelinTB.Name = "puhelinTB";
            this.puhelinTB.Size = new System.Drawing.Size(207, 34);
            this.puhelinTB.TabIndex = 6;
            // 
            // huonetyyppiTB
            // 
            this.huonetyyppiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huonetyyppiTB.Location = new System.Drawing.Point(297, 142);
            this.huonetyyppiTB.Name = "huonetyyppiTB";
            this.huonetyyppiTB.Size = new System.Drawing.Size(207, 34);
            this.huonetyyppiTB.TabIndex = 5;
            // 
            // huoneNroTB
            // 
            this.huoneNroTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huoneNroTB.Location = new System.Drawing.Point(297, 99);
            this.huoneNroTB.Name = "huoneNroTB";
            this.huoneNroTB.Size = new System.Drawing.Size(207, 34);
            this.huoneNroTB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vapaa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Puhelin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Huonetyyppi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Huoneen nro:";
            // 
            // Huoneikkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Huoneikkuna";
            this.Text = "Huoneiden hallinta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton eiRB;
        private System.Windows.Forms.RadioButton kyllaRB;
        private System.Windows.Forms.TextBox puhelinTB;
        private System.Windows.Forms.TextBox huonetyyppiTB;
        private System.Windows.Forms.TextBox huoneNroTB;
        private System.Windows.Forms.Button muokkaaBT;
        private System.Windows.Forms.Button tyhjennaBT;
        private System.Windows.Forms.Button poistaBT;
        private System.Windows.Forms.Button lisaaUusiHuoneBT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}