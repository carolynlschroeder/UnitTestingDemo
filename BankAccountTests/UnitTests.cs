using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountLibrary;

namespace BankAccountTests
{
    [TestClass]
    public class UnitTests
    { 
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_IfAmountGreaterThanBalance_ReturnsArgumentOutOfRangeException()
        {
            var bankAccount = new BankAccount("CustomerName", 1050);
            bankAccount.Debit(1200);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_IfAmountLessThanZero_ReturnsArgumentOutOfRangeException()
        {
            var bankAccount = new BankAccount("CustomerName", 1050);
            bankAccount.Debit(-100);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Credit_IfAmountLessThanZero_ReturnsArgumentException()
        {
            var bankAccount = new BankAccount("CustomerName", 1050);
            bankAccount.Credit(-100);
        }

        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            var bankAccount = new BankAccount("CustomerName", 1050);
            bankAccount.Debit(900);
            Assert.AreEqual(bankAccount.Balance, 150);
        }

        [TestMethod]
        public void Credit_WithValidAmount_UpdatesBalance()
        {
            var bankAccount = new BankAccount("CustomerName", 1050);
            bankAccount.Credit(500);
            Assert.AreEqual(bankAccount.Balance, 1550);
        }
    }
}
