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

                string linhaLog = $"[{dataAtual}] [{horaAtual}] [Form: {nomeFormAtivo}] ERRO: {ex.Message} | Detalhe: {ex.TargetSite}{Environment.NewLine}";
                File.AppendAllText(CaminhoLogGeral, linhaLog);
            }
            catch
            {
            }
        }

        /// <summary>
        /// Abre uma pequena janela de filtro de data (Dia/Mês/Ano) e abre logo o TXT filtrado.
        /// </summary>
        public static void AbrirBotaoLogs()
        {
            using (Form popupFiltro = new Form())
            {
                popupFiltro.Text = "Filtrar Logs de Erro";
                popupFiltro.Width = 280;
                popupFiltro.Height = 160;
                popupFiltro.StartPosition = FormStartPosition.CenterParent;
                popupFiltro.FormBorderStyle = FormBorderStyle.FixedDialog;
                popupFiltro.MaximizeBox = false;
                popupFiltro.MinimizeBox = false;

                Label lbl = new Label { Text = "Escolhe a data (Dia/Mês/Ano):", Left = 20, Top = 15, Width = 220 };
                DateTimePicker dtp = new DateTimePicker
                {
                    Left = 20,
                    Top = 40,
                    Width = 220,
                    Format = DateTimePickerFormat.Custom,
                    CustomFormat = "dd/MM/yyyy"
                };

                Button btnAbrirTxt = new Button
                {
                    Text = "Abrir TXT",
                    Left = 75,
                    Top = 80,
                    Width = 110,
                    DialogResult = DialogResult.OK
                };

                popupFiltro.Controls.Add(lbl);
                popupFiltro.Controls.Add(dtp);
                popupFiltro.Controls.Add(btnAbrirTxt);
                popupFiltro.AcceptButton = btnAbrirTxt;

                if (popupFiltro.ShowDialog() == DialogResult.OK)
                {
                    AbrirLogsPorData(dtp.Value);
                }
            }
        }

        private static void AbrirLogsPorData(DateTime dataEscolhida)
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