namespace Semana_11_Demosteracion_Concurrente
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
            //aca que se ejecute nuestro frm
            Application.Run(new  FrmPatronSingleton());
        }
    }
}