
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TouchpointApp.Model;
using System.Collections.Generic;
using TouchpointApp.Persistency;
using TouchpointApp.DataStorage;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void OpretUndervisingsstedUdenAdresse()
        { 

            Assert.ThrowsException<ArgumentException>(() => { Undervisningssted testSubject = new Undervisningssted("A1", " "); });





            //Assert.ThrowsException<ArgumentException>(() => { Undervisningssted us1 = new Undervisningssted(lokale, adresse); });

        }

        [TestMethod]
        public void TestMethod2()
        {

        }
    }
}