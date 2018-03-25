using Microsoft.VisualStudio.TestTools.UnitTesting;
using SteelManagement.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelManagement.Common.Tests
{
    [TestClass()]
    public class ObjPropertyReflectorTests
    {
        [TestMethod()]
        public void GetPropertyTest()
        {
            SteelManagement.Model.SteelInfo steelInfo = new Model.SteelInfo();
            steelInfo.Price = 10000;

            decimal d = (decimal)steelInfo.GetProperty("Price");


        }
    }
}