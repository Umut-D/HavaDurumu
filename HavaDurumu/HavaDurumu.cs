using System.Globalization;
using System.Text;
using HavaDurumuLibrary;
using HavaDurumuLibrary.Interfaces;
using HavaDurumuLibrary.Services;

namespace HavaDurumuUI
{
    public partial class FrmHavaDurumu : Form
    {
        private readonly CultureInfo _cultureInfo;
        private StringBuilder? _stringBuilder;
        private IHavaDataProvider? _havaMap;

        public FrmHavaDurumu(CultureInfo cultureInfo)
        {
            InitializeComponent();

            _cultureInfo = cultureInfo;
        }

        private void BtnGoster_Click(object sender, EventArgs e)
        {
            Konum konum = new Konum
            {
                Ad = txtSehir.Text
            };

            if (string.IsNullOrWhiteSpace(konum.Ad))
            {
                MessageBox.Show(@"Lütfen bir þehir adý girin.", @"Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (Baglanti.InternetVarMi())
                {
                    _havaMap = new HavaMapDataProvider(konum);
                    Koordinatlar();
                    HavaBilgisi();
                    AnlikDurum();
                    GunesBilgisi();
                    Ruzgar();

                    lblSonuc.Text = _stringBuilder?.ToString();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show($@"Þöyle bir hata var {hata.Message}", @"Hata", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void TxtSehir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnGoster_Click(this, EventArgs.Empty);
        }

        private void Koordinatlar()
        {
            _stringBuilder = new StringBuilder();

            var koordinatlar = _havaMap?.KoordinatlariCek();

            _stringBuilder.Append("Koordinatlar (E/B): ")
                .Append($@"{koordinatlar?.Enlem.ToString(_cultureInfo)}")
                .Append(" - ")
                .AppendLine($@"{koordinatlar?.Boylam.ToString(_cultureInfo)}")
                .AppendLine();
        }

        private void HavaBilgisi()
        {
            var havaBilgisi = _havaMap?.HavaBilgileriniCek();

            pbox.ImageLocation = havaBilgisi?.ElementAt(0).Icon;

            _stringBuilder?.Append("Hava Bilgisi: ")
                .AppendLine($@"{havaBilgisi?.ElementAt(0).Id.HavaDurumuTuruDonustur()}")
                .AppendLine();
        }

        private void AnlikDurum()
        {
            var anlikDurum = _havaMap?.AnlikDurumCek();

            _stringBuilder?.AppendLine("Anlýk Durum: ")
                .AppendLine($"Sýcaklýk: {anlikDurum?.Sicaklik}")
                .AppendLine($"Hissedilen Sýcaklýk: {anlikDurum?.HissedilenSicaklik}")
                .AppendLine($"Nem: %{anlikDurum?.Nem}")
                .AppendLine();
        }

        private void GunesBilgisi()
        {
            var gunesBilgisi = _havaMap?.GunesBilgileriniCek();

            if (gunesBilgisi != null)
                _stringBuilder?.AppendLine("Güneþ Bilgisi:")
                    .AppendLine($"Gün Doðumu: {Converter.UnixZamanDamgasiDonustur(gunesBilgisi.GunDogumu)}")
                    .AppendLine($"Gün Batýmý: {Converter.UnixZamanDamgasiDonustur(gunesBilgisi.GunBatimi)}")
                    .AppendLine();
        }

        private void Ruzgar()
        {
            var ruzgar = _havaMap?.RuzgarBilgisiniCek();

            _stringBuilder?.AppendLine("Rüzgar:")
                .AppendLine($"Hýz: {ruzgar}");
        }
    }
}