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
        public void colocarPeca(Peca p, Posicao pos)
        {
            _pecas[pos._linha, pos._coluna] = p;
            p._posicao = pos;
        }
    }
}
