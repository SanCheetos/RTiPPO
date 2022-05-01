using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTiPPO.OpenDB
{
    internal static class DB
    {
        
        public static string GetQuery()
        {
            string login = "postgres";
            string password = "";
            string port = "";
            return "server=localhost;port=" + port + ";database=CaptActIn;user id =" + login + "; password=" + password;
        }
    }
}
