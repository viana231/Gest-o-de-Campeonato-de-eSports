using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Gestão_de_Campeonato_de_eSports.Modelo;

namespace Gestão_de_Campeonato_de_eSports
{
    public partial class FormEquipasJogadores : Form
    {
        public FormEquipasJogadores()
        {
            InitializeComponent();

            // Liga os eventos que não estavam registados no Designer
            this.Load += new EventHandler(this.FormEquipasJogadores_Load);
            this.btnAddEquipa.Click += new EventHandler(this.btnAddEquipa_Click);
            this.btnEditEquipa.Click += new EventHandler(this.btnEditEquipa_Click);
            this.btnDelEquipa.Click += new EventHandler(this.btnDelEquipa_Click);
            this.btnAddJogador.Click += new EventHandler(this.btnAddJogador_Click);
            this.btnEditJogador.Click += new EventHandler(this.btnEditJogador_Click);
            this.btnDelJogador.Click += new EventHandler(this.btnDelJogador_Click);
            this.btnAddPontos.Click += new EventHandler(this.btnAddPontos_Click);
        }

        private void FormEquipasJogadores_Load(object sender, EventArgs e)
        {
            lstvPontuacoes.View = View.List;
            CarregarCombosTopo();
            AtualizarTabelaEquipas();
            AtualizarTabelaJogadores();
        }

        private void CarregarCombosTopo()
        {
            cmbCampeonatos.DataSource = null;
            cmbCampeonatos.DataSource = DadosGlobais.Campeonatos;
            cmbCampeonatos.DisplayMember = "Nome";

            cmbTorneios.DataSource = null;
            cmbTorneios.DataSource = DadosGlobais.Torneios;
            cmbTorneios.DisplayMember = "Nome";
        }

        // ==================== GESTÃO DE EQUIPAS ====================
        private void btnAddEquipa_Click(object sender, EventArgs e)
        {
            try
            {
                int idEquipa = int.Parse(txtIdEquipa.Text);
                if (DadosGlobais.Equipas.Any(eq => eq.Id == idEquipa))
                {
                    MessageBox.Show("Já existe uma equipa com este ID!");
                    return;
                }

                EquipaMock novaEquipa = new EquipaMock
                {
                    Id = idEquipa,
                    Nome = txtNomeEquipa.Text,
                    Pais = txtPaisEquipa.Text
                };

                GestorJson.AdicionarEquipa(novaEquipa);
                DadosGlobais.Equipas = GestorJson.ImportarEquipas();
                AtualizarTabelaEquipas();
                MessageBox.Show("Equipa guardada no JSON com sucesso!");
            }
            catch (Exception ex)
            {
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
                int idEquipa = int.Parse(txtIdEquipa.Text);
                GestorJson.RemoverEquipa(idEquipa);
                DadosGlobais.Equipas = GestorJson.ImportarEquipas();
                AtualizarTabelaEquipas();
                MessageBox.Show("Equipa removida do JSON!");
            }
            catch (Exception ex)
            {
                GestorLogs.RegistarErro(ex, this.Name);
                MessageBox.Show(ex.Message, "Erro ao Remover Equipa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarTabelaEquipas()
        {
            dgvEquipas.Rows.Clear();
            foreach (var eq in DadosGlobais.Equipas)
            {
                dgvEquipas.Rows.Add(eq.Id, eq.Nome, eq.Pais);
            }
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

                lstvPontuacoes.Items.Clear();
                foreach (var p in jogador.Pontuacoes)
                {
                    lstvPontuacoes.Items.Add($"Pontuação: {p}");
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

        private void btnAddJogador_Click_1(object sender, EventArgs e)
        {
            // Limpa erros anteriores
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtbNomeJogador.Text))
            {
                errorProvider1.SetError(txtbNomeJogador, "O nome é obrigatório!");
                txtbNomeJogador.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNickNameJogador.Text))
            {
                errorProvider1.SetError(txtNickNameJogador, "O nickname é obrigatório!");
                txtNickNameJogador.Focus();
                return;
            }
        }

        private void btnAddEquipa_Click_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtNomeEquipa.Text))
            {
                errorProvider1.SetError(txtNomeEquipa, "O nome é obrigatório!");
                txtNomeEquipa.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPaisEquipa.Text))
            {
                errorProvider1.SetError(txtPaisEquipa, "Escolher um país é obrigatório!");
                txtPaisEquipa.Focus();
                return;
            }

            
        }
    }
}