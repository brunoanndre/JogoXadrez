using ConsoleApp1.tabuleiro;
using Xadrez;
using Xadrez.tabuleiro;
using Xadrez.Xadrez;


Tabuleiro tab = new Tabuleiro();


tab.colocarPeca(new Rei(tab,Cor.Preta), new Posicao(0, 0));
tab.colocarPeca(new Torre(tab,Cor.Preta), new Posicao(1, 3));
tab.colocarPeca(new Torre(tab,Cor.Preta), new Posicao(2, 4));
Tela.imprimirTabuleiro(tab);
