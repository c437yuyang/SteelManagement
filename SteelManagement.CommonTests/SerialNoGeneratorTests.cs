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
                Assert.IsTrue(SerialNoGenerator.GetSerialNo(SerialNoGenerator.Type.Type01Purchase).Length == 20);
                Assert.IsTrue(string.Compare("1.5.1", "1.5") > 0);
                Assert.IsTrue(string.Compare("1.5.1", "1.5") > 0);
                Assert.IsTrue(string.Compare("1.5.1", "1.4.8.7") > 0);

                int j = Convert.ToInt32("0xf", 16);

            }
        }

    }
}
