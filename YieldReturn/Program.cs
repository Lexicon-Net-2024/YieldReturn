namespace YieldReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = GetNumbers();
            IEnumerator<int> enumerator = numbers.GetEnumerator();

            while (enumerator.MoveNext())
            {
                int item = enumerator.Current;
                Console.WriteLine(item);
            }

            foreach (var item in GetNumersYield().Take(10))
            {
                Console.WriteLine(item);
            }


        }

        private static IEnumerable<int> GetNumersYield()
        {
            int i = 0;

            while (true)
            {
                yield return i++;
            }
        }

        private static IEnumerable<int> GetNumersOrdinary()
        {
            int i = 0;
            var res = new List<int>();

            while(i < 100000000)
            {
                res.Add(i++);
            }

            return res;

        }

        private static IEnumerable<int> GetNumbers()
        {
            var num = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            foreach (var number in num)
            {
                yield return number;
            }
        }
    }
}
