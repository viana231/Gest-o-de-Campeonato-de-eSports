namespace Gestão_de_Campeonato_de_eSports
{
    partial class FormTorneiosPartidas
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
            this.lblCampeonato = new System.Windows.Forms.Label();
            this.cmbCampeonatos = new System.Windows.Forms.ComboBox();
            this.grpCriarTorneio = new System.Windows.Forms.GroupBox();
            this.btnCriarTorneio = new System.Windows.Forms.Button();
            this.txtJogo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblJogo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.grpInscricoes = new System.Windows.Forms.GroupBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnInscreverEquipa = new System.Windows.Forms.Button();
            this.cmbEquipasDisp = new System.Windows.Forms.ComboBox();
            this.lblEquipa = new System.Windows.Forms.Label();
            this.cmbTorneio = new System.Windows.Forms.ComboBox();
            this.lblTorneio = new System.Windows.Forms.Label();
            this.grpPartidas = new System.Windows.Forms.GroupBox();
            this.lblVS = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.cmbEquipaA = new System.Windows.Forms.ComboBox();
            this.txtIdPartida = new System.Windows.Forms.TextBox();
            this.lblResultadoA = new System.Windows.Forms.Label();
            this.lblEquipaA = new System.Windows.Forms.Label();
            this.lblIdPartida = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblVS = new System.Windows.Forms.Label();
            this.grpCriarTorneio.SuspendLayout();
            this.grpInscricoes.SuspendLayout();
            this.grpPartidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCampeonato
            // 
            this.lblCampeonato.AutoSize = true;
            this.lblCampeonato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCampeonato.Location = new System.Drawing.Point(13, 13);
            this.lblCampeonato.Name = "lblCampeonato";
            this.lblCampeonato.Size = new System.Drawing.Size(108, 20);
            this.lblCampeonato.TabIndex = 0;
            this.lblCampeonato.Text = "Campeonato:";
            // 
            // cmbCampeonatos
            // 
            this.cmbCampeonatos.FormattingEnabled = true;
            this.cmbCampeonatos.Location = new System.Drawing.Point(127, 12);
            this.cmbCampeonatos.Name = "cmbCampeonatos";
            this.cmbCampeonatos.Size = new System.Drawing.Size(121, 24);
            this.cmbCampeonatos.TabIndex = 1;
            // 
            // grpCriarTorneio
            // 
            this.grpCriarTorneio.Controls.Add(this.btnCriarTorneio);
            this.grpCriarTorneio.Controls.Add(this.txtJogo);
            this.grpCriarTorneio.Controls.Add(this.txtNome);
            this.grpCriarTorneio.Controls.Add(this.txtId);
            this.grpCriarTorneio.Controls.Add(this.lblJogo);
            this.grpCriarTorneio.Controls.Add(this.lblNome);
            this.grpCriarTorneio.Controls.Add(this.lblId);
            this.grpCriarTorneio.Location = new System.Drawing.Point(13, 37);
            this.grpCriarTorneio.Name = "grpCriarTorneio";
            this.grpCriarTorneio.Size = new System.Drawing.Size(294, 142);
            this.grpCriarTorneio.TabIndex = 2;
            this.grpCriarTorneio.TabStop = false;
            this.grpCriarTorneio.Text = "Criar Torneio";
            // 
            // btnCriarTorneio
            // 
            this.btnCriarTorneio.Location = new System.Drawing.Point(9, 106);
            this.btnCriarTorneio.Name = "btnCriarTorneio";
            this.btnCriarTorneio.Size = new System.Drawing.Size(130, 30);
            this.btnCriarTorneio.TabIndex = 3;
            this.btnCriarTorneio.Text = "Criar Torneio";
            this.btnCriarTorneio.UseVisualStyleBackColor = true;
            // 
            // txtJogo
            // 
            this.txtJogo.Location = new System.Drawing.Point(54, 72);
            this.txtJogo.Name = "txtJogo";
            this.txtJogo.Size = new System.Drawing.Size(100, 22);
            this.txtJogo.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(60, 43);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 22);
            this.txtNome.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(36, 18);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 3;
            // 
            // lblJogo
            // 
            this.lblJogo.AutoSize = true;
            this.lblJogo.Location = new System.Drawing.Point(6, 74);
            this.lblJogo.Name = "lblJogo";
            this.lblJogo.Size = new System.Drawing.Size(41, 16);
            this.lblJogo.TabIndex = 2;
            this.lblJogo.Text = "Jogo:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 43);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 18);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 16);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnVoltar.Location = new System.Drawing.Point(12, 511);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 30);
            this.btnVoltar.TabIndex = 21;
            this.btnVoltar.Text = "Voltar Menu";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // grpInscricoes
            // 
            this.grpInscricoes.Controls.Add(this.lblEstado);
            this.grpInscricoes.Controls.Add(this.btnInscreverEquipa);
            this.grpInscricoes.Controls.Add(this.cmbEquipasDisp);
            this.grpInscricoes.Controls.Add(this.lblEquipa);
            this.grpInscricoes.Controls.Add(this.cmbTorneio);
            this.grpInscricoes.Controls.Add(this.lblTorneio);
            this.grpInscricoes.Location = new System.Drawing.Point(328, 37);
            this.grpInscricoes.Name = "grpInscricoes";
            this.grpInscricoes.Size = new System.Drawing.Size(392, 142);
            this.grpInscricoes.TabIndex = 22;
            this.grpInscricoes.TabStop = false;
            this.grpInscricoes.Text = "Inscrições";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(251, 18);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(117, 16);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Estado: x/x () Min.4";
            // 
            // btnInscreverEquipa
            // 
            this.btnInscreverEquipa.Location = new System.Drawing.Point(10, 106);
            this.btnInscreverEquipa.Name = "btnInscreverEquipa";
            this.btnInscreverEquipa.Size = new System.Drawing.Size(130, 30);
            this.btnInscreverEquipa.TabIndex = 6;
            this.btnInscreverEquipa.Text = "Inscrever Equipa";
            this.btnInscreverEquipa.UseVisualStyleBackColor = true;
            // 
            // cmbEquipasDisp
            // 
            this.cmbEquipasDisp.FormattingEnabled = true;
            this.cmbEquipasDisp.Location = new System.Drawing.Point(66, 49);
            this.cmbEquipasDisp.Name = "cmbEquipasDisp";
            this.cmbEquipasDisp.Size = new System.Drawing.Size(121, 24);
            this.cmbEquipasDisp.TabIndex = 3;
            // 
            // lblEquipa
            // 
            this.lblEquipa.AutoSize = true;
            this.lblEquipa.Location = new System.Drawing.Point(7, 49);
            this.lblEquipa.Name = "lblEquipa";
            this.lblEquipa.Size = new System.Drawing.Size(53, 16);
            this.lblEquipa.TabIndex = 2;
            this.lblEquipa.Text = "Equipa:";
            // 
            // cmbTorneio
            // 
            this.cmbTorneio.FormattingEnabled = true;
            this.cmbTorneio.Location = new System.Drawing.Point(70, 15);
            this.cmbTorneio.Name = "cmbTorneio";
            this.cmbTorneio.Size = new System.Drawing.Size(121, 24);
            this.cmbTorneio.TabIndex = 1;
            // 
            // lblTorneio
            // 
            this.lblTorneio.AutoSize = true;
            this.lblTorneio.Location = new System.Drawing.Point(7, 18);
            this.lblTorneio.Name = "lblTorneio";
            this.lblTorneio.Size = new System.Drawing.Size(57, 16);
            this.lblTorneio.TabIndex = 0;
            this.lblTorneio.Text = "Torneio:";
            // 
            // grpPartidas
            // 
            this.grpPartidas.Controls.Add(this.btnGuardarPartida);
            this.grpPartidas.Controls.Add(this.txtResultadoB);
            this.grpPartidas.Controls.Add(this.txtResultadoA);
            this.grpPartidas.Controls.Add(this.cmbEquipaB);
            this.grpPartidas.Controls.Add(this.lblResultB);
            this.grpPartidas.Controls.Add(this.lblEquipaB);
            this.grpPartidas.Controls.Add(this.lblVS);
            this.grpPartidas.Controls.Add(this.dateTimePicker1);
            this.grpPartidas.Controls.Add(this.lblData);
            this.grpPartidas.Controls.Add(this.cmbEquipaA);
            this.grpPartidas.Controls.Add(this.txtIdPartida);
            this.grpPartidas.Controls.Add(this.lblResultadoA);
            this.grpPartidas.Controls.Add(this.lblEquipaA);
            this.grpPartidas.Controls.Add(this.lblIdPartida);
            this.grpPartidas.Location = new System.Drawing.Point(13, 180);
            this.grpPartidas.Name = "grpPartidas";
            this.grpPartidas.Size = new System.Drawing.Size(707, 155);
            this.grpPartidas.TabIndex = 23;
            this.grpPartidas.TabStop = false;
            this.grpPartidas.Text = "Agendar Partidas e Registar Resultados";
            // 
            // cmbEquipa
            // 
            this.cmbEquipaA.FormattingEnabled = true;
            this.cmbEquipaA.Location = new System.Drawing.Point(75, 46);
            this.cmbEquipaA.Name = "cmbEquipaA";
            this.cmbEquipaA.Size = new System.Drawing.Size(121, 24);
            this.cmbEquipaA.TabIndex = 9;
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.Location = new System.Drawing.Point(79, 19);
            this.txtIdPartida.Name = "txtIdPartida";
            this.txtIdPartida.Size = new System.Drawing.Size(100, 22);
            this.txtIdPartida.TabIndex = 8;
            // 
            // lblResultadoA
            // 
            this.lblResultadoA.AutoSize = true;
            this.lblResultadoA.Location = new System.Drawing.Point(6, 82);
            this.lblResultadoA.Name = "lblResultadoA";
            this.lblResultadoA.Size = new System.Drawing.Size(84, 16);
            this.lblResultadoA.TabIndex = 7;
            this.lblResultadoA.Text = "Resultado A:";
            // 
            // lblEquipaA
            // 
            this.lblEquipaA.AutoSize = true;
            this.lblEquipaA.Location = new System.Drawing.Point(4, 49);
            this.lblEquipaA.Name = "lblEquipaA";
            this.lblEquipaA.Size = new System.Drawing.Size(65, 16);
            this.lblEquipaA.TabIndex = 6;
            this.lblEquipaA.Text = "Equipa A:";
            // 
            // lblIdPartida
            // 
            this.lblIdPartida.AutoSize = true;
            this.lblIdPartida.Location = new System.Drawing.Point(4, 22);
            this.lblIdPartida.Name = "lblIdPartida";
            this.lblIdPartida.Size = new System.Drawing.Size(69, 16);
            this.lblIdPartida.TabIndex = 0;
            this.lblIdPartida.Text = "ID Partida:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(298, 18);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(39, 16);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "Data:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(265, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVS.Location = new System.Drawing.Point(297, 66);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(31, 20);
            this.lblVS.TabIndex = 12;
            this.lblVS.Text = "VS";
            // 
            // FormTorneiosPartidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 553);
            this.Controls.Add(this.dgvPartidas);
            this.Controls.Add(this.grpPartidas);
            this.Controls.Add(this.grpInscricoes);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.grpCriarTorneio);
            this.Controls.Add(this.cmbCampeonatos);
            this.Controls.Add(this.lblCampeonato);
            this.Name = "FormTorneiosPartidas";
            this.Text = "FormTorneiosPartidas";
            this.grpCriarTorneio.ResumeLayout(false);
            this.grpCriarTorneio.PerformLayout();
            this.grpInscricoes.ResumeLayout(false);
            this.grpInscricoes.PerformLayout();
            this.grpPartidas.ResumeLayout(false);
            this.grpPartidas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCampeonato;
        private System.Windows.Forms.ComboBox cmbCampeonatos;
        private System.Windows.Forms.GroupBox grpCriarTorneio;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblJogo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCriarTorneio;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtJogo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox grpInscricoes;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnInscreverEquipa;
        private System.Windows.Forms.ComboBox cmbEquipasDisp;
        private System.Windows.Forms.Label lblEquipa;
        private System.Windows.Forms.ComboBox cmbTorneio;
        private System.Windows.Forms.Label lblTorneio;
        private System.Windows.Forms.GroupBox grpPartidas;
        private System.Windows.Forms.Label lblResultadoA;
        private System.Windows.Forms.Label lblEquipaA;
        private System.Windows.Forms.Label lblIdPartida;
        private System.Windows.Forms.ComboBox cmbEquipaA;
        private System.Windows.Forms.TextBox txtIdPartida;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox cmbEquipaB;
        private System.Windows.Forms.Label lblResultB;
        private System.Windows.Forms.Label lblEquipaB;
        private System.Windows.Forms.Button btnGuardarPartida;
        private System.Windows.Forms.TextBox txtResultadoB;
        private System.Windows.Forms.TextBox txtResultadoA;
        private System.Windows.Forms.DataGridView dgvPartidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipaA;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultA;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipaB;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencedor;
    }
}