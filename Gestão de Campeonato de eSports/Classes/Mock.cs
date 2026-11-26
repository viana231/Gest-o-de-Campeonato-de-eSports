using System.Collections.Generic;
using Gestão_de_Campeonato_de_eSports.Modelo;

namespace Gestão_de_Campeonato_de_eSports
{
    public class CampeonatoMock
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public List<TorneioMock> Torneios { get; set; } = new List<TorneioMock>();
    }

    public class TorneioMock
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public string Jogo { get; set; } = "";
        public List<EquipaMock> Equipas { get; set; } = new List<EquipaMock>();
        public List<Partida> Partidas { get; set; } = new List<Partida>();
    }

    public class EquipaMock
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public string Pais { get; set; } = "";
        public List<Jogador> Jogadores { get; set; } = new List<Jogador>();
    }
}