using Gestão_de_Campeonato_de_eSports.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json; 

public static class GestorJson
{
    public static void ExportarParaJson<T>(T dados, string caminhoFicheiro)
    {
        try
        {
            var opcoes = new JsonSerializerOptions { WriteIndented = true, PropertyNameCaseInsensitive = true };
            string jsonString = JsonSerializer.Serialize(dados, opcoes);
            File.WriteAllText(caminhoFicheiro, jsonString);
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao guardar o ficheiro: {ex.Message}");
        }
    }

    public static T ImportarDeJson<T>(string caminhoFicheiro)
    {
        if (!File.Exists(caminhoFicheiro))
            return default(T); 

        try
        {
            string jsonString = File.ReadAllText(caminhoFicheiro);
            var opcoes = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            return JsonSerializer.Deserialize<T>(jsonString, opcoes);
        }
        catch (JsonException)
        {
            throw new Exception("Erro: O ficheiro JSON está corrompido ou tem um formato inválido.");
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro inesperado ao ler: {ex.Message}");
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
                throw new Exception($"Não foi possível sincronizar. {ex.Message}");
            }
        }

        listaAtual.Add(novoItem);

        ExportarParaJson(listaAtual, caminhoFicheiro);
    }

    internal static List<EquipaMock> ImportarEquipas()
    {
        throw new NotImplementedException();
    }

    internal static List<Jogador> ImportarJogadores()
    {
        throw new NotImplementedException();
    }

    internal static List<Partida> ImportarPartidas()
    {
        throw new NotImplementedException();
    }
}



