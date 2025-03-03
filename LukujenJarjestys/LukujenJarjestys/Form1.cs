namespace LukujenJarjestys
{
    public partial class LukujenJarjestys : Form
    {
        List<int> jono = new List<int>();
        public LukujenJarjestys()
        {
            InitializeComponent();
        }

        private void UusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if(UusiLukuTB.Text == "-999")
                {
                    VastausLB.Text = "";
                    int[] taulukko = jono.ToArray();
                    Array.Sort(taulukko);
                    foreach (var jasen in taulukko)
                    {
                        VastausLB.Text += jasen + " ";
                    }
                    VastausLB.Visible = true;
                }
                else
                {
                    jono.Add(Int32.Parse(UusiLukuTB.Text));
                    UusiLukuTB.Text = "";
                }
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                TyhjaaLomake();
            }
        }
        private void TyhjaaLomake()
        {
            UusiLukuTB.Text = "";
        }
        
    }
}
