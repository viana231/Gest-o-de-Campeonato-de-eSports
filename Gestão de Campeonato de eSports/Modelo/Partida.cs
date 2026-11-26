using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Campeonato_de_eSports.Modelo
{
    public class Partida
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int IdEquipaA { get; set; }
        public int IdEquipaB { get; set; }
        public int ResultadoA { get; set; }
        public int ResultadoB { get; set; }

        public Partida()
        {
        }

        public Partida(int id, DateTime data, int idEquipaA, int idEquipaB,
               int resultadoA, int resultadoB)
        {
            Id = id;
            Data = data;
            IdEquipaA = idEquipaA;
            IdEquipaB = idEquipaB;
            ResultadoA = resultadoA;
            ResultadoB = resultadoB;
        }
    }
}
