using HavaDurumuLibrary.Data;
using Newtonsoft.Json;

namespace HavaDurumuLibrary
{
    public class HavaData
    {
        [JsonProperty("coord")] public Koordinat? Koordinat;
        [JsonProperty("main")] public AnlikDurum? AnlikDurum { get; set; }
        [JsonProperty("sys")] public Gunes? Gunes { get; set; }
        [JsonProperty("wind")] public Ruzgar? Ruzgar { get; set; }
        [JsonProperty("weather")] public List<Hava>? Hava { get; set; }
    }
}