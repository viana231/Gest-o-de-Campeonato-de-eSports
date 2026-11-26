using System.Collections.Generic;
        
namespace Gestão_de_Campeonato_de_eSports.Modelo
{
    public class Torneio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Jogo { get; set; }
        public List<Equipa> Equipas { get; set; }
        public List<Partida> Partidas { get; set; }

        public Torneio()
        {
            Nome = "";
            Jogo = "";
            Equipas = new List<Equipa>();
            Partidas = new List<Partida>();
        }

        public Torneio(int id, string nome)
        {
            Id = id;
            Nome = nome;
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