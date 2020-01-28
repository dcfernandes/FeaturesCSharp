using System;

namespace Explorando.SwitchExpressions
{
    public static class DemonstracaoPadroesDePropriedades
    {
        public static void Executar()
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("----------DemonstracaoPadroesDePropriedades----------");
            Console.WriteLine("-----------------------------------------------------");

            var carros = new Carro[]
            {
                new Carro("Porshe", Cores.Azul),
                new Carro("Ferrari", Cores.Vermelho),
                new Carro("Camaro", Cores.Amarelo),
                new Carro("Camaro", Cores.Verde),
            };

            foreach (var carro in carros)
            {
                Console.ForegroundColor = ConsolePelaCorDoCarro(carro);
                Console.WriteLine(carro.ToString());
            }
            

            Console.WriteLine();
            Console.ResetColor();
        }

        private static ConsoleColor ConsolePelaCorDoCarro(Carro carro) =>
            carro switch
            {
                { Cor: Cores.Azul } => ConsoleColor.Blue,
                { Cor: Cores.Amarelo } => ConsoleColor.Yellow,
                { Cor: Cores.Vermelho } => ConsoleColor.Red,
                _ => ConsoleColor.DarkCyan

            };


        public class Carro
        {
            public Carro(string marca, Cores cor)
            {
                Cor = cor;
                MarcaModelo = marca;
            }

            public Cores Cor { get; private set; }
            public string MarcaModelo { get; private set; }


            public override string ToString() => $"Marca/Modelo: {MarcaModelo}, Cor: {Cor}";
        }
    }
}
