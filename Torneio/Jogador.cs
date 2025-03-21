using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torneio
{
    internal class Jogador
    {
        private int idJogador;
        private string nomeJogador;
        private Clube clubeJogador;

        public int IdJogador { get => idJogador; set => idJogador = value; }
        public string NomeJogador { get => nomeJogador; set => nomeJogador = value; }
        public Clube ClubeJogador { get => clubeJogador; set => clubeJogador = value; }
    }
}
