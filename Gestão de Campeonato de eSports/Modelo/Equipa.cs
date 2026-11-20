using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Campeonato_de_eSports.Modelo
{
    public class Equipa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Pais { get; set; }
        public List<Jogador> Jogadores { get; set; }

        public Equipa()
        {
            Jogadores = new List<Jogador>();
        }

        public Equipa(int id, string nome, string pais)
        {
            Id = id;
            Nome = nome;
            Pais = pais;
            Jogadores = new List<Jogador>();
        }
    }
}
