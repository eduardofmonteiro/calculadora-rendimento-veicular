using System;

namespace calculadora_rendimento_veicular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de rendimento veicular(Km/L)!");

            Console.WriteLine("Insira a distancia penrcorrida(KM): ");
            string dist = Console.ReadLine();
            decimal distd = Convert.ToDecimal(dist);

            Console.WriteLine("Insira o consumo de combustivel(L)");
            string cons = Console.ReadLine();
            decimal consd = Convert.ToDecimal(cons);

            decimal rend = 0;

            rend =
                distd / consd;

            Console.WriteLine("O rendimento do seu veiculo foi de:"+rend+"KM/L!");
        }
    }
}
