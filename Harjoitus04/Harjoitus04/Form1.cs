namespace Harjoitus04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            DateTime synttari = SynttariDT.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt - synttari).TotalDays);
            VuosissaLB.Text = Math.Floor(erotus / 365.25) + " vuotta";
            KuukausissaLB.Text = Math.Ceiling(erotus * 12 / 365.25) + " kuukautta";
            PaivissaLB.Text = (erotus + " p‰iv‰‰");
            TunnissaLB.Text = (erotus * 24 + " tuntia");
            MinuuteissaLB.Text = (erotus * 24 * 60 + " minuuttia");
            SekunneissaLB.Text = (erotus * 24 * 3600 + " sekunttia");
            VuosissaLB.Visible = true;
            KuukausissaLB.Visible = true;
            PaivissaLB.Visible= true;
            TunnissaLB.Visible = true;
            MinuuteissaLB.Visible = true;
            SekunneissaLB.Visible = true;

        }
    }
}
