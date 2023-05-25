using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApplication
{
    class Program
    {
        enum TransactionType { Buy = 1, Sell = -1 };

        static void Main(string[] args)
        {
            Console.WriteLine("Enter nominal of the trade");
            string nominalInput = Console.ReadLine();
            double nominal = double.Parse(nominalInput);

            Console.WriteLine("Enter trade price.");
            string tprice = Console.ReadLine();
            double tradePrice = double.Parse(tprice);

            Console.WriteLine("Enter origional price.");
            string oprice = Console.ReadLine();
            double origionalPrice = double.Parse(oprice);

            Console.WriteLine("Buy or Sell?");
            TransactionType transaction;
            string tType = Console.ReadLine();
            transaction = (TransactionType)Enum.Parse(typeof(TransactionType), tType, true);

            int sign = tType == "Buy" ? 1 : -1;
            double CV = nominal * origionalPrice * sign;
            Console.WriteLine($"The Currenct Value of your investment is {CV} EUR.");

            int factor = tType == "Buy" ? 0 : 1;
            double PL = (tradePrice - origionalPrice) * nominal * factor;
            Console.WriteLine($"Current profit is {PL} EUR");
            Console.ReadKey();
        }
    }
}
