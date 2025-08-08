using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var pagamentoBoleto = new PagamentoViaBoleto();
            pagamentoBoleto.Vencimento = DateTime.Now;
            pagamentoBoleto.Pagar();
            pagamentoBoleto.NumeroBoleto = "1234567";
        }
    }

    class Pagamento
    {
        // Propriedades
        public DateTime Vencimento;

        // Métodos
        public void Pagar() =>  Console.WriteLine("Hello, world!"); 
    }

    class PagamentoViaBoleto : Pagamento
    {
        public string NumeroBoleto;
    }
    
}
