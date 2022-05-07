using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTiPPO.SubjectArea
{
    internal class Role
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Function Function { get; set; }
        public string Access { get; set; }

        public Role(int id, string name, Function function, string access)
        {
            ID = id;
            Name = name;
            Function = function;
            Access = access;
        }
    }
}
