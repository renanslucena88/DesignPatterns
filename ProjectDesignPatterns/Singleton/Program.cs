using System;


namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton msg1 = Singleton.GetInstance;
            msg1.Message("1st call - It's being instantiated, because it's the first time it's being called!");

            Singleton msg2 = Singleton.GetInstance;
            msg2.Message("2nd call - Not instantiated, because it was already done on the first call!");

            Singleton msg3 = Singleton.GetInstance;
            msg3.Message("3rd call - Not instantiated, because it was already done on the first call!");

            Console.ReadKey();
        }
    }
}
