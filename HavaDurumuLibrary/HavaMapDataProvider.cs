using HavaDurumuLibrary.Data;
using HavaDurumuLibrary.Interfaces;
using HavaDurumuLibrary.Services;
using Newtonsoft.Json;

namespace HavaDurumuLibrary
{
    public class HavaMapDataProvider : IHavaDataProvider
    {
        private readonly Konum _konum;
        private readonly HavaData? _havaData;

        public HavaMapDataProvider(Konum konum)
        {
            _konum = konum;
            _havaData = DeserializeJson().Result;
        }

        private async Task<HavaData?> DeserializeJson()
        {
            if (Baglanti.InternetVarMi())
                return await Task.FromResult(JsonConvert.DeserializeObject<HavaData>(VeriRequest()));

            return null;
        }

        private string VeriRequest()
        {
            using var httpClient = new HttpClient();
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, UrlOlustur());
            var response = httpClient.Send(httpRequest);

            using var reader = new StreamReader(response.Content.ReadAsStream());
            return reader.ReadToEnd();
        }

        private string UrlOlustur()
        {
            const string apiAnahtari = "b312c0e529bb056ddef1380b5ec71429";
            const string adres = "https://api.openweathermap.org/data/2.5/weather?q=";
            const string birimTuru = "&units=metric";

            return $"{adres}{_konum.Ad}&appid={apiAnahtari}{birimTuru}";
        }

        public Koordinat? KoordinatlariCek()
        {
            return _havaData?.Koordinat;
        }

        public List<Hava>? HavaBilgileriniCek()
        {
            return _havaData?.Hava;
        }

        public AnlikDurum? AnlikDurumCek()
        {
            return _havaData?.AnlikDurum;
        }

        public Gunes? GunesBilgileriniCek()
        {
            return _havaData?.Gunes;
        }

        public double? RuzgarBilgisiniCek()
        {
            return _havaData?.Ruzgar?.Hiz;
        }
    }
}