using HavaDurumuLibrary.Data;

namespace HavaDurumuLibrary.Interfaces
{
    public interface IHavaDataProvider
    {
        Koordinat? KoordinatlariCek();
        List<Hava>? HavaBilgileriniCek();
        AnlikDurum? AnlikDurumCek();
        Gunes? GunesBilgileriniCek();
        double? RuzgarBilgisiniCek();
    }
}