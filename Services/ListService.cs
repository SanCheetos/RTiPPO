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
        public static DataTable GetActs(string tableQuery =
            "SELECT \"NumberMK\", \"DateMK\", \"NumberAct\", \"CaptCats\", \"CaptDogs\", " +
            "\"CaptAnimals\", \"CaptDate\", \"CaptPurpose\", \"OMSU\".\"Municipality_ID\", " +
            "\"OMSU\".\"Name\" AS \"OMSU.Name\", \"Municipality\".\"Name\" AS \"Municipality.Name\", \"CaptOrg\".\"Name\" AS \"CaptOrg.Name\", \"Locality\".\"Name\" AS \"Locality.Name\" " +

            "FROM \"CaptAct\" "+
            "JOIN \"OMSU\" ON \"CaptAct\".\"OMSU_ID\"=\"OMSU\".\"ID_OMSU\" "+

            "JOIN \"Municipality\" ON \"OMSU\".\"Municipality_ID\"=\"Municipality\".\"ID_Municipality\" " +

            "JOIN \"CaptOrg\" ON \"CaptAct\".\"CaptOrg_ID\"=\"CaptOrg\".\"ID_CaptOrg\" " +

            "JOIN \"Locality\" ON \"CaptAct\".\"Locality_ID\"=\"Locality\".\"ID_Locality\"")
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
