namespace Tehtava01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VaihdaBT_Click(object sender, EventArgs e)
        {
            if (TekstiLB.Text == "Heippa maailma!")
            {
                TekstiLB.Text = "Jotain tekstiä";
            }
            else
            {
                TekstiLB.Text = "Heippa maailma!";
            }
        }
    }
}
