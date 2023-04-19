using Newtonsoft.Json;

namespace HavaDurumuLibrary.Data
{
    public class Ruzgar
    {
        [JsonProperty("speed")] public double Hiz { get; set; }
    }
}