using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Campeonato_de_eSports.Modelo
{
    public class Torneio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Equipa> Equipas { get; set; }
        public Torneio(int id, string nome)
        {
            Equipas = new List<Equipa>();
        }
    }
}
