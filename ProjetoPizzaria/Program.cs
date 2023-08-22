using ProjetoPizzaria.ModuloLogin;
using System.Globalization;

namespace ProjetoPizzaria
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            #region Idioma
            // en-US, es, pt-BR, etc
            string auxIdiomaRegiao = "en-US";
            //ajusta o idioma/região
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(auxIdiomaRegiao);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(auxIdiomaRegiao);
            #endregion

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new TelaPrincipal());
        }
    }
}