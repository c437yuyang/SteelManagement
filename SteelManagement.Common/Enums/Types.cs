﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelManagement.Common.Enums
{

    /// <summary>
    /// 不能用静态类，不然不能声明对象，有时候会用到
    /// </summary>
    public class Types
    {
        public const string Individual = "个签";
        public const string Team = "团签";
        public const string Team2Individual = "团做个";
    }
}
