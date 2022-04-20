using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RTiPPO.SubjectArea;

namespace RTiPPO.Controllers
{
    internal class LogController
    {
        public static void Track(User user, AccountCard accountCard, SubjectArea.Action action)
        {
            // Запрос в БД на логирование 
        }

        public static void Track(User user, int accountCardID, SubjectArea.Action action)
        {
            // Запрос в БД на логирование 
        }
    }
}