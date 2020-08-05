using Facade.Facade;
using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            FacadeClass facade = new FacadeClass();
            facade.MethodA();
            facade.MethodB();

            Console.ReadKey();
        }
    }
}
