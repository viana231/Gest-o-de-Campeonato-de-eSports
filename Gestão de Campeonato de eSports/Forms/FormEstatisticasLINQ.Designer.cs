namespace Gestão_de_Campeonato_de_eSports.Forms
{
    partial class FormEstatisticasLINQ
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTorneios = new System.Windows.Forms.Label();
            this.cmbFiltroTorneio = new System.Windows.Forms.ComboBox();
            this.lblPesquisarNick = new System.Windows.Forms.Label();
            this.txtPesquisarNick = new System.Windows.Forms.TextBox();
            this.lblTabelaClassificativa = new System.Windows.Forms.Label();
            this.dgvTabelaClassificativa = new System.Windows.Forms.DataGridView();
            this.posicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jogos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.derrota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pontos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaClassificativa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTorneios
            // 
            this.lblTorneios.AutoSize = true;
            this.lblTorneios.Location = new System.Drawing.Point(13, 13);
            this.lblTorneios.Name = "lblTorneios";
            this.lblTorneios.Size = new System.Drawing.Size(64, 16);
            this.lblTorneios.TabIndex = 0;
            this.lblTorneios.Text = "Torneios:";
            // 
            // cmbFiltroTorneio
            // 
            this.cmbFiltroTorneio.FormattingEnabled = true;
            this.cmbFiltroTorneio.Location = new System.Drawing.Point(83, 10);
            this.cmbFiltroTorneio.Name = "cmbFiltroTorneio";
            this.cmbFiltroTorneio.Size = new System.Drawing.Size(121, 24);
            this.cmbFiltroTorneio.TabIndex = 1;
            // 
            // lblPesquisarNick
            // 
            this.lblPesquisarNick.AutoSize = true;
            this.lblPesquisarNick.Location = new System.Drawing.Point(442, 13);
            this.lblPesquisarNick.Name = "lblPesquisarNick";
            this.lblPesquisarNick.Size = new System.Drawing.Size(101, 16);
            this.lblPesquisarNick.TabIndex = 2;
            this.lblPesquisarNick.Text = "Pesquisar Nick:";
            // 
            // txtPesquisarNick
            // 
            this.txtPesquisarNick.Location = new System.Drawing.Point(550, 13);
            this.txtPesquisarNick.Name = "txtPesquisarNick";
            this.txtPesquisarNick.Size = new System.Drawing.Size(100, 22);
            this.txtPesquisarNick.TabIndex = 3;
            // 
            // lblTabelaClassificativa
            // 
            this.lblTabelaClassificativa.AutoSize = true;
            this.lblTabelaClassificativa.Location = new System.Drawing.Point(16, 44);
            this.lblTabelaClassificativa.Name = "lblTabelaClassificativa";
            this.lblTabelaClassificativa.Size = new System.Drawing.Size(136, 16);
            this.lblTabelaClassificativa.TabIndex = 4;
            this.lblTabelaClassificativa.Text = "Tabela Classificativa:";
            // 
            // dgvTabelaClassificativa
            // 
            this.dgvTabelaClassificativa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTabelaClassificativa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelaClassificativa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.posicao,
            this.equipa,
            this.jogos,
            this.vitoria,
            this.derrota,
            this.pontos});
            this.dgvTabelaClassificativa.Location = new System.Drawing.Point(16, 64);
            this.dgvTabelaClassificativa.Name = "dgvTabelaClassificativa";
            this.dgvTabelaClassificativa.RowHeadersVisible = false;
            this.dgvTabelaClassificativa.RowHeadersWidth = 51;
            this.dgvTabelaClassificativa.RowTemplate.Height = 24;
            this.dgvTabelaClassificativa.Size = new System.Drawing.Size(381, 199);
            this.dgvTabelaClassificativa.TabIndex = 5;
            // 
            // posicao
            // 
            this.posicao.HeaderText = "Posição";
            this.posicao.MinimumWidth = 6;
            this.posicao.Name = "posicao";
            // 
            // equipa
            // 
            this.equipa.HeaderText = "Equipa";
            this.equipa.MinimumWidth = 6;
            this.equipa.Name = "equipa";
            // 
            // jogos
            // 
            this.jogos.HeaderText = "Jogos";
            this.jogos.MinimumWidth = 6;
            this.jogos.Name = "jogos";
            // 
            // vitoria
            // 
            this.vitoria.HeaderText = "Vitória";
            this.vitoria.MinimumWidth = 6;
            this.vitoria.Name = "vitoria";
            // 
            // derrota
            // 
            this.derrota.HeaderText = "Derrota";
            this.derrota.MinimumWidth = 6;
            this.derrota.Name = "derrota";
            // 
            // pontos
            // 
            this.pontos.HeaderText = "Pontos";
            this.pontos.MinimumWidth = 6;
            this.pontos.Name = "pontos";
            // 
            // FormEstatisticasLINQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTabelaClassificativa);
            this.Controls.Add(this.lblTabelaClassificativa);
            this.Controls.Add(this.txtPesquisarNick);
            this.Controls.Add(this.lblPesquisarNick);
            this.Controls.Add(this.cmbFiltroTorneio);
            this.Controls.Add(this.lblTorneios);
            this.Name = "FormEstatisticasLINQ";
            this.Text = "FILTROS E PESQUISAS ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaClassificativa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTorneios;
        private System.Windows.Forms.ComboBox cmbFiltroTorneio;
        private System.Windows.Forms.Label lblPesquisarNick;
        private System.Windows.Forms.TextBox txtPesquisarNick;
        private System.Windows.Forms.Label lblTabelaClassificativa;
        private System.Windows.Forms.DataGridView dgvTabelaClassificativa;
        private System.Windows.Forms.DataGridViewTextBoxColumn posicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipa;
        private System.Windows.Forms.DataGridViewTextBoxColumn jogos;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn derrota;
        private System.Windows.Forms.DataGridViewTextBoxColumn pontos;
    }
}