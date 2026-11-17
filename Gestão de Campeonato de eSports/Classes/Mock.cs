using System.Collections.Generic;

public class JogadorMock
{
    public int Id { get; set; }
    public string Nome { get; set; }
}

public class EquipaMock
{
    public string NomeEquipa { get; set; }
    public List<JogadorMock> Jogadores { get; set; } = new List<JogadorMock>();
}