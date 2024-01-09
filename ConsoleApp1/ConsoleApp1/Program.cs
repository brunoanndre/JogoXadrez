using tabuleiro;
using Xadrez;

try
{


    Tabuleiro tab = new Tabuleiro();

    PartidaXadrez partida = new PartidaXadrez();

    while (!partida.terminada)
    {
        Console.Clear();
        Tela.imprimirTabuleiro(partida.tab);

        Console.WriteLine();
        Console.Write("Origem:");
        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

        //Imprimir o tabuleiro novamente com as posições possíveis marcadas
        Console.Clear();
        Tela.imprimirTabuleiro(partida.tab,posicoesPossiveis);
        Console.WriteLine();
        Console.Write("Destino:");
        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

        partida.executaMovimento(origem, destino);

    }

}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}