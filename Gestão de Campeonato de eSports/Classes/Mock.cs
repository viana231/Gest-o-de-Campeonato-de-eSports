using System.Collections.Generic;
using Gestão_de_Campeonato_de_eSports.Modelo;

namespace Gestão_de_Campeonato_de_eSports
{
    public class EquipaMock
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public string Pais { get; set; } = "";
        public List<Jogador> Jogadores { get; set; } = new List<Jogador>();
    }
}