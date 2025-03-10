namespace Muistio
{
    partial class Muistio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Muistio));
            menuStrip1 = new MenuStrip();
            tiedostoToolStripMenuItem = new ToolStripMenuItem();
            uusiToolStripMenuItem = new ToolStripMenuItem();
            avaaToolStripMenuItem = new ToolStripMenuItem();
            tallennaToolStripMenuItem = new ToolStripMenuItem();
            tallennaNimelläToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            tulostuksenEsikatseluToolStripMenuItem = new ToolStripMenuItem();
            tulostaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            poistuToolStripMenuItem = new ToolStripMenuItem();
            muotoileToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            kopioToolStripMenuItem = new ToolStripMenuItem();
            leikkaaToolStripMenuItem = new ToolStripMenuItem();
            liitäToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            valitseKaikkiToolStripMenuItem = new ToolStripMenuItem();
            muokkaaToolStripMenuItem = new ToolStripMenuItem();
            kirjasinToolStripMenuItem = new ToolStripMenuItem();
            tekstinKorostusToolStripMenuItem = new ToolStripMenuItem();
            tekstinRivitysToolStripMenuItem = new ToolStripMenuItem();
            apuaToolStripMenuItem = new ToolStripMenuItem();
            tietoaToolStripMenuItem = new ToolStripMenuItem();
            RikasTB = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            fontDialog1 = new FontDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tiedostoToolStripMenuItem, muotoileToolStripMenuItem, muokkaaToolStripMenuItem, apuaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            tiedostoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uusiToolStripMenuItem, avaaToolStripMenuItem, tallennaToolStripMenuItem, tallennaNimelläToolStripMenuItem, toolStripMenuItem2, tulostuksenEsikatseluToolStripMenuItem, tulostaToolStripMenuItem, toolStripMenuItem1, poistuToolStripMenuItem });
            tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            tiedostoToolStripMenuItem.Size = new Size(81, 24);
            tiedostoToolStripMenuItem.Text = "&Tiedosto";
            // 
            // uusiToolStripMenuItem
            // 
            uusiToolStripMenuItem.Name = "uusiToolStripMenuItem";
            uusiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            uusiToolStripMenuItem.Size = new Size(237, 26);
            uusiToolStripMenuItem.Text = "Uusi";
            uusiToolStripMenuItem.Click += uusiToolStripMenuItem_Click;
            // 
            // avaaToolStripMenuItem
            // 
            avaaToolStripMenuItem.Name = "avaaToolStripMenuItem";
            avaaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            avaaToolStripMenuItem.Size = new Size(237, 26);
            avaaToolStripMenuItem.Text = "Avaa";
            avaaToolStripMenuItem.Click += avaaToolStripMenuItem_Click;
            // 
            // tallennaToolStripMenuItem
            // 
            tallennaToolStripMenuItem.Name = "tallennaToolStripMenuItem";
            tallennaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            tallennaToolStripMenuItem.Size = new Size(237, 26);
            tallennaToolStripMenuItem.Text = "Tallenna";
            tallennaToolStripMenuItem.Click += tallennaToolStripMenuItem_Click;
            // 
            // tallennaNimelläToolStripMenuItem
            // 
            tallennaNimelläToolStripMenuItem.Name = "tallennaNimelläToolStripMenuItem";
            tallennaNimelläToolStripMenuItem.Size = new Size(237, 26);
            tallennaNimelläToolStripMenuItem.Text = "Tallenna nimellä...";
            tallennaNimelläToolStripMenuItem.Click += tallennaNimelläToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(234, 6);
            // 
            // tulostuksenEsikatseluToolStripMenuItem
            // 
            tulostuksenEsikatseluToolStripMenuItem.Name = "tulostuksenEsikatseluToolStripMenuItem";
            tulostuksenEsikatseluToolStripMenuItem.Size = new Size(237, 26);
            tulostuksenEsikatseluToolStripMenuItem.Text = "Tulostuksen esikatselu";
            tulostuksenEsikatseluToolStripMenuItem.Click += tulostuksenEsikatseluToolStripMenuItem_Click;
            // 
            // tulostaToolStripMenuItem
            // 
            tulostaToolStripMenuItem.Name = "tulostaToolStripMenuItem";
            tulostaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            tulostaToolStripMenuItem.Size = new Size(237, 26);
            tulostaToolStripMenuItem.Text = "Tulosta";
            tulostaToolStripMenuItem.Click += tulostaToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(234, 6);
            // 
            // poistuToolStripMenuItem
            // 
            poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            poistuToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            poistuToolStripMenuItem.Size = new Size(237, 26);
            poistuToolStripMenuItem.Text = "Poistu";
            poistuToolStripMenuItem.Click += poistuToolStripMenuItem_Click;
            // 
            // muotoileToolStripMenuItem
            // 
            muotoileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripMenuItem3, kopioToolStripMenuItem, leikkaaToolStripMenuItem, liitäToolStripMenuItem, toolStripMenuItem4, valitseKaikkiToolStripMenuItem });
            muotoileToolStripMenuItem.Name = "muotoileToolStripMenuItem";
            muotoileToolStripMenuItem.Size = new Size(83, 24);
            muotoileToolStripMenuItem.Text = "&Muokkaa";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(228, 26);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(228, 26);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(225, 6);
            // 
            // kopioToolStripMenuItem
            // 
            kopioToolStripMenuItem.Enabled = false;
            kopioToolStripMenuItem.Name = "kopioToolStripMenuItem";
            kopioToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            kopioToolStripMenuItem.Size = new Size(228, 26);
            kopioToolStripMenuItem.Text = "Kopio";
            kopioToolStripMenuItem.Click += kopioToolStripMenuItem_Click;
            // 
            // leikkaaToolStripMenuItem
            // 
            leikkaaToolStripMenuItem.Enabled = false;
            leikkaaToolStripMenuItem.Name = "leikkaaToolStripMenuItem";
            leikkaaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            leikkaaToolStripMenuItem.Size = new Size(228, 26);
            leikkaaToolStripMenuItem.Text = "Leikkaa";
            leikkaaToolStripMenuItem.Click += leikkaaToolStripMenuItem_Click;
            // 
            // liitäToolStripMenuItem
            // 
            liitäToolStripMenuItem.Name = "liitäToolStripMenuItem";
            liitäToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            liitäToolStripMenuItem.Size = new Size(228, 26);
            liitäToolStripMenuItem.Text = "Liitä";
            liitäToolStripMenuItem.Click += liitäToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(228, 26);
            toolStripMenuItem4.Text = "Poista";
            // 
            // valitseKaikkiToolStripMenuItem
            // 
            valitseKaikkiToolStripMenuItem.Name = "valitseKaikkiToolStripMenuItem";
            valitseKaikkiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            valitseKaikkiToolStripMenuItem.Size = new Size(228, 26);
            valitseKaikkiToolStripMenuItem.Text = "Valitse kaikki";
            valitseKaikkiToolStripMenuItem.Click += valitseKaikkiToolStripMenuItem_Click;
            // 
            // muokkaaToolStripMenuItem
            // 
            muokkaaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kirjasinToolStripMenuItem, tekstinKorostusToolStripMenuItem, tekstinRivitysToolStripMenuItem });
            muokkaaToolStripMenuItem.Name = "muokkaaToolStripMenuItem";
            muokkaaToolStripMenuItem.Size = new Size(83, 24);
            muokkaaToolStripMenuItem.Text = "M&uotoile";
            // 
            // kirjasinToolStripMenuItem
            // 
            kirjasinToolStripMenuItem.Name = "kirjasinToolStripMenuItem";
            kirjasinToolStripMenuItem.Size = new Size(224, 26);
            kirjasinToolStripMenuItem.Text = "Kirjasin";
            kirjasinToolStripMenuItem.Click += kirjasinToolStripMenuItem_Click;
            // 
            // tekstinKorostusToolStripMenuItem
            // 
            tekstinKorostusToolStripMenuItem.Name = "tekstinKorostusToolStripMenuItem";
            tekstinKorostusToolStripMenuItem.Size = new Size(224, 26);
            tekstinKorostusToolStripMenuItem.Text = "Tekstin korostus";
            tekstinKorostusToolStripMenuItem.Click += tekstinKorostusToolStripMenuItem_Click;
            // 
            // tekstinRivitysToolStripMenuItem
            // 
            tekstinRivitysToolStripMenuItem.Name = "tekstinRivitysToolStripMenuItem";
            tekstinRivitysToolStripMenuItem.Size = new Size(224, 26);
            tekstinRivitysToolStripMenuItem.Text = "Tekstin rivitys";
            tekstinRivitysToolStripMenuItem.Click += tekstinRivitysToolStripMenuItem_Click;
            // 
            // apuaToolStripMenuItem
            // 
            apuaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tietoaToolStripMenuItem });
            apuaToolStripMenuItem.Name = "apuaToolStripMenuItem";
            apuaToolStripMenuItem.Size = new Size(58, 24);
            apuaToolStripMenuItem.Text = "&Apua";
            // 
            // tietoaToolStripMenuItem
            // 
            tietoaToolStripMenuItem.Name = "tietoaToolStripMenuItem";
            tietoaToolStripMenuItem.Size = new Size(224, 26);
            tietoaToolStripMenuItem.Text = "Tietoa";
            tietoaToolStripMenuItem.Click += tietoaToolStripMenuItem_Click;
            // 
            // RikasTB
            // 
            RikasTB.Dock = DockStyle.Fill;
            RikasTB.Location = new Point(0, 28);
            RikasTB.Name = "RikasTB";
            RikasTB.Size = new Size(800, 422);
            RikasTB.TabIndex = 1;
            RikasTB.Text = "";
            RikasTB.WordWrap = false;
            RikasTB.TextChanged += RikasTB_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // Muistio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(RikasTB);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Muistio";
            Text = "Muotoile";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tiedostoToolStripMenuItem;
        private ToolStripMenuItem uusiToolStripMenuItem;
        private ToolStripMenuItem tallennaToolStripMenuItem;
        private ToolStripMenuItem tallennaNimelläToolStripMenuItem;
        private ToolStripMenuItem tulostuksenEsikatseluToolStripMenuItem;
        private ToolStripMenuItem tulostaToolStripMenuItem;
        private ToolStripMenuItem poistuToolStripMenuItem;
        private ToolStripMenuItem avaaToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem muotoileToolStripMenuItem;
        private ToolStripMenuItem muokkaaToolStripMenuItem;
        private ToolStripMenuItem apuaToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem kopioToolStripMenuItem;
        private ToolStripMenuItem leikkaaToolStripMenuItem;
        private ToolStripMenuItem liitäToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem valitseKaikkiToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem kirjasinToolStripMenuItem;
        private ToolStripMenuItem tekstinKorostusToolStripMenuItem;
        private ToolStripMenuItem tekstinRivitysToolStripMenuItem;
        private ToolStripMenuItem tietoaToolStripMenuItem;
        private RichTextBox RikasTB;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private FontDialog fontDialog1;
    }
}
