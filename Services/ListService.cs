using System;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using RTiPPO.SubjectArea;
using RTiPPO.OpenDB;

namespace RTiPPO.Services
{
    internal class ListService
    {
        public static DataTable GetActs(string tableQuery)
        {
            return SQL(tableQuery);
        }

        public static DataTable GetMunicipality(string tableQuery = "SELECT * FROM \"Municipality\"")
        {
            return SQL(tableQuery);
        }

        public static DataTable GetOMSU(string tableQuery = "SELECT * FROM \"OMSU\"")
        {
            return SQL(tableQuery);
        }

        public static DataTable GetContractor(string tableQuery = "SELECT * FROM \"CaptOrg\"")
        {
            return SQL(tableQuery);
        }

        public static DataTable GetLocality(string tableQuery = "SELECT * FROM \"Locality\"")
        {
            return SQL(tableQuery);
        }

        private static DataTable SQL(string tableQuery)
        {
            string query = DB.GetQuery();
            NpgsqlConnection zapros = new NpgsqlConnection(query);
            NpgsqlCommand cmd = zapros.CreateCommand();
            DataTable dt = new DataTable();
            zapros.Open();
            cmd.CommandText = tableQuery;
            cmd.ExecuteNonQuery();
            zapros.Close();
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            return dt;
        }
    }
}
