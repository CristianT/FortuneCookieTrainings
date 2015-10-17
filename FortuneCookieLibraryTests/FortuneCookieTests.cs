using FortuneCookieLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneCookieLibraryTests
{
    [TestClass]
    public class FortuneCookieTests
    {
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void FortuneCookie_Constructor_PassAnEmptyName_ThrowsException()
        {
            //Arrange
            //Act
            var cookie = new FortuneCookie("");

            // Assert
            Assert.Fail("An exception should have been thrown.");
        }

        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void FortuneCookie_Constructor_PassANullName_ThrowsException()
        {
            //Arrange
            //Act
            var cookie = new FortuneCookie(null);

            // Assert
            Assert.Fail("An exception should have been thrown.");
        }
    }
}
