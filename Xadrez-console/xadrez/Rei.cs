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
        private PartidaDeXadrez _partida;

        public Rei(Tabuleiro tab, Cor cor, PartidaDeXadrez partida) : base(tab, cor)
        {
            _partida = partida;
        }

        public override string ToString()
        {
            return "R";
        }
        private bool podeMover(Posicao pos)
        {
            Peca p = _tab.peca(pos);
            return p == null || p._cor != _cor;
        }

        private bool testeTorreParaRoque(Posicao pos)
        {
            Peca p = _tab.peca(pos);
            return p != null && p is Torre && p._cor == _cor && p._qteMovimentos == 0;
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
            //# Jogada especial roque
            if (_qteMovimentos == 0 && !_partida.xeque)
            {//roque pequeno
                Posicao posT1 = new Posicao(_posicao._linha, _posicao._coluna + 3);
                if (testeTorreParaRoque(posT1))
                {
                    Posicao p1 = new Posicao(_posicao._linha, _posicao._coluna + 1);
                    Posicao p2 = new Posicao(_posicao._linha, _posicao._coluna + 2);
                    if(_tab.peca(p1) == null && _tab.peca(p2) == null)
                    {
                        mat[_posicao._linha, _posicao._coluna + 2] = true;
                    }
                }
                //roque grande
                Posicao posT2 = new Posicao(_posicao._linha, _posicao._coluna - 4);
                if (testeTorreParaRoque(posT2))
                {
                    Posicao p1 = new Posicao(_posicao._linha, _posicao._coluna - 1);
                    Posicao p2 = new Posicao(_posicao._linha, _posicao._coluna - 2);
                    Posicao p3 = new Posicao(_posicao._linha, _posicao._coluna - 3);
                    if (_tab.peca(p1) == null && _tab.peca(p2) == null && _tab.peca(p3) == null)
                    {
                        mat[_posicao._linha, _posicao._coluna - 2] = true;
                    }
                }
            }

                return mat;
        }
    }
}
