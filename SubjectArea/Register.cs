using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTiPPO.SubjectArea
{
    internal class Register
    {
        public List<AccountCard> AccountCards { get; set; }

        public Register(List<AccountCard> accCards)
        {
            AccountCards = accCards;
        }
    }
}
