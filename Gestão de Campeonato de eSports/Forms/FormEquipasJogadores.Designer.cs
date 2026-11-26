namespace Gestão_de_Campeonato_de_eSports
{
    partial class FormEquipasJogadores
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
            this.pnlCampeonato = new System.Windows.Forms.Panel();
            this.lblCampeonato = new System.Windows.Forms.Label();
            this.cmbCampeonatos = new System.Windows.Forms.ComboBox();
            this.lblTorneio = new System.Windows.Forms.Label();
            this.pnlTorneio = new System.Windows.Forms.Panel();
            this.cmbTorneios = new System.Windows.Forms.ComboBox();
            this.pnlGestaoEquipas = new System.Windows.Forms.Panel();
            this.grpEquipa = new System.Windows.Forms.GroupBox();
            this.btnDelEquipa = new System.Windows.Forms.Button();
            this.btnEditEquipa = new System.Windows.Forms.Button();
            this.btnAddEquipa = new System.Windows.Forms.Button();
            this.txtPaisEquipa = new System.Windows.Forms.TextBox();
            this.txtNomeEquipa = new System.Windows.Forms.TextBox();
            this.txtIdEquipa = new System.Windows.Forms.TextBox();
            this.lblPaisEquipa = new System.Windows.Forms.Label();
            this.lblNomeEquipa = new System.Windows.Forms.Label();
            this.lblIdEquipa = new System.Windows.Forms.Label();
            this.pnlGestaoJogadores = new System.Windows.Forms.Panel();
            this.grpJogador = new System.Windows.Forms.GroupBox();
            this.btnAddPontos = new System.Windows.Forms.Button();
            this.lstvPontuacoes = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numIdade = new System.Windows.Forms.NumericUpDown();
            this.lblIdadeJogador = new System.Windows.Forms.Label();
            this.txtNickNameJogador = new System.Windows.Forms.TextBox();
            this.lblNickNameJogador = new System.Windows.Forms.Label();
            this.txtbNomeJogador = new System.Windows.Forms.TextBox();
            this.txtbIdJogador = new System.Windows.Forms.TextBox();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.lblIdJogador = new System.Windows.Forms.Label();
            this.btnDelJogador = new System.Windows.Forms.Button();
            this.btnAddJogador = new System.Windows.Forms.Button();
            this.btnEditJogador = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dgvEquipas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvJogadores = new System.Windows.Forms.DataGridView();
            this.dgvidJogador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.media = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnHelpLogs = new System.Windows.Forms.Button();
            this.lblIdade = new System.Windows.Forms.Label();
            this.pnlCampeonato.SuspendLayout();
            this.pnlTorneio.SuspendLayout();
            this.pnlGestaoEquipas.SuspendLayout();
            this.grpEquipa.SuspendLayout();
            this.pnlGestaoJogadores.SuspendLayout();
            this.grpJogador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogadores)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCampeonato
            // 
            this.pnlCampeonato.Controls.Add(this.lblCampeonato);
            this.pnlCampeonato.Controls.Add(this.cmbCampeonatos);
            this.pnlCampeonato.Location = new System.Drawing.Point(13, 13);
            this.pnlCampeonato.Name = "pnlCampeonato";
            this.pnlCampeonato.Size = new System.Drawing.Size(374, 23);
            this.pnlCampeonato.TabIndex = 0;
            // 
            // lblCampeonato
            // 
            this.lblCampeonato.AutoSize = true;
            this.lblCampeonato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCampeonato.Location = new System.Drawing.Point(3, 0);
            this.lblCampeonato.Name = "lblCampeonato";
            this.lblCampeonato.Size = new System.Drawing.Size(113, 20);
            this.lblCampeonato.TabIndex = 0;
            this.lblCampeonato.Text = "Campeonato: ";
            // 
            // cmbCampeonatos
            // 
            this.cmbCampeonatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampeonatos.FormattingEnabled = true;
            this.cmbCampeonatos.Location = new System.Drawing.Point(122, 0);
            this.cmbCampeonatos.Name = "cmbCampeonatos";
            this.cmbCampeonatos.Size = new System.Drawing.Size(121, 24);
            this.cmbCampeonatos.TabIndex = 3;
            // 
            // lblTorneio
            // 
            this.lblTorneio.AutoSize = true;
            this.lblTorneio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTorneio.Location = new System.Drawing.Point(3, 0);
            this.lblTorneio.Name = "lblTorneio";
            this.lblTorneio.Size = new System.Drawing.Size(75, 20);
            this.lblTorneio.TabIndex = 1;
            this.lblTorneio.Text = "Torneio: ";
            // 
            // pnlTorneio
            // 
            this.pnlTorneio.Controls.Add(this.cmbTorneios);
            this.pnlTorneio.Controls.Add(this.lblTorneio);
            this.pnlTorneio.Location = new System.Drawing.Point(394, 13);
            this.pnlTorneio.Name = "pnlTorneio";
            this.pnlTorneio.Size = new System.Drawing.Size(376, 24);
            this.pnlTorneio.TabIndex = 2;
            // 
            // cmbTorneios
            // 
            this.cmbTorneios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTorneios.FormattingEnabled = true;
            this.cmbTorneios.Location = new System.Drawing.Point(84, 0);
            this.cmbTorneios.Name = "cmbTorneios";
            this.cmbTorneios.Size = new System.Drawing.Size(121, 24);
            this.cmbTorneios.TabIndex = 4;
            // 
            // pnlGestaoEquipas
            // 
            this.pnlGestaoEquipas.Controls.Add(this.grpEquipa);
            this.pnlGestaoEquipas.Location = new System.Drawing.Point(13, 42);
            this.pnlGestaoEquipas.Name = "pnlGestaoEquipas";
            this.pnlGestaoEquipas.Size = new System.Drawing.Size(374, 158);
            this.pnlGestaoEquipas.TabIndex = 3;
            // 
            // grpEquipa
            // 
            this.grpEquipa.Controls.Add(this.btnDelEquipa);
            this.grpEquipa.Controls.Add(this.btnEditEquipa);
            this.grpEquipa.Controls.Add(this.btnAddEquipa);
            this.grpEquipa.Controls.Add(this.txtPaisEquipa);
            this.grpEquipa.Controls.Add(this.txtNomeEquipa);
            this.grpEquipa.Controls.Add(this.txtIdEquipa);
            this.grpEquipa.Controls.Add(this.lblPaisEquipa);
            this.grpEquipa.Controls.Add(this.lblNomeEquipa);
            this.grpEquipa.Controls.Add(this.lblIdEquipa);
            this.grpEquipa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpEquipa.Location = new System.Drawing.Point(3, 5);
            this.grpEquipa.Name = "grpEquipa";
            this.grpEquipa.Size = new System.Drawing.Size(364, 150);
            this.grpEquipa.TabIndex = 0;
            this.grpEquipa.TabStop = false;
            this.grpEquipa.Text = "Gestão de Equipas";
            // 
            // btnDelEquipa
            // 
            this.btnDelEquipa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnDelEquipa.Location = new System.Drawing.Point(202, 107);
            this.btnDelEquipa.Name = "btnDelEquipa";
            this.btnDelEquipa.Size = new System.Drawing.Size(130, 30);
            this.btnDelEquipa.TabIndex = 7;
            this.btnDelEquipa.Text = "Deletar Equipa";
            this.btnDelEquipa.UseVisualStyleBackColor = true;
            // 
            // btnEditEquipa
            // 
            this.btnEditEquipa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnEditEquipa.Location = new System.Drawing.Point(202, 69);
            this.btnEditEquipa.Name = "btnEditEquipa";
            this.btnEditEquipa.Size = new System.Drawing.Size(130, 30);
            this.btnEditEquipa.TabIndex = 6;
            this.btnEditEquipa.Text = "Editar Equipa";
            this.btnEditEquipa.UseVisualStyleBackColor = true;
            // 
            // btnAddEquipa
            // 
            this.btnAddEquipa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnAddEquipa.Location = new System.Drawing.Point(202, 25);
            this.btnAddEquipa.Name = "btnAddEquipa";
            this.btnAddEquipa.Size = new System.Drawing.Size(130, 30);
            this.btnAddEquipa.TabIndex = 5;
            this.btnAddEquipa.Text = "Adicionar Equipa";
            this.btnAddEquipa.UseVisualStyleBackColor = true;
            // 
            // txtPaisEquipa
            // 
            this.txtPaisEquipa.Location = new System.Drawing.Point(59, 101);
            this.txtPaisEquipa.Name = "txtPaisEquipa";
            this.txtPaisEquipa.Size = new System.Drawing.Size(100, 26);
            this.txtPaisEquipa.TabIndex = 5;
            // 
            // txtNomeEquipa
            // 
            this.txtNomeEquipa.Location = new System.Drawing.Point(59, 63);
            this.txtNomeEquipa.Name = "txtNomeEquipa";
            this.txtNomeEquipa.Size = new System.Drawing.Size(100, 26);
            this.txtNomeEquipa.TabIndex = 4;
            // 
            // txtIdEquipa
            // 
            this.txtIdEquipa.Location = new System.Drawing.Point(59, 26);
            this.txtIdEquipa.Name = "txtIdEquipa";
            this.txtIdEquipa.Size = new System.Drawing.Size(100, 26);
            this.txtIdEquipa.TabIndex = 3;
            // 
            // lblPaisEquipa
            // 
            this.lblPaisEquipa.AutoSize = true;
            this.lblPaisEquipa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblPaisEquipa.Location = new System.Drawing.Point(6, 107);
            this.lblPaisEquipa.Name = "lblPaisEquipa";
            this.lblPaisEquipa.Size = new System.Drawing.Size(37, 16);
            this.lblPaisEquipa.TabIndex = 2;
            this.lblPaisEquipa.Text = "País:";
            // 
            // lblNomeEquipa
            // 
            this.lblNomeEquipa.AutoSize = true;
            this.lblNomeEquipa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblNomeEquipa.Location = new System.Drawing.Point(6, 69);
            this.lblNomeEquipa.Name = "lblNomeEquipa";
            this.lblNomeEquipa.Size = new System.Drawing.Size(47, 16);
            this.lblNomeEquipa.TabIndex = 1;
            this.lblNomeEquipa.Text = "Nome:";
            // 
            // lblIdEquipa
            // 
            this.lblIdEquipa.AutoSize = true;
            this.lblIdEquipa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblIdEquipa.Location = new System.Drawing.Point(6, 32);
            this.lblIdEquipa.Name = "lblIdEquipa";
            this.lblIdEquipa.Size = new System.Drawing.Size(23, 16);
            this.lblIdEquipa.TabIndex = 0;
            this.lblIdEquipa.Text = "ID:";
            // 
            // pnlGestaoJogadores
            // 
            this.pnlGestaoJogadores.Controls.Add(this.grpJogador);
            this.pnlGestaoJogadores.Location = new System.Drawing.Point(394, 43);
            this.pnlGestaoJogadores.Name = "pnlGestaoJogadores";
            this.pnlGestaoJogadores.Size = new System.Drawing.Size(376, 307);
            this.pnlGestaoJogadores.TabIndex = 4;
            // 
            // grpJogador
            // 
            this.grpJogador.Controls.Add(this.lblIdade);
            this.grpJogador.Controls.Add(this.btnAddPontos);
            this.grpJogador.Controls.Add(this.lstvPontuacoes);
            this.grpJogador.Controls.Add(this.label1);
            this.grpJogador.Controls.Add(this.numericUpDown1);
            this.grpJogador.Controls.Add(this.numIdade);
            this.grpJogador.Controls.Add(this.lblIdadeJogador);
            this.grpJogador.Controls.Add(this.txtNickNameJogador);
            this.grpJogador.Controls.Add(this.lblNickNameJogador);
            this.grpJogador.Controls.Add(this.txtbNomeJogador);
            this.grpJogador.Controls.Add(this.txtbIdJogador);
            this.grpJogador.Controls.Add(this.lblNomeJogador);
            this.grpJogador.Controls.Add(this.lblIdJogador);
            this.grpJogador.Controls.Add(this.btnDelJogador);
            this.grpJogador.Controls.Add(this.btnAddJogador);
            this.grpJogador.Controls.Add(this.btnEditJogador);
            this.grpJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpJogador.Location = new System.Drawing.Point(3, 0);
            this.grpJogador.Name = "grpJogador";
            this.grpJogador.Size = new System.Drawing.Size(369, 303);
            this.grpJogador.TabIndex = 0;
            this.grpJogador.TabStop = false;
            this.grpJogador.Text = "Gestão de Jogadores";
            // 
            // btnAddPontos
            // 
            this.btnAddPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnAddPontos.Location = new System.Drawing.Point(233, 160);
            this.btnAddPontos.Name = "btnAddPontos";
            this.btnAddPontos.Size = new System.Drawing.Size(130, 30);
            this.btnAddPontos.TabIndex = 21;
            this.btnAddPontos.Text = "Add Pontos";
            this.btnAddPontos.UseVisualStyleBackColor = true;
            // 
            // lstvPontuacoes
            // 
            this.lstvPontuacoes.HideSelection = false;
            this.lstvPontuacoes.Location = new System.Drawing.Point(7, 210);
            this.lstvPontuacoes.Name = "lstvPontuacoes";
            this.lstvPontuacoes.Size = new System.Drawing.Size(356, 87);
            this.lstvPontuacoes.TabIndex = 20;
            this.lstvPontuacoes.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label1.Location = new System.Drawing.Point(7, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Pontuação:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.numericUpDown1.Location = new System.Drawing.Point(88, 182);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 22);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numIdade
            // 
            this.numIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.numIdade.Location = new System.Drawing.Point(88, 105);
            this.numIdade.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.numIdade.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numIdade.Name = "numIdade";
            this.numIdade.Size = new System.Drawing.Size(60, 22);
            this.numIdade.TabIndex = 5;
            this.numIdade.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // lblIdadeJogador
            // 
            this.lblIdadeJogador.Location = new System.Drawing.Point(0, 0);
            this.lblIdadeJogador.Name = "lblIdadeJogador";
            this.lblIdadeJogador.Size = new System.Drawing.Size(100, 23);
            this.lblIdadeJogador.TabIndex = 22;
            // 
            // txtNickNameJogador
            // 
            this.txtNickNameJogador.Location = new System.Drawing.Point(87, 142);
            this.txtNickNameJogador.Name = "txtNickNameJogador";
            this.txtNickNameJogador.Size = new System.Drawing.Size(100, 26);
            this.txtNickNameJogador.TabIndex = 16;
            // 
            // lblNickNameJogador
            // 
            this.lblNickNameJogador.AutoSize = true;
            this.lblNickNameJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblNickNameJogador.Location = new System.Drawing.Point(7, 148);
            this.lblNickNameJogador.Name = "lblNickNameJogador";
            this.lblNickNameJogador.Size = new System.Drawing.Size(74, 16);
            this.lblNickNameJogador.TabIndex = 15;
            this.lblNickNameJogador.Text = "NickName:";
            // 
            // txtbNomeJogador
            // 
            this.txtbNomeJogador.Location = new System.Drawing.Point(87, 63);
            this.txtbNomeJogador.Name = "txtbNomeJogador";
            this.txtbNomeJogador.Size = new System.Drawing.Size(100, 26);
            this.txtbNomeJogador.TabIndex = 14;
            // 
            // txtbIdJogador
            // 
            this.txtbIdJogador.Location = new System.Drawing.Point(87, 26);
            this.txtbIdJogador.Name = "txtbIdJogador";
            this.txtbIdJogador.Size = new System.Drawing.Size(100, 26);
            this.txtbIdJogador.TabIndex = 13;
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblNomeJogador.Location = new System.Drawing.Point(7, 69);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(47, 16);
            this.lblNomeJogador.TabIndex = 12;
            this.lblNomeJogador.Text = "Nome:";
            // 
            // lblIdJogador
            // 
            this.lblIdJogador.AutoSize = true;
            this.lblIdJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblIdJogador.Location = new System.Drawing.Point(7, 32);
            this.lblIdJogador.Name = "lblIdJogador";
            this.lblIdJogador.Size = new System.Drawing.Size(23, 16);
            this.lblIdJogador.TabIndex = 11;
            this.lblIdJogador.Text = "ID:";
            // 
            // btnDelJogador
            // 
            this.btnDelJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnDelJogador.Location = new System.Drawing.Point(233, 107);
            this.btnDelJogador.Name = "btnDelJogador";
            this.btnDelJogador.Size = new System.Drawing.Size(130, 30);
            this.btnDelJogador.TabIndex = 10;
            this.btnDelJogador.Text = "Deletar Jogador";
            this.btnDelJogador.UseVisualStyleBackColor = true;
            // 
            // btnAddJogador
            // 
            this.btnAddJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnAddJogador.Location = new System.Drawing.Point(233, 25);
            this.btnAddJogador.Name = "btnAddJogador";
            this.btnAddJogador.Size = new System.Drawing.Size(130, 30);
            this.btnAddJogador.TabIndex = 8;
            this.btnAddJogador.Text = "Adicionar Jogador";
            this.btnAddJogador.UseVisualStyleBackColor = true;
            // 
            // btnEditJogador
            // 
            this.btnEditJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnEditJogador.Location = new System.Drawing.Point(233, 69);
            this.btnEditJogador.Name = "btnEditJogador";
            this.btnEditJogador.Size = new System.Drawing.Size(130, 30);
            this.btnEditJogador.TabIndex = 9;
            this.btnEditJogador.Text = "Editar Jogador";
            this.btnEditJogador.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnVoltar.Location = new System.Drawing.Point(56, 513);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 30);
            this.btnVoltar.TabIndex = 20;
            this.btnVoltar.Text = "Voltar Menu";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dgvEquipas
            // 
            this.dgvEquipas.AllowUserToAddRows = false;
            this.dgvEquipas.AllowUserToDeleteRows = false;
            this.dgvEquipas.AllowUserToResizeColumns = false;
            this.dgvEquipas.AllowUserToResizeRows = false;
            this.dgvEquipas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEquipas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.pais});
            this.dgvEquipas.Location = new System.Drawing.Point(12, 203);
            this.dgvEquipas.Name = "dgvEquipas";
            this.dgvEquipas.RowHeadersVisible = false;
            this.dgvEquipas.RowHeadersWidth = 51;
            this.dgvEquipas.RowTemplate.Height = 24;
            this.dgvEquipas.Size = new System.Drawing.Size(372, 302);
            this.dgvEquipas.TabIndex = 21;
            // 
            // id
            // 
            this.id.FillWeight = 50F;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // nome
            // 
            this.nome.FillWeight = 150F;
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            // 
            // pais
            // 
            this.pais.HeaderText = "País";
            this.pais.MinimumWidth = 6;
            this.pais.Name = "pais";
            // 
            // dgvJogadores
            // 
            this.dgvJogadores.AllowUserToAddRows = false;
            this.dgvJogadores.AllowUserToDeleteRows = false;
            this.dgvJogadores.AllowUserToResizeColumns = false;
            this.dgvJogadores.AllowUserToResizeRows = false;
            this.dgvJogadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJogadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJogadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvidJogador,
            this.nickname,
            this.idade,
            this.media});
            this.dgvJogadores.Location = new System.Drawing.Point(394, 352);
            this.dgvJogadores.Name = "dgvJogadores";
            this.dgvJogadores.RowHeadersVisible = false;
            this.dgvJogadores.RowHeadersWidth = 51;
            this.dgvJogadores.RowTemplate.Height = 24;
            this.dgvJogadores.Size = new System.Drawing.Size(376, 196);
            this.dgvJogadores.TabIndex = 22;
            // 
            // dgvidJogador
            // 
            this.dgvidJogador.FillWeight = 50F;
            this.dgvidJogador.HeaderText = "ID";
            this.dgvidJogador.MinimumWidth = 6;
            this.dgvidJogador.Name = "dgvidJogador";
            // 
            // nickname
            // 
            this.nickname.HeaderText = "NickName";
            this.nickname.MinimumWidth = 6;
            this.nickname.Name = "nickname";
            // 
            // idade
            // 
            this.idade.HeaderText = "Idade";
            this.idade.MinimumWidth = 6;
            this.idade.Name = "idade";
            // 
            // media
            // 
            this.media.HeaderText = "Média";
            this.media.MinimumWidth = 6;
            this.media.Name = "media";
            // 
            // BtnHelpLogs
            // 
            this.BtnHelpLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHelpLogs.Location = new System.Drawing.Point(13, 510);
            this.BtnHelpLogs.Name = "BtnHelpLogs";
            this.BtnHelpLogs.Size = new System.Drawing.Size(37, 33);
            this.BtnHelpLogs.TabIndex = 23;
            this.BtnHelpLogs.Text = "?";
            this.BtnHelpLogs.UseVisualStyleBackColor = true;
            this.BtnHelpLogs.Click += new System.EventHandler(this.BtnHelpLogs_Click);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblIdade.Location = new System.Drawing.Point(9, 105);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(45, 16);
            this.lblIdade.TabIndex = 23;
            this.lblIdade.Text = "Idade:";
            // 
            // FormEquipasJogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.BtnHelpLogs);
            this.Controls.Add(this.dgvJogadores);
            this.Controls.Add(this.dgvEquipas);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pnlGestaoJogadores);
            this.Controls.Add(this.pnlGestaoEquipas);
            this.Controls.Add(this.pnlTorneio);
            this.Controls.Add(this.pnlCampeonato);
            this.Name = "FormEquipasJogadores";
            this.Text = "Equipas e Jogadores";
            this.pnlCampeonato.ResumeLayout(false);
            this.pnlCampeonato.PerformLayout();
            this.pnlTorneio.ResumeLayout(false);
            this.pnlTorneio.PerformLayout();
            this.pnlGestaoEquipas.ResumeLayout(false);
            this.grpEquipa.ResumeLayout(false);
            this.grpEquipa.PerformLayout();
            this.pnlGestaoJogadores.ResumeLayout(false);
            this.grpJogador.ResumeLayout(false);
            this.grpJogador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCampeonato;
        private System.Windows.Forms.Label lblCampeonato;
        private System.Windows.Forms.Label lblTorneio;
        private System.Windows.Forms.Panel pnlTorneio;
        private System.Windows.Forms.ComboBox cmbCampeonatos;
        private System.Windows.Forms.ComboBox cmbTorneios;
        private System.Windows.Forms.Panel pnlGestaoEquipas;
        private System.Windows.Forms.Panel pnlGestaoJogadores;
        private System.Windows.Forms.GroupBox grpEquipa;
        private System.Windows.Forms.Label lblIdEquipa;
        private System.Windows.Forms.GroupBox grpJogador;
        private System.Windows.Forms.Label lblNomeEquipa;
        private System.Windows.Forms.Button btnAddEquipa;
        private System.Windows.Forms.TextBox txtPaisEquipa;
        private System.Windows.Forms.TextBox txtNomeEquipa;
        private System.Windows.Forms.TextBox txtIdEquipa;
        private System.Windows.Forms.Label lblPaisEquipa;
        private System.Windows.Forms.Button btnDelEquipa;
        private System.Windows.Forms.Button btnEditEquipa;
        private System.Windows.Forms.Button btnDelJogador;
        private System.Windows.Forms.Button btnAddJogador;
        private System.Windows.Forms.Button btnEditJogador;
        private System.Windows.Forms.TextBox txtNickNameJogador;
        private System.Windows.Forms.Label lblNickNameJogador;
        private System.Windows.Forms.TextBox txtbNomeJogador;
        private System.Windows.Forms.TextBox txtbIdJogador;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.Label lblIdJogador;
        private System.Windows.Forms.NumericUpDown numIdade;
        private System.Windows.Forms.Label lblIdadeJogador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dgvEquipas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn pais;
        private System.Windows.Forms.ListView lstvPontuacoes;
        private System.Windows.Forms.DataGridView dgvJogadores;
        private System.Windows.Forms.Button btnAddPontos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvidJogador;
        private System.Windows.Forms.DataGridViewTextBoxColumn nickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn media;
        private System.Windows.Forms.Button BtnHelpLogs;
        private System.Windows.Forms.Label lblIdade;
    }
}