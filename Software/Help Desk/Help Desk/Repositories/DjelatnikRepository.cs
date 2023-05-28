using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Help_Desk.FrmLogin;

namespace Help_Desk.Repositories
{
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
