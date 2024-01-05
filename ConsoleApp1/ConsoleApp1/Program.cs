using ConsoleApp1.tabuleiro;
using Xadrez;
using Xadrez.tabuleiro;
using Xadrez.Xadrez;

try
{


Tabuleiro tab = new Tabuleiro();

    PosicaoXadrez pos = new PosicaoXadrez('c', 7);


    Console.WriteLine(pos.toPosicao());

}
catch(TabuleiroException e)
{
    Console.WriteLine(e.Message);
}