using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class payAccountCalculator: ICalculator
    {
        public void CalculateInterest(Account account)
        {
            account.Interest = account.Balance * 0.04;

            if (account.Interest < 50000) 
            {
                account.Interest += account.Balance * 0.02;
            }
            if (account.Interest < 1000)
            {
                account.Interest -= account.Balance * 0.04;
            }
        }
    }
}
