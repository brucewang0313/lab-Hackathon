namespace contentchange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一個整數(至少大於90)");
            var input = int.Parse(Console.ReadLine());
            for (var i = 1; i <= input; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("Dann");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("School");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Build");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
