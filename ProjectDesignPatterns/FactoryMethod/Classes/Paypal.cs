using System;

namespace FactoryMethod
{
    public class Paypal : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("PayPal Method");
        }
    }
}
