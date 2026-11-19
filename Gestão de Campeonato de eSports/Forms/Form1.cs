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
                    MessageBox.Show($"Ocorreu um erro ao importar:\n{ex.Message}",
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show($"Ocorreu um erro ao exportar:\n{ex.Message}",
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnConverterJSON_Click(object sender, EventArgs e)
        {
        }
    }
}
