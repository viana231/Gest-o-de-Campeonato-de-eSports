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

        private void txtPesquisarNick_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {

        }
    }
}