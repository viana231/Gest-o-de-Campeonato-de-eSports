using Gestão_de_Campeonato_de_eSports.Modelo;
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
    public partial class FormEquipasJogadores : Form
    {
        public FormEquipasJogadores()
        {
            InitializeComponent();
        }


        private void btnAddJogador_Click(object sender, EventArgs e)
        {
            Jogador novo = new Jogador
            {
                Id = int.Parse(txtbIdJogador.Text),
                Nome = txtbNomeJogador.Text,
                Idade = (int)numIdade.Value,
                Nickname = txtNickNameJogador.Text
            };

            GestorJson.AdicionarJogador(novo);
            DadosGlobais.Jogadores = GestorJson.ImportarJogadores();
            MessageBox.Show("Jogador guardado no JSON com sucesso!");
        }

        private void btnEditJogador_Click(object sender, EventArgs e)
        {
            Jogador editado = new Jogador
            {
                Id = int.Parse(txtbIdJogador.Text),
                Nome = txtbNomeJogador.Text,
                Idade = (int)numIdade.Value,
                Nickname = txtNickNameJogador.Text
            };

            GestorJson.EditarJogador(editado);
            DadosGlobais.Jogadores = GestorJson.ImportarJogadores();
            MessageBox.Show("Jogador atualizado no JSON!");
        }

        private void btnDelJogador_Click(object sender, EventArgs e)
        {
            int idParaApagar = int.Parse(txtbIdJogador.Text);
            GestorJson.RemoverJogador(idParaApagar);
            DadosGlobais.Jogadores = GestorJson.ImportarJogadores();
            MessageBox.Show("Jogador removido do JSON!");
        }

        private void btnAddEquipa_Click(object sender, EventArgs e)
        {
            EquipaMock novaEquipa = new EquipaMock
            {
                Id = int.Parse(txtIdEquipa.Text),
                Nome = txtNomeEquipa.Text,
                Pais = txtPaisEquipa.Text
            };

            GestorJson.AdicionarEquipa(novaEquipa);
            DadosGlobais.Equipas = GestorJson.ImportarEquipas();
            MessageBox.Show("Equipa guardada no JSON com sucesso!");
        }

        private void btnEditEquipa_Click(object sender, EventArgs e)
        {
            EquipaMock equipaEditada = new EquipaMock
            {
                Id = int.Parse(txtIdEquipa.Text),
                Nome = txtNomeEquipa.Text,
                Pais = txtPaisEquipa.Text
            };

            GestorJson.EditarEquipa(equipaEditada);
            DadosGlobais.Equipas = GestorJson.ImportarEquipas();
            MessageBox.Show("Equipa atualizada no JSON!");
        }

        private void btnDelEquipa_Click(object sender, EventArgs e)
        {
            int idParaApagar = int.Parse(txtIdEquipa.Text);
            GestorJson.RemoverEquipa(idParaApagar);
            DadosGlobais.Equipas = GestorJson.ImportarEquipas();
            MessageBox.Show("Equipa removida do JSON!");
        }
    }
}
