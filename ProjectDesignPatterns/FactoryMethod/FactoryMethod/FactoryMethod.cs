namespace FactoryMethod
{
    public class FactoryMethod
    {
        public IPayment ChoosePaymentMethod(string method)
        {
            switch (method)
            {
                case "Credit Card":
                    return new CreditCard();
                case "Debit Card":
                    return new DebitCard();
                case "PayPal":
                    return new Paypal();
                default:
                    return null;
            }
        }
    }
}
