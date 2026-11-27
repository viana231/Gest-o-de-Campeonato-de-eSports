using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Gestão_de_Campeonato_de_eSports
{
    public static class GestorLogs
    {
        private static readonly string CaminhoLogXml = "logs_erros.xml";

        public static void RegistarErro(Exception ex, string origem = "Sistema")
        {
            try
            {
                XDocument doc;
                if (File.Exists(CaminhoLogXml))
                {
                    doc = XDocument.Load(CaminhoLogXml);
                }
                else
                {
                    doc = new XDocument(new XElement("Logs"));
                }

                XElement novoErro = new XElement("Erro",
                    new XElement("Data", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                    new XElement("Origem", origem),
                    new XElement("Mensagem", ex.Message)
                );

                doc.Root?.Add(novoErro);
                doc.Save(CaminhoLogXml);
            }
            catch
            {
                // Ignora falhas de escrita de log para não bloquear a aplicação
            }
        }

        public static void AbrirBotaoLogs()
        {
            if (File.Exists(CaminhoLogXml))
            {
                Process.Start(new ProcessStartInfo(CaminhoLogXml) { UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("Ainda não existem erros registados!", "Logs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}