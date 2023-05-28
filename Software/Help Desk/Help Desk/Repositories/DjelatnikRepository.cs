using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Help_Desk.FrmLogin;

namespace Help_Desk.Repositories
{
    private static Djelatnik CreateObject(SqlDataReader reader)
    {
        int id = int.Parse(reader["Id"].ToString());
        string imeprezime = reader["ImePrezime"].ToString();
        string email = reader["E-mail"].ToString();
        string zaporka = reader["Zaporka"].ToString();
        var djelatnik = new Djelatnik
        {
            Id = id,
            ImePrezime = imeprezime,
            Email = email,
            Zaporka = zaporka
        };
        return djelatnik;
    }

    public static List<Djelatnik> GetDjelatnik()
    {
        List<Djelatnik> djelatnik = new List<Djelatnik>();
        string sql = "SELECT * FROM Djelatnik";
        DB.OpenConnection();
        var reader = DB.GetDataReader(sql);
        while (reader.Read())
        {
            Djelatnik djelatnik = CreateObject(reader);
            djelatnik.Add(djelatnik);
        }
        reader.Close();
        DB.CloseConnection();
        return djelatnik;
    }

    public static Djelatnik GetDjelatnik(int id)
    {
        Djelatnik djelatnik = null;
        string sql = $"SELECT * FROM Djelatnik WHERE Id = {id}";
        DB.OpenConnection();
        var reader = DB.GetDataReader(sql);
        if (reader.HasRows)
        {
            reader.Read();
            djelatnik = CreateObject(reader);
            reader.Close();
        }
        DB.CloseConnection();
        return djelatnik;
    }
}
