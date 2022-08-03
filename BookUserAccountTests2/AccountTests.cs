using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookUserAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookUserAccount.Tests
{
    [TestClass()]
    public class AccountTests
    {
        // Testing DepositBooks
        [TestMethod()]
        [DataRow(5)]
        [DataRow(3)]
        public void DepositBooks_APositiveAmount_AddToBooks(int amount)
        {
            Account acc = new("J Leon");
            acc.DepositBooks(amount);

            Assert.AreEqual(amount, acc.Books);
        }

        [TestMethod()]
        public void DepositBooks_APositiveAmount_ReturnsUpdatedBooks()
        {
            // AAA - Arrange Act Assert
            // Arrange 
            Account acc = new("H Jakons");
            int depositBooks = 3;
            int expectedReturn = 3;

            // Act
            int returnValue = acc.DepositBooks(depositBooks);

            // Assert
            Assert.AreEqual(expectedReturn, returnValue);
        }

        [TestMethod]
        [DataRow(-3)]
        [DataRow(0)]
        public void DepositBooks_ZeroOrLess_ThrowsArgumentException(int invalidAmount)
        {
            // Arrange
            Account acc = new("B Howler");

            // Assert => Act
            Assert.ThrowsException<ArgumentOutOfRangeException>
                (() => acc.DepositBooks(invalidAmount));
        }

        // Testing DepositHours
        [TestMethod()]
        [DataRow(3)]
        [DataRow(7)]
        public void DepositHours_APositiveAmount_AddToHours(int amount)
        {
            Account acc = new("B Wilbur");
            acc.DepositHours(amount);

            Assert.AreEqual(amount, acc.Hours);
        }

        [TestMethod()]
        public void DepositHours_APositiveAmount_ReturnsUpdatedBooks()
        {
            // AAA - Arrange Act Assert
            // Arrange 
            Account acc = new("F Flores");
            int depositHours = 1;
            int expectedReturn = 1;

            // Act
            int returnValue = acc.DepositHours(depositHours);

            // Assert
            Assert.AreEqual(expectedReturn, returnValue);
        }

        [TestMethod]
        [DataRow(-4)]
        [DataRow(-6)]
        public void DepositHours_ZeroOrLess_ThrowsArgumentException(int invalidAmount)
        {
            // Arrange
            Account acc = new("H Nick");

            // Assert => Act
            Assert.ThrowsException<ArgumentOutOfRangeException>
                (() => acc.DepositHours(invalidAmount));
        }
    }
}