using Newtonsoft.Json;

namespace HavaDurumuLibrary.Data;

public class AnlikDurum
{
    [JsonProperty("temp")] public double Sicaklik { get; set; }
    [JsonProperty("feels_like")] public double HissedilenSicaklik { get; set; }
    [JsonProperty("humidity")] public int Nem { get; set; }
}