using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod fm = new FactoryMethod();

            Console.WriteLine("Credit Card | Debit Card | PayPal");
            Console.WriteLine();
            Console.WriteLine("Choose the payment method");
            var method = Console.ReadLine();

            IPayment payment = fm.ChoosePaymentMethod(method);

            Console.WriteLine();
            Console.WriteLine("Payment Method Chosen");
            payment.Pay();
            Console.ReadKey();
        }
    }
}
