using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Gestão_de_Campeonato_de_eSports.XML
{
    public class XMLManager
    {
        // Ler o ficheiro XML
        public XDocument LerXML(string caminho)
        {
            try
            {
                XDocument documento = XDocument.Load(caminho);
                return documento;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao ler o ficheiro XML: " + ex.Message);
            }
        }

        // Guardar o ficheiro XML
        public void GuardarXML(XDocument documento, string caminho)
        {
            try
            {
                documento.Save(caminho);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao guardar o ficheiro XML: " + ex.Message);
            }
        }

        // Validar a estrutura do ficheiro XML
        public bool ValidarXML(XDocument documento)
        {
            if (documento == null || documento.Root == null)
                return false;

            if (documento.Root.Name != "Campeonatos")
                return false;

            if (!documento.Root.Elements("Campeonato").Any())
                return false;

            foreach (XElement campeonato in documento.Root.Elements("Campeonato"))
            {
                if (campeonato.Element("Id") == null ||
                    campeonato.Element("Nome") == null ||
                    campeonato.Element("Ano") == null ||
                    campeonato.Element("Torneios") == null)
                    return false;
            }

            foreach (XElement torneio in documento.Descendants("Torneio"))
            {
                if (torneio.Element("Id") == null ||
                    torneio.Element("Nome") == null ||
                    torneio.Element("Jogo") == null ||
                    torneio.Element("Equipas") == null ||
                    torneio.Element("Partidas") == null)
                    return false;
            }

            foreach (XElement equipa in documento.Descendants("Equipa"))
            {
                if (equipa.Element("Id") == null ||
                    equipa.Element("Nome") == null ||
                    equipa.Element("Pais") == null ||
                    equipa.Element("Jogadores") == null)
                    return false;
            }

            foreach (XElement jogador in documento.Descendants("Jogador"))
            {
                if (jogador.Element("Id") == null ||
                    jogador.Element("Nome") == null ||
                    jogador.Element("Nickname") == null ||
                    jogador.Element("Idade") == null ||
                    jogador.Element("Pontuacoes") == null)
                    return false;
            }

            return true;
        }

        // Adicionar uma equipa
        public void AdicionarEquipa(XDocument documento, XElement novaEquipa)
        {
            XElement equipas = documento.Descendants("Equipas").FirstOrDefault();

            if (equipas != null)
            {
                equipas.Add(novaEquipa);
            }
        }

        // Alterar o nome de uma equipa
        public void AlterarNomeEquipa(XDocument documento, int id, string novoNome)
        {
            XElement equipa = documento.Descendants("Equipa")
                .FirstOrDefault(e => (int)e.Element("Id") == id);

            if (equipa != null)
            {
                equipa.Element("Nome").Value = novoNome;
            }
        }

        // Adicionar um jogador
        public void AdicionarJogador(XDocument documento, int idEquipa, XElement novoJogador)
        {
            XElement equipa = documento.Descendants("Equipa")
                .FirstOrDefault(e => (int)e.Element("Id") == idEquipa);

            if (equipa != null)
            {
                XElement jogadores = equipa.Element("Jogadores");

                if (jogadores != null)
                {
                    jogadores.Add(novoJogador);
                }
            }
        }

        // Alterar o nome de um jogador
        public void AlterarNomeJogador(XDocument documento, int id, string novoNome)
        {
            XElement jogador = documento.Descendants("Jogador")
                .FirstOrDefault(j => (int)j.Element("Id") == id);

            if (jogador != null)
            {
                jogador.Element("Nome").Value = novoNome;
            }
        
        }



        // Alterar o nickname de um jogador
        public void AlterarNicknameJogador(XDocument documento, int id, string novoNickname)
        {
            XElement jogador = documento.Descendants("Jogador")
                .FirstOrDefault(j => (int)j.Element("Id") == id);

            if (jogador != null)
            {
                jogador.Element("Nickname").Value = novoNickname;
            }
        }

        // Eliminar uma equipa
        public void EliminarEquipa(XDocument documento, int id)
        {
            XElement equipa = documento.Descendants("Equipa")
                .FirstOrDefault(e => (int)e.Element("Id") == id);

            if (equipa != null)
            {
                equipa.Remove();
            }
        }

        // Eliminar um jogador
        public void EliminarJogador(XDocument documento, int id)
        {
            XElement jogador = documento.Descendants("Jogador")
                .FirstOrDefault(j => (int)j.Element("Id") == id);

            if (jogador != null)
            {
                jogador.Remove();
            }
        }
    }
}
