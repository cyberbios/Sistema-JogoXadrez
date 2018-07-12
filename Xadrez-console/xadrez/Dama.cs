using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
    class Dama : Peca
    {
        public Dama(Tabuleiro tab, Cor cor) : base(tab, cor){
        }
        public override string ToString()
        {
            return "D";
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

            //esquerda
            pos.definirValores(_posicao._linha, _posicao._coluna - 1);
            while(_tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos._linha, pos._coluna] = true;
                if(_tab.peca(pos) != null && _tab.peca(pos)._cor != _cor){ break;
                }
                pos.definirValores(pos._linha, pos._coluna - 1);
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
                pos.definirValores(pos._linha, pos._coluna + 1);
            }
            //acima
            pos.definirValores(_posicao._linha - 1, _posicao._coluna);
            while (_tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos._linha, pos._coluna] = true;
                if (_tab.peca(pos) != null && _tab.peca(pos)._cor != _cor)
                {
                    break;
                }
                pos.definirValores(pos._linha - 1, pos._coluna);
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
                pos.definirValores(pos._linha + 1, pos._coluna);
            }
            //noroeste
            pos.definirValores(_posicao._linha - 1, _posicao._coluna - 1);
            while (_tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos._linha, pos._coluna] = true;
                if (_tab.peca(pos) != null && _tab.peca(pos)._cor != _cor)
                {
                    break;
                }
                pos.definirValores(pos._linha - 1, pos._coluna - 1);
            }
            //nordeste
            pos.definirValores(_posicao._linha - 1, _posicao._coluna + 1);
            while (_tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos._linha, pos._coluna] = true;
                if (_tab.peca(pos) != null && _tab.peca(pos)._cor != _cor)
                {
                    break;
                }
                pos.definirValores(pos._linha - 1, pos._coluna + 1);
            }
            //sudeste
            pos.definirValores(_posicao._linha + 1, _posicao._coluna + 1);
            while (_tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos._linha, pos._coluna] = true;
                if (_tab.peca(pos) != null && _tab.peca(pos)._cor != _cor)
                {
                    break;
                }
                pos.definirValores(pos._linha + 1, pos._coluna + 1);
            }
            //suldoeste
            pos.definirValores(_posicao._linha + 1, _posicao._coluna - 1);
            while (_tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos._linha, pos._coluna] = true;
                if (_tab.peca(pos) != null && _tab.peca(pos)._cor != _cor)
                {
                    break;
                }
                pos.definirValores(pos._linha + 1, pos._coluna - 1);
            }
            return mat;
        }
    }
}
