using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var pagamento = new Pagamento();

        }
    }

    // 4 modificadores de acesso no C#. Private, protected, internal e public
    public class Pagamento
    {
        // Propriedades
        protected DateTime Vencimento;

        // Métodos
        private void Pagar() { }
    }
    
    public class PagamentoBoleto : Pagamento
    {
        void Teste()
        {
            base.
        }
    }
}
