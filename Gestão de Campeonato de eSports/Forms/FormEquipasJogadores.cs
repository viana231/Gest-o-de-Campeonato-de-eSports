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
        private void BtnHelpLogs_Click(object sender, EventArgs e)
        {
            GestorLogs.AbrirBotaoLogs();
        }

    }
}
