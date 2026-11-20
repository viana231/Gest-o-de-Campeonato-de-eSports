using System.Collections.Generic;
using System.Text.Json.Serialization;
public class JogadorMock
{
    public int Id { get; set; }
    public string Nome { get; set; }
}

public class EquipaMock
{
    [JsonPropertyName("nome_equipa")]
    public string NomeEquipa { get; set; }

    [JsonPropertyName("jogadores_lista")]
    public List<JogadorMock> Jogadores { get; set; } = new List<JogadorMock>();
}