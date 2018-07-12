using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor){            
        }
        public override string ToString()
        {
            return "C";
        }
        private bool podeMover(Posicao pos)
        {
            Peca p = _tab.peca(pos);
            return p == null || p._cor != _cor;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[_tab._linhas, _tab._colunas];

            Posicao pos = new Posicao(0, 0);

            pos.definirValores(_posicao._linha - 1, _posicao._coluna - 2);
            if(_tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos._linha, pos._coluna] = true;
            }
            pos.definirValores(_posicao._linha - 2, _posicao._coluna - 1);
            if (_tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos._linha, pos._coluna] = true;
            }
            pos.definirValores(_posicao._linha - 2, _posicao._coluna + 1);
            if (_tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos._linha, pos._coluna] = true;
            }
            pos.definirValores(_posicao._linha - 1, _posicao._coluna + 2);
            if (_tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos._linha, pos._coluna] = true;
            }
            pos.definirValores(_posicao._linha + 1, _posicao._coluna + 2);
            if (_tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos._linha, pos._coluna] = true;
            }
            pos.definirValores(_posicao._linha + 2, _posicao._coluna + 1);
            if (_tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos._linha, pos._coluna] = true;
            }
            pos.definirValores(_posicao._linha +2, _posicao._coluna - 1);
            if (_tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos._linha, pos._coluna] = true;
            }
            pos.definirValores(_posicao._linha + 1, _posicao._coluna - 2);
            if (_tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos._linha, pos._coluna] = true;
            }
            return mat;
        }
    }
}
