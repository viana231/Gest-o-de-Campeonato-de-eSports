using System;
using System.Threading;
using System.Windows.Forms;

namespace Gestão_de_Campeonato_de_eSports
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += new ThreadExceptionEventHandler(CapturarErroDeForm);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CapturarErroFatal);

            Application.Run(new Form1());
        }

        private static void CapturarErroDeForm(object sender, ThreadExceptionEventArgs e)
        {

            MessageBox.Show($"Ocorreu um erro e foi registado no Log:\n{e.Exception.Message}",
                            "Erro Registado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void RegistarErro(Exception ex, string origem = "Sistema") { }

        private static void CapturarErroFatal(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject is Exception ex)
            {
                GestorLogs.RegistarErro(ex, "Erro Fatal");
            }
        }
    }
}