namespace Tehtava12
{
    public partial class Form1 : Form
    {
        string[] vastaukset = new string[11];
        string[] oikeat = new string[] { "", "B", "D", "A", "A", "C", "A", "B", "A", "C", "D" };
        int laskuri = 0;
        int oikein = 0;
        public Form1()
        {
            InitializeComponent();
            ARB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            BRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            CRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            DRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
        }
        private void radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton && laskuri <= 10)
            {

                RadioButton radioButton = (RadioButton)sender;
                vastaukset[laskuri] = radioButton.Text;
                KysymysLB.Text = "Vastaus " + (laskuri) + ". kysymykseen";
                laskuri++;
            }
            else
            {
                VastausLB.Text = "";
                ARB.Enabled = false;
                BRB.Enabled = false;
                CRB.Enabled = false;
                DRB.Enabled = false;
                for(int j =  1; j <= 10; j++)
                {
                    if (vastaukset[j] == oikeat[j])
                    {
                        oikein++;
                    }
                }
                VastausLB.Text = "Oikeita vastauksia oli: " + oikein;
                VastausLB.Visible = true;
            }
            TyhjaaVastaus();
        }
        private void TyhjaaVastaus()
        {
            if(ARB.Checked == true)
            {
                ARB.Checked = false;
                laskuri--;
            }
            if (BRB.Checked == true)
            {
                BRB.Checked = false;
                laskuri--;
            }
            if (CRB.Checked == true)
            {
                CRB.Checked = false;
                laskuri--;
            }
            if (DRB.Checked == true)
            {
                DRB.Checked = false;
                laskuri--;
            }
        }
    }
}
