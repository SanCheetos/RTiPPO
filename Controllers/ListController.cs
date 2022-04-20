using RTiPPO.SubjectArea;
using System;
using System.Collections.Generic;
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
            return new AccountCard();
        }

        public static Register GetActs(User user, string filter = "")
        {
            return new Register();
        }

        public static Register Filter(User user, Dictionary<string, string> filter)
        {
            string filterQuery = "filterQuery";
            return GetActs(user, filterQuery);
        }

        public static void SaveExcel(string path, string name, string[,] data)
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
    }
}