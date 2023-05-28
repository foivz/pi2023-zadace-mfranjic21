using DBLayer;
using Help_Desk.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Help_Desk.FrmLogin;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Help_Desk.Repositories
{
    public class DjelatnikRepository
    {
        public static Djelatnik GetDjelatnik(string Email)
        {
            string sql = $"SELECT * FROM Djelatnik WHERE Email = '{Email}'";
            return FetchDjelatnik(sql);
        }


        public static Djelatnik GetDjelatnik(int id)
        {
            string sql = $"SELECT * FROM Djelatnik WHERE ID_djelatnik = {id}";
            return FetchDjelatnik(sql);
        }

        private static Djelatnik FetchDjelatnik(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Djelatnik djelatnik = null;

            if (reader.HasRows == true)
            {
                reader.Read();
                djelatnik = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();

            return djelatnik;
        }

        private static Djelatnik CreateObject(SqlDataReader reader)
        {
            int id_djelatnik = int.Parse(reader["ID_djelatnik"].ToString());
            string imeprezime = reader["ImePrezime"].ToString();
            string email = reader["Email"].ToString();
            string zaporka = reader["Zaporka"].ToString();

            var djelatnik = new Djelatnik
            {
                ID_djelatnik = id_djelatnik,
                ImePrezime = imeprezime,
                Email = email,
                Zaporka = zaporka
            };
            return djelatnik;
        }
    }
}
