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
            this.lblTorneio = new System.Windows.Forms.Label();
            this.pnlTorneio = new System.Windows.Forms.Panel();
            this.cmbCampeonatos = new System.Windows.Forms.ComboBox();
            this.cmbTorneios = new System.Windows.Forms.ComboBox();
            this.pnlGestaoEquipas = new System.Windows.Forms.Panel();
            this.pnlGestaoJogadores = new System.Windows.Forms.Panel();
            this.grpEquipa = new System.Windows.Forms.GroupBox();
            this.grpJogador = new System.Windows.Forms.GroupBox();
            this.lblIdEquipa = new System.Windows.Forms.Label();
            this.lblNomeEquipa = new System.Windows.Forms.Label();
            this.lblPaisEquipa = new System.Windows.Forms.Label();
            this.txtIdEquipa = new System.Windows.Forms.TextBox();
            this.txtNomeEquipa = new System.Windows.Forms.TextBox();
            this.txtPaisEquipa = new System.Windows.Forms.TextBox();
            this.btnAddEquipa = new System.Windows.Forms.Button();
            this.btnEditEquipa = new System.Windows.Forms.Button();
            this.btnDelEquipa = new System.Windows.Forms.Button();
            this.pnlCampeonato.SuspendLayout();
            this.pnlTorneio.SuspendLayout();
            this.pnlGestaoEquipas.SuspendLayout();
            this.pnlGestaoJogadores.SuspendLayout();
            this.grpEquipa.SuspendLayout();
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
            // cmbCampeonatos
            // 
            this.cmbCampeonatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampeonatos.FormattingEnabled = true;
            this.cmbCampeonatos.Location = new System.Drawing.Point(122, 3);
            this.cmbCampeonatos.Name = "cmbCampeonatos";
            this.cmbCampeonatos.Size = new System.Drawing.Size(121, 24);
            this.cmbCampeonatos.TabIndex = 3;
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
            // pnlGestaoJogadores
            // 
            this.pnlGestaoJogadores.Controls.Add(this.grpJogador);
            this.pnlGestaoJogadores.Location = new System.Drawing.Point(394, 57);
            this.pnlGestaoJogadores.Name = "pnlGestaoJogadores";
            this.pnlGestaoJogadores.Size = new System.Drawing.Size(376, 193);
            this.pnlGestaoJogadores.TabIndex = 4;
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
            // grpJogador
            // 
            this.grpJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpJogador.Location = new System.Drawing.Point(4, 4);
            this.grpJogador.Name = "grpJogador";
            this.grpJogador.Size = new System.Drawing.Size(369, 186);
            this.grpJogador.TabIndex = 0;
            this.grpJogador.TabStop = false;
            this.grpJogador.Text = "Gestão de Jogadores";
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
            // txtIdEquipa
            // 
            this.txtIdEquipa.Location = new System.Drawing.Point(35, 26);
            this.txtIdEquipa.Name = "txtIdEquipa";
            this.txtIdEquipa.Size = new System.Drawing.Size(100, 26);
            this.txtIdEquipa.TabIndex = 3;
            // 
            // txtNomeEquipa
            // 
            this.txtNomeEquipa.Location = new System.Drawing.Point(59, 63);
            this.txtNomeEquipa.Name = "txtNomeEquipa";
            this.txtNomeEquipa.Size = new System.Drawing.Size(100, 26);
            this.txtNomeEquipa.TabIndex = 4;
            // 
            // txtPaisEquipa
            // 
            this.txtPaisEquipa.Location = new System.Drawing.Point(49, 101);
            this.txtPaisEquipa.Name = "txtPaisEquipa";
            this.txtPaisEquipa.Size = new System.Drawing.Size(100, 26);
            this.txtPaisEquipa.TabIndex = 5;
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
            this.pnlGestaoJogadores.ResumeLayout(false);
            this.grpEquipa.ResumeLayout(false);
            this.grpEquipa.PerformLayout();
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
    }
}