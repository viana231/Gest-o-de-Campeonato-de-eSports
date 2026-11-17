namespace Gestão_de_Campeonato_de_eSports
{
    partial class Form1
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
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlXML = new System.Windows.Forms.Panel();
            this.pnlJSON = new System.Windows.Forms.Panel();
            this.grpXML = new System.Windows.Forms.GroupBox();
            this.grpJSON = new System.Windows.Forms.GroupBox();
            this.btnImportarXML = new System.Windows.Forms.Button();
            this.btnExportarXML = new System.Windows.Forms.Button();
            this.btnConverterXMLParaJSON = new System.Windows.Forms.Button();
            this.btnConverterJSONParaXML = new System.Windows.Forms.Button();
            this.btnExportarJSON = new System.Windows.Forms.Button();
            this.btnImportarJSON = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpModulos = new System.Windows.Forms.GroupBox();
            this.ofdFicheiro = new System.Windows.Forms.OpenFileDialog();
            this.sfdFicheiro = new System.Windows.Forms.SaveFileDialog();
            this.pnlTitulo.SuspendLayout();
            this.pnlXML.SuspendLayout();
            this.pnlJSON.SuspendLayout();
            this.grpXML.SuspendLayout();
            this.grpJSON.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Location = new System.Drawing.Point(13, 13);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(444, 31);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTitulo.Location = new System.Drawing.Point(4, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(426, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "GESTÃO DE CAMPEONATOS DE ESPORTS";
            // 
            // pnlXML
            // 
            this.pnlXML.Controls.Add(this.grpXML);
            this.pnlXML.Location = new System.Drawing.Point(13, 51);
            this.pnlXML.Name = "pnlXML";
            this.pnlXML.Size = new System.Drawing.Size(324, 154);
            this.pnlXML.TabIndex = 1;
            // 
            // pnlJSON
            // 
            this.pnlJSON.Controls.Add(this.grpJSON);
            this.pnlJSON.Location = new System.Drawing.Point(343, 51);
            this.pnlJSON.Name = "pnlJSON";
            this.pnlJSON.Size = new System.Drawing.Size(327, 154);
            this.pnlJSON.TabIndex = 2;
            // 
            // grpXML
            // 
            this.grpXML.Controls.Add(this.btnConverterXMLParaJSON);
            this.grpXML.Controls.Add(this.btnExportarXML);
            this.grpXML.Controls.Add(this.btnImportarXML);
            this.grpXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpXML.Location = new System.Drawing.Point(4, 4);
            this.grpXML.Name = "grpXML";
            this.grpXML.Size = new System.Drawing.Size(317, 147);
            this.grpXML.TabIndex = 0;
            this.grpXML.TabStop = false;
            this.grpXML.Text = "Ficheiros XML";
            // 
            // grpJSON
            // 
            this.grpJSON.Controls.Add(this.btnConverterJSONParaXML);
            this.grpJSON.Controls.Add(this.btnImportarJSON);
            this.grpJSON.Controls.Add(this.btnExportarJSON);
            this.grpJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpJSON.Location = new System.Drawing.Point(7, 7);
            this.grpJSON.Name = "grpJSON";
            this.grpJSON.Size = new System.Drawing.Size(317, 147);
            this.grpJSON.TabIndex = 1;
            this.grpJSON.TabStop = false;
            this.grpJSON.Text = "Ficheiros JSON";
            // 
            // btnImportarXML
            // 
            this.btnImportarXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnImportarXML.Location = new System.Drawing.Point(7, 32);
            this.btnImportarXML.Name = "btnImportarXML";
            this.btnImportarXML.Size = new System.Drawing.Size(75, 23);
            this.btnImportarXML.TabIndex = 0;
            this.btnImportarXML.Text = "Importar";
            this.btnImportarXML.UseVisualStyleBackColor = true;
            // 
            // btnExportarXML
            // 
            this.btnExportarXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnExportarXML.Location = new System.Drawing.Point(7, 62);
            this.btnExportarXML.Name = "btnExportarXML";
            this.btnExportarXML.Size = new System.Drawing.Size(75, 23);
            this.btnExportarXML.TabIndex = 1;
            this.btnExportarXML.Text = "Exportar";
            this.btnExportarXML.UseVisualStyleBackColor = true;
            // 
            // btnConverterXMLParaJSON
            // 
            this.btnConverterXMLParaJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnConverterXMLParaJSON.Location = new System.Drawing.Point(7, 92);
            this.btnConverterXMLParaJSON.Name = "btnConverterXMLParaJSON";
            this.btnConverterXMLParaJSON.Size = new System.Drawing.Size(75, 23);
            this.btnConverterXMLParaJSON.TabIndex = 2;
            this.btnConverterXMLParaJSON.Text = "Converter";
            this.btnConverterXMLParaJSON.UseVisualStyleBackColor = true;
            // 
            // btnConverterJSONParaXML
            // 
            this.btnConverterJSONParaXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnConverterJSONParaXML.Location = new System.Drawing.Point(6, 89);
            this.btnConverterJSONParaXML.Name = "btnConverterJSONParaXML";
            this.btnConverterJSONParaXML.Size = new System.Drawing.Size(75, 23);
            this.btnConverterJSONParaXML.TabIndex = 5;
            this.btnConverterJSONParaXML.Text = "Converter";
            this.btnConverterJSONParaXML.UseVisualStyleBackColor = true;
            // 
            // btnExportarJSON
            // 
            this.btnExportarJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnExportarJSON.Location = new System.Drawing.Point(6, 59);
            this.btnExportarJSON.Name = "btnExportarJSON";
            this.btnExportarJSON.Size = new System.Drawing.Size(75, 23);
            this.btnExportarJSON.TabIndex = 4;
            this.btnExportarJSON.Text = "Exportar";
            this.btnExportarJSON.UseVisualStyleBackColor = true;
            // 
            // btnImportarJSON
            // 
            this.btnImportarJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnImportarJSON.Location = new System.Drawing.Point(6, 29);
            this.btnImportarJSON.Name = "btnImportarJSON";
            this.btnImportarJSON.Size = new System.Drawing.Size(75, 23);
            this.btnImportarJSON.TabIndex = 3;
            this.btnImportarJSON.Text = "Importar";
            this.btnImportarJSON.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpModulos);
            this.panel1.Location = new System.Drawing.Point(13, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 100);
            this.panel1.TabIndex = 3;
            // 
            // grpModulos
            // 
            this.grpModulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpModulos.Location = new System.Drawing.Point(4, 4);
            this.grpModulos.Name = "grpModulos";
            this.grpModulos.Size = new System.Drawing.Size(647, 93);
            this.grpModulos.TabIndex = 0;
            this.grpModulos.TabStop = false;
            this.grpModulos.Text = "Módulos de Gestão e Análise";
            // 
            // ofdFicheiro
            // 
            this.ofdFicheiro.FileName = "OpenFileDialog";
            // 
            // sfdFicheiro
            // 
            this.sfdFicheiro.FileName = "SaveFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlJSON);
            this.Controls.Add(this.pnlXML);
            this.Controls.Add(this.pnlTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlXML.ResumeLayout(false);
            this.pnlJSON.ResumeLayout(false);
            this.grpXML.ResumeLayout(false);
            this.grpJSON.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlXML;
        private System.Windows.Forms.Panel pnlJSON;
        private System.Windows.Forms.GroupBox grpXML;
        private System.Windows.Forms.Button btnImportarXML;
        private System.Windows.Forms.GroupBox grpJSON;
        private System.Windows.Forms.Button btnConverterXMLParaJSON;
        private System.Windows.Forms.Button btnExportarXML;
        private System.Windows.Forms.Button btnConverterJSONParaXML;
        private System.Windows.Forms.Button btnImportarJSON;
        private System.Windows.Forms.Button btnExportarJSON;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpModulos;
        private System.Windows.Forms.OpenFileDialog ofdFicheiro;
        private System.Windows.Forms.SaveFileDialog sfdFicheiro;
    }
}

