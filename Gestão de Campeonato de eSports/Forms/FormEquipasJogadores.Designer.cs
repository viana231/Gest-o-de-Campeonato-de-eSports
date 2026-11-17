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
            this.btnDelJogador = new System.Windows.Forms.Button();
            this.btnEditJogador = new System.Windows.Forms.Button();
            this.btnAddJogador = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.lblIdJogador = new System.Windows.Forms.Label();
            this.lblNickNameJogador = new System.Windows.Forms.Label();
            this.txtNickNameJogador = new System.Windows.Forms.TextBox();
            this.numIdade = new System.Windows.Forms.NumericUpDown();
            this.lblIdadeJogador = new System.Windows.Forms.Label();
            this.pnlCampeonato.SuspendLayout();
            this.pnlTorneio.SuspendLayout();
            this.pnlGestaoEquipas.SuspendLayout();
            this.grpEquipa.SuspendLayout();
            this.pnlGestaoJogadores.SuspendLayout();
            this.grpJogador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCampeonato
            // 
            this.pnlCampeonato.Controls.Add(this.lblCampeonato);
            this.pnlCampeonato.Controls.Add(this.cmbCampeonatos);
            this.pnlCampeonato.Location = new System.Drawing.Point(13, 13);
            this.pnlCampeonato.Name = "pnlCampeonato";
            this.pnlCampeonato.Size = new System.Drawing.Size(374, 37);
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
            this.cmbCampeonatos.Location = new System.Drawing.Point(122, 3);
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
            this.pnlTorneio.Size = new System.Drawing.Size(376, 37);
            this.pnlTorneio.TabIndex = 2;
            // 
            // cmbTorneios
            // 
            this.cmbTorneios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTorneios.FormattingEnabled = true;
            this.cmbTorneios.Location = new System.Drawing.Point(84, 3);
            this.cmbTorneios.Name = "cmbTorneios";
            this.cmbTorneios.Size = new System.Drawing.Size(121, 24);
            this.cmbTorneios.TabIndex = 4;
            // 
            // pnlGestaoEquipas
            // 
            this.pnlGestaoEquipas.Controls.Add(this.grpEquipa);
            this.pnlGestaoEquipas.Location = new System.Drawing.Point(13, 57);
            this.pnlGestaoEquipas.Name = "pnlGestaoEquipas";
            this.pnlGestaoEquipas.Size = new System.Drawing.Size(374, 193);
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
            this.grpEquipa.Location = new System.Drawing.Point(7, 4);
            this.grpEquipa.Name = "grpEquipa";
            this.grpEquipa.Size = new System.Drawing.Size(364, 186);
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
            this.txtPaisEquipa.Location = new System.Drawing.Point(49, 101);
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
            this.txtIdEquipa.Location = new System.Drawing.Point(35, 26);
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
            this.pnlGestaoJogadores.Location = new System.Drawing.Point(394, 57);
            this.pnlGestaoJogadores.Name = "pnlGestaoJogadores";
            this.pnlGestaoJogadores.Size = new System.Drawing.Size(376, 292);
            this.pnlGestaoJogadores.TabIndex = 4;
            // 
            // grpJogador
            // 
            this.grpJogador.Controls.Add(this.numIdade);
            this.grpJogador.Controls.Add(this.lblIdadeJogador);
            this.grpJogador.Controls.Add(this.txtNickNameJogador);
            this.grpJogador.Controls.Add(this.lblNickNameJogador);
            this.grpJogador.Controls.Add(this.textBox1);
            this.grpJogador.Controls.Add(this.textBox2);
            this.grpJogador.Controls.Add(this.lblNomeJogador);
            this.grpJogador.Controls.Add(this.lblIdJogador);
            this.grpJogador.Controls.Add(this.btnDelJogador);
            this.grpJogador.Controls.Add(this.btnAddJogador);
            this.grpJogador.Controls.Add(this.btnEditJogador);
            this.grpJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpJogador.Location = new System.Drawing.Point(4, 4);
            this.grpJogador.Name = "grpJogador";
            this.grpJogador.Size = new System.Drawing.Size(369, 285);
            this.grpJogador.TabIndex = 0;
            this.grpJogador.TabStop = false;
            this.grpJogador.Text = "Gestão de Jogadores";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(36, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 13;
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
            // txtNickNameJogador
            // 
            this.txtNickNameJogador.Location = new System.Drawing.Point(87, 142);
            this.txtNickNameJogador.Name = "txtNickNameJogador";
            this.txtNickNameJogador.Size = new System.Drawing.Size(100, 26);
            this.txtNickNameJogador.TabIndex = 16;
            // 
            // numIdade
            // 
            this.numIdade.Location = new System.Drawing.Point(58, 105);
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
            this.numIdade.Size = new System.Drawing.Size(78, 26);
            this.numIdade.TabIndex = 5;
            this.numIdade.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // lblIdadeJogador
            // 
            this.lblIdadeJogador.AutoSize = true;
            this.lblIdadeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblIdadeJogador.Location = new System.Drawing.Point(7, 107);
            this.lblIdadeJogador.Name = "lblIdadeJogador";
            this.lblIdadeJogador.Size = new System.Drawing.Size(45, 16);
            this.lblIdadeJogador.TabIndex = 17;
            this.lblIdadeJogador.Text = "Idade:";
            // 
            // FormEquipasJogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
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
            ((System.ComponentModel.ISupportInitialize)(this.numIdade)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.Label lblIdJogador;
        private System.Windows.Forms.NumericUpDown numIdade;
        private System.Windows.Forms.Label lblIdadeJogador;
    }
}