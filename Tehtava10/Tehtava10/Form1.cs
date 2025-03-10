namespace Tehtava10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0;
            paino = Convert.ToDouble(PainoTB.Text);
            pituus = Convert.ToDouble(PituusTB.Text);
            double bmi = Math.Round(paino / (pituus * pituus));

            if (bmi < 18.5)
            {
                VastausLB.Text = "Painoindeksi on " + bmi;
                VastausLB.ForeColor = Color.Aqua;
                VastausLB.Visible = true;
                KuvausLB.Text = "Alipaino";
                KuvausLB.ForeColor = Color.Aqua;
                KuvausLB.Visible = true;
            }
            else if(bmi < 25)
            {
                VastausLB.Text = "Painoindeksi on " + bmi;
                VastausLB.ForeColor = Color.Green;
                VastausLB.Visible = true;
                KuvausLB.Text = "Normaalipaino";
                KuvausLB.ForeColor = Color.Green;
                KuvausLB.Visible = true;
            }
            else if (bmi < 40)
            {
                VastausLB.Text = "Painoindeksi on " + bmi;
                VastausLB.ForeColor = Color.Gold;
                VastausLB.Visible = true;
                KuvausLB.Text = "Ylipaino";
                KuvausLB.ForeColor = Color.Gold;
                KuvausLB.Visible = true;
            }
            else
            {
                VastausLB.Text = "Painoindeksi on " + bmi;
                VastausLB.ForeColor = Color.Red;
                VastausLB.Visible = true;
                KuvausLB.Text = "Huomattava ylipaino";
                KuvausLB.ForeColor = Color.Red;
                KuvausLB.Visible = true;
            }
        }
    }
}
