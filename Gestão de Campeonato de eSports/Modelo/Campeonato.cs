using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Campeonato_de_eSports.Modelo
{
    public class Campeonato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }
        public List<Torneio> Torneios  { get; set; }

        // construtor vazio (o JSON precisa dele)
        public Campeonato()
        {
            Torneios = new List<Torneio>();
        }
        public Campeonato(int id, string nome, int ano)
        {
            Id = id;
            Nome = nome;
            Ano = ano;
            Torneios = new List<Torneio>();
        }
    }
}
