using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Account
    {
        public string Type { get; set; }        
        public double Balance { get; set; }
        public double Interest { get; set; }

        public Account(string type, double balance)
        {
        Type = type;
        Balance = balance;
        }

        public void Calculate(ICalculator calculator) 
        { 
        calculator.CalculateInterest(this);
            Console.WriteLine($"Процентная ставка по вкладу '{this.Type}' \nсоставит {this.Interest} руб в месяц");
            Console.WriteLine();
        }
    }
}
