using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HotelManagementSystem
{
    internal class Class3
    {
        Yhdista yhteys = new Yhdista();

        public bool LisaaVarus(String vrnumero, String asnumero, String hunumero, String sisaan, String ulos)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysele = "INSERT INTO huoneet " +
                "(varausnumero, asiakasnumero, huonenumero, sisaan, ulos) " +
                "VALUES (@vnr, @anr, @hnr, @sis, @ulo); ";
            komento.CommandText = lisayskysele;
            komento.Connection = yhteys.OtaYhteys();
            komento.Parameters.Add("@vnr", MySqlDbType.VarChar).Value = vrnumero;
            komento.Parameters.Add("@anr", MySqlDbType.VarChar).Value = asnumero;
            komento.Parameters.Add("@hnr", MySqlDbType.VarChar).Value = hunumero;
            komento.Parameters.Add("@sis", MySqlDbType.Date).Value = sisaan;
            komento.Parameters.Add("@ulo", MySqlDbType.Date).Value = ulos;
           

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

        public DataTable HaeVaraukset()
        {
            MySqlCommand komento = new MySqlCommand("SELECT varausnumero, asiakasnumero, huonenumero, sisaan, ulos FROM huoneet", yhteys.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }
        public DataTable HaeHuoneTyyppi()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM huonekategoria", yhteys.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

        public bool MuokkaaVarausta(String asnumero, String hunumero, String sisaan, String ulos, int vara)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivitakysely = "UPDATE ´huoneet´ SET ´huonenumero´= @hnr" +
                "´sisaan´= @sis, ´ulos´= @ulo, ´asiakasnumero´= @anr0" +
                " WHERE varausnumero = @vnr";
            komento.CommandText = paivitakysely;
            komento.Connection = yhteys.OtaYhteys();
            komento.Parameters.Add("@ulo", MySqlDbType.VarChar).Value = vara;
            komento.Parameters.Add("@anr", MySqlDbType.VarChar).Value = asnumero;
            komento.Parameters.Add("@hnr", MySqlDbType.VarChar).Value = hunumero;
            komento.Parameters.Add("@sis", MySqlDbType.Date).Value = sisaan;
            komento.Parameters.Add("@ulo", MySqlDbType.Date).Value = ulos;

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

        public bool PoistaVaraus(String vrnumero)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistakysely = "SELECT FROM huoneet WHERE varausnumero = @vnr";
            komento.CommandText = poistakysely;
            komento.Connection = yhteys.OtaYhteys();
            komento.Parameters.Add("@vnr", MySqlDbType.VarChar).Value = vrnumero;

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
