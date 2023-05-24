using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApplication
{
    class Program
    {
        enum TransactionType {Buy=1,Sell=-1};

        static void Main(string[] args)
        {
            Console.WriteLine("Enter nominal of the trade");
            string nominalInput = Console.ReadLine();
            int nominal = int.Parse(nominalInput);

            Console.WriteLine("Enter trade price.");
            string priceInput = Console.ReadLine();
            int price = int.Parse(priceInput);

            Console.WriteLine("Buy or Sell?");
            TransactionType transaction;
            string tType = Console.ReadLine();
            transaction = (TransactionType) Enum.Parse( typeof(TransactionType), tType, true);

            int sign = tType == "Buy" ? 1: -1; 
            int CV = nominal * price * sign;
            Console.WriteLine($"The Currenct Value of your investment is {CV}.");
            Console.ReadKey();
        }
    }
}
