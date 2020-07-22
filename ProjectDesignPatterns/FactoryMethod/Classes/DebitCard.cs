using System;

namespace FactoryMethod
{
    public class DebitCard : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Debit Card Method");
        }
    }
}
