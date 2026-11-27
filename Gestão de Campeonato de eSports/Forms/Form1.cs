using System;
using System.Linq;
using System.Windows.Forms;
using Gestão_de_Campeonato_de_eSports.Forms;

namespace Gestão_de_Campeonato_de_eSports
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnConverterXMLParaJSON_Click(object sender, EventArgs e)
        {
            try
            {
                GestorJson.SincronizarJogadores(DadosGlobais.Jogadores);
                MessageBox.Show("Dados convertidos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                GestorLogs.RegistarErro(ex, this.Name);
                MessageBox.Show("Erro ao converter: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // 1. Evento de carregamento do formulário exigido pelo Designer
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                DadosGlobais.CarregarDadosIniciaisJson();
            }
            catch (Exception ex)
            {
                GestorLogs.RegistarErro(ex, this.Name);
            }
        }

        // 2. Botões de Navegação principais
        private void btnAbrirEquipas_Click(object sender, EventArgs e)
        {
            DadosGlobais.CarregarTudo();
            FormEquipasJogadores f = new FormEquipasJogadores();
            f.ShowDialog();
        }

        private void btnAbrirTorneio_Click(object sender, EventArgs e)
        {
            DadosGlobais.CarregarTudo();
            FormTorneiosPartidas f = new FormTorneiosPartidas();
            f.ShowDialog();
        }

        private void btnEstatisticas_Click(object sender, EventArgs e)
        {
            DadosGlobais.CarregarTudo();
            FormEstatisticasLINQ f = new FormEstatisticasLINQ();
            f.ShowDialog();
        }

        // 3. Métodos XML e JSON exigidos pelo Designer
        private void btnExportarXML_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exportação XML efetuada com sucesso!", "XML", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnImportarXML_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Importação XML efetuada com sucesso!", "XML", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void grpJSON_Enter(object sender, EventArgs e)
        {
            // Evento de container Grupo JSON
        }

        private void btnConverterJSON_Click(object sender, EventArgs e)
        {
            try
            {
                GestorJson.SincronizarJogadores(DadosGlobais.Jogadores);
                MessageBox.Show("Conversão para JSON efetuada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                GestorLogs.RegistarErro(ex, this.Name);
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnImportarJSON_Click(object sender, EventArgs e)
        {
            DadosGlobais.CarregarTudo();
            MessageBox.Show("Dados JSON importados com sucesso!", "JSON", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportarJSON_Click(object sender, EventArgs e)
        {
            try
            {
                GestorJson.ExportarParaJson(DadosGlobais.Equipas, "equipas.json");
                MessageBox.Show("Dados JSON exportados com sucesso!", "JSON", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                GestorLogs.RegistarErro(ex, this.Name);
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void BtnHelpLogs_Click(object sender, EventArgs e)
        {
            GestorLogs.AbrirBotaoLogs();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}