using System.Collections.Generic;
using Gestão_de_Campeonato_de_eSports.Modelo;

namespace Gestão_de_Campeonato_de_eSports
{
    public static class DadosGlobais
    {
        public static List<CampeonatoMock> Campeonatos { get; set; } = new List<CampeonatoMock>();
        public static List<EquipaMock> Equipas { get; set; } = new List<EquipaMock>();
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