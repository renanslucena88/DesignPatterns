using System;

namespace FactoryMethod
{
    public class CreditCard : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Credit Card Method");
        }
    }
}
