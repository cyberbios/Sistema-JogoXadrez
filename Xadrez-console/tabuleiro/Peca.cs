using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace tabuleiro
{
    class Peca
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
    }
}
