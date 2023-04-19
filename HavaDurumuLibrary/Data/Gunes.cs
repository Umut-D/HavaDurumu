using Newtonsoft.Json;

namespace HavaDurumuLibrary.Data
{
    public class Gunes
    {
        [JsonProperty("sunrise")] public int GunDogumu { get; set; }
        [JsonProperty("sunset")] public int GunBatimi { get; set; }
    }
}