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
                Console.WriteLine($"{item.ToString()} - Tempo entrega: {CalcularTempoEntrega(item.Classe, item.EntregaAgendada)}");
            }
        }

        private static object CalcularTempoEntrega(Classe classe, bool entregaAgendada)
        {
            throw new NotImplementedException();
        }

        static Endereco[] ObterEnderecos()
        {
            Endereco[] enderecos =
            {
                new Endereco(Classe.A, true, "Rua A", "25", "Cobertura", "Centro"),
                new Endereco(Classe.A, false,"Rua B", "100", null, "Centro"),
                new Endereco(Classe.C, true, "Rua C", null, "Terreno", "Zanzada"),
                new Endereco(Classe.D, true, "Rua D", null, null, "Centro"),
            };

            return enderecos;
        }


    }
}
