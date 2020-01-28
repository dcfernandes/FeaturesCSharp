namespace FeaturesCSharp.Demonstracao.Model
{
    using System;

    public class Endereco
    {
        public Endereco(Classe classe, bool entrega, string logradouro, string? numero, string? complemento, string bairro)
        {
            Classe = Classe;
            EntregaAgendada = entrega;
            Logradouro = !string.IsNullOrEmpty(logradouro)? logradouro : throw new ArgumentNullException(nameof(logradouro));
            Numero = numero;
            Complemento = complemento;
            Bairro = !string.IsNullOrEmpty(bairro) ? bairro : throw new ArgumentNullException(nameof(logradouro));
        }

        public Classe Classe { get; set; }
        public bool EntregaAgendada { get; set; }
        public string Logradouro { get; private set; }
        public string? Numero { get; private set; }
        public string? Complemento { get; private set; }
        public string Bairro { get; private set; }


        public override string ToString()
        {
            return (Logradouro, Numero, Complemento, Bairro) switch
            {
                (string l, string n, string c, string b) => $"{l}, {n} {c} - {b}",
                (string l, string n, null, string b) => $"{l}, {n} - {b}",
                (string l, null, string c, string b) => $"{l} {c} - {b}",
                (string l, null, null, string b) => $"{l} - {b}"
            };
        }
    }
    public enum Classe
    {
        A, B, C, D
    }
}
