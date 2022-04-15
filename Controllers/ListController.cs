using RTiPPO.SubjectArea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTiPPO.Controllers
{
    internal static class ListController
    {
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
            //Магия
        }
    }
}
