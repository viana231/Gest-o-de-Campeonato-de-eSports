using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Campeonato_de_eSports.Modelo
{
    public class Campeonato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Torneio> torneios  { get; set; }

        public Campeonato(int id, string nome)
        {
            torneios = new List<Torneio>();
        }
    }
}
