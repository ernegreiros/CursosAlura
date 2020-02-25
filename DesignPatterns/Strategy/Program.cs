using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Orcamento orcamento = new Orcamento(1000.0);

            ICMS icms = new ICMS();
            ISS iss = new ISS();

            CalculadorDeImposto calculadorDeImposto = new CalculadorDeImposto();

            Console.WriteLine("Calculando ICMS");
            calculadorDeImposto.CalcularImposto(orcamento, icms);
            Console.WriteLine("Calculando ISS");
            calculadorDeImposto.CalcularImposto(orcamento, iss);

            Console.ReadLine();
        }
    }
}
