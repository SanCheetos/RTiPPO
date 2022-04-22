using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTiPPO.SubjectArea
{
    internal class OMSU
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Municipality Municipality { get; set; }

        public OMSU(string name, int id = -1, Municipality municipality = null)
        {
            Name = name;
            Municipality = municipality;
            ID = id;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
