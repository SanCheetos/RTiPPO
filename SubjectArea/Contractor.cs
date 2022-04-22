using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTiPPO.SubjectArea
{
    internal class Contractor
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Contractor(string name, int id = -1)
        {
            Name = name;
            ID = id;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
