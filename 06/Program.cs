namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入年收入");
            var input = decimal.Parse(Console.ReadLine());
            decimal tax = 0;
            if (input < 0)
            {
                Console.WriteLine("年收入不能為負數");
                return;
            }
            if (input > 10310000m)
            {
                tax = (input - 10310000m) * 0.50m
                    + (10310000m - 4530000m) * 0.40m
                    + (4530000m - 2420000m) * 0.30m
                    + (2420000m - 1210000m) * 0.20m
                    + (1210000m - 540000m) * 0.12m
                    + (540000m * 0.05m);
            }
            else if (input > 4530000m)
            {
                tax = (input - 4530000m) * 0.40m
                    + (4530000m - 2420000m) * 0.30m
                    + (2420000m - 1210000m) * 0.20m
                    + (1210000m - 540000m) * 0.12m
                    + (540000m * 0.05m);
            }
            else if (input > 2420000m)
            {
                tax = (input - 2420000m) * 0.30m
                    + (2420000m - 1210000m) * 0.20m
                    + (1210000m - 540000m) * 0.12m
                    + (540000m * 0.05m);
            }
            else if (input > 1210000m)
            {
                tax = (input - 1210000m) * 0.20m
                    + (1210000m - 540000m) * 0.12m
                    + (540000m * 0.05m);
            }
            else if (input > 540000m)
            {
                tax = (input - 540000m) * 0.12m
                    + (540000m * 0.05m);
            }
            else
            {
                tax = input * 0.05m;
            }

            Console.WriteLine($"應繳稅額為{tax}");
        }
    }
}
