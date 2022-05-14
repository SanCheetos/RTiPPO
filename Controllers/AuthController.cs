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
    internal class AuthController
    {
        // Авторизация 

        public static string Login(string login, string password)
        {
            string query = "SELECT \"ID_User\", \"Login\", \"Password\", \"Role\".\"ID_Role\", \"OMSU\".\"ID_OMSU\", " +

            "\"CaptOrg\".\"ID_CaptOrg\", \"Role\".\"Function_ID\", \"OMSU\".\"Municipality_ID\", " +

            "\"Role\".\"ID_Role\" AS \"Role.ID\", \"Role\".\"RoleName\" AS \"Role.Name\", \"OMSU\".\"Name\" AS \"OMSU.Name\", \"CaptOrg\".\"Name\" AS \"CaptOrg.Name\", " +

            "\"Role\".\"Access\" AS \"Role.Access\", \"Function\".\"FunctionName\" AS \"Function.Name\", \"Municipality\".\"Name\" AS \"Municipality.Name\" " +

            "FROM \"User\" " +

            "JOIN \"Role\" ON \"User\".\"Role_ID\"=\"Role\".\"ID_Role\" " +

            "JOIN \"OMSU\" ON \"User\".\"OMSU_ID\"=\"OMSU\".\"ID_OMSU\" " +

            "JOIN \"CaptOrg\" ON \"User\".\"CaptOrg_ID\"=\"CaptOrg\".\"ID_CaptOrg\" " +

            "JOIN \"Function\" ON \"Role\".\"Function_ID\"=\"Function\".\"ID_Function\" " +

            "JOIN \"Municipality\" ON \"OMSU\".\"Municipality_ID\"=\"Municipality\".\"ID_Municipality\" " +

            "WHERE \"Login\" = '" + login + "' AND \"Password\" = '" + password + "';";

            DataTable dt = DBService.GetUsers(query);
            if (dt.Rows.Count == 1)
            {
                foreach (DataRow row in dt.Rows)
                {
                    User.ID = int.Parse(row["ID_User"].ToString());
                    User.Login = row["Login"].ToString();
                    User.Password = row["Password"].ToString();
                    User.Role = new Role(int.Parse(row["Role.ID"].ToString()), row["Role.Name"].ToString(), new Function(row["Function.Name"].ToString()), row["Role.Access"].ToString());
                    User.OMSU = new OMSU(row["OMSU.Name"].ToString(), int.Parse(row["ID_OMSU"].ToString()), new Municipality(row["Municipality.Name"].ToString()));
                    User.CaptOrg = new Contractor(row["CaptOrg.Name"].ToString(), int.Parse(row["ID_CaptOrg"].ToString()));
                } 
                return "OK";
            }
            else
            {
                return "Error";
            }
        }
    }
} 