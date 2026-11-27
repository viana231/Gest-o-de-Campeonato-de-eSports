using Gestão_de_Campeonato_de_eSports.Modelo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Gestão_de_Campeonato_de_eSports.Forms
{
    public partial class FormEstatisticasLINQ : Form
    {
        public FormEstatisticasLINQ()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.FormEstatisticasLINQ_Load);
            this.cmbFiltroTorneio.SelectedIndexChanged += new EventHandler(this.cmbFiltroTorneio_SelectedIndexChanged);
        }

        private void FormEstatisticasLINQ_Load(object sender, EventArgs e)
        {
            cmbFiltroTorneio.DataSource = null;
            cmbFiltroTorneio.DataSource = DadosGlobais.Torneios;
            cmbFiltroTorneio.DisplayMember = "Nome";

            CarregarTabelaClassificativa();
        }

        private void cmbFiltroTorneio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarTabelaClassificativa();
        }

        private void CarregarTabelaClassificativa()
        {
            dgvTabelaClassificativa.Rows.Clear();

            var classificacao = DadosGlobais.Equipas.Select(eq =>
            {
                var partidasEquipa = DadosGlobais.Partidas
                    .Where(p => p.IdEquipaA == eq.Id || p.IdEquipaB == eq.Id)
                    .ToList();

                int vitorias = partidasEquipa.Count(p =>
                    (p.IdEquipaA == eq.Id && p.ResultadoA > p.ResultadoB) ||
                    (p.IdEquipaB == eq.Id && p.ResultadoB > p.ResultadoA));

                int derrotas = partidasEquipa.Count(p =>
                    (p.IdEquipaA == eq.Id && p.ResultadoA < p.ResultadoB) ||
                    (p.IdEquipaB == eq.Id && p.ResultadoB < p.ResultadoA));

                return new
                {
                    Equipa = eq.Nome,
                    Jogos = partidasEquipa.Count,
                    Vitorias = vitorias,
                    Derrotas = derrotas,
                    Pontos = vitorias * 3
                };
            })
            .OrderByDescending(c => c.Pontos)
            .ThenByDescending(c => c.Vitorias)
            .ToList();

            int pos = 1;
            foreach (var item in classificacao)
            {
                dgvTabelaClassificativa.Rows.Add(pos++, item.Equipa, item.Jogos, item.Vitorias, item.Derrotas, item.Pontos);
            }
        }

        private void cmbFiltroTorneio_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var torneioSelecionado = (Torneio)cmbFiltroTorneio.SelectedItem;
            if (torneioSelecionado == null) return;

            var classificacao = torneioSelecionado.Equipas.Select(e => {
                int vitorias = torneioSelecionado.Partidas.Count(p =>
                    (p.IdEquipaA == e.Id && p.ResultadoA > p.ResultadoB) ||
                    (p.IdEquipaB == e.Id && p.ResultadoB > p.ResultadoA));

                int derrotas = torneioSelecionado.Partidas.Count(p =>
                    (p.IdEquipaA == e.Id && p.ResultadoA < p.ResultadoB) ||
                    (p.IdEquipaB == e.Id && p.ResultadoB < p.ResultadoA));

                int pontos = vitorias * 3;

                return new
                {
                    Equipa = e.Nome,
                    Jogos = vitorias + derrotas,
                    Vitorias = vitorias,
                    Derrotas = derrotas,
                    Pontos = pontos
                };
            }).OrderByDescending(c => c.Pontos).ToList();

            dgvTabelaClassificativa.DataSource = classificacao;


            var torneioSelecionado = (Torneio)cmbFiltroTorneio.SelectedItem;
            if (torneioSelecionado == null) return;

            var top3 = torneioSelecionado.Equipas
                .SelectMany(e => e.Jogadores.Select(j => new {
                    Nickname = j.Nickname,
                    Equipa = e.Nome,
                    MediaPontos = j.Pontuacoes.Any() ? j.Pontuacoes.Average() : 0
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

            string termo = txtPesquisarNick.Text.Trim();

            var resultado = torneioSelecionado.Equipas
                .SelectMany(e => e.Jogadores)
                .Where(j => j.Nickname.Contains(termo, StringComparison.OrdinalIgnoreCase))
                .Select(j => new {
                    j.Id,
                    j.Nome,
                    j.Nickname,
                    j.Idade,
                    Media = j.Pontuacoes.Any() ? j.Pontuacoes.Average() : 0
                }).ToList();

            dgvResultPesquisaNickname.DataSource = resultado;
        }
    }
}