namespace homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("son kiriting ");
            int a = int.Parse(Console.ReadLine());
            int b, c = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    c++;
                }
            }
            if (c == 2)
            {
                Console.WriteLine("tub son");
            }
            else
            {
                Console.WriteLine("tub emas");
            };
        }
    }
}