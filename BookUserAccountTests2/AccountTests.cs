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
        [TestMethod()]
        public void DepositBooks_APositiveAmount_AddToBooks()
        {
            Account acc = new("J Leon");
            acc.DepositBooks(2);

            Assert.AreEqual(2, acc.Books);
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

        [TestMethod()]
        public void DepositHours_APositiveAmount_AddToHours()
        {
            Account acc = new("B Wilbur");
            acc.DepositHours(3);

            Assert.AreEqual(3, acc.Hours);
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
    }
}