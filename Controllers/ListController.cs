﻿using RTiPPO.Services;
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

        public static AccountCard GetEntity(User user, string numMK)
        {
            Register register = GetActs(user, "WHERE \"CaptAct\".\"NumberMK\" = '" + numMK + "'");
            return register.AccountCards[0];
        }

        public static Register GetActs(User user, string filter = "")
        {
            string query = "SELECT \"NumberMK\", \"DateMK\", \"NumberAct\", \"CaptCats\", \"CaptDogs\", " +
            "\"CaptAnimals\", \"CaptDate\", \"CaptPurpose\", \"OMSU\".\"Municipality_ID\", " +
            "\"OMSU\".\"Name\" AS \"OMSU.Name\", \"Municipality\".\"Name\" AS \"Municipality.Name\", \"CaptOrg\".\"Name\" AS \"CaptOrg.Name\", \"Locality\".\"Name\" AS \"Locality.Name\" " +

            "FROM \"CaptAct\" " +
            "JOIN \"OMSU\" ON \"CaptAct\".\"OMSU_ID\"=\"OMSU\".\"ID_OMSU\" " +

            "JOIN \"Municipality\" ON \"OMSU\".\"Municipality_ID\"=\"Municipality\".\"ID_Municipality\" " +

            "JOIN \"CaptOrg\" ON \"CaptAct\".\"CaptOrg_ID\"=\"CaptOrg\".\"ID_CaptOrg\" " +

            "JOIN \"Locality\" ON \"CaptAct\".\"Locality_ID\"=\"Locality\".\"ID_Locality\"" + filter;
            DataTable dt = ListService.GetActs(query);
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

        public static Register Filter(User user, Dictionary<string, string> filterData)
        {
            string filterQuery = "WHERE";
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

                if (filterData.ContainsKey("Municipality"))
                    filterQuery += EntitiesQuery("\"OMSU\".\"Municipality_ID\"", filterData["Municipality"]);
                if (filterData.ContainsKey("OMSU"))
                    filterQuery += EntitiesQuery("\"CaptAct\".\"OMSU_ID\"", filterData["OMSU"]);
                if (filterData.ContainsKey("Contractor"))
                    filterQuery += EntitiesQuery("\"CaptAct\".\"CaptOrg_ID\"", filterData["Contractor"]);
                if (filterData.ContainsKey("Locality"))
                    filterQuery += EntitiesQuery("\"CaptAct\".\"Locality_ID\"", filterData["Locality"]);
                filterQuery = filterQuery.Substring(0, filterQuery.Length - 3);
            }
            return GetActs(user, filterQuery);
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

        public static string SaveExcel(File file, DataTable dt)
        {
            //Объявляем приложение
            Excel.Application ex = new Excel.Application();
            Excel.Workbook workBook = ex.Workbooks.Add(Type.Missing);
            Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);
            sheet.Name = "Реестр актов отлова";
            int j = 1;
            foreach (DataColumn column in dt.Columns)
            {
                sheet.Cells[1, j].Value = column.ColumnName;
                j++;
            }
            int i = 2;
            j = 1;
            foreach (DataRow row in dt.Rows)
            {
                foreach (var value in row.ItemArray)
                {
                    sheet.Cells[i, j].Value = value;
                    j++;
                }
                j = 1;
                i++;
            }
            Excel.Range left = sheet.Cells[1, 1];
            Excel.Range right = sheet.Cells[i - 1, dt.Columns.Count];
            Excel.Range range = sheet.get_Range(left, right);
            range.EntireColumn.AutoFit();
            range.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            left = sheet.Cells[1, 7];
            right = sheet.Cells[i - 1, 9];
            range = sheet.get_Range(left, right);
            range.ColumnWidth = 13;
            range.WrapText = true;
            try
            {
                ex.Application.ActiveWorkbook.SaveAs(file.Path + file.Name);
                ex.Application.ActiveWorkbook.Close();
                return "Сохранение прошло успешно";
            }
            catch (Exception exep)
            {
                return "Ошибка: " + exep.Message;
            }
            
            //ex.Visible = true;
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