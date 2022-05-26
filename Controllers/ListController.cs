using RTiPPO.Services;
using RTiPPO.SubjectArea;
using System;
using System.Collections.Generic;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTiPPO.Controllers
{
    internal class ListController
    {
        //------------ Третьяк Александр -------------------

        //public static AccountCard GetEntity(User user, string numMK)
        public static AccountCard GetEntity(int idMK)
        {
            //Register register = GetActs(user, "WHERE \"CaptAct\".\"NumberMK\" = '" + numMK + "'");
            Register register = GetActs("WHERE \"CaptAct\".\"ID_CaptAct\" = '" + idMK + "'");
            return register.AccountCards[0];
        }

        //public static Register GetActs(User user, string filter = "")
        public static Register GetActs(string filter = "", int limit = 1, int offset = 0)
        {
            string query = "SELECT \"ID_CaptAct\", \"NumberMK\", \"DateMK\", \"NumberAct\", \"CaptCats\", \"CaptDogs\", " +
            "\"CaptAnimals\", \"CaptDate\", \"CaptPurpose\", \"OMSU\".\"Municipality_ID\", " +
            "\"OMSU\".\"Name\" AS \"OMSU.Name\", \"Municipality\".\"Name\" AS \"Municipality.Name\", \"CaptOrg\".\"Name\" AS \"CaptOrg.Name\", \"Locality\".\"Name\" AS \"Locality.Name\" " +

            "FROM \"CaptAct\" " +
            "JOIN \"OMSU\" ON \"CaptAct\".\"OMSU_ID\"=\"OMSU\".\"ID_OMSU\" " +

            "JOIN \"Municipality\" ON \"OMSU\".\"Municipality_ID\"=\"Municipality\".\"ID_Municipality\" " +

            "JOIN \"CaptOrg\" ON \"CaptAct\".\"CaptOrg_ID\"=\"CaptOrg\".\"ID_CaptOrg\" " +

            "JOIN \"Locality\" ON \"CaptAct\".\"Locality_ID\"=\"Locality\".\"ID_Locality\" ";

            //Подстановка Where
            string access = "";
            if (filter.IndexOf("WHERE") != -1)
                access = "AND";
            else
                access = "WHERE";
            if (User.Role.Access.Trim() == "муниципальное образование")
                access += "\"OMSU\".\"Municipality_ID\"=" + User.OMSU.Municipality.ID + " ";
            else if (User.Role.Access.Trim() == "организация по отлову")
                access += "\"CaptAct\".\"CaptOrg_ID\"=" + User.CaptOrg.ID + " ";
            else access = "";
            query += access + filter + /*пагинация*/ " LIMIT " + limit + " OFFSET " + offset;




            DataTable dt = DBService.GetActs(query);
            List<AccountCard> accCard = new List<AccountCard>();
            foreach (DataRow row in dt.Rows)
            {
                string[] dateTime1 = row["DateMK"].ToString().Split(' ');
                string[] dateString1 = dateTime1[0].ToString().Split('.');
                DateTime date1 = new DateTime(int.Parse(dateString1[2]), int.Parse(dateString1[1]), int.Parse(dateString1[0]));
                string[] dateTime2 = row["CaptDate"].ToString().Split(' ');
                string[] dateString2 = dateTime2[0].ToString().Split('.');
                DateTime date2 = new DateTime(int.Parse(dateString2[2]), int.Parse(dateString2[1]), int.Parse(dateString2[0]));
                Municipality municipality = new Municipality(row["Municipality.Name"].ToString());
                accCard.Add(new AccountCard(
                    int.Parse(row["ID_CaptAct"].ToString()),
                    row["NumberMK"].ToString(),
                    date1,
                    municipality,
                    new OMSU(row["OMSU.Name"].ToString(), -1, municipality),
                    new Contractor(row["CaptOrg.Name"].ToString()),
                    row["NumberAct"].ToString(),
                    int.Parse(row["CaptDogs"].ToString()),
                    int.Parse(row["CaptCats"].ToString()),
                    int.Parse(row["CaptAnimals"].ToString()),
                    new Locality(row["Locality.Name"].ToString()),
                    null,
                    date2,
                    row["CaptPurpose"].ToString())); ;
            }
            return new Register(accCard);
        }

        //public static Register Filter(User user, Dictionary<string, string> filterData)
        public static Register FilterSort(Dictionary<string, string> filterData, List<Sort> sortData, int limit = 2, int offset = 0)
        {

            string filterQuery = "";
            //фильтр
            if (filterData != null && filterData.Count > 0)
            {
                filterQuery += "WHERE";
                if (filterData.ContainsKey("NumberMK"))
                    filterQuery += " \"NumberMK\" = '" + filterData["NumberMK"] + "'";
                else if (filterData.ContainsKey("NumberAct"))
                    filterQuery += " \"NumberAct\" = '" + filterData["NumberAct"] + "'";
                else
                {
                    if (filterData.ContainsKey("DateMK"))
                        filterQuery += " \"DateMK\" BETWEEN " + filterData["DateMK"] + " AND";
                    if (filterData.ContainsKey("DateCapt"))
                        filterQuery += " \"CaptDate\" BETWEEN " + filterData["DateCapt"] + " AND";

                    if (filterData.ContainsKey("CaptDogs"))
                        filterQuery += CaptCountQuery("CaptDogs", filterData["CaptDogs"]);
                    if (filterData.ContainsKey("CaptCats"))
                        filterQuery += CaptCountQuery("CaptCats", filterData["CaptCats"]);
                    if (filterData.ContainsKey("CaptSum"))
                        filterQuery += CaptCountQuery("CaptAnimals", filterData["CaptSum"]);

                    if (filterData.ContainsKey("Municipality") && User.Role.Access != "муниципальное образование")
                        filterQuery += EntitiesQuery("\"OMSU\".\"Municipality_ID\"", filterData["Municipality"]);
                    if (filterData.ContainsKey("OMSU"))
                        filterQuery += EntitiesQuery("\"CaptAct\".\"OMSU_ID\"", filterData["OMSU"]);
                    if (filterData.ContainsKey("Contractor") && User.Role.Access != "организация по отлову")
                        filterQuery += EntitiesQuery("\"CaptAct\".\"CaptOrg_ID\"", filterData["Contractor"]);
                    if (filterData.ContainsKey("Locality"))
                        filterQuery += EntitiesQuery("\"CaptAct\".\"Locality_ID\"", filterData["Locality"]);
                    filterQuery = filterQuery.Substring(0, filterQuery.Length - 3);
                }
            }
           
            //Сортировка
            if (sortData != null && sortData.Count != 0)
            {
                filterQuery += " ORDER BY";
                foreach (var sort in sortData)
                {
                    switch (sort.Column)
                    {
                        case "NumMK":
                            filterQuery += " \"NumberMK\" " + sort.SortType + ",";
                            break;
                        case "DateMK":
                            filterQuery += " \"DateMK\" " + sort.SortType + ",";
                            break;
                        case "Municipality":
                            filterQuery += " \"Municipality\".\"Name\" " + sort.SortType + ",";
                            break;
                        case "OMSU":
                            filterQuery += " \"OMSU\".\"Name\" " + sort.SortType + ",";
                            break;
                        case "Executor":
                            filterQuery += " \"CaptOrg\".\"Name\" " + sort.SortType + ",";
                            break;
                        case "ActNum":
                            filterQuery += " \"NumberAct\" " + sort.SortType + ",";
                            break;
                        case "CaptDogs":
                            filterQuery += " \"CaptDogs\" " + sort.SortType + ",";
                            break;
                        case "CaptCats":
                            filterQuery += " \"CaptCats\" " + sort.SortType + ",";
                            break;
                        case "CaptSum":
                            filterQuery += " \"CaptAnimals\" " + sort.SortType + ",";
                            break;
                        case "Locality":
                            filterQuery += " \"Locality\".\"Name\" " + sort.SortType + ",";
                            break;
                        case "CaptDate":
                            filterQuery += " \"CaptDate\" " + sort.SortType + ",";
                            break;
                        case "Purpose":
                            filterQuery += " \"CaptPurpose\" " + sort.SortType + ",";
                            break;
                    }
                }
                filterQuery = filterQuery.Substring(0, filterQuery.Length - 1);
            }
            //return GetActs(user, filterQuery);
            return GetActs(filterQuery, limit, offset);
        }

        private static string CaptCountQuery(string key, string value)
        {
            string[] counts = value.Split(" AND ");
            if (counts[1] == "0")
                return " \"" + key + "\" >= " + counts[0] + " AND";
            return " \"" + key + "\" BETWEEN " + value + " AND";
        }

        private static string EntitiesQuery(string key, string value)
        {
            return " " + key + " IN (" + value + ") AND";
        }

        // Добавление записи 

        public static void AddAct(AccountCard accountCard)
        {
            string query = "INSERT INTO \"CaptAct\" (\"NumberMK\", \"DateMK\", \"NumberAct\", \"CaptCats\", \"CaptDogs\", " +
            "\"CaptAnimals\", \"CaptDate\", \"CaptPurpose\", \"OMSU_ID\", \"CaptOrg_ID\", \"Locality_ID\", \"File_ID\")" +
            "VALUES" +
            "('" + accountCard.NumberMK + "', DATE('" + accountCard.DateOfConclusionMK.ToString("yyyy-MM-dd") + "'), '" + accountCard.NumberActCatching + "', " + accountCard.CaugthCats +
            ", " + accountCard.CaugthDogs + ", " + accountCard.CaugthAnimals + ", DATE('" + accountCard.DateCatch.ToString("yyyy-MM-dd") + "'), '" + accountCard.PurposeOfCatch +
            "', " + accountCard.OMSU.ID + ", " + accountCard.ContractorMK.ID + ", " + accountCard.Locality.ID + ", null);";
            DBService.CRUDRequest(query);
            LogController.Track(accountCard, new SubjectArea.Action("добавление", 1));
        }

        // Удаление записи 

        public static void DeleteAct(AccountCard accountCard)
        {
            string query = $"DELETE FROM \"CaptAct\" WHERE \"CaptAct\".\"ID_CaptAct\" = '{accountCard.ID}';";
            DBService.CRUDRequest(query);
            LogController.Track(accountCard, new SubjectArea.Action("удаление", 3));
        }

        //------------ Реализация ------------------
        public static List<Municipality> GetMunicipality(string desc = "")
        {
            DataTable dt = DBService.GetMunicipality();
            List<Municipality> municipalities = new List<Municipality>();
            foreach (DataRow row in dt.Rows)
                municipalities.Add(new Municipality(row["Name"].ToString(), int.Parse(row["ID_Municipality"].ToString())));
            return municipalities;
        }

        public static List<OMSU> GetOMSU(string desc = "")
        {
            DataTable dt = DBService.GetOMSU();
            List<OMSU> omsus = new List<OMSU>();
            foreach (DataRow row in dt.Rows)
                omsus.Add(new OMSU(row["Name"].ToString(), int.Parse(row["ID_OMSU"].ToString())));
            return omsus;
        }

        public static List<Contractor> GetContractor(string desc = "")
        {
            DataTable dt = DBService.GetContractor();
            List<Contractor> contractors = new List<Contractor>();
            foreach (DataRow row in dt.Rows)
                contractors.Add(new Contractor(row["Name"].ToString(), int.Parse(row["ID_CaptOrg"].ToString())));
            return contractors;
        }

        public static List<Locality> GetLocality(string desc = "")
        {
            DataTable dt = DBService.GetLocality();
            List<Locality> localities = new List<Locality>();
            foreach (DataRow row in dt.Rows)
                localities.Add(new Locality(row["Name"].ToString(), int.Parse(row["ID_Locality"].ToString())));
            return localities;
        }
    }
}