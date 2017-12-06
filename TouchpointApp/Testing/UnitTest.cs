
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TouchpointApp.Model;
<<<<<<< HEAD
=======
using System.Collections.Generic;

>>>>>>> edc27d607db0a48d9ecf25ff32f45bad1c4e7f37

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        

        public UnitTest1()
        {
            //testobjekt = new Undervisningssted("","");
        }
        [TestMethod]
        public void OpretUndervisingsstedUdenAdresse()
        {
<<<<<<< HEAD
            // Arrange
            Underviser h = new Underviser(); 
            S
            
=======
>>>>>>> edc27d607db0a48d9ecf25ff32f45bad1c4e7f37

            // arrange 
           





            Assert.ThrowsException<ArgumentException>(() => { new Undervisningssted("", ""); });





            //Assert.ThrowsException<ArgumentException>(() => { Undervisningssted us1 = new Undervisningssted(lokale, adresse); });

        }

        [TestMethod]
        public void OpretUnderviserUdenPersonligInfo()
        {
            Assert.ThrowsException<ArgumentException>(() => { new Underviser("", "", "", ""); });
        }
    }
}