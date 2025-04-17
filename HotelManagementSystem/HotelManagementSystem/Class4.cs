using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HotelManagementSystem
{
    internal class Class4
    {
        Yhdista yhteys = new Yhdista();

        public bool LisaaHuone(String hunumero, String hutyyppi, String puhelin, String vapaa)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysele = "INSERT INTO huonenumerot " +
                "(huonenumero, huonetyyppi, puhelin, vapaa) " +
                "VALUES (@hnr, @hty, @puh, @vap); ";
            komento.CommandText = lisayskysele;
            komento.Connection = yhteys.OtaYhteys();
            komento.Parameters.Add("@hnr", MySqlDbType.VarChar).Value = hunumero;
            komento.Parameters.Add("@hty", MySqlDbType.Date).Value = hutyyppi;
            komento.Parameters.Add("@´puh", MySqlDbType.Date).Value = puhelin;
            komento.Parameters.Add("@vap", MySqlDbType.Date).Value = vapaa;


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

        public DataTable HaeHuoneet()
        {
            MySqlCommand komento = new MySqlCommand("SELECT huonenumero, huonetyyppi, puhelin, vapaa FROM huonenumerot", yhteys.OtaYhteys());
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

        public bool MuokkaaHuone(String hunumero, String hutyyppi, String puhelin, String vapaa)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivitakysely = "UPDATE ´huonenumerot´ SET ´huonetyyppi´= @hty" +
                "´puhelin´= @puh, ´vapaa´= @vap" +
                " WHERE huonenumero = @hnr";
            komento.CommandText = paivitakysely;
            komento.Connection = yhteys.OtaYhteys();
            komento.Parameters.Add("@hnr", MySqlDbType.VarChar).Value = hunumero;
            komento.Parameters.Add("@hty", MySqlDbType.VarChar).Value = hutyyppi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puhelin;
            komento.Parameters.Add("@vap", MySqlDbType.Date).Value = vapaa;
            

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

        public bool PoistaHuone(String hunumero)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistakysely = "SELECT FROM huonenumerot WHERE huonenumero = @hnr";
            komento.CommandText = poistakysely;
            komento.Connection = yhteys.OtaYhteys();
            komento.Parameters.Add("@hnr", MySqlDbType.VarChar).Value = hunumero;

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

        public DataTable TyypillisetHuoneet(int htype)
        {
            MySqlCommand komento = new MySqlCommand
            String lisayskysely = "SELECT * FROM huonenumerot WHERE huonetyyppi = @hty";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.OtaYhteys();
            komento.Parameters.Add("@hty", MySqlDbType.VarChar).Value = htype;
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;

        }
    }
    
}
