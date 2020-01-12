namespace FeaturesCSharp.Console
{
    using FeaturesCSharp.Demonstracao.Model;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Imprimir();
        }

        private static void Imprimir()
        {
            foreach (var item in ObterEnderecos())
            {
                Console.WriteLine(item.ToString());
            }
        }

        static Endereco[] ObterEnderecos()
        {
            Endereco[] enderecos =
            {
                new Endereco("Rua A", "25", "Cobertura", "Centro"),
                new Endereco("Rua B", "100", null, "Centro"),
                new Endereco("Rua C", null, "Terreno", "Centro"),
                new Endereco("Rua D", null, null, "Centro"),
            };

            return enderecos;
        }
    }
}
