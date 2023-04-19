namespace HavaDurumuLibrary.Services;

public static class Converter
{
    public static string HavaDurumuTuruDonustur(this string? id)
    {
        return Convert.ToInt32(id) switch
        {
            >= 200 and <= 232 => "Fırtınalı",
            >= 300 and <= 321 => "Çiseleme",
            >= 500 and <= 531 => "Yağmurlu",
            >= 600 and <= 622 => "Karlı",
            >= 700 and < 800 => "Sisli",
            800 => "Açık",
            > 800 => "Bulutlu",
            _ => "..."
        };
    }

    public static DateTime UnixZamanDamgasiDonustur(int zamanDamgasi)
    {
        DateTime tarih = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        return tarih.AddSeconds(zamanDamgasi).ToLocalTime();
    }
}