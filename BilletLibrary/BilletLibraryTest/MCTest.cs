using System;
using System.Collections.Generic;
using System.Text;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibraryTest
{
    [TestClass]
    public class MCTest
    {
        /// <summary>
        /// Tjekker om MC pris returnerer 125.
        /// </summary>
        [TestMethod]
        public void TestMCPris()
        {
            //ARRANGE
            MC mc = new MC();

            //ACT
            decimal pris = mc.Pris();

            //ASSERT
            Assert.AreEqual(125, pris);
        }

        /// <summary>
        /// Tjekker om metoden køretøj returnerer "MC"
        /// </summary>
        [TestMethod]
        public void TestMCKøretøj()
        {
            //ARRANGE
            MC mc = new MC();

            //ACT
            string køretøj = mc.Køretøj();

            //ASSERT
            Assert.AreEqual("MC", køretøj);
        }
    }
}
