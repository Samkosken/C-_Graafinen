namespace Tehtava02
{
    public partial class Harjoitus02 : Form
    {
        public Harjoitus02()
        {
            InitializeComponent();
        }

        private void OtsikkoLB_Click(object sender, EventArgs e)
        {

        }

        private void TulostaTB_Click(object sender, EventArgs e)
        {
            string teksti = ViestiTB.Text;
            TulostusLB.Text = teksti;
            TulostusLB.Visible = true;
        }
    }
}
