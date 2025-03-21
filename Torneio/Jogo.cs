using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torneio
{
    internal class Jogo
    {
        private int idJogo;
        private Clube clubeCasa;
        private Clube clubeFora;

        public int IdJogo { get => idJogo; set => idJogo = value; }
        public Clube ClubeCasa { get => clubeCasa; set => clubeCasa = value; }
        public Clube ClubeFora { get => clubeFora; set => clubeFora = value; }
    }
}
