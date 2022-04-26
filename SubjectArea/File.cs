using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTiPPO.SubjectArea
{
    internal class File
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public File(string name, string path)
        {
            Name = name;
            Path = path;
        }
    }
}
