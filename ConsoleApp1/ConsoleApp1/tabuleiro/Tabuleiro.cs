using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez.tabuleiro
{
    internal class Tabuleiro
    {
        public int linhas;
        public int colunas;
        private Peca[,] pecas;

        public Tabuleiro()
        {
            this.linhas = 8;
            this.colunas = 8;
            pecas = new Peca[ linhas, colunas ];
        }

        public Peca peca( int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
    }
}
