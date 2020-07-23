using System.Collections.Generic;

namespace Strategy
{
    public abstract class OrderStrategy
    {
        public abstract List<int> Sort(List<int> list);
    }
}
