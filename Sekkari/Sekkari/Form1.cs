using System.Diagnostics;
namespace Sekkari
{
    public partial class sekkariFM : Form
    {
        private Stopwatch sekkari = new Stopwatch();
        public sekkariFM()
        {
            InitializeComponent();
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            sekkari.Start();
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            sekkari.Stop();
        }

        private void ResetBT_Click(object sender, EventArgs e)
        {
            sekkari.Reset();
        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            KelloLB.Text = String.Format("{0:hh\\:mm\\:ss\\:fff}", sekkari.Elapsed);  
        }
    }
}
