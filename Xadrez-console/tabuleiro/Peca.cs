using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao _posicao { get; set; }
        public Cor _cor { get; protected set; }
        public int _qteMovimentos { get; protected set; }
        public Tabuleiro _tab { get; protected set; }

        public Peca (Tabuleiro tab, Cor cor) {
            _posicao = null;
            _tab = tab;
            _cor = cor;
            _qteMovimentos = 0;
        }
        public void incrementarQteMovimentos()
        {
            _qteMovimentos++;
        }

        public void decrementarQteMovimentos()
        {
            _qteMovimentos--;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for(int i = 0; i < _tab._linhas ; i++)
            {
                for(int j = 0; j < _tab._colunas; j++)
                {
                    if(mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool movimentoPossivel(Posicao pos)
        {
            return movimentosPossiveis()[pos._linha, pos._coluna];
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
