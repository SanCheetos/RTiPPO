using RTiPPO.Services;
using RTiPPO.SubjectArea;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTiPPO.Controllers
{
    internal class ListController
    {
        //------------ Третьяк Александр -------------------

        public static AccountCard GetEntity(int id)
        {
            return null;
        }

        public static Register GetActs(User user, string filter = "")
        {
            DataTable dt = ListService.GetActs();
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
                    -1,
                    row["NumberMK"].ToString(),
                    date1,
                    municipality,
                    new OMSU(row["OMSU.Name"].ToString(), -1, municipality),
                    new Contractor(row["CaptOrg.Name"].ToString()),
                    row["NumberAct"].ToString(),
                    int.Parse(row["CaptCats"].ToString()),
                    int.Parse(row["CaptDogs"].ToString()),
                    int.Parse(row["CaptAnimals"].ToString()),
                    new Locality(row["Locality.Name"].ToString()),
                    null,
                    date2,
                    row["CaptPurpose"].ToString())); ;
            }
            return new Register(accCard);
        }

        public static Register Filter(User user, Dictionary<string, string> filter)
        {
            string filterQuery = "filterQuery";
            return GetActs(user, filterQuery);
        }

        public static void SaveExcel(File file, string[,] data)
        {
            // Магия эскпорта акта в Excel
        }

        //------------ Самусенко Владислав ------------------

        public static void AddAct(AccountCard accountCard)
        {
            // Запрос в БД на добавление записи
            User user = new User();     
            SubjectArea.Action action = new SubjectArea.Action() { name = "Добавление" };
            LogController.Track(user, accountCard, action);
        }

        public static void DeleteAct(int accountCardID)
        {
            // Запрос в БД на добавление записи
            User user = new User();
            SubjectArea.Action action = new SubjectArea.Action() { name = "Удаление" };
            LogController.Track(user, accountCardID, action);
        }

        //------------ Реализация ------------------
        public static List<Municipality> GetMunicipality(string desc = "")
        {
            DataTable dt = ListService.GetMunicipality();
            List<Municipality> municipalities = new List<Municipality>();
            foreach (DataRow row in dt.Rows)
                municipalities.Add(new Municipality(row["Name"].ToString(), int.Parse(row["ID_Municipality"].ToString())));
            return municipalities;
        }

        public static List<OMSU> GetOMSU(string desc = "")
        {
            DataTable dt = ListService.GetOMSU();
            List<OMSU> omsus = new List<OMSU>();
            foreach (DataRow row in dt.Rows)
                omsus.Add(new OMSU(row["Name"].ToString(), int.Parse(row["ID_OMSU"].ToString())));
            return omsus;
        }

        public static List<Contractor> GetContractor(string desc = "")
        {
            DataTable dt = ListService.GetContractor();
            List<Contractor> contractors = new List<Contractor>();
            foreach (DataRow row in dt.Rows)
                contractors.Add(new Contractor(row["Name"].ToString(), int.Parse(row["ID_CaptOrg"].ToString())));
            return contractors;
        }

        public static List<Locality> GetLocality(string desc = "")
        {
            DataTable dt = ListService.GetLocality();
            List<Locality> localities = new List<Locality>();
            foreach (DataRow row in dt.Rows)
                localities.Add(new Locality(row["Name"].ToString(), int.Parse(row["ID_Locality"].ToString())));
            return localities;
        }
    }
}