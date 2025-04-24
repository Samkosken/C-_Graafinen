using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;

namespace HotelManagementSystem
{
    public partial class varaustenHallintaForm : Form
    {
        Class2 asiakas = new Class2();
        Class3 varaus = new Class3();
        Class4 huoneet = new Class4();
        public varaustenHallintaForm()
        {
            InitializeComponent();
        }

        private void lisaaUusiVarausBT_Click(object sender, EventArgs e)
        {
            int asnumero = Convert.ToInt32(asiakasnroCB.SelectedValue.ToString());
            int hunumero = Convert.ToInt32(huonenroCB.SelectedValue.ToString());
            DateTime ulos = Convert.ToDateTime(ulosDTP.Value);
            DateTime sisaan = Convert.ToDateTime(sisaanDTP.Value);
           

            if (varaus.LisaaVarus(asnumero, hunumero, ulos, sisaan))
            {
                MessageBox.Show("Varaus lisätty onnistuneesti", "Varauksen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Varausta ei pystytty lisäämään", "Varauksen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            varauksetDG.DataSource = varaus.HaeVaraukset();
        }

        private void tyhjennaBT_Click(object sender, EventArgs e)
        {
            varausnumeroTB.Text = "";
            asiakasnroCB.SelectedIndex = 0;
            huonetyyppiCB.SelectedIndex = 0;
            huonenroCB.SelectedIndex = 0;
            sisaanDTP.Text = "";
            ulosDTP.Text = "";
        }

        private void muokkaaBT_Click(object sender, EventArgs e)
        {
            int asnumero = Convert.ToInt32(asiakasnroCB.SelectedValue.ToString());
            int hunumero = Convert.ToInt32(huonenroCB.SelectedValue.ToString());
            DateTime ulos = Convert.ToDateTime(ulosDTP.Value);
            DateTime sisaan = Convert.ToDateTime(sisaanDTP.Value);
            try
            {
                int vrnumero = Convert.ToInt32(varausnumeroTB.Text);
                if(varaus.MuokkaaVarausta(hunumero, asnumero, sisaan, ulos, vrnumero))
                {
                    MessageBox.Show("Varaus päivitetty onnistuneesti", "Varauksen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Varausta ei pystytty päivittämään", "Varauksen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("VIRHE: " + ex.Message, "Huoneen numero virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            varauksetDG.DataSource = varaus.HaeVaraukset();



        }

        private void varauksetDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            varausnumeroTB.Text = varauksetDG.CurrentRow.Cells[0].Value.ToString();
            asiakasnroCB.SelectedValue = varauksetDG.CurrentRow.Cells[1].Value.ToString();
            huonenroCB.SelectedValue = varauksetDG.CurrentRow.Cells[2].Value.ToString();
            sisaanDTP.Value = Convert.ToDateTime(varauksetDG.CurrentRow.Cells[3].Value);
            ulosDTP.Value = Convert.ToDateTime(varauksetDG.CurrentRow.Cells[4].Value);
            
        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            
            String vrnumero = varausnumeroTB.Text;
            if (vrnumero.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Varausnumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (varaus.PoistaVaraus(vrnumero))
                {
                    varauksetDG.DataSource = varaus.HaeVaraukset();
                    MessageBox.Show("Varaus poistettu onnistuneesti", "Varauksen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Varausta ei pystytty poistamaan", "Varauksen poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                tyhjennaBT.PerformClick();

            }
        }

        private void varaustenHallintaForm_Load(object sender, EventArgs e)
        {
            huonetyyppiCB.DataSource = huoneet.HaeHuoneTyyppi();
            huonetyyppiCB.DisplayMember = "huonetyyppi";
            huonetyyppiCB.ValueMember = "kategoriaid";

            asiakasnroCB.DataSource = asiakas.HaeAsiakkaat();
            asiakasnroCB.DisplayMember = "etunimi";
            asiakasnroCB.ValueMember = "asiakasid";
            varauksetDG.DataSource = varaus.HaeVaraukset();
        }

        private void huonetyyppiCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int hutype = huonetyyppiCB.SelectedIndex + 1;

            huonenroCB.DataSource = huoneet.TyypillisetHuoneet(hutype);
            huonenroCB.DisplayMember = "huoneennumero";
            huonenroCB.ValueMember = "huoneennumero";

        }
    }
}
