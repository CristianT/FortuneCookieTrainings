using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FortuneCookieLibrary;
using System.Linq;

namespace FortuneCookieLibraryTests
{
    [TestClass]
    public class EnumerableExtensionsTests
    {
        [TestMethod]
        public void EnumerableExtensionsTests_Shuffle_OrderIsShuffled()
        {
            // Arrange
            var list = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Act
            var result = list.Shuffle().ToList();

            // Assert
            for (var i = 0; i < result.Count; i++)
            {
                if (list[i] != result[i])
                {
                    return;
                }
            }

            Assert.Fail("List has not been shuffled.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EnumerableExtensionsTests_Shuffle_ListCannotBeNull_ThrowsException()
        {
            // Arrange
            List<int> list = null;

            // Act
            list.Shuffle();

            // Assert
            Assert.Fail("Exception was not trown.");
        }
    }
}
