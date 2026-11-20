using System.Collections.Generic;
using Gestão_de_Campeonato_de_eSports.Modelo;

namespace Gestão_de_Campeonato_de_eSports
{
    public static class DadosGlobais
    {
        public static List<Campeonato> Campeonatos { get; set; } = new List<Campeonato>();
        public static List<Torneio> Torneios { get; set; } = new List<Torneio>();
        public static List<Equipa> Equipas { get; set; } = new List<Equipa>();
        public static List<Jogador> Jogadores { get; set; } = new List<Jogador>();
        public static List<Partida> Partidas { get; set; } = new List<Partida>();
        public static void CarregarDadosIniciaisJson()
        {
            Equipas = GestorJson.ImportarEquipas();
            Jogadores = GestorJson.ImportarJogadores();
            Partidas = GestorJson.ImportarPartidas();
            Campeonatos = GestorJson.ImportarDeJson<List<CampeonatoMock>>("campeonatos.json") ?? new List<CampeonatoMock>();
        }
    }
}