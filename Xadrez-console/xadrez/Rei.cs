using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        public override string ToString()
        {
            return "R";
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
            
            //acima
            pos.definirValores(_posicao._linha - 1, _posicao._coluna);
            if (_tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos._linha, pos._coluna] = true;
            }
            //nordeste
            pos.definirValores(_posicao._linha - 1, _posicao._coluna + 1);
            if (_tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos._linha, pos._coluna] = true;
            }
            //direita
            pos.definirValores(_posicao._linha, _posicao._coluna + 1);
            if (_tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos._linha, pos._coluna] = true;
            }
            //sudeste
            pos.definirValores(_posicao._linha + 1, _posicao._coluna + 1);
            if (_tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos._linha, pos._coluna] = true;
            }
            //abaixo
            pos.definirValores(_posicao._linha + 1, _posicao._coluna);
            if (_tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos._linha, pos._coluna] = true;
            }
            //sudoeste
            pos.definirValores(_posicao._linha + 1, _posicao._coluna - 1);
            if (_tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos._linha, pos._coluna] = true;
            }
            //esquerda
            pos.definirValores(_posicao._linha, _posicao._coluna - 1);
            if (_tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos._linha, pos._coluna] = true;
            }
            //noroeste
            pos.definirValores(_posicao._linha - 1, _posicao._coluna - 1);
            if (_tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos._linha, pos._coluna] = true;
            }
            return mat;
        }
    }
}
