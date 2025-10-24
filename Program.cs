namespace QLTVNhom3
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Force the app to render at 100% (DPI unaware).
            // Warning: UI may appear smaller or blurry on high-DPI monitors.
            Application.SetHighDpiMode(HighDpiMode.SystemAware);

            // Standard initialization
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frmDocGia());
            Application.Run(new frmmainthuthu());
        }
    }
}