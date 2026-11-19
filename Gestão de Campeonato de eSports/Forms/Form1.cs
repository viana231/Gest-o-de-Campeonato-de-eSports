using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestão_de_Campeonato_de_eSports
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            btnExportarXML.Enabled = false;
            btnExportarJSON.Enabled = false;
            DadosGlobais.CarregarDadosIniciaisJson();
        
        }
        private void btnImportarJSON_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Ficheiros JSON (*.json)|*.json";
            openFileDialog.Title = "Importar e Sincronizar Jogadores (JSON)";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int novos = GestorJson.SincronizarJogadores(DadosGlobais.Jogadores, openFileDialog.FileName);

                    GestorJson.ExportarJogadores(DadosGlobais.Jogadores);

                    MessageBox.Show($"Sincronização concluída!\nForam validados e adicionados {novos} novos jogadores.\nTotal em memória: {DadosGlobais.Jogadores.Count}",
                                    "Sincronização JSON", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao Importar JSON", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnExportarJSON_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Ficheiros JSON (*.json)|*.json";
            saveFileDialog.Title = "Exportar Jogadores para JSON";
            saveFileDialog.FileName = "jogadores_exportados.json";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Se a memória estiver vazia, tenta primeiro carregar do ficheiro local
                    if (DadosGlobais.Jogadores.Count == 0)
                    {
                        DadosGlobais.Jogadores = GestorJson.ImportarJogadores();
                    }

                    GestorJson.ExportarParaJson(DadosGlobais.Jogadores, saveFileDialog.FileName);
                    MessageBox.Show("Dados exportados com sucesso para JSON!", "Exportação JSON", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao Exportar JSON", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnConverterJSON_Click(object sender, EventArgs e)
        {
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
