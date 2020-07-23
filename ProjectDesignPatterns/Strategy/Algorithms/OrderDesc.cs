using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy
{
    public class OrderDesc : OrderStrategy
    {
        public override List<int> Sort(List<int> list)
        {
            Console.WriteLine("DESC");
            return list.OrderByDescending(x => x).ToList();
        }
    }
}
