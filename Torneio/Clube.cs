using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torneio
{
    internal class Clube
    {
        private int idClube;
        private string nomeClube;
        private int pontos;

        public int IdClube { get => idClube; set => idClube = value; }
        public string NomeClube { get => nomeClube; set => nomeClube = value; }
        public int Pontos { get => pontos; set => pontos = value; }
    }
}
