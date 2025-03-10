namespace Tehtava13
{
    using System.IO;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EtsiBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible = false;
            string[] pojat = File.ReadAllLines("C:/Users/samps/sorsa/C-_Graafinen/Tehtava13/Tehtava13/pojat.txt");
            string[] tytot = File.ReadAllLines("C:/Users/samps/sorsa/C-_Graafinen/Tehtava13/Tehtava13/tytot.txt");
            string nimi = NimiTB.Text;
            int laskurip = 1;
            int laskurit = 1;
            foreach (string poika in pojat)
            {
                if (nimi == poika)
                {
                    VastausLB.Text = "Nimesi on " + laskurip + ", suosituin poikien nimi vuonna 2020";
                    VastausLB.Visible = true;
                }
                laskurip++;
            }
            foreach (string tytto in tytot)
            {
                if (nimi == tytto)
                {
                    VastausLB.Text = "Nimesi on " + laskurit + ", suosituin tyttöjem nimi vuonna 2020";
                    VastausLB.Visible = true;
                }
                laskurit++;
            }
            if (VastausLB.Visible == false)
            {
                VastausLB.Text = "Nimesi ei löytnyt suosituimpien nimien joukosta";
                VastausLB.Visible = true;
            }

        }
    }
    
}
