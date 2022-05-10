using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using RTiPPO.SubjectArea;
using RTiPPO.Services;
using System.Text.Json;

namespace RTiPPO.Controllers
{
    internal class LogController
    {
        // Журналирование 

        public static void Track(AccountCard accountCard, SubjectArea.Action action)
        {
            string objAccountCard = "AccountCard " +
                "{" +
                "NumberMK = " + accountCard.NumberMK.Trim() + ", " +
                "DateOfConclusionMK = " + accountCard.DateOfConclusionMK.ToString("yyyy-MM-dd") + ", " +
                "Municipality = " + accountCard.Municipality.Name + ", " +
                "OMSU = " + accountCard.OMSU.Name + ", " +
                "ContractorMK = " + accountCard.ContractorMK.Name + ", " +
                "NumberActCatching = " + accountCard.NumberActCatching.Trim() + ", " +
                "CaugthDogs = " + accountCard.CaugthDogs.ToString() + ", " +
                "CaugthCats = " + accountCard.CaugthCats.ToString() + ", " +
                "CaugthAnimals = " + accountCard.CaugthAnimals.ToString() + ", " +
                "Locality = " + accountCard.Locality.Name + ", " +
                "File = " + "null" + ", " +
                "DateCatch = " + accountCard.DateCatch.ToString("yyyy-MM-dd") + ", " +
                "PurposeOfCatch = " + accountCard.PurposeOfCatch.Trim() +
                "}";
            string query = "INSERT INTO \"Log\" (\"ActionDate\", \"User_ID\", \"Action_ID\", \"CaptAct_String\") " +
            "VALUES (current_timestamp(0), " + User.ID + ", " + action.ID + ", '" + objAccountCard + "');";
            DBService.CRUDRequest(query);
        }
    }
}