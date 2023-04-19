using System.Globalization;

namespace HavaDurumuUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmHavaDurumu(CultureInfo.InvariantCulture));
        }
    }
}