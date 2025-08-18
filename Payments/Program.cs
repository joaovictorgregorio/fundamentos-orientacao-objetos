using System;
using System.Diagnostics.CodeAnalysis;

namespace Payments
{
    public class Program
    {
        static void RealizarPagamento(double valor)
        {
            Console.WriteLine($"Pago o valor de {valor}");
        }
        static void Main(string[] args)
        {
            Console.Clear();

            var pagar = new Pagamento.Pagar(RealizarPagamento);
            pagar(25);
        }
    }

    public class Pagamento
        {
            public delegate void Pagar(double valor);
        }
}
