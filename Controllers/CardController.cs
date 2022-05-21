using RTiPPO.Services;
using RTiPPO.SubjectArea;
using System;
using System.Collections.Generic;
using System.Data;
using Word = Microsoft.Office.Interop.Word;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTiPPO.Controllers
{
    internal class CardController
    {
        public static string WordExport(AccountCard accountCard, string name)
        {
            //������� ������ � ����
            return "������� ����� ������ �������";
        }

        public static bool UpdateAct(AccountCard accountCard)
        {
            //��������� ������
            string query = "UPDATE \"CaptAct\" " +
                "SET \"NumberMK\" = '" + accountCard.NumberMK + "', " +
                "\"DateMK\" = DATE('" + accountCard.DateOfConclusionMK.ToString("yyyy-MM-dd") + "'), "+
                "\"NumberAct\" = '" + accountCard.NumberActCatching + "', " +
                "\"CaptCats\" = '" + accountCard.CaugthCats + "', " +
                "\"CaptDogs\" = '" + accountCard.CaugthDogs + "', " +
                "\"CaptAnimals\" = '" + accountCard.CaugthAnimals + "', " +
                "\"CaptDate\" = DATE('" + accountCard.DateCatch.ToString("yyyy-MM-dd") + "'), " +
                "\"CaptPurpose\" = '" + accountCard.PurposeOfCatch + "', " +
                "\"OMSU_ID\" = '" + accountCard.OMSU.ID + "', " +
                "\"CaptOrg_ID\" = '" + accountCard.ContractorMK.ID + "', " +
                "\"Locality_ID\" = '" + accountCard.Locality.ID + "', " +
                "\"File_ID\" = null " +
                "WHERE \"ID_CaptAct\" = '" + accountCard.ID + "';";

            try
            {
                DBService.CRUDRequest(query);
                LogController.Track(accountCard, new SubjectArea.Action("���������", 2));

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            

        }

        public static string AddFile(File file, int cardId)
        {
            //���������� ����� � ������
            return "����� ������� ��������";
        }

        public static string DeleteFile(File file, int cardId)
        {
            //�������� ����� �� ������
            return "����� ������� ������";
        }
    }
}