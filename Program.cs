using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var payAccount = new Account("Зарплатный", 5000);
                payAccount.Calculate(new payAccountCalculator());

            var depositAccount = new Account("Депозитный", 900);
            depositAccount.Calculate(new depositAccountCalculator());
        }
    }
}
