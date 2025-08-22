using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Payments
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            IList<Payment> payments = new List<Payment>();
            payments.Add(new Payment(1));
            payments.Add(new Payment(2));
            payments.Add(new Payment(3));
            payments.Add(new Payment(10));
            payments.Add(new Payment(13));

            payments.Remove(payments[3]);

            foreach (var item in payments)
            {
                Console.WriteLine(item.Id);
            }

            var payment = payments.Where(x => x.Id == 2);
            Console.WriteLine("\nStatus - " + (payment.Any() ? "pagamento encontrado: " + payment.First().Id.ToString() : "Nenhum pagamento encontrado"));
        }
        public class Payment
        {
            public int Id { get; set; }
            public Payment(int id)
            {
                Id = id;
            }
        }
    }
}
