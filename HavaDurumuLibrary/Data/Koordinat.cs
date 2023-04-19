using Newtonsoft.Json;

namespace HavaDurumuLibrary.Data
{
    public class Koordinat
    {
        [JsonProperty("lon")] public double Boylam { get; set; }
        [JsonProperty("lat")] public double Enlem { get; set; }
    }
}