using System;

namespace calculadora_rendimento_veicular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vehicle Performance Calculator (Km / L)!");

            Console.WriteLine("Enter the distance traveled (KM): ");
            string dist = Console.ReadLine();
            decimal distd = Convert.ToDecimal(dist);

            Console.WriteLine("Enter fuel consumption (L)");
            string cons = Console.ReadLine();
            decimal consd = Convert.ToDecimal(cons);

            decimal perf = 0;

            perf =
                distd / consd;

            Console.WriteLine("The performance of your vehicle was: "+perf+"KM/L!");
        }
    }
}
