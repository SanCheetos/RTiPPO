using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using RTiPPO.SubjectArea;
using RTiPPO.Services;

namespace RTiPPO.Controllers
{
    internal class LogController
    {
        // Журналирование 

        public static void Track(SubjectArea.Action action)
        {
            string query = "INSERT INTO \"Log\" (\"ActionDate\", \"User_ID\", \"Action_ID\") " +
            "VALUES (current_timestamp(0), " + User.ID + ", " + action.ID + ");";
            DBService.CRUDRequest(query);
        }
    }
}