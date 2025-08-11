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

            var pagamento = new Pagamento();
            Console.WriteLine(pagamento.ToString());

            var pagamentoCartaoCredito = new PagamentoCartaCredito();
            pagamentoCartaoCredito.NumeroCartao = "12324343434";
            pagamentoCartaoCredito.ConfirmarNumeroValidoCartaoCredito();
        }
    }

    class Pagamento
    {
        // Propriedades
        public DateTime Vencimento;

        // Métodos
        public virtual void Pagar()
            => Console.WriteLine("Hello, world!");

        public override string ToString()
            => Vencimento.ToString("dd/MM/yyyy");
        
    }

    class PagamentoViaBoleto : Pagamento
    {
        public string NumeroBoleto;
        public override void Pagar()
            => Console.WriteLine("Pagou o boleto!");
        
    }

    class PagamentoCartaCredito : Pagamento
    {
        public string NumeroCartao;
        public void ConfirmarNumeroValidoCartaoCredito()
            => Console.WriteLine($"{NumeroCartao}, foi válidado com sucesso!");
    }
    
}
