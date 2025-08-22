using System;
using System.Diagnostics.CodeAnalysis;

namespace Payments
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var genericContext = new DataContext<IPerson, Payment, Subscription>();
            genericContext.Save(new Payment());
            genericContext.Save(new Person());
            genericContext.Save(new Subscription());

        }

        public class DataContext<P, PA, S>
            where P : IPerson
            where PA : Payment
            where S : Subscription
        {
            public void Save(P entity)
            {
                Console.WriteLine($"Saving {entity.GetType().Name}");
            }

            public void Save(PA entity)
            {
                Console.WriteLine($"Saving {entity.GetType().Name}");
            }

            public void Save(S entity)
            {
                Console.WriteLine($"Saving {entity.GetType().Name}");
            }
        }

        public interface IPerson { }
        public class Payment { }
        public class Person : IPerson { }
        public class Subscription { }
    }
}
