using tabuleiro;
using Xadrez;

try
{


    Tabuleiro tab = new();

    PartidaXadrez partida = new();

    while (!partida.terminada)
    {
        try
        {
            Console.Clear();
            Tela.ImprimirPartida(partida);

            Console.WriteLine();
            Console.Write("Origem:");
            Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
            partida.validarPosicaoDeOrigem(origem);
            bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

            //Imprimir o tabuleiro novamente com as posições possíveis marcadas
            Console.Clear();
            Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);
            Console.WriteLine();
            Console.Write("Destino:");
            Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
            partida.validarPosicaoDeDestino(origem, destino);

            partida.realizaJogada(origem, destino);
        }
        catch(TabuleiroException e)
        {
            Console.WriteLine(e.Message);
            Console.ReadLine();
        }
    }
    Console.Clear();
    Tela.ImprimirPartida(partida);
}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}