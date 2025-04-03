namespace HotelManagementSystem
{
    partial class varaustenHallintaForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.varausNroTB = new System.Windows.Forms.TextBox();
            this.asiakasNroTB = new System.Windows.Forms.TextBox();
            this.huoneenNroTB = new System.Windows.Forms.TextBox();
            this.huonetyyppiTB = new System.Windows.Forms.TextBox();
            this.sisaanDTP = new System.Windows.Forms.DateTimePicker();
            this.ulosDTP = new System.Windows.Forms.DateTimePicker();
            this.lisaaUusiVarausBT = new System.Windows.Forms.Button();
            this.muokkaaBT = new System.Windows.Forms.Button();
            this.poistaBT = new System.Windows.Forms.Button();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 114);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.tyhjennaBT);
            this.panel2.Controls.Add(this.poistaBT);
            this.panel2.Controls.Add(this.muokkaaBT);
            this.panel2.Controls.Add(this.lisaaUusiVarausBT);
            this.panel2.Controls.Add(this.ulosDTP);
            this.panel2.Controls.Add(this.sisaanDTP);
            this.panel2.Controls.Add(this.huoneenNroTB);
            this.panel2.Controls.Add(this.huonetyyppiTB);
            this.panel2.Controls.Add(this.asiakasNroTB);
            this.panel2.Controls.Add(this.varausNroTB);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1183, 448);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varausten hallinta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Varaus nro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Asiakas nro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Huoneen nro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Huonetyyppi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(109, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ulos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(109, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Sisään:";
            // 
            // varausNroTB
            // 
            this.varausNroTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varausNroTB.Location = new System.Drawing.Point(303, 54);
            this.varausNroTB.Name = "varausNroTB";
            this.varausNroTB.Size = new System.Drawing.Size(197, 34);
            this.varausNroTB.TabIndex = 6;
            // 
            // asiakasNroTB
            // 
            this.asiakasNroTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asiakasNroTB.Location = new System.Drawing.Point(303, 92);
            this.asiakasNroTB.Name = "asiakasNroTB";
            this.asiakasNroTB.Size = new System.Drawing.Size(197, 34);
            this.asiakasNroTB.TabIndex = 7;
            // 
            // huoneenNroTB
            // 
            this.huoneenNroTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huoneenNroTB.Location = new System.Drawing.Point(303, 170);
            this.huoneenNroTB.Name = "huoneenNroTB";
            this.huoneenNroTB.Size = new System.Drawing.Size(197, 34);
            this.huoneenNroTB.TabIndex = 9;
            // 
            // huonetyyppiTB
            // 
            this.huonetyyppiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huonetyyppiTB.Location = new System.Drawing.Point(303, 131);
            this.huonetyyppiTB.Name = "huonetyyppiTB";
            this.huonetyyppiTB.Size = new System.Drawing.Size(197, 34);
            this.huonetyyppiTB.TabIndex = 8;
            // 
            // sisaanDTP
            // 
            this.sisaanDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sisaanDTP.Location = new System.Drawing.Point(303, 210);
            this.sisaanDTP.Name = "sisaanDTP";
            this.sisaanDTP.Size = new System.Drawing.Size(200, 34);
            this.sisaanDTP.TabIndex = 10;
            // 
            // ulosDTP
            // 
            this.ulosDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ulosDTP.Location = new System.Drawing.Point(303, 250);
            this.ulosDTP.Name = "ulosDTP";
            this.ulosDTP.Size = new System.Drawing.Size(200, 34);
            this.ulosDTP.TabIndex = 11;
            // 
            // lisaaUusiVarausBT
            // 
            this.lisaaUusiVarausBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lisaaUusiVarausBT.Location = new System.Drawing.Point(114, 320);
            this.lisaaUusiVarausBT.Name = "lisaaUusiVarausBT";
            this.lisaaUusiVarausBT.Size = new System.Drawing.Size(209, 33);
            this.lisaaUusiVarausBT.TabIndex = 12;
            this.lisaaUusiVarausBT.Text = "Lisää uusi varaus";
            this.lisaaUusiVarausBT.UseVisualStyleBackColor = true;
            // 
            // muokkaaBT
            // 
            this.muokkaaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muokkaaBT.Location = new System.Drawing.Point(329, 320);
            this.muokkaaBT.Name = "muokkaaBT";
            this.muokkaaBT.Size = new System.Drawing.Size(128, 33);
            this.muokkaaBT.TabIndex = 13;
            this.muokkaaBT.Text = "Muokkaa";
            this.muokkaaBT.UseVisualStyleBackColor = true;
            // 
            // poistaBT
            // 
            this.poistaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poistaBT.Location = new System.Drawing.Point(114, 368);
            this.poistaBT.Name = "poistaBT";
            this.poistaBT.Size = new System.Drawing.Size(99, 33);
            this.poistaBT.TabIndex = 14;
            this.poistaBT.Text = "Poista";
            this.poistaBT.UseVisualStyleBackColor = true;
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyhjennaBT.Location = new System.Drawing.Point(243, 366);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(214, 35);
            this.tyhjennaBT.TabIndex = 15;
            this.tyhjennaBT.Text = "Tyhjennä kentät";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(549, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(621, 376);
            this.dataGridView1.TabIndex = 16;
            // 
            // varaustenHallintaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "varaustenHallintaForm";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button tyhjennaBT;
        private System.Windows.Forms.Button poistaBT;
        private System.Windows.Forms.Button muokkaaBT;
        private System.Windows.Forms.Button lisaaUusiVarausBT;
        private System.Windows.Forms.DateTimePicker ulosDTP;
        private System.Windows.Forms.DateTimePicker sisaanDTP;
        private System.Windows.Forms.TextBox huoneenNroTB;
        private System.Windows.Forms.TextBox huonetyyppiTB;
        private System.Windows.Forms.TextBox asiakasNroTB;
        private System.Windows.Forms.TextBox varausNroTB;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}