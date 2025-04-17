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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.varauksetDG = new System.Windows.Forms.DataGridView();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.poistaBT = new System.Windows.Forms.Button();
            this.muokkaaBT = new System.Windows.Forms.Button();
            this.lisaaUusiVarausBT = new System.Windows.Forms.Button();
            this.ulosDTP = new System.Windows.Forms.DateTimePicker();
            this.sisaanDTP = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.asiakasnroCB = new System.Windows.Forms.ComboBox();
            this.huonetyyppiCB = new System.Windows.Forms.ComboBox();
            this.huonenroCB = new System.Windows.Forms.ComboBox();
            this.varausnumeroTB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetDG)).BeginInit();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.varausnumeroTB);
            this.panel2.Controls.Add(this.huonenroCB);
            this.panel2.Controls.Add(this.huonetyyppiCB);
            this.panel2.Controls.Add(this.asiakasnroCB);
            this.panel2.Controls.Add(this.varauksetDG);
            this.panel2.Controls.Add(this.tyhjennaBT);
            this.panel2.Controls.Add(this.poistaBT);
            this.panel2.Controls.Add(this.muokkaaBT);
            this.panel2.Controls.Add(this.lisaaUusiVarausBT);
            this.panel2.Controls.Add(this.ulosDTP);
            this.panel2.Controls.Add(this.sisaanDTP);
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
            // varauksetDG
            // 
            this.varauksetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.varauksetDG.Location = new System.Drawing.Point(549, 54);
            this.varauksetDG.Name = "varauksetDG";
            this.varauksetDG.RowHeadersWidth = 51;
            this.varauksetDG.RowTemplate.Height = 24;
            this.varauksetDG.Size = new System.Drawing.Size(621, 376);
            this.varauksetDG.TabIndex = 16;
            this.varauksetDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.varauksetDG_CellClick);
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
            this.tyhjennaBT.Click += new System.EventHandler(this.tyhjennaBT_Click);
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
            this.poistaBT.Click += new System.EventHandler(this.poistaBT_Click);
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
            this.muokkaaBT.Click += new System.EventHandler(this.muokkaaBT_Click);
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
            this.lisaaUusiVarausBT.Click += new System.EventHandler(this.lisaaUusiVarausBT_Click);
            // 
            // ulosDTP
            // 
            this.ulosDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ulosDTP.Location = new System.Drawing.Point(303, 250);
            this.ulosDTP.Name = "ulosDTP";
            this.ulosDTP.Size = new System.Drawing.Size(200, 34);
            this.ulosDTP.TabIndex = 11;
            // 
            // sisaanDTP
            // 
            this.sisaanDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sisaanDTP.Location = new System.Drawing.Point(303, 210);
            this.sisaanDTP.Name = "sisaanDTP";
            this.sisaanDTP.Size = new System.Drawing.Size(200, 34);
            this.sisaanDTP.TabIndex = 10;
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
            // asiakasnroCB
            // 
            this.asiakasnroCB.FormattingEnabled = true;
            this.asiakasnroCB.Location = new System.Drawing.Point(303, 97);
            this.asiakasnroCB.Name = "asiakasnroCB";
            this.asiakasnroCB.Size = new System.Drawing.Size(197, 24);
            this.asiakasnroCB.TabIndex = 18;
            // 
            // huonetyyppiCB
            // 
            this.huonetyyppiCB.FormattingEnabled = true;
            this.huonetyyppiCB.Location = new System.Drawing.Point(303, 136);
            this.huonetyyppiCB.Name = "huonetyyppiCB";
            this.huonetyyppiCB.Size = new System.Drawing.Size(197, 24);
            this.huonetyyppiCB.TabIndex = 19;
            this.huonetyyppiCB.SelectedIndexChanged += new System.EventHandler(this.huonetyyppiCB_SelectedIndexChanged);
            // 
            // huonenroCB
            // 
            this.huonenroCB.FormattingEnabled = true;
            this.huonenroCB.Location = new System.Drawing.Point(303, 175);
            this.huonenroCB.Name = "huonenroCB";
            this.huonenroCB.Size = new System.Drawing.Size(197, 24);
            this.huonenroCB.TabIndex = 20;
            // 
            // varausnumeroTB
            // 
            this.varausnumeroTB.Location = new System.Drawing.Point(303, 59);
            this.varausnumeroTB.Name = "varausnumeroTB";
            this.varausnumeroTB.Size = new System.Drawing.Size(200, 22);
            this.varausnumeroTB.TabIndex = 21;
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
            this.Load += new System.EventHandler(this.varaustenHallintaForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetDG)).EndInit();
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
        private System.Windows.Forms.DataGridView varauksetDG;
        private System.Windows.Forms.ComboBox huonenroCB;
        private System.Windows.Forms.ComboBox huonetyyppiCB;
        private System.Windows.Forms.ComboBox asiakasnroCB;
        private System.Windows.Forms.TextBox varausnumeroTB;
    }
}