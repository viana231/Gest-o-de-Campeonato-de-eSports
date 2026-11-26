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

            // Liga os eventos dos controlos que não estavam registados no Designer
            this.Load += new EventHandler(this.FormTorneiosPartidas_Load);
            this.btnCriarTorneio.Click += new EventHandler(this.btnCriarTorneio_Click);
            this.btnInscreverEquipa.Click += new EventHandler(this.btnInscreverEquipa_Click);
            this.btnGuardarPartida.Click += new EventHandler(this.btnGuardarPartida_Click);
            this.cmbTorneio.SelectedIndexChanged += new EventHandler(this.cmbTorneio_SelectedIndexChanged);
        }

        private void FormTorneiosPartidas_Load(object sender, EventArgs e)
        {
            AtualizarCombos();
            AtualizarTabelaPartidas();
        }

        private void AtualizarCombos()
        {
            cmbCampeonatos.DataSource = null;
            cmbCampeonatos.DataSource = DadosGlobais.Campeonatos;
            cmbCampeonatos.DisplayMember = "Nome";

            cmbTorneio.DataSource = null;
            cmbTorneio.DataSource = DadosGlobais.Torneios.ToList();
            cmbTorneio.DisplayMember = "Nome";

            cmbEquipasDisp.DataSource = null;
            cmbEquipasDisp.DataSource = DadosGlobais.Equipas.ToList();
            cmbEquipasDisp.DisplayMember = "Nome";

            cmbEquipaA.DataSource = null;
            cmbEquipaA.DataSource = DadosGlobais.Equipas.ToList();
            cmbEquipaA.DisplayMember = "Nome";

            cmbEquipaB.DataSource = null;
            cmbEquipaB.DataSource = DadosGlobais.Equipas.ToList();
            cmbEquipaB.DisplayMember = "Nome";

            AtualizarLabelEstado();
        }

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
                MessageBox.Show("Torneio criado e guardado em JSON!");
            }
            catch (Exception ex)
            {
                GestorLogs.RegistarErro(ex, this.Name);
                MessageBox.Show("Erro ao criar torneio: verifica se o ID é numérico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

                AtualizarLabelEstado();
                MessageBox.Show($"Equipa '{equipaSelecionada.Nome}' inscrita com sucesso!");
            }
            catch (Exception ex)
            {
                GestorLogs.RegistarErro(ex, this.Name);
                MessageBox.Show(ex.Message, "Erro na Inscrição", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbTorneio_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarLabelEstado();
        }

        private void AtualizarLabelEstado()
        {
            var torneio = cmbTorneio.SelectedItem as TorneioMock;
            if (torneio != null)
            {
                int inscritas = torneio.Equipas.Count;
                string status = inscritas >= 4 ? "Pronto" : "Aguardar";
                lblEstado.Text = $"Estado: {inscritas}/4 ({status}) Min.4";
            }
            else
            {
                lblEstado.Text = "Estado: 0/4 () Min.4";
            }
        }

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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}