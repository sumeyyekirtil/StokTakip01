namespace StokTakip01
{
	public class OrtakOzellikler //public : erişilebilir yapıldı
	{ //her sınıfta bulunması gereken özellikler listelendi
		public int Id { get; set; }
		public string? Ad { get; set; }
		public string? BolumAdi { get; set; }
		public DateTime CreateTime { get; set; }
		public int Kilo { get; set; }
		public string? Bozukmu { get; set; }
	}
}
