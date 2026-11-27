using System;
using System.Collections.Generic;

namespace Gestão_de_Campeonato_de_eSports.Modelo
{
    public class CampeonatoMock
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<TorneioMock> Torneios { get; set; } = new List<TorneioMock>();
    }

    public class TorneioMock
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Jogo { get; set; }
        public List<EquipaMock> Equipas { get; set; } = new List<EquipaMock>();
        public List<Partidas> Partidas { get; set; } = new List<Partidas>();
    }

    public class EquipaMock
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Pais { get; set; }
        public List<Jogares> Jogadores { get; set; } = new List<Jogares>();
    }

    public class Jogares
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Nickname { get; set; }
        public int Idade { get; set; }
        public List<int> Pontuacoes { get; set; } = new List<int>();
    }

    public class Partidas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int IdEquipaA { get; set; }
        public int IdEquipaB { get; set; }
        public int ResultadoA { get; set; }
        public int ResultadoB { get; set; }
    }
}