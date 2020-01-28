using System;

namespace Explorando.SwitchExpressions
{
    public static class DemonstracaoPadroesTupla
    {
        public static void Executar()
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("---------------DemonstracaoPadroesTupla--------------");
            Console.WriteLine("-----------------------------------------------------");

            Console.ForegroundColor = DemonstracaoSwitchExpression.UsarACor(Cores.Amarelo);
            Console.WriteLine(PedraPapelTesoura("papel", "tesoura"));

            Console.ForegroundColor = DemonstracaoSwitchExpression.UsarACor(Cores.Azul);
            Console.WriteLine(PedraPapelTesoura("pedra", "tesoura"));

            Console.ForegroundColor = DemonstracaoSwitchExpression.UsarACor(Cores.Verde);
            Console.WriteLine(PedraPapelTesoura("pedra", "pedra"));


            Console.WriteLine();
            Console.ResetColor();
        }

        private static string PedraPapelTesoura(string jogador1, string jogador2) =>
            $"Jogador 1 - {jogador1} | Jogador 2 - {jogador2}." + Environment.NewLine +
            (jogador1, jogador2) switch
            {
                ("pedra", "papel") => "Pedra foi coberta pelo Papel. Papel ganhou!",
                ("pedra", "tesoura") => "Pedra quebra Tesoura. Pedra ganhou!",
                ("papel", "pedra") => "Papel cobriu a Pedra. Papel ganhou!",
                ("papel", "tesoura") => "Papel foi cortado pela Tesoura. Tesoura ganhou!",
                ("tesoura", "pedra") => "Tesoura foi quebrada pela Pedra. Pedra ganhou!",
                ("tesoura", "papel") => "Tesoura corta o Papel. Tesoura ganhou!",
                (_, _) => "Empate"
            };
    }
}
