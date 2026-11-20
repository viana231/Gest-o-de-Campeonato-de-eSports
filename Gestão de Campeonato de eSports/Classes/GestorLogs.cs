using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Gestão_de_Campeonato_de_eSports
{
    public static class GestorLogs
    {
        private static readonly string CaminhoLogGeral = "logs_erros.txt";
        private static readonly string CaminhoLogFiltrado = "logs_filtrados.txt";
        public static void RegistarErro(Exception ex, string origem = "Sistema")
        {
            try
            {
                string dataAtual = DateTime.Now.ToString("dd/MM/yyyy");
                string horaAtual = DateTime.Now.ToString("HH:mm:ss");
                string nomeFormAtivo = Form.ActiveForm != null ? Form.ActiveForm.Name : origem;

                string linhaLog = $"[{dataAtual}] [{horaAtual}] [Origem: {nomeFormAtivo}] ERRO: {ex.Message} | Detalhe: {ex.TargetSite}{Environment.NewLine}";

                File.AppendAllText(CaminhoLogGeral, linhaLog);
            }
            catch
            {
            }
        }

        
        public static void AbrirLogsPorData(DateTime dataEscolhida)
        {
            if (!File.Exists(CaminhoLogGeral))
            {
                File.WriteAllText(CaminhoLogGeral, "");
            }

            string dataFiltro = $"[{dataEscolhida:dd/MM/yyyy}]";
            string[] todasAsLinhas = File.ReadAllLines(CaminhoLogGeral);

            List<string> linhasFiltradas = todasAsLinhas
                .Where(linha => linha.StartsWith(dataFiltro))
                .ToList();

            if (linhasFiltradas.Count == 0)
            {
                linhasFiltradas.Add($"Nenhum erro registado na aplicação na data {dataEscolhida:dd/MM/yyyy}.");
            }

            File.WriteAllLines(CaminhoLogFiltrado, linhasFiltradas);
            Process.Start("notepad.exe", CaminhoLogFiltrado);
        }
    }
}