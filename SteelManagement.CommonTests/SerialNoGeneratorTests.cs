using Microsoft.VisualStudio.TestTools.UnitTesting;
using SteelManagement.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteelManagement.Common.Tests
{
    [TestClass()]
    public class SerialNoGeneratorTests
    {
        [TestMethod()]
        public void GetSerialNoTest()
        {
            for (int i = 0; i < 10; i++)
            {
                Assert.IsTrue(SerialNoGenerator.GetSerialNo(SerialNoGenerator.Type.Type01Purchase).Length==20);
            }
        }

    }
}
