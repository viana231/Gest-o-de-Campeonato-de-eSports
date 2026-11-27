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
            this.components = new System.ComponentModel.Container();
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
            this.lblTop3Jogadores = new System.Windows.Forms.Label();
            this.dgvTop3Jogadores = new System.Windows.Forms.DataGridView();
            this.posicaotop3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._equipa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.media = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvResultPesquisaNickname = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equiparesultnickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mediaptsnickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltarMenu = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaClassificativa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop3Jogadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultPesquisaNickname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTorneios
            // 
            this.lblTorneios.AutoSize = true;
            this.lblTorneios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTorneios.Location = new System.Drawing.Point(13, 13);
            this.lblTorneios.Name = "lblTorneios";
            this.lblTorneios.Size = new System.Drawing.Size(79, 20);
            this.lblTorneios.TabIndex = 0;
            this.lblTorneios.Text = "Torneios:";
            // 
            // cmbFiltroTorneio
            // 
            this.cmbFiltroTorneio.FormattingEnabled = true;
            this.cmbFiltroTorneio.Location = new System.Drawing.Point(98, 13);
            this.cmbFiltroTorneio.Name = "cmbFiltroTorneio";
            this.cmbFiltroTorneio.Size = new System.Drawing.Size(121, 24);
            this.cmbFiltroTorneio.TabIndex = 1;
            this.cmbFiltroTorneio.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroTorneio_SelectedIndexChanged_1);
            // 
            // lblPesquisarNick
            // 
            this.lblPesquisarNick.AutoSize = true;
            this.lblPesquisarNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPesquisarNick.Location = new System.Drawing.Point(442, 13);
            this.lblPesquisarNick.Name = "lblPesquisarNick";
            this.lblPesquisarNick.Size = new System.Drawing.Size(127, 20);
            this.lblPesquisarNick.TabIndex = 2;
            this.lblPesquisarNick.Text = "Pesquisar Nick:";
            // 
            // txtPesquisarNick
            // 
            this.txtPesquisarNick.Location = new System.Drawing.Point(575, 13);
            this.txtPesquisarNick.Name = "txtPesquisarNick";
            this.txtPesquisarNick.Size = new System.Drawing.Size(100, 22);
            this.txtPesquisarNick.TabIndex = 3;
            // 
            // lblTabelaClassificativa
            // 
            this.lblTabelaClassificativa.AutoSize = true;
            this.lblTabelaClassificativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTabelaClassificativa.Location = new System.Drawing.Point(16, 44);
            this.lblTabelaClassificativa.Name = "lblTabelaClassificativa";
            this.lblTabelaClassificativa.Size = new System.Drawing.Size(169, 20);
            this.lblTabelaClassificativa.TabIndex = 4;
            this.lblTabelaClassificativa.Text = "Tabela Classificativa:";
            // 
            // dgvTabelaClassificativa
            // 
            this.dgvTabelaClassificativa.AllowUserToAddRows = false;
            this.dgvTabelaClassificativa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTabelaClassificativa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelaClassificativa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.posicao,
            this.equipa,
            this.jogos,
            this.vitoria,
            this.derrota,
            this.pontos});
            this.dgvTabelaClassificativa.Location = new System.Drawing.Point(16, 67);
            this.dgvTabelaClassificativa.Name = "dgvTabelaClassificativa";
            this.dgvTabelaClassificativa.RowHeadersVisible = false;
            this.dgvTabelaClassificativa.RowHeadersWidth = 51;
            this.dgvTabelaClassificativa.RowTemplate.Height = 24;
            this.dgvTabelaClassificativa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabelaClassificativa.Size = new System.Drawing.Size(381, 178);
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
            // lblTop3Jogadores
            // 
            this.lblTop3Jogadores.AutoSize = true;
            this.lblTop3Jogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTop3Jogadores.Location = new System.Drawing.Point(407, 44);
            this.lblTop3Jogadores.Name = "lblTop3Jogadores";
            this.lblTop3Jogadores.Size = new System.Drawing.Size(139, 20);
            this.lblTop3Jogadores.TabIndex = 6;
            this.lblTop3Jogadores.Text = "Top 3 Jogadores:";
            // 
            // dgvTop3Jogadores
            // 
            this.dgvTop3Jogadores.AllowUserToAddRows = false;
            this.dgvTop3Jogadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTop3Jogadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTop3Jogadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.posicaotop3,
            this.nick,
            this._equipa,
            this.media});
            this.dgvTop3Jogadores.Location = new System.Drawing.Point(410, 67);
            this.dgvTop3Jogadores.Name = "dgvTop3Jogadores";
            this.dgvTop3Jogadores.RowHeadersVisible = false;
            this.dgvTop3Jogadores.RowHeadersWidth = 51;
            this.dgvTop3Jogadores.RowTemplate.Height = 24;
            this.dgvTop3Jogadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTop3Jogadores.Size = new System.Drawing.Size(378, 178);
            this.dgvTop3Jogadores.TabIndex = 7;
            // 
            // posicaotop3
            // 
            this.posicaotop3.HeaderText = "Posição";
            this.posicaotop3.MinimumWidth = 6;
            this.posicaotop3.Name = "posicaotop3";
            // 
            // nick
            // 
            this.nick.HeaderText = "Nick";
            this.nick.MinimumWidth = 6;
            this.nick.Name = "nick";
            // 
            // _equipa
            // 
            this._equipa.HeaderText = "Equipa";
            this._equipa.MinimumWidth = 6;
            this._equipa.Name = "_equipa";
            // 
            // media
            // 
            this.media.HeaderText = "Média";
            this.media.MinimumWidth = 6;
            this.media.Name = "media";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(16, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Resultados da Pesquisa por Nickname:";
            // 
            // dgvResultPesquisaNickname
            // 
            this.dgvResultPesquisaNickname.AllowUserToAddRows = false;
            this.dgvResultPesquisaNickname.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultPesquisaNickname.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultPesquisaNickname.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.NomeCompleto,
            this.nickname,
            this.idade,
            this.equiparesultnickname,
            this.Mediaptsnickname});
            this.dgvResultPesquisaNickname.Location = new System.Drawing.Point(16, 271);
            this.dgvResultPesquisaNickname.Name = "dgvResultPesquisaNickname";
            this.dgvResultPesquisaNickname.RowHeadersVisible = false;
            this.dgvResultPesquisaNickname.RowHeadersWidth = 51;
            this.dgvResultPesquisaNickname.RowTemplate.Height = 24;
            this.dgvResultPesquisaNickname.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultPesquisaNickname.Size = new System.Drawing.Size(772, 189);
            this.dgvResultPesquisaNickname.TabIndex = 9;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // NomeCompleto
            // 
            this.NomeCompleto.HeaderText = "NomeCompleto";
            this.NomeCompleto.MinimumWidth = 6;
            this.NomeCompleto.Name = "NomeCompleto";
            // 
            // nickname
            // 
            this.nickname.HeaderText = "Nickname";
            this.nickname.MinimumWidth = 6;
            this.nickname.Name = "nickname";
            // 
            // idade
            // 
            this.idade.HeaderText = "Idade";
            this.idade.MinimumWidth = 6;
            this.idade.Name = "idade";
            // 
            // equiparesultnickname
            // 
            this.equiparesultnickname.HeaderText = "Equipa";
            this.equiparesultnickname.MinimumWidth = 6;
            this.equiparesultnickname.Name = "equiparesultnickname";
            // 
            // Mediaptsnickname
            // 
            this.Mediaptsnickname.HeaderText = "Média";
            this.Mediaptsnickname.MinimumWidth = 6;
            this.Mediaptsnickname.Name = "Mediaptsnickname";
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnVoltarMenu.Location = new System.Drawing.Point(20, 466);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.Size = new System.Drawing.Size(95, 30);
            this.btnVoltarMenu.TabIndex = 22;
            this.btnVoltarMenu.Text = "Voltar Menu";
            this.btnVoltarMenu.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnPesquisar.Location = new System.Drawing.Point(695, 13);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(95, 30);
            this.btnPesquisar.TabIndex = 23;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // FormEstatisticasLINQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 503);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnVoltarMenu);
            this.Controls.Add(this.dgvResultPesquisaNickname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTop3Jogadores);
            this.Controls.Add(this.lblTop3Jogadores);
            this.Controls.Add(this.dgvTabelaClassificativa);
            this.Controls.Add(this.lblTabelaClassificativa);
            this.Controls.Add(this.txtPesquisarNick);
            this.Controls.Add(this.lblPesquisarNick);
            this.Controls.Add(this.cmbFiltroTorneio);
            this.Controls.Add(this.lblTorneios);
            this.Name = "FormEstatisticasLINQ";
            this.Text = "Filtros e Pesquisas ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaClassificativa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop3Jogadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultPesquisaNickname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.Label lblTop3Jogadores;
        private System.Windows.Forms.DataGridView dgvTop3Jogadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn posicaotop3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nick;
        private System.Windows.Forms.DataGridViewTextBoxColumn _equipa;
        private System.Windows.Forms.DataGridViewTextBoxColumn media;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvResultPesquisaNickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn equiparesultnickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mediaptsnickname;
        private System.Windows.Forms.Button btnVoltarMenu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnPesquisar;
    }
}