using Dip.Factory;
using Dip.Model;
using System;

namespace Dip.Payments
{
    class PaymentProcess
    {
        public void Pay(int id)
        {
            var product = DbProductFactory.Create();
            var productData = product.GetProductById(id);

            Console.WriteLine(productData);
        }
    }
}
