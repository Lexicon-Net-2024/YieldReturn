namespace YieldReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = GetNumbers();
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
