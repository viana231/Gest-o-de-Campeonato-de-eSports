using Gestão_de_Campeonato_de_eSports.Modelo;
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

            CarregarEstatisticasTorneio();
        }

        private void cmbFiltroTorneio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarEstatisticasTorneio();
        }

        private void CarregarEstatisticasTorneio()
        {
            var torneioSelecionado = (Torneio)cmbFiltroTorneio.SelectedItem;
            if (torneioSelecionado == null) return;

            // 1. Tabela Classificativa
            var classificacao = torneioSelecionado.Equipas.Select(eq => {
                int vitorias = torneioSelecionado.Partidas.Count(p =>
                    (p.IdEquipaA == eq.Id && p.ResultadoA > p.ResultadoB) ||
                    (p.IdEquipaB == eq.Id && p.ResultadoB > p.ResultadoA));

                int derrotas = torneioSelecionado.Partidas.Count(p =>
                    (p.IdEquipaA == eq.Id && p.ResultadoA < p.ResultadoB) ||
                    (p.IdEquipaB == eq.Id && p.ResultadoB < p.ResultadoA));

                int pontos = vitorias * 3;

                return new
                {
                    Equipa = eq.Nome,
                    Jogos = vitorias + derrotas,
                    Vitorias = vitorias,
                    Derrotas = derrotas,
                    Pontos = pontos
                };
            }).OrderByDescending(c => c.Pontos).ThenByDescending(c => c.Vitorias).ToList();

            dgvTabelaClassificativa.DataSource = classificacao;

            // 2. Top 3 Jogadores
            var top3 = torneioSelecionado.Equipas
                .SelectMany(eq => eq.Jogadores.Select(j => new {
                    Nickname = j.Nickname,
                    Equipa = eq.Nome,
                    MediaPontos = j.Pontuacoes != null && j.Pontuacoes.Any() ? j.Pontuacoes.Average() : 0
                }))
                .OrderByDescending(j => j.MediaPontos)
                .Take(3)
                .ToList();

            dgvTop3Jogadores.DataSource = top3;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var torneioSelecionado = (Torneio)cmbFiltroTorneio.SelectedItem;
            if (torneioSelecionado == null) return;

            string termo = txtPesquisarNick.Text.Trim().ToLower();

            var resultado = torneioSelecionado.Equipas
                .SelectMany(eq => eq.Jogadores)
                .Where(j => j.Nickname != null && j.Nickname.ToLower().Contains(termo))
                .Select(j => new {
                    j.Id,
                    j.Nome,
                    j.Nickname,
                    j.Idade,
                    Media = j.Pontuacoes != null && j.Pontuacoes.Any() ? j.Pontuacoes.Average() : 0
                }).ToList();

            dgvResultPesquisaNickname.DataSource = resultado;
        }
    }
}