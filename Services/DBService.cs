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
    internal class DBService
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

        public static DataTable GetUsers(string tableQuery = "SELECT * FROM \"User\"")
        {
            return SQL(tableQuery);
        }

        public static void CRUDRequest(string tableQuery)
        {
            SQLCRUD(tableQuery);
        }

        private static DataTable SQL(string tableQuery)
        {
            string query = DB.GetQuery();
            NpgsqlConnection connection = new NpgsqlConnection(query);
            NpgsqlCommand cmd = connection.CreateCommand();
            DataTable dt = new DataTable();
            cmd.CommandText = tableQuery;
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            return dt;
        }

        // Запросы к БД, который ничего не возвращает

        private static void SQLCRUD(string tableQuery)
        {
            string query = DB.GetQuery();
            NpgsqlConnection connection = new NpgsqlConnection(query);
            NpgsqlCommand cmd = connection.CreateCommand();
            DataTable dt = new DataTable();
            cmd.CommandText = tableQuery;
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
