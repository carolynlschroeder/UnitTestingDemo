using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccountService;
using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankAccountTests
{
    [TestClass]
    public class BankAccountServiceTests
    {
        [TestMethod]
        public void GetBankAccountBalance_ReturnsBalance()
        {
            var repository = A.Fake<IRepository>();
            A.CallTo(() => repository.GetBalance("Acct01")).Returns(1000);
            var service = new BankService(repository);
            Assert.AreEqual(service.GetBankAccountBalance("Acct01"), 1000);
        }
    }
}
