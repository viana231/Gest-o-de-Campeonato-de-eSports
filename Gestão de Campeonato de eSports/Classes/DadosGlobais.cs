using System.Collections.Generic;
using Gestão_de_Campeonato_de_eSports.Modelo;

namespace Gestão_de_Campeonato_de_eSports
{
    public static class DadosGlobais
    {
        public static List<CampeonatoMock> Campeonatos { get; set; } = new List<CampeonatoMock>();
        public static List<TorneioMock> Torneios { get; set; } = new List<TorneioMock>();
        public static List<EquipaMock> Equipas { get; set; } = new List<EquipaMock>();
        public static List<Jogares> Jogadores { get; set; } = new List<Jogares>();
        public static List<Partidas> Partidas { get; set; } = new List<Partidas>();

        public static void CarregarTudo()
        {
            Campeonatos = GestorJson.ImportarCampeonatos();
            Torneios = GestorJson.ImportarTorneios();
            Equipas = GestorJson.ImportarEquipas();
            Jogadores = GestorJson.ImportarJogadores();
            Partidas = GestorJson.ImportarPartidas();

            if (Campeonatos.Count == 0)
            {
                Campeonatos.Add(new CampeonatoMock { Id = 1, Nome = "Campeonato Nacional eSports" });
                GestorJson.ExportarParaJson(Campeonatos, "campeonatos.json");
            }
        }

        public static void CarregarDadosIniciaisJson()
        {
            CarregarTudo();
        }
    }
}