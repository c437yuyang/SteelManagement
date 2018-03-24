using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelManagement.Common
{
    public interface ICopyRight
    {
        bool CheckAvailable();

        void UpdateUserInfo();

    }
}
