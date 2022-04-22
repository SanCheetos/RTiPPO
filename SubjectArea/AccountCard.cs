using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTiPPO.SubjectArea
{
    internal class AccountCard
    {
        public int ID { get; set; }
        public string NumberMK { get; set; }
        public DateTime DateOfConclusionMK { get; set; }
        public Municipality Municipality { get; set; }
        public OMSU OMSU { get; set; }
        public Contractor ContractorMK { get; set; } 
        public string NumberActCatching { get; set; }
        public int CaugthDogs { get; set; }
        public int CaugthCats { get; set; }
        public int CaugthAnimals { get; set; }
        public Locality Locality { get; set; }
        public File File { get; set; }
        public DateTime DateCatch { get; set; }
        public string PurposeOfCatch { get; set; }
        public AccountCard(int id,
            string numberMK, 
            DateTime dateOfConclusionMK, 
            Municipality municipality,
            OMSU omsu,
            Contractor contractorMK,
            string numberActCatching,
            int caugthDogs,
            int caugthCats,
            int caugthAnimals,
            Locality locality,
            File file,
            DateTime dateCatch,
            string purposeOfCatch)
        {
            ID = id;
            NumberMK = numberMK;
            DateOfConclusionMK = dateOfConclusionMK;
            Municipality = municipality;
            OMSU = omsu;
            ContractorMK = contractorMK;
            NumberActCatching = numberActCatching;
            CaugthDogs = caugthDogs;
            CaugthCats = caugthCats;
            CaugthAnimals = caugthAnimals;
            Locality = locality;
            File = file;
            DateCatch = dateCatch;
            PurposeOfCatch = purposeOfCatch;
        }
    }
}
