using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Gestão_de_Campeonato_de_eSports.Modelo;

namespace Gestão_de_Campeonato_de_eSports
{
    public static class GestorJson
    {
        private static readonly JsonSerializerOptions Opcoes = new JsonSerializerOptions { WriteIndented = true };

        public static void ExportarParaJson<T>(List<T> dados, string caminhoFicheiro)
        {
            string json = JsonSerializer.Serialize(dados, Opcoes);
            File.WriteAllText(caminhoFicheiro, json);
        }

        public static List<T> ImportarDeJson<T>(string caminhoFicheiro)
        {
            if (!File.Exists(caminhoFicheiro))
                return new List<T>();

            string json = File.ReadAllText(caminhoFicheiro);
            return string.IsNullOrWhiteSpace(json)
                ? new List<T>()
                : JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }

        public static List<CampeonatoMock> ImportarCampeonatos() => ImportarDeJson<CampeonatoMock>("campeonatos.json");
        public static List<TorneioMock> ImportarTorneios() => ImportarDeJson<TorneioMock>("torneios.json");
        public static List<EquipaMock> ImportarEquipas() => ImportarDeJson<EquipaMock>("equipas.json");

        public static void AdicionarEquipa(EquipaMock nova)
        {
            var lista = ImportarEquipas();
            lista.Add(nova);
            ExportarParaJson(lista, "equipas.json");
        }

        public static void EditarEquipa(EquipaMock editada)
        {
            var lista = ImportarEquipas();
            var eq = lista.FirstOrDefault(x => x.Id == editada.Id);
            if (eq == null) throw new Exception("Equipa com esse ID não encontrada!");

            eq.Nome = editada.Nome;
            eq.Pais = editada.Pais;
            ExportarParaJson(lista, "equipas.json");
        }

        public static void RemoverEquipa(int id)
        {
            var lista = ImportarEquipas();
            var eq = lista.FirstOrDefault(x => x.Id == id);
            if (eq == null) throw new Exception("Equipa com esse ID não encontrada!");

            lista.Remove(eq);
            ExportarParaJson(lista, "equipas.json");
        }

        public static List<Jogares> ImportarJogadores() => ImportarDeJson<Jogares>("jogadores.json");

        public static void ExportarJogadores(List<Jogares> lista = null)
        {
            ExportarParaJson(lista ?? DadosGlobais.Jogadores, "jogadores.json");
        }

        public static List<Jogares> SincronizarJogadores(List<Jogares> listaMemoria = null)
        {
            var doFicheiro = ImportarJogadores();
            if (listaMemoria != null)
            {
                foreach (var j in listaMemoria)
                {
                    if (!doFicheiro.Any(x => x.Id == j.Id))
                        doFicheiro.Add(j);
                }
            }
            DadosGlobais.Jogadores = doFicheiro;
            ExportarParaJson(doFicheiro, "jogadores.json");
            return doFicheiro;
        }

        public static void AdicionarJogador(Jogares novo)
        {
            var lista = ImportarJogadores();
            lista.Add(novo);
            ExportarParaJson(lista, "jogadores.json");
        }

        public static void EditarJogador(Jogares editado)
        {
            var lista = ImportarJogadores();
            var jog = lista.FirstOrDefault(x => x.Id == editado.Id);
            if (jog == null) throw new Exception("Jogador com esse ID não encontrado!");

            jog.Nome = editado.Nome;
            jog.Nickname = editado.Nickname;
            jog.Idade = editado.Idade;
            jog.Pontuacoes = editado.Pontuacoes ?? new List<int>();
            ExportarParaJson(lista, "jogadores.json");
        }

        public static void RemoverJogador(int id)
        {
            var lista = ImportarJogadores();
            var jog = lista.FirstOrDefault(x => x.Id == id);
            if (jog == null) throw new Exception("Jogador com esse ID não encontrado!");

            lista.Remove(jog);
            ExportarParaJson(lista, "jogadores.json");
        }

        public static List<Partidas> ImportarPartidas() => ImportarDeJson<Partidas>("partidas.json");

        public static void AdicionarPartida(Partidas nova)
        {
            var lista = ImportarPartidas();
            if (lista.Any(p => p.Id == nova.Id))
                throw new Exception("Já existe uma partida com este ID!");

            lista.Add(nova);
            ExportarParaJson(lista, "partidas.json");
        }
    }
}