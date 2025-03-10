namespace Tehtava14
{
    using System.IO;
    public partial class Diaryform : Form
    {
        public Diaryform()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("C:/demo.txt");
            TekstiTB.Text = teksti;
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += TekstiTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:/demo.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }
    }
}
