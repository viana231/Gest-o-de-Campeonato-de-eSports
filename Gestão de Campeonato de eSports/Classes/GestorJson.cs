using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Gestão_de_Campeonato_de_eSports.Modelo;

namespace Gestão_de_Campeonato_de_eSports
{
    public static class GestorJson
    {
        private static readonly JsonSerializerOptions OpcoesJson = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true
        };

        #region Métodos Genéricos (Base do Módulo)

        public static void ExportarParaJson<T>(T dados, string caminhoFicheiro)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(dados, OpcoesJson);
                File.WriteAllText(caminhoFicheiro, jsonString);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao guardar ficheiro JSON ({caminhoFicheiro}): {ex.Message}");
            }
        }

        public static T ImportarDeJson<T>(string caminhoFicheiro)
        {
            if (!File.Exists(caminhoFicheiro))
            {
                return default(T);
            }

            try
            {
                string jsonString = File.ReadAllText(caminhoFicheiro);

                if (string.IsNullOrWhiteSpace(jsonString))
                {
                    return default(T);
                }

                return JsonSerializer.Deserialize<T>(jsonString, OpcoesJson);
            }
            catch (JsonException)
            {
                throw new Exception($"O ficheiro '{caminhoFicheiro}' está corrompido ou contém formato JSON inválido.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao ler ficheiro JSON ({caminhoFicheiro}): {ex.Message}");
            }
        }

        public static void AdicionarItemAListaJson<T>(T novoItem, string caminhoFicheiro)
        {
            List<T> listaAtual = new List<T>();

            if (File.Exists(caminhoFicheiro))
            {
                try
                {
                    listaAtual = ImportarDeJson<List<T>>(caminhoFicheiro) ?? new List<T>();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Não foi possível sincronizar os dados. {ex.Message}");
                }
            }

            listaAtual.Add(novoItem);
            ExportarParaJson(listaAtual, caminhoFicheiro);
        }

        #endregion

        #region Métodos Específicos do Domínio (Partidas, Jogadores e Equipas)

        public static List<Partida> ImportarPartidas(string caminho = "partidas.json")
        {
            return ImportarDeJson<List<Partida>>(caminho) ?? new List<Partida>();
        }

        public static void ExportarPartidas(List<Partida> partidas, string caminho = "partidas.json")
        {
            ExportarParaJson(partidas, caminho);
        }

        public static void AdicionarPartida(Partida novaPartida, string caminho = "partidas.json")
        {
            AdicionarItemAListaJson(novaPartida, caminho);
        }

        public static List<Jogador> ImportarJogadores(string caminho = "jogadores.json")
        {
            return ImportarDeJson<List<Jogador>>(caminho) ?? new List<Jogador>();
        }

        public static void ExportarJogadores(List<Jogador> jogadores, string caminho = "jogadores.json")
        {
            ExportarParaJson(jogadores, caminho);
        }

        public static void AdicionarJogador(Jogador novoJogador, string caminho = "jogadores.json")
        {
            AdicionarItemAListaJson(novoJogador, caminho);
        }

        public static void EditarJogador(Jogador jogadorEditado, string caminho = "jogadores.json")
        {
            var lista = ImportarJogadores(caminho);
            int index = lista.FindIndex(j => j.Id == jogadorEditado.Id);

            if (index != -1)
            {
                lista[index] = jogadorEditado;
                ExportarJogadores(lista, caminho);
            }
        }

        public static void RemoverJogador(int idJogador, string caminho = "jogadores.json")
        {
            var lista = ImportarJogadores(caminho);
            lista.RemoveAll(j => j.Id == idJogador);
            ExportarJogadores(lista, caminho);
        }

        public static int SincronizarJogadores(List<Jogador> listaEmMemoria, string caminhoFicheiro)
        {
            var jogadoresDoJson = ImportarDeJson<List<Jogador>>(caminhoFicheiro);
            if (jogadoresDoJson == null) return 0;

            int adicionados = 0;

            foreach (var j in jogadoresDoJson)
            {
                bool dadosValidos = j.Id > 0 &&
                                    !string.IsNullOrWhiteSpace(j.Nome) &&
                                    !string.IsNullOrWhiteSpace(j.Nickname) &&
                                    j.Idade >= 15;

                bool jaExiste = listaEmMemoria.Exists(existente => existente.Id == j.Id);

                if (dadosValidos && !jaExiste)
                {
                    listaEmMemoria.Add(j);
                    adicionados++;
                }
            }

            return adicionados;
        }

        public static List<EquipaMock> ImportarEquipas(string caminho = "equipas.json")
        {
            return ImportarDeJson<List<EquipaMock>>(caminho) ?? new List<EquipaMock>();
        }

        public static void ExportarEquipas(List<EquipaMock> equipas, string caminho = "equipas.json")
        {
            ExportarParaJson(equipas, caminho);
        }

        public static void AdicionarEquipa(EquipaMock novaEquipa, string caminho = "equipas.json")
        {
            AdicionarItemAListaJson(novaEquipa, caminho);
        }

        public static void EditarEquipa(EquipaMock equipaEditada, string caminho = "equipas.json")
        {
            var lista = ImportarEquipas(caminho);
            int index = lista.FindIndex(eq => eq.Id == equipaEditada.Id);

            if (index != -1)
            {
                lista[index] = equipaEditada;
                ExportarEquipas(lista, caminho);
            }
        }

        public static void RemoverEquipa(int idEquipa, string caminho = "equipas.json")
        {
            var lista = ImportarEquipas(caminho);
            lista.RemoveAll(eq => eq.Id == idEquipa);
            ExportarEquipas(lista, caminho);
        }

        #endregion
    }
}