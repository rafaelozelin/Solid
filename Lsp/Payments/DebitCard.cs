using System;

namespace Lsp.Payments
{
    class DebitCard : NubankCard
    {
        public override void Validate()
        {
            Console.WriteLine("Verificar o saldo...");
            Console.WriteLine("Saldo disponivel!");
        }
    }
}
