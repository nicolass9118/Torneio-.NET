using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torneio
{
    internal class Gol
    {
        private int idGol;
        private string tempoGol;
        private Jogador jogadorGol;
        private Jogo jogoGol;

        public int IdGol { get => idGol; set => idGol = value; }
        public string TempoGol { get => tempoGol; set => tempoGol = value; }
        public Jogador JogadorGol { get => jogadorGol; set => jogadorGol = value; }
        public Jogo JogoGol { get => jogoGol; set => jogoGol = value; }
    }
}
