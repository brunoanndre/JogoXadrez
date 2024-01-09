namespace tabuleiro
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

        public void colocarPeca(Peca p ,Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        public Peca retirarPeca(Posicao pos)
        {
            if(peca(pos) == null)
            {
                return null;
            }
            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux; 
        }
        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha,pos.coluna];
        }

        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        public bool posicaoValida(Posicao pos)
        {
            if(pos.linha < 0 || pos.linha >= 8 || pos.coluna < 0 || pos.coluna >= 8) 
            {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao pos)
        {
            if(!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida!");
            }
        }
    }
}
