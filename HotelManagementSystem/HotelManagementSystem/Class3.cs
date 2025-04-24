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

        public bool LisaaVarus(int asnumero, int hunumero, DateTime sisaan, DateTime ulos)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysele = "INSERT INTO huoneet " +
                "(asiakasnumero, huonenumero, sisaan, ulos) " +
                "VALUES (@anr, @hnr, @sis, @ulo); ";
            komento.CommandText = lisayskysele;
            komento.Connection = yhteys.OtaYhteys();
     
            komento.Parameters.Add("@anr", MySqlDbType.Int32).Value = asnumero;
            komento.Parameters.Add("@hnr", MySqlDbType.Int32).Value = hunumero;
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

        public bool MuokkaaVarausta(int asnumero, int hunumero, DateTime sisaan, DateTime ulos, int vrnumero)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivitakysely = "UPDATE huoneet SET huonenumero = @hnr," +
                " sisaan = @sis, ulos = @ulo, asiakasnumero = @anr" +
                " WHERE varausnumero = @vnr";
            komento.CommandText = paivitakysely;
            komento.Connection = yhteys.OtaYhteys();
            komento.Parameters.Add("@vnr", MySqlDbType.Int32).Value = vrnumero;
            komento.Parameters.Add("@anr", MySqlDbType.Int32).Value = asnumero;
            komento.Parameters.Add("@hnr", MySqlDbType.Int32).Value = hunumero;
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

        public bool PoistaVaraus(int vrnumero)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistakysely = "DELETE FROM huoneet WHERE varausnumero = @vnr";
            komento.CommandText = poistakysely;
            komento.Connection = yhteys.OtaYhteys();
            komento.Parameters.Add("@vnr", MySqlDbType.Int32).Value = vrnumero;

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
