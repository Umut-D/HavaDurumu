using Newtonsoft.Json;

namespace HavaDurumuLibrary.Data
{
    public class Hava
    {
        [JsonProperty("id")] public string? Id { get; set; }

        private string? _icon;

        [JsonProperty("icon")]
        public string? Icon
        {
            get => $"https://openweathermap.org/img/wn/{_icon}@2x.png";
            set => _icon = value;
        }
    }
}