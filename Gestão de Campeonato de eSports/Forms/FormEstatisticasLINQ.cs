using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Gestão_de_Campeonato_de_eSports.Modelo;

namespace Gestão_de_Campeonato_de_eSports.Forms
{
    public partial class FormEstatisticasLINQ : Form
    {
        public FormEstatisticasLINQ()
        {
            InitializeComponent();

            // Liga os eventos diretamente aos controlos do teu Designer
            this.Load += FormEstatisticasLINQ_Load;
            this.cmbFiltroTorneio.SelectedIndexChanged += cmbFiltroTorneio_SelectedIndexChanged;
            this.txtPesquisarNick.TextChanged += txtPesquisarNick_TextChanged;
            this.btnVoltarMenu.Click += btnVoltarMenu_Click;
        }

        private void FormEstatisticasLINQ_Load(object sender, EventArgs e)
        {
            DadosGlobais.CarregarTudo();
            CarregarComboTorneios();
            AtualizarTabelaClassificativa();
            AtualizarTop3Jogadores();
            AtualizarPesquisaNickname();
        }

        private void CarregarComboTorneios()
        {
            var listaOpcoes = new List<TorneioMock>
            {
                new TorneioMock { Id = 0, Nome = "Todos os Torneios" }
            };
            listaOpcoes.AddRange(DadosGlobais.Torneios);

            cmbFiltroTorneio.DataSource = null;
            cmbFiltroTorneio.DataSource = listaOpcoes;
            cmbFiltroTorneio.DisplayMember = "Nome";
        }

        private void cmbFiltroTorneio_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarTabelaClassificativa();
        }

        private void txtPesquisarNick_TextChanged(object sender, EventArgs e)
        {
            AtualizarPesquisaNickname();
        }

        // 1. Tabela Classificativa (dgvTabelaClassificativa: Posição, Equipa, Jogos, Vitória, Derrota, Pontos)
        private void AtualizarTabelaClassificativa()
        {
            dgvTabelaClassificativa.Rows.Clear();

            var torneioSel = cmbFiltroTorneio.SelectedItem as TorneioMock;
            List<EquipaMock> equipasFiltradas = DadosGlobais.Equipas;

            // Se escolher um torneio específico que tenha equipas inscritas, filtra por essas equipas
            if (torneioSel != null && torneioSel.Id != 0 && torneioSel.Equipas != null && torneioSel.Equipas.Count > 0)
            {
                var idsInscritos = torneioSel.Equipas.Select(eq => eq.Id).ToHashSet();
                equipasFiltradas = DadosGlobais.Equipas.Where(eq => idsInscritos.Contains(eq.Id)).ToList();
            }

            var classificacao = equipasFiltradas.Select(eq =>
            {
                var partidasEquipa = DadosGlobais.Partidas
                    .Where(p => p.IdEquipaA == eq.Id || p.IdEquipaB == eq.Id)
                    .ToList();

                int vitorias = partidasEquipa.Count(p =>
                    (p.IdEquipaA == eq.Id && p.ResultadoA > p.ResultadoB) ||
                    (p.IdEquipaB == eq.Id && p.ResultadoB > p.ResultadoA));

                int empates = partidasEquipa.Count(p => p.ResultadoA == p.ResultadoB);
                int derrotas = partidasEquipa.Count - vitorias - empates;
                int pontos = (vitorias * 3) + empates;

                return new
                {
                    Equipa = eq.Nome,
                    Jogos = partidasEquipa.Count,
                    Vitorias = vitorias,
                    Derrotas = derrotas,
                    Pontos = pontos
                };
            })
            .OrderByDescending(c => c.Pontos)
            .ThenByDescending(c => c.Vitorias)
            .ToList();

            int pos = 1;
            foreach (var item in classificacao)
            {
                dgvTabelaClassificativa.Rows.Add(
                    pos++,
                    item.Equipa,
                    item.Jogos,
                    item.Vitorias,
                    item.Derrotas,
                    item.Pontos
                );
            }
        }

        // 2. Top 3 Jogadores por Média (dataGridView1: Posição, Nick, Equipa, Média)
        private void AtualizarTop3Jogadores()
        {
            dataGridView1.Rows.Clear();

            var top3 = DadosGlobais.Jogadores
                .Select(j => new
                {
                    Nick = j.Nickname,
                    Equipa = ObterNomeEquipaDoJogador(j.Id),
                    Media = (j.Pontuacoes != null && j.Pontuacoes.Count > 0)
                        ? Math.Round(j.Pontuacoes.Average(), 1)
                        : 0
                })
                .OrderByDescending(j => j.Media)
                .Take(3)
                .ToList();

            int pos = 1;
            foreach (var j in top3)
            {
                dataGridView1.Rows.Add(pos++, j.Nick, j.Equipa, j.Media);
            }
        }

        // 3. Pesquisa por Nickname com LINQ (dataGridView2: ID, NomeCompleto, Nickname, Idade, Equipa, Média)
        private void AtualizarPesquisaNickname()
        {
            dataGridView2.Rows.Clear();
            if (errorProvider1 != null) errorProvider1.Clear();

            string termo = txtPesquisarNick.Text.Trim().ToLower();

            var resultados = DadosGlobais.Jogadores
                .Where(j => string.IsNullOrEmpty(termo) ||
                            (j.Nickname != null && j.Nickname.ToLower().Contains(termo)) ||
                            (j.Nome != null && j.Nome.ToLower().Contains(termo)))
                .Select(j => new
                {
                    Id = j.Id,
                    NomeCompleto = j.Nome,
                    Nickname = j.Nickname,
                    Idade = j.Idade,
                    Equipa = ObterNomeEquipaDoJogador(j.Id),
                    Media = (j.Pontuacoes != null && j.Pontuacoes.Count > 0)
                        ? Math.Round(j.Pontuacoes.Average(), 1)
                        : 0
                })
                .OrderByDescending(j => j.Media)
                .ToList();

            if (resultados.Count == 0 && !string.IsNullOrEmpty(termo))
            {
                if (errorProvider1 != null)
                    errorProvider1.SetError(txtPesquisarNick, "Nenhum jogador encontrado com esse Nickname.");
                return;
            }

            foreach (var r in resultados)
            {
                dataGridView2.Rows.Add(r.Id, r.NomeCompleto, r.Nickname, r.Idade, r.Equipa, r.Media);
            }
        }

        private string ObterNomeEquipaDoJogador(int idJogador)
        {
            var equipa = DadosGlobais.Equipas
                .FirstOrDefault(eq => eq.Jogadores != null && eq.Jogadores.Any(jog => jog.Id == idJogador));

            return equipa != null ? equipa.Nome : "Sem Equipa";
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}