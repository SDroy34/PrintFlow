using Microsoft.Extensions.DependencyInjection;
using PrintFlow2.Busisnes.ConfNontIcon;
using System.ComponentModel.Design;

namespace PrintFlow2
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
            ApplicationConfiguration.Initialize();
            using (var icon = new NotifyIcon())
            {
                TrayIconManager.IconM.Initialize(icon);
                Application.ApplicationExit += (s, e) => TrayIconManager.IconM.DisposeResources();
                Application.Run(new FInicio());
            }
        }
    }
}