using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Google.Protobuf.WellKnownTypes;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    internal class Class2
    {
        Yhdista yhteys = new Yhdista();

        public bool LisaaAsiakas(String enimi, String snimi, String osoite, String pnro, String ppaikka, String kayttaja, String ssana)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysele = "INSERT INTO asiakkaat " +
                "(kayttajanimi, etunimi, sukunimi, lahiosoite, postinumero, postitoimipaikka, salasana) " +
                "VALUES (@ktu, @enm, @snm, @oso, @pno, @ptp, @ssa); ";
            komento.CommandText = lisayskysele;
            komento.Connection = yhteys.OtaYhteys();
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite;
            komento.Parameters.Add("@pno", MySqlDbType.VarChar).Value = pnro;
            komento.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = ppaikka;

            if (kayttaja != "")
            {
                komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = kayttaja.ToLower();
            }
            else
            {
                komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = enimi.Substring(0, 3).ToLower() + snimi.Substring(0, 5).ToLower();
            }
            if (ssana != "")
            {
                komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = ssana;
            }
            else
            {
                komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = "12345";
            }
            

            yhteys.AvaaYhteys();
            if(komento.ExecuteNonQuery() == 1)
            {
                yhteys.SuljeYhteys();
                return true;
            }
            else
            {
                yhteys.SuljeYhteys();
                return false;
            }

        }

        public DataTable HaeAsiakkaat()
        {
            MySqlCommand komento = new MySqlCommand("SELECT asiakasid, etunimi, sukunimi, lahiosoite, postinumero, postitoimipaikka, kayttajanimi FROM asiakkaat", yhteys.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

        public bool MuokkaaAsiakasta(String enimi, String snimi, String osoite, String pnro, String ppaikka, String ktunnus)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivitakysely = "UPDATE asiakkaat SET etunimi = @enm," +
                "sukunimi = @snm, lahiosoite = @oso, postinumero = @pno, postitoimipaikka = @ptp" +
                " WHERE kayttajanimi = @ktu";
            komento.CommandText = paivitakysely;
            komento.Connection = yhteys.OtaYhteys();
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite;
            komento.Parameters.Add("@pno", MySqlDbType.VarChar).Value = pnro;
            komento.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = ppaikka;
            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = ktunnus;

           
            yhteys.AvaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.SuljeYhteys();
                return true;
            }
            else
            {
                yhteys.SuljeYhteys();
                return false;
            }
        }

        public bool PoistaAsiakas(String ktunnus)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistakysely = "DELETE FROM asiakkaat WHERE kayttajanimi = @ktu";
            komento.CommandText = poistakysely;
            komento.Connection = yhteys.OtaYhteys();
            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = ktunnus;

            yhteys.AvaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.SuljeYhteys();
                return true;
            }
            else
            {
                yhteys.SuljeYhteys();
                return false;
            }

        }



    }
}
