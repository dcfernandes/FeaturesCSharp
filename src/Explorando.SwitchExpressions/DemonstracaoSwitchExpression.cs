using System;

namespace Explorando.SwitchExpressions
{
    public static class DemonstracaoSwitchExpression
    {
        public static void Executar()
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("-------------DemonstracaoSwitchExpression------------");
            Console.WriteLine("-----------------------------------------------------");

            foreach (Cores cor in Enum.GetValues(typeof(Cores)))
            {
                Console.ForegroundColor = UsarACor(cor);
                Console.WriteLine(cor.ToString());

                Console.ForegroundColor = UsarACor(cor, true);
                Console.WriteLine(cor.ToString());
            }

            try
            {
                Console.ForegroundColor = UsarACor((Cores)20, true);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
            Console.ResetColor();
        }

        public static ConsoleColor UsarACorIsntrucaoSwitch(Cores cor)
        {
            switch (cor)
            {
                case Cores.Vermelho:
                    return ConsoleColor.Red;
                case Cores.Amarelo:
                    return ConsoleColor.Yellow;
                case Cores.Verde:
                    return ConsoleColor.Green;
                case Cores.Azul:
                    return ConsoleColor.Blue;
                default:
                    throw new ArgumentException(message: "Cor inválida para o enum", paramName: nameof(cor));
            }
        }

        public static ConsoleColor UsarACor(Cores cor) =>
            cor switch
            {
                Cores.Vermelho => ConsoleColor.Red,
                Cores.Amarelo => ConsoleColor.Yellow,
                Cores.Verde => ConsoleColor.Green,
                Cores.Azul => ConsoleColor.Blue,
                _ => throw new ArgumentException(message: "Cor inválida para o enum", paramName: nameof(cor))
            };

        public static ConsoleColor UsarACor(Cores cor, bool escuro = false) =>
            cor switch
            {
                Cores.Vermelho when escuro => ConsoleColor.DarkRed,
                Cores.Vermelho => ConsoleColor.Red,
                Cores.Amarelo when escuro => ConsoleColor.DarkYellow,
                Cores.Amarelo => ConsoleColor.Yellow,
                Cores.Verde when escuro => ConsoleColor.DarkGreen,
                Cores.Verde => ConsoleColor.Green,
                Cores.Azul when escuro => ConsoleColor.DarkBlue,
                Cores.Azul => ConsoleColor.Blue,
                _ => throw new ArgumentException(message: "Cor inválida para o enum", paramName: nameof(cor)),
            };
    }
}
