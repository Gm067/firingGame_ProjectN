using Microsoft.VisualStudio.TestTools.UnitTesting;
using firingGame_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firingGame_Project.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            ButtonControlles btn = new ButtonControlles();
            if (btn.btnloadTask() == 2)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }
    }
}