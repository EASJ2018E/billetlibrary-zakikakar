using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibraryTest
{
    [TestClass]
    public class BilTest
    {
        /// <summary>
        /// Tjekker om bilens pris returnerer 240.
        /// </summary>
        [TestMethod]
        public void TestBilPris()
        {
            //ARRANGE
            Bil bil = new Bil();

            //ACT
            decimal pris = bil.Pris();

            //ASSERT
            Assert.AreEqual(240, pris);
        }

        /// <summary>
        /// Tjekker om metoden k�ret�j returnerer "Bil"
        /// </summary>
        [TestMethod]
        public void TestBilK�ret�j()
        {
            //ARRANGE
            Bil bil = new Bil();

            //ACT
            string k�ret�j = bil.K�ret�j();

            //ASSERT
            Assert.AreEqual("Bil", k�ret�j);
        }
    }
}
