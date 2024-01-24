using Lsp.Payments;
using System;

namespace Lsp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var card = new CreditCard();            
            //var card = new DebitCard();  
            var card = new NubankRewards();

            card.Validate();
            card.CollectPayment();

            Console.ReadLine();
        }
    }
}
