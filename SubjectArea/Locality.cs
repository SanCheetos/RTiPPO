using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTiPPO.SubjectArea
{
    internal class Locality
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Locality(string name, int id = -1)
        {
            Name = name;
            ID = id;
        }

        public override string ToString()
        {
            return string.Format(Name);
        }
    }
}
