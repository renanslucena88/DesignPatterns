using Facade.SubSystem;
using System;

namespace Facade.Facade
{
    public class FacadeClass
    {
        public SubSystem01 one;
        public SubSystem02 two;
        public SubSystem03 three;

        public FacadeClass()
        {
            this.one = new SubSystem01();
            this.two = new SubSystem02();
            this.three = new SubSystem03();
        }


        public void MethodA()
        {
            Console.WriteLine();
            Console.WriteLine("Method A");
            this.two.MethodTwo();
            this.three.MethodThree();
        }

        public void MethodB()
        {
            Console.WriteLine();
            Console.WriteLine("Method A");
            this.one.MethodOne();
            this.three.MethodThree();
        }
    }
}
