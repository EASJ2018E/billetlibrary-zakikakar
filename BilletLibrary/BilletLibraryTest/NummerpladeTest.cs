using System;
using System.Collections.Generic;
using System.Text;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibraryTest
{
    [TestClass]
    public class NummerpladeTest 
    {
        
        [TestMethod]
        public void TestNummerpladeLength()
        {
            //ARRANGE
            Bil bil = new Bil();
            bil.Nummerplade = "AB123456";

            //ACT
            string nummerPlade = bil.Nummerplade;

            //ASSERT
            Assert.AreNotEqual("AB123456", nummerPlade);


            //try
            //{
            //    TestNummerpladeLength();
            //    Assert.Fail("no exception thrown");
            //}
            //catch (Exception ex)
            //{
            //    Assert.IsTrue(ex is Exception);
            //}

        }

    }
}
