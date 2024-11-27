using DocumentRequesting.AdminPanels;
using DocumentRequesting.Data;
using DocumentRequesting.Popup;
using DocumentRequesting.RequestFormPanels;
using DocumentRequesting.StaffPanels;
using System.Reflection;

namespace DocumentRequesting
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += (sender, eventArgs) =>
            {
                string assemblyName = new AssemblyName(eventArgs.Name).Name + ".dll";
                string customPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "lib", assemblyName);

                if (File.Exists(customPath))
                {
                    return Assembly.LoadFrom(customPath);
                }

                return null; // Return null if the assembly is not found
            };


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            Utilities.RefreshData();

            Utilities.mainPanel = OpenPanels.loginPanel;
            Application.Run(OpenPanels.loginPanel);
        }
    }
}