using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTiPPO.SubjectArea
{
    internal static class User
    {
        public static int ID { get; set; }
        public static string Login { get; set; }
        public static string Password { get; set; }
        public static Role Role { get; set; }
        public static OMSU OMSU { get; set; }
        public static Contractor CaptOrg { get; set; }
    }
}
