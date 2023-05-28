using DBLayer;
using Help_Desk.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help_Desk.Repositories
{
    internal class ZahtjevRepository
    {
        public static List<Zahtjev> GetZahtjeviFromDjelatnik(int djelatnikID)
        {
            List<Zahtjev> zahtjevi = new List<Zahtjev>();

            string sql = $"SELECT * FROM Zahtjevi WHERE DjelatnikID = {djelatnikID}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Zahtjev zahtjev = CreateObject(reader);
                zahtjevi.Add(zahtjev);
            }

            reader.Close();
            DB.CloseConnection();

            return zahtjevi;
        }
        public static List<Zahtjev> GetZahtjevi()
        {
            List<Zahtjev> zahtjevi = new List<Zahtjev>();

            string sql = "SELECT * FROM Zahtjevi";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Zahtjev zahtjev = CreateObject(reader);
                zahtjevi.Add(zahtjev);
            }

            reader.Close();
            DB.CloseConnection();

            return zahtjevi;
        }
        private static Zahtjev CreateObject(SqlDataReader reader)
        {
            int id_Zahtjev = int.Parse(reader["ID_Zahtjev"].ToString());
            int djelatnikID = int.Parse(reader["DjelatnikID"].ToString());
            int status = int.Parse(reader["Status"].ToString());
            var komentar = reader["Komentar"].ToString();
            DateTime vrijemePrijave = DateTime.Parse(reader["VrijemePrijave"].ToString());
            int prioritet = int.Parse(reader["Prioritet"].ToString());
            var opis = reader["Opis"].ToString();
            var lokacija = reader["Lokacija"].ToString();


            var zahtjev = new Zahtjev
            {
                ID_Zahtjev = id_Zahtjev,
                DjelatnikID = djelatnikID,
                Status = status,
                Komentar = komentar,
                VrijemePrijave = vrijemePrijave,
                Prioritet = prioritet,
                Opis = opis,
                Lokacija = lokacija
            };

            return zahtjev;
        }
        public static void InsertZahtjev(Zahtjev zahtjev)
        {
            string getMaxIdSql = "SELECT MAX(ID_Zahtjev) FROM Zahtjevi";
            DB.OpenConnection();
            var reader = DB.GetDataReader(getMaxIdSql);

            int maxId = 0;
            if (reader.Read() && !reader.IsDBNull(0))
            {
                maxId = reader.GetInt32(0);
            }
            reader.Close();

            int nextId = maxId + 1;

            string sql = $"INSERT INTO Zahtjevi (ID_Zahtjev, DjelatnikID, Status, Komentar, VrijemePrijave, Prioritet, Opis, Lokacija) " +
                 $"VALUES ({nextId}, {zahtjev.DjelatnikID}, {zahtjev.Status}, '{zahtjev.Komentar}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                 $"{zahtjev.Prioritet}, '{zahtjev.Opis}', '{zahtjev.Lokacija}')";

            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void DeleteZahtjev(int id_Zahtjev)
        {
            string sql = $"DELETE FROM Zahtjevi WHERE ID_Zahtjev = {id_Zahtjev}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        public static void PreuzmiZahtjev(int id_Zahtjev)
        {
            string sql = $"UPDATE Zahtjevi SET Status = 1 WHERE ID_Zahtjev = {id_Zahtjev}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        public static void DodajKomentar(int id_Zahtjev, string komentarText)
        {
            string sql = $"UPDATE Zahtjevi SET Komentar = '{komentarText}' WHERE ID_Zahtjev = {id_Zahtjev}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
