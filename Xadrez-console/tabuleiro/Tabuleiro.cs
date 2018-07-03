using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int _linhas { get; set; }
        public int _colunas { get; set; }
        private Peca[,] _pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            _linhas = linhas;
            _colunas = colunas;
            _pecas = new Peca[linhas, colunas];
        }
        public Peca peca(int linha, int coluna)
        {
            return _pecas[linha, coluna];
        }
        public Peca peca(Posicao pos)
        {
            return _pecas[pos._linha, pos._coluna];
        }

        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos)) { throw new TabuleiroException("Já existe uma peça nessa posição!!"); }
            _pecas[pos._linha, pos._coluna] = p;
            p._posicao = pos;
        }
        public bool posicaoValida(Posicao pos)
        {
            if(pos._linha < 0 || pos._linha >= _linhas || pos._coluna < 0 || pos._coluna >= _colunas) { return false; }
            else { return true; }
        }
        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida!!");
            }
        }
    }
}
