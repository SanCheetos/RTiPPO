using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTiPPO.SubjectArea
{
    internal class Action
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Action(string name, int id = -1)
        {
            Name = name;
            ID = id;
        }
    }
}
