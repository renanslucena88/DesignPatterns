using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy
{
    public class TakeThree : OrderStrategy
    {
        public override List<int> Sort(List<int> list)
        {
            Console.WriteLine("Take 3");
            return list.Take(3).ToList();
        }
    }
}
