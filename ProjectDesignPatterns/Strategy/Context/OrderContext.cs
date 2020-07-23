using System;
using System.Collections.Generic;

namespace Strategy
{
    public class OrderContext
    {
        private List<int> _listNumber = new List<int>();
        private OrderStrategy _sortStrategy;

        public void SetSortStrategy(OrderStrategy sortStrategy)
        {
            this._sortStrategy = sortStrategy;
        }

        public void Add(int number)
        {
            _listNumber.Add(number);
        }

        public void Sort()
        {
            var listOrdered = _sortStrategy.Sort(_listNumber);

            foreach (var number in listOrdered)
            {
                Console.WriteLine(" " + number);
            }

            Console.WriteLine();
        }
    }
}
