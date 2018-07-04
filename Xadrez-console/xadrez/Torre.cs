using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        public override string ToString()
        {
            return "T";
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
            while (_tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos._linha, pos._coluna] = true;
                if (_tab.peca(pos) != null && _tab.peca(pos)._cor != _cor)
                {
                    break;
                }
                pos._linha = pos._linha - 1;
            }
            //abaixo
            pos.definirValores(_posicao._linha + 1, _posicao._coluna);
            while (_tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos._linha, pos._coluna] = true;
                if (_tab.peca(pos) != null && _tab.peca(pos)._cor != _cor)
                {
                    break;
                }
                pos._linha = pos._linha + 1;
            }
            //direita
            pos.definirValores(_posicao._linha, _posicao._coluna + 1);
            while (_tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos._linha, pos._coluna] = true;
                if (_tab.peca(pos) != null && _tab.peca(pos)._cor != _cor)
                {
                    break;
                }
                pos._coluna = pos._coluna + 1;
            }
            //esquerda
            pos.definirValores(_posicao._linha, _posicao._coluna - 1);
            while (_tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos._linha, pos._coluna] = true;
                if (_tab.peca(pos) != null && _tab.peca(pos)._cor != _cor)
                {
                    break;
                }
                pos._coluna = pos._coluna - 1;
            }
            return mat;
        }
    }
}
