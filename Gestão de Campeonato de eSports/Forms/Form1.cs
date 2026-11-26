using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

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
        }
        private void btnImportarJSON_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Ficheiros JSON (*.json)|*.json|Todos os ficheiros (*.*)|*.*";
            openFileDialog.Title = "Selecionar Ficheiro JSON para Importar";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string caminhoFicheiro = openFileDialog.FileName;
                    var dadosImportados = GestorJson.ImportarDeJson<List<EquipaMock>>(caminhoFicheiro);

                    if (dadosImportados != null)
                    {
                        MessageBox.Show($"Sucesso! Foram importadas {dadosImportados.Count} equipas do ficheiro JSON.",
                                        "Importação JSON", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    GestorLogs.RegistarErro(ex, this.Name);
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnExportarJSON_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Ficheiro JSON (*.json)|*.json";
            saveFileDialog.Title = "Guardar Dados em JSON";
            saveFileDialog.FileName = "meus_dados_esports.json"; 

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    var listaParaGuardar = new List<EquipaMock>
            {
                new EquipaMock { NomeEquipa = "Equipa A" },
                new EquipaMock { NomeEquipa = "Equipa B" }
            };

                    string caminhoFicheiro = saveFileDialog.FileName;
                    GestorJson.ExportarParaJson(listaParaGuardar, caminhoFicheiro);

                    MessageBox.Show("Ficheiro JSON guardado e exportado com sucesso!",
                                    "Exportação JSON", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    GestorLogs.RegistarErro(ex, this.Name);
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnConverterJSON_Click(object sender, EventArgs e)
        {
            string mensagem = "Para converter dados:\n\n" +
                              "1. Precisa de importar o ficheiro XML primeiro.\n" +
                              "2. Quando os dados do XML estiverem na memória do programa, " +
                              "o teu módulo JSON só tem de pegar nesses dados e usar a função 'Exportar'.\n\n" +
                              "Fica a aguardar a sincronização com o Membro 2!";

            MessageBox.Show(mensagem, "Módulo de Conversão", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void BtnHelpLogs_Click(object sender, EventArgs e)
        {
            GestorLogs.AbrirBotaoLogs();
        }

        private void btnAbrirEquipas_Click(object sender, EventArgs e)
        {
            FormEquipasJogadores formEquipas = new FormEquipasJogadores();
            formEquipas.Show();
        }

        private void btnAbrirTorneio_Click(object sender, EventArgs e)
        {
            FormTorneiosPartidas formEquipas = new FormTorneiosPartidas();
            formEquipas.Show();
        }

        private void btnImportarXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Ficheiros XML (*.xml)|*.xml|Todos os ficheiros (*.*)|*.*";
            openFileDialog.Title = "Selecionar ficheiro XML";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoFicheiro = openFileDialog.FileName;

                MessageBox.Show("Ficheiro selecionado: " + caminhoFicheiro);
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
    }
}
