using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class asiakkaidenHallintaForm : Form
    {
        Class2 asiakas = new Class2();
        public asiakkaidenHallintaForm()
        {
            InitializeComponent();
        }

        private void tyhjennaKentatBT_Click(object sender, EventArgs e)
        {
            etunimiTB.Text = "";
            SukunimiTB.Text = "";
            lahiosoiteTB.Text = "";
            postinumeroTB.Text = "";
            postipaikkaTB.Text = "";
            kayttajatunnusTB.Text = "";
            salasanaTB.Text = "";
        }

        private void muokkaaBT_Click(object sender, EventArgs e)
        {
            String enimi = etunimiTB.Text;
            String snimi = SukunimiTB.Text;
            String osoite = lahiosoiteTB.Text;
            String pnro = postinumeroTB.Text;
            String ppaikka = postipaikkaTB.Text;
            String ktunnus = kayttajatunnusTB.Text;

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || osoite.Trim().Equals("") || pnro.Trim().Equals("") || ppaikka.Trim().Equals("") || ktunnus.Trim().Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, Osoite, Postinumero, Postitoimipaikka", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean muokkaaAsiakas = asiakas.MuokkaaAsiakasta(enimi, snimi, osoite, pnro, ppaikka, ktunnus);
                if (muokkaaAsiakas)
                {
                    MessageBox.Show("Uusi asiakas päivitetty onnistuneesti", "Asiakkaan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta asiakasta ei pystytty päivittämään", "Asiakkaan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                AsiakkaatDG.DataSource = asiakas.HaeAsiakkaat();
            }
        }

        private void AsiakkaatDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            etunimiTB.Text = AsiakkaatDG.CurrentRow.Cells[0].Value.ToString();
            SukunimiTB.Text = AsiakkaatDG.CurrentRow.Cells[1].Value.ToString();
            lahiosoiteTB.Text = AsiakkaatDG.CurrentRow.Cells[2].Value.ToString();
            postinumeroTB.Text = AsiakkaatDG.CurrentRow.Cells[3].Value.ToString();
            postipaikkaTB.Text = AsiakkaatDG.CurrentRow.Cells[4].Value.ToString();
            kayttajatunnusTB.Text = AsiakkaatDG.CurrentRow.Cells[5].Value.ToString();
        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            String ktunnus = kayttajatunnusTB.Text;
            if (asiakas.PoistaAsiakas(ktunnus))
            {
                AsiakkaatDG.DataSource = asiakas.HaeAsiakkaat();
                MessageBox.Show("Asiakas poistettu onnistuneesti", "Asiakkaan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Äsiakasta ei pystytty poistamaan", "Asiakkaan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tyhjennaKentatBT.PerformClick();
        }

        private void asiakkaidenHallintaForm_Load(object sender, EventArgs e)
        {
            AsiakkaatDG.DataSource = asiakas.HaeAsiakkaat();
        }

        private void lisaaUusiAsiakasBT_Click(object sender, EventArgs e)
        {
            String enimi = etunimiTB.Text;
            String snimi = SukunimiTB.Text;
            String osoite = lahiosoiteTB.Text;
            String pnro = postinumeroTB.Text;
            String ppaikka = postipaikkaTB.Text;
            String ktunnus = kayttajatunnusTB.Text;
            String ssana = salasanaTB.Text;

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || osoite.Trim().Equals("") || pnro.Trim().Equals("") || ppaikka.Trim().Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, Osoite, Postinumero, Postitoimipaikka", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = asiakas.LisaaAsiakas(enimi, snimi, osoite, pnro, ppaikka, ktunnus, ssana);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi asiakas lisätty onnistuneesti", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
                else
                {
                    MessageBox.Show("Uutta asiakasta ei pystytty lisäämään", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                AsiakkaatDG.DataSource = asiakas.HaeAsiakkaat();
            }
        }
    }
}
