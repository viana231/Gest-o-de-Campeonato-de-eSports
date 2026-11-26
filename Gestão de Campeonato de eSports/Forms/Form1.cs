using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Gestão_de_Campeonato_de_eSports.Forms;
using Gestão_de_Campeonato_de_eSports.Modelo;

namespace Gestão_de_Campeonato_de_eSports
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

            // Liga o botão Abrir Linq que ainda não tinha evento no Designer
            this.btnAbrirLinq.Click += new EventHandler(this.btnAbrirLinq_Click);
        }

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

        private void btnImportarJSON_Click(object sender, EventArgs e)
        {
            ofdFicheiro.Filter = "Ficheiros JSON (*.json)|*.json";
            ofdFicheiro.Title = "Importar e Sincronizar Jogadores (JSON)";

            if (ofdFicheiro.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int novos = GestorJson.SincronizarJogadores(DadosGlobais.Jogadores, ofdFicheiro.FileName);
                    GestorJson.ExportarJogadores(DadosGlobais.Jogadores);

                    MessageBox.Show($"Sincronização concluída!\nAdicionados {novos} novos jogadores.\nTotal em memória: {DadosGlobais.Jogadores.Count}",
                                    "Importar JSON", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    GestorLogs.RegistarErro(ex, this.Name);
                    MessageBox.Show(ex.Message, "Erro ao Importar JSON", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExportarJSON_Click(object sender, EventArgs e)
        {
            sfdFicheiro.Filter = "Ficheiros JSON (*.json)|*.json";
            sfdFicheiro.Title = "Exportar Jogadores para JSON";
            sfdFicheiro.FileName = "jogadores_exportados.json";

            if (sfdFicheiro.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    GestorJson.ExportarParaJson(DadosGlobais.Jogadores, sfdFicheiro.FileName);
                    MessageBox.Show("Dados exportados com sucesso para JSON!", "Exportar JSON", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    GestorLogs.RegistarErro(ex, this.Name);
                    MessageBox.Show(ex.Message, "Erro ao Exportar JSON", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnConverterJSON_Click(object sender, EventArgs e)
        {
            ofdFicheiro.Filter = "Ficheiros JSON (*.json)|*.json";
            ofdFicheiro.Title = "Escolher JSON para converter em XML";

            if (ofdFicheiro.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var lista = GestorJson.ImportarDeJson<List<Jogador>>(ofdFicheiro.FileName);
                    string caminhoXml = Path.ChangeExtension(ofdFicheiro.FileName, ".xml");

                    XmlSerializer serializer = new XmlSerializer(typeof(List<Jogador>));
                    using (StreamWriter writer = new StreamWriter(caminhoXml))
                    {
                        serializer.Serialize(writer, lista);
                    }

                    MessageBox.Show($"Ficheiro convertido para XML com sucesso:\n{caminhoXml}", "Conversão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    GestorLogs.RegistarErro(ex, this.Name);
                    MessageBox.Show(ex.Message, "Erro ao Converter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAbrirEquipas_Click(object sender, EventArgs e)
        {
            FormEquipasJogadores frm = new FormEquipasJogadores();
            frm.ShowDialog();
        }

        private void btnAbrirTorneio_Click(object sender, EventArgs e)
        {
            FormTorneiosPartidas frm = new FormTorneiosPartidas();
            frm.ShowDialog();
        }

        private void btnAbrirLinq_Click(object sender, EventArgs e)
        {
            FormEstatisticasLINQ frm = new FormEstatisticasLINQ();
            frm.ShowDialog();
        }

        private void BtnHelpLogs_Click(object sender, EventArgs e)
        {
            GestorLogs.AbrirBotaoLogs();
        }
    }
}