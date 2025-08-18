using System;
using System.Diagnostics.CodeAnalysis;

namespace Payments
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var pessoaUm = new Pessoa(2, "João Victor");
            var pessoaDois = new Pessoa(2, "João Victor");
            Console.WriteLine(pessoaUm.Equals(pessoaDois));
        }
    }

    public class Pessoa : IEquatable<Pessoa>
    {
        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public bool Equals(Pessoa pessoa)
        {
            return Id == pessoa.Id && Nome == pessoa.Nome;
        }
    }
}
