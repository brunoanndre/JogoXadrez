using ConsoleApp1.tabuleiro;
using Xadrez;
using Xadrez.tabuleiro;
using Xadrez.Xadrez;

try
{


Tabuleiro tab = new Tabuleiro();


tab.colocarPeca(new Rei(tab,Cor.Preta), new Posicao(0, 0));
tab.colocarPeca(new Torre(tab,Cor.Preta), new Posicao(1, 3));
tab.colocarPeca(new Torre(tab,Cor.Preta), new Posicao(0, 1));

    tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(3,5));
    Tela.imprimirTabuleiro(tab);
}catch(TabuleiroException e)
{
    Console.WriteLine(e.Message);
}