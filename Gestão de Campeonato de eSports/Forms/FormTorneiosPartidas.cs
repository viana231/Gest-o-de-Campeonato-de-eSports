using System;
using System.Linq;
using System.Windows.Forms;
using Gestão_de_Campeonato_de_eSports.Modelo;

namespace Gestão_de_Campeonato_de_eSports
{
    public partial class FormTorneiosPartidas : Form
    {
        public FormTorneiosPartidas()
        {
            InitializeComponent();
        }

        private void FormTorneiosPartidas_Load(object sender, EventArgs e)
        {
            AtualizarCombos();
            AtualizarTabelaPartidas();
        }

        private void AtualizarCombos()
        {
            // Combobox do Campeonato no topo
            cmbCampeonatos.DataSource = null;
            cmbCampeonatos.DataSource = DadosGlobais.Campeonatos;
            cmbCampeonatos.DisplayMember = "Nome";

            // Combobox do Torneio na secção de Inscrições
            cmbTorneio.DataSource = null;
            cmbTorneio.DataSource = DadosGlobais.Torneios.ToList();
            cmbTorneio.DisplayMember = "Nome";

            // Combobox das Equipas disponíveis para Inscrição e Partidas
            cmbEquipasDisp.DataSource = null;
            cmbEquipasDisp.DataSource = DadosGlobais.Equipas.ToList();
            cmbEquipasDisp.DisplayMember = "Nome";

            cmbEquipaA.DataSource = null;
            cmbEquipaA.DataSource = DadosGlobais.Equipas.ToList();
            cmbEquipaA.DisplayMember = "Nome";

            cmbEquipaB.DataSource = null;
            cmbEquipaB.DataSource = DadosGlobais.Equipas.ToList();
            cmbEquipaB.DisplayMember = "Nome";
        }

        // ==================== CRIAR TORNEIO ====================
        private void btnCriarTorneio_Click(object sender, EventArgs e)
        {
            try
            {
                int idTorneio = int.Parse(txtId.Text);
                if (DadosGlobais.Torneios.Any(t => t.Id == idTorneio))
                {
                    MessageBox.Show("Já existe um torneio com este ID!");
                    return;
                }

                TorneioMock novoTorneio = new TorneioMock
                {
                    Id = idTorneio,
                    Nome = txtNome.Text,
                    Jogo = txtJogo.Text
                };

                DadosGlobais.Torneios.Add(novoTorneio);
                GestorJson.ExportarParaJson(DadosGlobais.Torneios, "torneios.json");

                AtualizarCombos();
                MessageBox.Show("Torneio criado e guardado em JSON com sucesso!");
            }
            catch (Exception ex)
            {
                GestorLogs.RegistarErro(ex, this.Name);
                MessageBox.Show("Erro ao criar torneio: verifica se o ID é numérico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==================== INSCREVER EQUIPA ====================
        private void btnInscreverEquipa_Click(object sender, EventArgs e)
        {
            try
            {
                var torneioSelecionado = cmbTorneio.SelectedItem as TorneioMock;
                var equipaSelecionada = cmbEquipasDisp.SelectedItem as EquipaMock;

                if (torneioSelecionado == null || equipaSelecionada == null)
                {
                    MessageBox.Show("Seleciona um Torneio e uma Equipa primeiro!");
                    return;
                }

                if (torneioSelecionado.Equipas.Any(eq => eq.Id == equipaSelecionada.Id))
                {
                    MessageBox.Show("Esta equipa já está inscrita neste torneio!");
                    return;
                }

                torneioSelecionado.Equipas.Add(equipaSelecionada);
                GestorJson.ExportarParaJson(DadosGlobais.Torneios, "torneios.json");

                MessageBox.Show($"Equipa '{equipaSelecionada.Nome}' inscrita com sucesso no torneio '{torneioSelecionado.Nome}'!");
            }
            catch (Exception ex)
            {
                GestorLogs.RegistarErro(ex, this.Name);
                MessageBox.Show(ex.Message, "Erro na Inscrição", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbTorneio_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Opcional para atualizar dados ao mudar de torneio
        }

        // ==================== AGENDAR E GUARDAR PARTIDA ====================
        private void btnGuardarPartida_Click(object sender, EventArgs e)
        {
            try
            {
                var eqA = cmbEquipaA.SelectedItem as EquipaMock;
                var eqB = cmbEquipaB.SelectedItem as EquipaMock;

                if (eqA == null || eqB == null)
                {
                    MessageBox.Show("Seleciona a Equipa A e a Equipa B!");
                    return;
                }

                if (eqA.Id == eqB.Id)
                {
                    MessageBox.Show("Uma equipa não pode jogar contra si própria!");
                    return;
                }

                Partida novaPartida = new Partida
                {
                    Id = int.Parse(txtIdPartida.Text),
                    Data = dateTimePicker1.Value,
                    IdEquipaA = eqA.Id,
                    IdEquipaB = eqB.Id,
                    ResultadoA = int.Parse(txtResultadoA.Text),
                    ResultadoB = int.Parse(txtResultadoB.Text)
                };

                GestorJson.AdicionarPartida(novaPartida);
                DadosGlobais.Partidas = GestorJson.ImportarPartidas();

                AtualizarTabelaPartidas();
                MessageBox.Show("Partida guardada no JSON com sucesso!");
            }
            catch (Exception ex)
            {
                GestorLogs.RegistarErro(ex, this.Name);
                MessageBox.Show("Verifica se o ID da Partida e os Resultados A e B são números inteiros.", "Erro ao Guardar Partida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarTabelaPartidas()
        {
            dgvPartidas.Rows.Clear();

            foreach (var p in DadosGlobais.Partidas)
            {
                string nomeA = DadosGlobais.Equipas.FirstOrDefault(eq => eq.Id == p.IdEquipaA)?.Nome ?? $"ID {p.IdEquipaA}";
                string nomeB = DadosGlobais.Equipas.FirstOrDefault(eq => eq.Id == p.IdEquipaB)?.Nome ?? $"ID {p.IdEquipaB}";
                string resTexto = $"{p.ResultadoA} - {p.ResultadoB}";

                string nomeVencedor = "Empate";
                if (p.ResultadoA > p.ResultadoB) nomeVencedor = nomeA;
                else if (p.ResultadoB > p.ResultadoA) nomeVencedor = nomeB;

                dgvPartidas.Rows.Add(
                    p.Id,
                    p.Data.ToString("dd/MM/yyyy"),
                    nomeA,
                    resTexto,
                    nomeB,
                    nomeVencedor
                );
            }
        }
        private void AtualizarComboEquipas()
        {
            var listaEquipas = GestorJson.ImportarEquipas();

            cmbEquipaA.DataSource = null;

            cmbEquipaA.DataSource = listaEquipas;

            cmbEquipaA.DisplayMember = "Nome";

            cmbEquipaA.ValueMember = "Id";
        }

        // ==================== BOTÃO VOLTAR ====================
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCriarTorneio_Click_1(object sender, EventArgs e)
        {
            var torneioSelecionado = (Torneio)cmbTorneio.SelectedItem;

            if (torneioSelecionado == null) return;

            if (torneioSelecionado.Equipas.Count < 4)
            {
                MessageBox.Show("O torneio precisa de ter pelo menos 4 equipas inscritas para poder agendar partidas!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnGuardarPartida_Click_1(object sender, EventArgs e)
        {
            var equipaA = (Equipa)cmbEquipaA.SelectedItem;
            var equipaB = (Equipa)cmbEquipaB.SelectedItem;

            if (equipaA != null && equipaB != null && equipaA.Id == equipaB.Id)
            {
                MessageBox.Show("Uma equipa não pode jogar contra si própria!",
                                "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var torneio = (Torneio)cmbTorneio.SelectedItem;
            if (torneio != null && torneio.Equipas.Count < 4)
            {
                MessageBox.Show("O torneio necessita de ter pelo menos 4 equipas inscritas para agendar partidas!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void cmbTorneio_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var torneioSelecionado = (Torneio)cmbTorneio.SelectedItem;

            if (torneioSelecionado != null)
            {
                cmbEquipaA.DataSource = null;
                cmbEquipaA.DataSource = torneioSelecionado.Equipas;
                cmbEquipaA.DisplayMember = "Nome";

                cmbEquipaB.DataSource = null;
                cmbEquipaB.DataSource = torneioSelecionado.Equipas.ToList();
                cmbEquipaB.DisplayMember = "Nome";
            }
        }

        private void cmbCampeonatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var torneioSelecionado = (Torneio)cmbTorneio.SelectedItem;

            if (torneioSelecionado != null)
            {
                cmbEquipaA.DataSource = null;
                cmbEquipaA.DataSource = torneioSelecionado.Equipas;
                cmbEquipaA.DisplayMember = "Nome";

                cmbEquipaB.DataSource = null;
                cmbEquipaB.DataSource = torneioSelecionado.Equipas.ToList();
                cmbEquipaB.DisplayMember = "Nome";
            }
        }
    }
}