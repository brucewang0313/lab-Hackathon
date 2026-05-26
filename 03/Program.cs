namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一個有意義的英文敘述字串");
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var output = input.GroupBy(x => x, StringComparer.OrdinalIgnoreCase);//大小寫忽略
            if (input.Length>0)
            {
                foreach (var group in output)
                {
                    Console.WriteLine($"字串: {group.Key}，出現了 {group.Count()} 次");
                }
            }
            else
            {
                Console.Write("沒東西謝謝:)");
            }
        }
    }
}
