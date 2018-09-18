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

        /// <summary>
        /// Fortæller at man forventer en exception af typen 'ArgumentException'
        /// Her laver man ikke en assert, da 'expectedexception' fungerer som assert.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))] 
        public void TestNummerpladeLength()
        {
            //ARRANGE
            Bil bil = new Bil();

            //ACT
            bil.Nummerplade = "AB123456";
        }

    }
}
