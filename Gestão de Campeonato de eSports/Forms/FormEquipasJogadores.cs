using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Gestão_de_Campeonato_de_eSports.Modelo;

namespace Gestão_de_Campeonato_de_eSports
{
    public partial class FormEquipasJogadores : Form
    {
        private bool isProcessando = false;

        public FormEquipasJogadores()
        {
            InitializeComponent();
            LigarEventos();
        }

        // Liga cada evento UMA única vez.
        // O "-=" antes do "+=" garante que, mesmo que o Designer já tenha ligado
        // o mesmo método, o handler nunca fica registado duas vezes.
        private void LigarEventos()
        {
            this.Load -= FormEquipasJogadores_Load;
            this.Load += FormEquipasJogadores_Load;

            btnAddEquipa.Click -= btnAddEquipa_Click;
            btnAddEquipa.Click += btnAddEquipa_Click;

            btnEditEquipa.Click -= btnEditEquipa_Click;
            btnEditEquipa.Click += btnEditEquipa_Click;

            btnDelEquipa.Click -= btnDelEquipa_Click;
            btnDelEquipa.Click += btnDelEquipa_Click;

            btnAddJogador.Click -= btnAddJogador_Click;
            btnAddJogador.Click += btnAddJogador_Click;

            btnEditJogador.Click -= btnEditJogador_Click;
            btnEditJogador.Click += btnEditJogador_Click;

            btnDelJogador.Click -= btnDelJogador_Click;
            btnDelJogador.Click += btnDelJogador_Click;

            btnAddPontos.Click -= btnAddPontos_Click;
            btnAddPontos.Click += btnAddPontos_Click;

            if (dgvEquipas != null)
            {
                dgvEquipas.CellClick -= dgvEquipas_CellClick;
                dgvEquipas.CellClick += dgvEquipas_CellClick;
            }
        }

        private void FormEquipasJogadores_Load(object sender, EventArgs e)
        {
            if (lstvPontuacoes != null)
            {
                lstvPontuacoes.View = View.List;
            }
            CarregarCombosTopo();
            AtualizarTabelaEquipas();
            AtualizarTabelaJogadores();
        }

        private void CarregarCombosTopo()
        {
            if (cmbCampeonatos != null)
            {
                cmbCampeonatos.DataSource = null;
                cmbCampeonatos.DataSource = DadosGlobais.Campeonatos;
                cmbCampeonatos.DisplayMember = "Nome";
            }

            if (cmbTorneios != null)
            {
                cmbTorneios.DataSource = null;
                cmbTorneios.DataSource = DadosGlobais.Torneios;
                cmbTorneios.DisplayMember = "Nome";
            }
        }

        // ==================== GESTÃO DE EQUIPAS ====================
        private void btnAddEquipa_Click(object sender, EventArgs e)
        {
            try
            {
                if (errorProvider1 != null)
                {
                    errorProvider1.Clear();
                }

                string nomeEquipa = txtNomeEquipa.Text.Trim();
                string paisEquipa = txtPaisEquipa.Text.Trim();

                if (string.IsNullOrWhiteSpace(nomeEquipa))
                {
                    if (errorProvider1 != null) errorProvider1.SetError(txtNomeEquipa, "O nome é obrigatório!");
                    MessageBox.Show("O nome da equipa é obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNomeEquipa.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(paisEquipa))
                {
                    if (errorProvider1 != null) errorProvider1.SetError(txtPaisEquipa, "Escolher um país é obrigatório!");
                    MessageBox.Show("O país da equipa é obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPaisEquipa.Focus();
                    return;
                }

                if (!int.TryParse(txtIdEquipa.Text, out int idInserido))
                {
                    if (errorProvider1 != null) errorProvider1.SetError(txtIdEquipa, "Insira um ID numérico válido!");
                    MessageBox.Show("Insira um ID numérico válido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIdEquipa.Focus();
                    return;
                }

                // 1. Validação de ID único
                if (DadosGlobais.Equipas.Any(eq => eq.Id == idInserido))
                {
                    if (errorProvider1 != null) errorProvider1.SetError(txtIdEquipa, "Este ID já está a ser utilizado!");
                    MessageBox.Show("Já existe uma equipa com este ID!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIdEquipa.Focus();
                    return;
                }

                // 2. Validação de nomes iguais (ignorando maiúsculas/minúsculas)
                if (DadosGlobais.Equipas.Any(eq => eq.Nome.Equals(nomeEquipa, StringComparison.OrdinalIgnoreCase)))
                {
                    if (errorProvider1 != null) errorProvider1.SetError(txtNomeEquipa, "Já existe uma equipa com este nome!");
                    MessageBox.Show("Já existe uma equipa registada com este nome!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNomeEquipa.Focus();
                    return;
                }

                EquipaMock novaEquipa = new EquipaMock
                {
                    Id = idInserido,
                    Nome = nomeEquipa,
                    Pais = paisEquipa
                };

                GestorJson.AdicionarEquipa(novaEquipa);
                DadosGlobais.Equipas = GestorJson.ImportarEquipas();

                isProcessando = true;
                if (errorProvider1 != null) errorProvider1.Clear();
                txtIdEquipa.Clear();
                txtNomeEquipa.Clear();
                txtPaisEquipa.Clear();
                isProcessando = false;

                AtualizarTabelaEquipas();
                AtualizarComboEquipas();

                MessageBox.Show("Equipa guardada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                isProcessando = false;
                GestorLogs.RegistarErro(ex, this.Name);
                MessageBox.Show("Erro ao adicionar equipa: verifica se o ID é numérico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditEquipa_Click(object sender, EventArgs e)
        {
            try
            {
                EquipaMock editada = new EquipaMock
                {
                    Id = int.Parse(txtIdEquipa.Text),
                    Nome = txtNomeEquipa.Text,
                    Pais = txtPaisEquipa.Text
                };

                GestorJson.EditarEquipa(editada);
                DadosGlobais.Equipas = GestorJson.ImportarEquipas();
                AtualizarTabelaEquipas();
                MessageBox.Show("Equipa atualizada no JSON!");
            }
            catch (Exception ex)
            {
                GestorLogs.RegistarErro(ex, this.Name);
                MessageBox.Show(ex.Message, "Erro ao Editar Equipa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelEquipa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdEquipa.Text) || !int.TryParse(txtIdEquipa.Text, out int idEquipa))
                {
                    MessageBox.Show("Insira ou selecione um ID de equipa válido para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Impede apagar equipas com partidas registadas
                bool temPartidas = DadosGlobais.Partidas.Any(p => p.IdEquipaA == idEquipa || p.IdEquipaB == idEquipa);
                if (temPartidas)
                {
                    MessageBox.Show("Não pode apagar esta equipa pois já tem partidas registadas!",
                                    "Ação Bloqueada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                GestorJson.RemoverEquipa(idEquipa);
                DadosGlobais.Equipas = GestorJson.ImportarEquipas();

                isProcessando = true;

                if (errorProvider1 != null)
                {
                    errorProvider1.Clear();
                }

                txtIdEquipa.Clear();
                txtNomeEquipa.Clear();
                txtPaisEquipa.Clear();

                this.ActiveControl = dgvEquipas;

                isProcessando = false;

                AtualizarTabelaEquipas();
                MessageBox.Show("Equipa removida do JSON com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                isProcessando = false;
                GestorLogs.RegistarErro(ex, this.Name);
                MessageBox.Show(ex.Message, "Erro ao Remover Equipa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEquipas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isProcessando) return;

            if (e.RowIndex >= 0 && e.RowIndex < dgvEquipas.Rows.Count)
            {
                DataGridViewRow row = dgvEquipas.Rows[e.RowIndex];
                if (row.Cells[0].Value != null)
                {
                    txtIdEquipa.Text = row.Cells[0].Value.ToString();
                    txtNomeEquipa.Text = row.Cells[1].Value?.ToString() ?? "";
                    txtPaisEquipa.Text = row.Cells[2].Value?.ToString() ?? "";

                    if (errorProvider1 != null) errorProvider1.Clear();
                }
            }
        }

        private void AtualizarTabelaEquipas()
        {
            if (dgvEquipas == null) return;

            dgvEquipas.Rows.Clear();
            foreach (var eq in DadosGlobais.Equipas)
            {
                dgvEquipas.Rows.Add(eq.Id, eq.Nome, eq.Pais);
            }
        }

        private void AtualizarComboEquipas()
        {
            // Método auxiliar para atualizar comboboxes de equipas se existirem
        }

        // ==================== GESTÃO DE JOGADORES ====================
        private void btnAddJogador_Click(object sender, EventArgs e)
        {
            try
            {
                int idJog = int.Parse(txtbIdJogador.Text);
                if (DadosGlobais.Jogadores.Any(j => j.Id == idJog))
                {
                    MessageBox.Show("Já existe um jogador com este ID!");
                    return;
                }

                Jogador novo = new Jogador
                {
                    Id = idJog,
                    Nome = txtbNomeJogador.Text,
                    Idade = (int)numIdade.Value,
                    Nickname = txtNickNameJogador.Text
                };

                GestorJson.AdicionarJogador(novo);
                DadosGlobais.Jogadores = GestorJson.ImportarJogadores();
                AtualizarTabelaJogadores();
                MessageBox.Show("Jogador guardado no JSON com sucesso!");
            }
            catch (Exception ex)
            {
                GestorLogs.RegistarErro(ex, this.Name);
                MessageBox.Show("Erro ao adicionar jogador: verifica se o ID é numérico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditJogador_Click(object sender, EventArgs e)
        {
            try
            {
                int idJog = int.Parse(txtbIdJogador.Text);
                var existente = DadosGlobais.Jogadores.FirstOrDefault(j => j.Id == idJog);

                Jogador editado = new Jogador
                {
                    Id = idJog,
                    Nome = txtbNomeJogador.Text,
                    Idade = (int)numIdade.Value,
                    Nickname = txtNickNameJogador.Text,
                    Pontuacoes = existente != null ? existente.Pontuacoes : new List<int>()
                };

                GestorJson.EditarJogador(editado);
                DadosGlobais.Jogadores = GestorJson.ImportarJogadores();
                AtualizarTabelaJogadores();
                MessageBox.Show("Jogador atualizado no JSON!");
            }
            catch (Exception ex)
            {
                GestorLogs.RegistarErro(ex, this.Name);
                MessageBox.Show(ex.Message, "Erro ao Editar Jogador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelJogador_Click(object sender, EventArgs e)
        {
            try
            {
                int idJog = int.Parse(txtbIdJogador.Text);
                GestorJson.RemoverJogador(idJog);
                DadosGlobais.Jogadores = GestorJson.ImportarJogadores();
                AtualizarTabelaJogadores();
                MessageBox.Show("Jogador removido do JSON!");
            }
            catch (Exception ex)
            {
                GestorLogs.RegistarErro(ex, this.Name);
                MessageBox.Show(ex.Message, "Erro ao Remover Jogador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddPontos_Click(object sender, EventArgs e)
        {
            try
            {
                int idJog = int.Parse(txtbIdJogador.Text);
                int pontos = (int)nmd_Pontuação.Value;

                var jogador = DadosGlobais.Jogadores.FirstOrDefault(j => j.Id == idJog);
                if (jogador == null)
                {
                    MessageBox.Show("Escreve primeiro o ID de um jogador já criado!");
                    return;
                }

                jogador.Pontuacoes.Add(pontos);
                GestorJson.EditarJogador(jogador);
                DadosGlobais.Jogadores = GestorJson.ImportarJogadores();

                if (lstvPontuacoes != null)
                {
                    lstvPontuacoes.Items.Clear();
                    foreach (var p in jogador.Pontuacoes)
                    {
                        lstvPontuacoes.Items.Add($"Pontuação: {p}");
                    }
                }

                AtualizarTabelaJogadores();
            }
            catch (Exception ex)
            {
                GestorLogs.RegistarErro(ex, this.Name);
                MessageBox.Show("Verifica se o ID do jogador está preenchido corretamente.", "Erro ao Adicionar Pontos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarTabelaJogadores()
        {
            if (dgvJogadores == null) return;

            dgvJogadores.Rows.Clear();
            foreach (var j in DadosGlobais.Jogadores)
            {
                double mediaJog = j.Pontuacoes != null && j.Pontuacoes.Count > 0
                    ? Math.Round(j.Pontuacoes.Average(), 1)
                    : 0;

                dgvJogadores.Rows.Add(j.Id, j.Nickname, j.Idade, mediaJog);
            }
        }

        private void BtnHelpLogs_Click(object sender, EventArgs e)
        {
            GestorLogs.AbrirBotaoLogs();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}