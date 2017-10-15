using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountService
{
    public interface IRepository
    {
        double GetBalance(string acctId);
    }
}
