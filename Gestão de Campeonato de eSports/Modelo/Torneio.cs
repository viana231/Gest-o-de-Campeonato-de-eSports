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
        public string Jogo { get; set; }
        public List<Equipa> Equipas { get; set; }
        public List<Partida> Partidas { get; set; }

        // construtor vazio (o JSON precisa dele)
        public Torneio(int id, string nome)
        {
            Equipas = new List<Equipa>();
            Partidas = new List<Partida>();
        }
  

        public Torneio(int id, string nome, string jogo)
        
        {
            Id = id;
            Nome = nome;
            Jogo = jogo;
            Equipas = new List<Equipa>();
            Partidas = new List<Partida>();
        }
    }
}
