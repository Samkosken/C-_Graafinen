using System.IO;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.DataFormats;
namespace Muistio
{
    public partial class Muistio : Form
    {
        string tiedostoPolku = "";
        public Muistio()
        {
            InitializeComponent();
        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RikasTB.Text != "")
            {
                tallennaToolStripMenuItem_Click(sender, e);
                RikasTB.Text = "";
            }
            else
            {
                RikasTB.Text = "";
            }
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog atk = new OpenFileDialog()
            { Filter = "TextDocument|*txt|Rich Text Format|*.rtf", ValidateNames = true, Multiselect = false })
            {
                if (atk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader v1 = new StreamReader(atk.FileName))
                    {
                        tiedostoPolku = atk.FileName;
                        Task<string> text = v1.ReadToEndAsync();
                        RikasTB.Rtf = text.Result;
                    }

                }
            }
;
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tiedostoPolku))
            {
                using (SaveFileDialog ttk = new SaveFileDialog()
                { Filter = "TextDocument|*txt|Rich Text Format|*.rtf", ValidateNames = true })
                {
                    if (ttk.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter tiedosto = new StreamWriter(ttk.FileName);
                        tiedosto.WriteLine(this.RikasTB.Rtf);
                        tiedosto.Close();
                    }
                }
            }
            else
            {
                using (StreamWriter vk = new StreamWriter(tiedostoPolku))
                {
                    vk.WriteLineAsync(RikasTB.Rtf);
                }
            }
        }

        private void tallennaNimelläToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ttk = new SaveFileDialog()
            { Filter = "TextDocument|*txt|Rich Text Format|*.rtf", ValidateNames = true })
            {
                if (ttk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter jonokirjoittaja = new StreamWriter(ttk.FileName))
                    {
                        jonokirjoittaja.WriteLineAsync(RikasTB.Rtf);
                    }
                }
            }
        }

        private void tulostuksenEsikatseluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void tulostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(RikasTB.Text, RikasTB.Font, Brushes.Black, 12, 10);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RikasTB.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RikasTB.Redo();
        }

        private void kopioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RikasTB.Copy();
        }

        private void leikkaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RikasTB.Cut();
        }

        private void liitäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RikasTB.Paste();
        }

        private void valitseKaikkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RikasTB.SelectAll();
        }

        private void RikasTB_TextChanged(object sender, EventArgs e)
        {
            if (RikasTB.Text.Length > 0)
            {
                kopioToolStripMenuItem.Enabled = true;
                leikkaaToolStripMenuItem.Enabled = true;
            }
            else
            {
                kopioToolStripMenuItem.Enabled = false;
                leikkaaToolStripMenuItem.Enabled = false;
            }
        }

        private void tekstinRivitysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tekstinRivitysToolStripMenuItem.Checked == true)
            {
                tekstinRivitysToolStripMenuItem.Checked = false;
                RikasTB.WordWrap = false;
            }
            else
            {
                tekstinRivitysToolStripMenuItem.Checked = true;
                RikasTB.WordWrap = true;
            }
        }

        private void kirjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            RikasTB.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
        }

        private void tekstinKorostusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RikasTB.SelectionBackColor = Color.Yellow;
        }

        private void tietoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tietoa tietoa = new tietoa();
            tietoa.ShowDialog();
        }
    }
}
