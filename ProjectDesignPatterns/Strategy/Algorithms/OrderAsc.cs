using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy
{
    public class OrderAsc : OrderStrategy
    {
        public override List<int> Sort(List<int> list)
        {
            Console.WriteLine("ASC");
            return list.OrderBy(x => x).ToList();

        }
    }
}
