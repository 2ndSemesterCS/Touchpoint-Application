
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TouchpointApp.Model;
using System.Collections.Generic;


namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        

      
        [TestMethod]
        public void OpretUndervisingsstedUdenAdresse()
        { 
            Assert.ThrowsException<ArgumentException>(() => { new Undervisningssted("", ""); });
        }

        [TestMethod]
        public void OpretUnderviserUdenPersonligInfo()
        {
            Assert.ThrowsException<ArgumentException>(() => { new Underviser("", "", "", ""); });
        }

        [TestMethod]
        public void OpretKursistUdenPersonligInfo()
        {
            Assert.ThrowsException<ArgumentException>(() => { new Kursist("", "", "", "", "", ""); });
        }

        [TestMethod]
        public void OpretKursusMedManglendeInformation()
        {
            Assert.ThrowsException<ArgumentException>(() => { new Kursus("","","","",0 ,null,null,"","",0); });
        }
        
        [TestMethod]
        public void OpretSerieUdenValgAfKurser()
        {
            Assert.ThrowsException<ArgumentException>(() => { new Serie(null,""); });
        }

        [TestMethod]
        public void OpretUnderviserMedTal()
        {
            Assert.ThrowsException<ArgumentException>(() => { new Underviser("","","",""); });
        }
    }
}