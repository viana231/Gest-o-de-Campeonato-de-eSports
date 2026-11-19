using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Campeonato_de_eSports.Modelo
{
    public class Jogador
    {
            public int Id { get; set; }
            public string Nome { get; set; } = "";
            public string Nickname { get; set; } = "";
            public int Idade { get; set; }
           public List<int> Pontuacoes { get; set; } = new List<int>();

    }
}
