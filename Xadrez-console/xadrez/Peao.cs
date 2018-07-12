using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
    class Peao : Peca
    {
        public Peao(Tabuleiro tab, Cor cor) : base(tab, cor){
        }
        public override string ToString()
        {
            return "P";
        }
        private bool existeInimigo(Posicao pos)
        {
            Peca p = _tab.peca(pos);
            return p != null && p._cor != _cor;
        }
        private bool livre(Posicao pos)
        {
            return _tab.peca(pos) == null;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[_tab._linhas, _tab._colunas];

            Posicao pos = new Posicao(0, 0);

            if (_cor == Cor.Branca)
            {
                pos.definirValores(_posicao._linha - 1, _posicao._coluna);
                if(_tab.posicaoValida(pos) && livre(pos))
                {
                    mat[pos._linha, pos._coluna] = true;
                }
                pos.definirValores(_posicao._linha - 2, _posicao._coluna);
                if (_tab.posicaoValida(pos) && livre(pos) && _qteMovimentos == 0)
                {
                    mat[pos._linha, pos._coluna] = true;
                }
                pos.definirValores(_posicao._linha - 1, _posicao._coluna - 1);
                if (_tab.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos._linha, pos._coluna] = true;
                }
                pos.definirValores(_posicao._linha - 1, _posicao._coluna + 1);
                if (_tab.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos._linha, pos._coluna] = true;
                }
            }
            else
            {
                pos.definirValores(_posicao._linha + 1, _posicao._coluna);
                if (_tab.posicaoValida(pos) && livre(pos))
                {
                    mat[pos._linha, pos._coluna] = true;
                }
                pos.definirValores(_posicao._linha + 2, _posicao._coluna);
                if (_tab.posicaoValida(pos) && livre(pos) && _qteMovimentos == 0)
                {
                    mat[pos._linha, pos._coluna] = true;
                }
                pos.definirValores(_posicao._linha + 1, _posicao._coluna - 1);
                if (_tab.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos._linha, pos._coluna] = true;
                }
                pos.definirValores(_posicao._linha + 1, _posicao._coluna + 1);
                if (_tab.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos._linha, pos._coluna] = true;
                }
            }
            return mat;
        }
    }
}
