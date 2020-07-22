using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = ExecAbstractFactory.ProdCar("Luxury");
            Car car2 = ExecAbstractFactory.ProdCar("Popular");


            Console.ReadKey();
        }
    }
}
