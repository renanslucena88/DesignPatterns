using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderContext studentRecorts = new OrderContext();
            studentRecorts.Add(20);
            studentRecorts.Add(45);
            studentRecorts.Add(51);
            studentRecorts.Add(3);
            studentRecorts.Add(41);
            studentRecorts.Add(19);

            studentRecorts.SetSortStrategy(new OrderAsc());
            studentRecorts.Sort();

            studentRecorts.SetSortStrategy(new OrderDesc());
            studentRecorts.Sort();

            studentRecorts.SetSortStrategy(new TakeThree());
            studentRecorts.Sort();



            Console.ReadKey();

        }
    }
}
