using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelManagementSystem
{
    public partial class kirjautumisForm : Form
    {
        public kirjautumisForm()
        {
            InitializeComponent();
        }

        private void kirjauduBT_Click(object sender, EventArgs e)
        {
            Yhdista tietokantaan = new Yhdista();
            DataTable taulu = new DataTable();
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            MySqlCommand komento = new MySqlCommand();

            String kysely = "SELECT kayttajanimi, salasana FROM asiakkaat WHERE kayttajanimi = @kn AND salasana = @ss";

            komento.CommandText = kysely;
            komento.Connection = tietokantaan.OtaYhteys();

            komento.Parameters.Add("@kn", MySqlDbType.VarChar).Value = kayttajaTB.Text;
            komento.Parameters.Add("@ss", MySqlDbType.VarChar).Value = salasanaTB.Text;

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            if(taulu.Rows.Count > 0)
            {
                this.Hide();
                paaikkunaForm plomake = new paaikkunaForm();
                plomake.Show();

            }
            else
            {
                if (kayttajaTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Syötä käyttäjänimesi", "Käyttäjänimi on tyhjä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (salasanaTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Syötä salasana", "Salasana on tyhjä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Käyttäjänimi tai salasana on väärin", "Tietoja ei löydy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
