﻿namespace tabuleiro
{
    abstract class Peca
    {
        public Cor cor { get; protected  set; }
        public Posicao posicao{ get; set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.cor = cor;
            this.tab = tab;
            this.posicao = null;
            this.qtdMovimentos = 0;
        }

        public void IncrementarQtdMovimentos()
        {
            qtdMovimentos++;
        }

        public void DecrementarQtdMovimentos()
        {
            qtdMovimentos--;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();

            for(int i = 0; i < tab.linhas; i++)
            {
                for(int j=0; j< tab.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool movimentoPossivel(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }
        public abstract bool[,] movimentosPossiveis();
    }
}
