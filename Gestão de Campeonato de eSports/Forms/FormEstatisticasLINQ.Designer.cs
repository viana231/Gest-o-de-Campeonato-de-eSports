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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaClassificativa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop3Jogadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultPesquisaNickname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTorneios
            // 
            this.lblTorneios.AutoSize = true;
            this.lblTorneios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.lblTorneios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTorneios.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTorneios.Location = new System.Drawing.Point(21, 81);
            this.lblTorneios.Name = "lblTorneios";
            this.lblTorneios.Size = new System.Drawing.Size(95, 25);
            this.lblTorneios.TabIndex = 0;
            this.lblTorneios.Text = "Torneios:";
            // 
            // cmbFiltroTorneio
            // 
            this.cmbFiltroTorneio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.cmbFiltroTorneio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFiltroTorneio.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbFiltroTorneio.FormattingEnabled = true;
            this.cmbFiltroTorneio.Location = new System.Drawing.Point(116, 80);
            this.cmbFiltroTorneio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFiltroTorneio.Name = "cmbFiltroTorneio";
            this.cmbFiltroTorneio.Size = new System.Drawing.Size(136, 28);
            this.cmbFiltroTorneio.TabIndex = 1;
            this.cmbFiltroTorneio.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroTorneio_SelectedIndexChanged);
            // 
            // lblPesquisarNick
            // 
            this.lblPesquisarNick.AutoSize = true;
            this.lblPesquisarNick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.lblPesquisarNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPesquisarNick.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPesquisarNick.Location = new System.Drawing.Point(497, 79);
            this.lblPesquisarNick.Name = "lblPesquisarNick";
            this.lblPesquisarNick.Size = new System.Drawing.Size(148, 25);
            this.lblPesquisarNick.TabIndex = 2;
            this.lblPesquisarNick.Text = "Pesquisar Nick:";
            // 
            // txtPesquisarNick
            // 
            this.txtPesquisarNick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.txtPesquisarNick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisarNick.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtPesquisarNick.Location = new System.Drawing.Point(651, 79);
            this.txtPesquisarNick.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPesquisarNick.Name = "txtPesquisarNick";
            this.txtPesquisarNick.Size = new System.Drawing.Size(112, 26);
            this.txtPesquisarNick.TabIndex = 3;
            this.txtPesquisarNick.TextChanged += new System.EventHandler(this.txtPesquisarNick_TextChanged);
            // 
            // lblTabelaClassificativa
            // 
            this.lblTabelaClassificativa.AutoSize = true;
            this.lblTabelaClassificativa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.lblTabelaClassificativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabelaClassificativa.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTabelaClassificativa.Location = new System.Drawing.Point(23, 130);
            this.lblTabelaClassificativa.Name = "lblTabelaClassificativa";
            this.lblTabelaClassificativa.Size = new System.Drawing.Size(203, 22);
            this.lblTabelaClassificativa.TabIndex = 4;
            this.lblTabelaClassificativa.Text = "Tabela Classificativa:";
            // 
            // dgvTabelaClassificativa
            // 
            this.dgvTabelaClassificativa.AllowUserToAddRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            this.dgvTabelaClassificativa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTabelaClassificativa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTabelaClassificativa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.dgvTabelaClassificativa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabelaClassificativa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvTabelaClassificativa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelaClassificativa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.posicao,
            this.equipa,
            this.jogos,
            this.vitoria,
            this.derrota,
            this.pontos});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTabelaClassificativa.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvTabelaClassificativa.EnableHeadersVisualStyles = false;
            this.dgvTabelaClassificativa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(67)))), ((int)(((byte)(82)))));
            this.dgvTabelaClassificativa.Location = new System.Drawing.Point(20, 157);
            this.dgvTabelaClassificativa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTabelaClassificativa.Name = "dgvTabelaClassificativa";
            this.dgvTabelaClassificativa.RowHeadersVisible = false;
            this.dgvTabelaClassificativa.RowHeadersWidth = 51;
            this.dgvTabelaClassificativa.RowTemplate.Height = 24;
            this.dgvTabelaClassificativa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabelaClassificativa.Size = new System.Drawing.Size(439, 222);
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
            this.lblTop3Jogadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.lblTop3Jogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop3Jogadores.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTop3Jogadores.Location = new System.Drawing.Point(488, 129);
            this.lblTop3Jogadores.Name = "lblTop3Jogadores";
            this.lblTop3Jogadores.Size = new System.Drawing.Size(167, 22);
            this.lblTop3Jogadores.TabIndex = 6;
            this.lblTop3Jogadores.Text = "Top 3 Jogadores:";
            // 
            // dgvTop3Jogadores
            // 
            this.dgvTop3Jogadores.AllowUserToAddRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            this.dgvTop3Jogadores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvTop3Jogadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTop3Jogadores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.dgvTop3Jogadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTop3Jogadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvTop3Jogadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTop3Jogadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.posicaotop3,
            this.nick,
            this._equipa,
            this.media});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTop3Jogadores.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvTop3Jogadores.EnableHeadersVisualStyles = false;
            this.dgvTop3Jogadores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(67)))), ((int)(((byte)(82)))));
            this.dgvTop3Jogadores.Location = new System.Drawing.Point(489, 156);
            this.dgvTop3Jogadores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTop3Jogadores.Name = "dgvTop3Jogadores";
            this.dgvTop3Jogadores.RowHeadersVisible = false;
            this.dgvTop3Jogadores.RowHeadersWidth = 51;
            this.dgvTop3Jogadores.RowTemplate.Height = 24;
            this.dgvTop3Jogadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTop3Jogadores.Size = new System.Drawing.Size(442, 222);
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
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(18, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Resultados da Pesquisa por Nickname:";
            // 
            // dgvResultPesquisaNickname
            // 
            this.dgvResultPesquisaNickname.AllowUserToAddRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            this.dgvResultPesquisaNickname.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvResultPesquisaNickname.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultPesquisaNickname.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.dgvResultPesquisaNickname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultPesquisaNickname.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvResultPesquisaNickname.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultPesquisaNickname.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.NomeCompleto,
            this.nickname,
            this.idade,
            this.equiparesultnickname,
            this.Mediaptsnickname});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResultPesquisaNickname.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvResultPesquisaNickname.EnableHeadersVisualStyles = false;
            this.dgvResultPesquisaNickname.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(67)))), ((int)(((byte)(82)))));
            this.dgvResultPesquisaNickname.Location = new System.Drawing.Point(15, 30);
            this.dgvResultPesquisaNickname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvResultPesquisaNickname.Name = "dgvResultPesquisaNickname";
            this.dgvResultPesquisaNickname.RowHeadersVisible = false;
            this.dgvResultPesquisaNickname.RowHeadersWidth = 51;
            this.dgvResultPesquisaNickname.RowTemplate.Height = 24;
            this.dgvResultPesquisaNickname.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultPesquisaNickname.Size = new System.Drawing.Size(895, 236);
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
            this.btnVoltarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.btnVoltarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnVoltarMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVoltarMenu.Location = new System.Drawing.Point(22, 691);
            this.btnVoltarMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.Size = new System.Drawing.Size(123, 30);
            this.btnVoltarMenu.TabIndex = 22;
            this.btnVoltarMenu.Text = "Voltar Menu";
            this.btnVoltarMenu.UseVisualStyleBackColor = false;
            this.btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormEstatisticasLINQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 503);
            this.Controls.Add(this.btnVoltarMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTop3Jogadores);
            this.Controls.Add(this.lblTop3Jogadores);
            this.Controls.Add(this.dgvTabelaClassificativa);
            this.Controls.Add(this.lblTabelaClassificativa);
            this.Controls.Add(this.txtPesquisarNick);
            this.Controls.Add(this.lblPesquisarNick);
            this.Controls.Add(this.cmbFiltroTorneio);
            this.Controls.Add(this.lblTorneios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormEstatisticasLINQ";
            this.Text = "Filtros e Pesquisas ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaClassificativa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop3Jogadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultPesquisaNickname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
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
    }
}