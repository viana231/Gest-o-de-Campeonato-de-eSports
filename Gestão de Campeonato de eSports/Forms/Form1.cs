using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Gestão_de_Campeonato_de_eSports.Forms;
using Gestão_de_Campeonato_de_eSports.Modelo;
using Gestão_de_Campeonato_de_eSports.XML;
using System.Xml.Linq;

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

        private void btnImportarXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Ficheiros XML (*.xml)|*.xml";
            openFileDialog.Title = "Selecionar ficheiro XML";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XMLManager gestor = new XMLManager();

                    XDocument documento = gestor.LerXML(openFileDialog.FileName);

                    if (gestor.ValidarXML(documento))
                    {
                        MessageBox.Show("Ficheiro XML importado e validado com sucesso!",
                            "Importação XML",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("O ficheiro XML não tem uma estrutura válida.",
                            "Erro de validação",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao importar XML: " + ex.Message,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnConverterXMLParaJSON_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Ficheiros XML (*.xml)|*.xml";
            openFileDialog.Title = "Selecionar ficheiro XML para converter";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoXML = openFileDialog.FileName;

                try
                {
                    XDocument documento = XDocument.Load(caminhoXML);

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Ficheiros JSON (*.json)|*.json";
                    saveFileDialog.FileName = "campeonatos.json";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var dados = System.Xml.Linq.XDocument.Parse(documento.ToString());

                        var json = System.Text.Json.JsonSerializer.Serialize(
                            dados.Root.ToString(),
                            new System.Text.Json.JsonSerializerOptions
                            {
                                WriteIndented = true
                            });

                        File.WriteAllText(saveFileDialog.FileName, json);

                        MessageBox.Show("Conversão de XML para JSON concluída!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na conversão: " + ex.Message);
                }
            }
        }

        private void btnExportarXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Ficheiros XML (*.xml)|*.xml";
            saveFileDialog.Title = "Guardar ficheiro XML";
            saveFileDialog.FileName = "campeonatos.xml";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XDocument documento = new XDocument(
                        new XElement("Campeonatos",
                            new XElement("Campeonato",
                                new XElement("Id", 1),
                                new XElement("Nome", "Liga Nacional eSports"),
                                new XElement("Ano", 2026),
                                new XElement("Torneios")
                            )
                        )
                    );

                    documento.Save(saveFileDialog.FileName);

                    MessageBox.Show("Ficheiro XML exportado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao exportar XML: " + ex.Message);
                }
            }
        }

        private void grpJSON_Enter(object sender, EventArgs e)
        {

        }
    }
}