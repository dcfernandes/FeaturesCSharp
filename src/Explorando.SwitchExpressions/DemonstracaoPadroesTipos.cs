using System;

namespace Explorando.SwitchExpressions
{
    public static class DemonstracaoPadroesTipos
    {
        public static void Executar()
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("---------------DemonstracaoPadroesTipos--------------");
            Console.WriteLine("-----------------------------------------------------");

            var veiculos = new object[]
            {
                new Carro(),
                new Moto(),
                new Caminhao(3),
                new Caminhao(5),
                new Taxi("TO"),
                new Taxi("ES"),
                new Onibus()
            };

            foreach (var veiculo in veiculos)
            {
                decimal pedagio = PedagioParaOVeiculo(veiculo);
                Console.WriteLine($"Pedágio de R$ {pedagio.ToString("C")} para o tipo de veículo {veiculo.GetType().Name}.");
            }


            Console.WriteLine();
            Console.ResetColor();
        }

        private static decimal PedagioParaOVeiculo(object veiculo) =>
            veiculo switch
            {
                Carro _ => 8M,
                Moto _ => 3M,
                Caminhao ca => 10 * ca.Eixos,
                Taxi tx => tx.Estado == "ES" ? 5M : 8M,
                Onibus _ => 5M,
                { } => throw new ArgumentException(message: "Tipo de veiculo não reconhecido.", paramName: nameof(veiculo)),
                null => throw new ArgumentNullException(nameof(veiculo))
            };
        
    }

    public class Carro { }

    public class Moto { }

    public class Caminhao
    {
        public Caminhao(int eixos)
        {
            Eixos = eixos;
        }

        public int Eixos { get; private set; }
    }

    public class Taxi 
    {
        public Taxi(string estado)
        {
            Estado = estado;
        }

        public string Estado { get; private set; }
    }

    public class Onibus { }
}
