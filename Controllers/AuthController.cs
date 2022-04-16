using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RTiPPO.SubjectArea;

namespace RTiPPO.Controllers
{
    internal class AuthController
    {
        public static Register Login(User user)
        {
            return ListController.GetActs(user);
        }
    }
}
