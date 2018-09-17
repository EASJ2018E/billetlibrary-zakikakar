using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace BilletLibraryTest
{
    [TestClass]
    public class BrobizzRabatTest
    {
        /// <summary>
        /// Tjekker om brobizz rabat bliver trukket fra hvis brobizzen bliver anvendt
        /// </summary>
        [TestMethod]
        public void TestBrobizzRabat()
        {
            //ARRANGE
            Bil bil = new Bil();
            bil.AnvendtBrobizz = true;

            //ACT
            decimal pris = bil.Pris();

            //ASSERT
            Assert.AreEqual(228, pris);

        }
    }
}
