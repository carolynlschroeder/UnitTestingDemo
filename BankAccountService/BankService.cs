using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountService
{
    public class BankService
    {
        private IRepository _repository;

        public BankService(IRepository repository)
        {
            _repository = repository;
        }

        public double GetBankAccountBalance(string acctId)
        {
            return _repository.GetBalance(acctId);
        }
    }
}
