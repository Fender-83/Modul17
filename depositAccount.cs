using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class depositAccountCalculator: ICalculator
    {
        public void CalculateInterest(Account account)
        {
            account.Interest = account.Balance * 0.05;
        }
    }
}
