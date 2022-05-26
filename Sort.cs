using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTiPPO
{
    internal class Sort
    {
        public string Column { get; set; }
        public string SortType { get; set; }
        public Sort(string column, string sortType)
        {
            Column = column;
            SortType = sortType;
        }
    }
}
