namespace HotelManagementSystem
{
    partial class kirjautumisForm
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
            this.kayttajaTB = new System.Windows.Forms.TextBox();
            this.salasanaTB = new System.Windows.Forms.TextBox();
            this.kirjauduBT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Käyttäjä:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salasana:";
            // 
            // kayttajaTB
            // 
            this.kayttajaTB.Location = new System.Drawing.Point(167, 20);
            this.kayttajaTB.Name = "kayttajaTB";
            this.kayttajaTB.Size = new System.Drawing.Size(206, 30);
            this.kayttajaTB.TabIndex = 2;
            // 
            // salasanaTB
            // 
            this.salasanaTB.Location = new System.Drawing.Point(167, 93);
            this.salasanaTB.Name = "salasanaTB";
            this.salasanaTB.Size = new System.Drawing.Size(206, 30);
            this.salasanaTB.TabIndex = 3;
            // 
            // kirjauduBT
            // 
            this.kirjauduBT.Location = new System.Drawing.Point(115, 153);
            this.kirjauduBT.Name = "kirjauduBT";
            this.kirjauduBT.Size = new System.Drawing.Size(160, 37);
            this.kirjauduBT.TabIndex = 4;
            this.kirjauduBT.Text = "Kirjaudu";
            this.kirjauduBT.UseVisualStyleBackColor = true;
            this.kirjauduBT.Click += new System.EventHandler(this.kirjauduBT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 51);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kirjaudu sisään";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.kirjauduBT);
            this.panel1.Controls.Add(this.kayttajaTB);
            this.panel1.Controls.Add(this.salasanaTB);
            this.panel1.Location = new System.Drawing.Point(110, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 202);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-2, 239);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 77);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::HotelManagementSystem.Properties.Resources.login;
            this.panel3.Location = new System.Drawing.Point(170, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(259, 221);
            this.panel3.TabIndex = 8;
            // 
            // kirjautumisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "kirjautumisForm";
            this.Text = "Kirjautumisikkuna";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kayttajaTB;
        private System.Windows.Forms.TextBox salasanaTB;
        private System.Windows.Forms.Button kirjauduBT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

