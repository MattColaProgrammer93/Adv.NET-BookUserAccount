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
            Account acc = new Account("J Leon");
            acc.DepositBooks(2);

            Assert.AreEqual(2, acc.Books);
        }

        [TestMethod()]
        public void DepositHours_APositiveAmount_AddToHours()
        {
            Account acc = new Account("B Wilbur");
            acc.DepositHours(3);

            Assert.AreEqual(3, acc.Hours);
        }
    }
}