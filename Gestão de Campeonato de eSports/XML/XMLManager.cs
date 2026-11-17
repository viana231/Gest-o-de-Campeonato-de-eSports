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
