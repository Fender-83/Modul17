using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Calculator
    {
        public static void CalculateInterest(Account account)
        {
            if (account.Type == "Обычный")
            {
                account.Interest = account.Balance * 0.4;

                if (account.Balance < 1000)
                    account.Interest = account.Balance * 0.2;
                if (account.Balance < 51000)
                    account.Interest = account.Balance * 0.4;
            }
            else if (account.Type == "Зарплатный")
                account.Interest = account.Balance * 0.5;
        }
    }
}
