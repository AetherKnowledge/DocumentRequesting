using DocumentRequesting;
using DocumentRequesting.Data;
using MaterialSkin;

namespace DocumentRequestingStudent
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(Color.FromArgb(128, 175, 129), Color.FromArgb(128, 175, 129), Color.FromArgb(212, 231, 197), Color.FromArgb(212, 231, 197), MaterialSkin.TextShade.WHITE);

            Utilities.RefreshData();

            ApplicationConfiguration.Initialize();
            Application.Run(OpenPanels.login);
            
        }
    }
}