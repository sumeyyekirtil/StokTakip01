namespace StokTakip01
{
	class Stok
	{
		public string Tur;
		public void KontrolEt()
		{
			Console.WriteLine("Kontrol sağlandı");
		}
	}
	class Deterjan : OrtakOzellikler
	{
		public DateTime Skt { get; set; }
	}
	class Sebze : OrtakOzellikler
	{
		public string Ad { get; set; }
	}
	class Meyveler : Stok
	{
		public int Kilo { get; set; }
		public string Cesit { get; set; }
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Stok-Takip!");
			Stok stok = new(); //yeni değer atama işlemi
			stok.Tur = "Stok"; //void değere atama yapmaz
			Console.WriteLine("Stok Türü: " + stok.Tur); //stok.Tur = "stok türü :"

			Meyveler meyveler = new();
			meyveler.Cesit = "Çilek";
			meyveler.Kilo = 4;
			meyveler.Tur = "Meyve"; //Tur Stok class ının kalıtımdan dolayı kullanılabilir
			Console.WriteLine("Stok Türü: " + meyveler.Tur);
			meyveler.KontrolEt();//stok sınıfından geliyor
			Console.WriteLine();

			Kategori yeniUrun = new()
			{
				Id = 1,
				Ad = "Elma",
				Bozukmu = "Kullanışlı",
				UstMenu = true,
				CreateTime = DateTime.Now,
			};
			if (yeniUrun.UstMenu == true)
			{
				Console.WriteLine($"Kategori detayı : \n\n Adı: {yeniUrun.Ad} \n Kullanış Durumu: {yeniUrun.Bozukmu} \n Eklenme Tarihi : {yeniUrun.CreateTime}"); //$ : yeniUrun değişkenini aktif eder
			}
			Console.WriteLine();

			Kategori yeniUrun2 = new()
			{
				Id = 2,
				Ad = "Bulaşık Tableti",
				BolumAdi = "Deterjan",
				Kilo = 35,
				YanMenu = true,
				CreateTime = DateTime.Now,
			};
			if (yeniUrun2.YanMenu == true)
			{
				Console.WriteLine($"Kategori detayı : \n\n Adı: {yeniUrun2.Ad} \n Eklenme Tarihi : {yeniUrun2.CreateTime}");
			}
			Console.WriteLine();

			Kategori yeniUrun3 = new()
			{
				Id = 3,
				Ad = "Kireç Çözücü",
				BolumAdi = "Deterjan",
				Kilo = 15,
				YanMenu = true,
				CreateTime = DateTime.Now,
			};
			Console.WriteLine("Ürün Detayı:");
			Console.WriteLine($"\n Adı : {yeniUrun3.Ad}");
			Console.WriteLine($" Bölüm Adı : {yeniUrun3.BolumAdi}");
			Console.WriteLine($" Kilo : {yeniUrun3.Kilo}");
			Console.WriteLine($" Giriş Tarihi : {yeniUrun3.CreateTime}");
			Console.WriteLine();

			Kategori yeniUrun4 = new()
			{
				Id = 4,
				Ad = "Patates",
				BolumAdi = "Sebze",
				Kilo = 55,
				Bozukmu = "8 kilo bozuk",
				AltMenu = true,
				CreateTime = DateTime.Now,
			};
			Console.WriteLine("Ürün Detayı:");
			Console.WriteLine($"\n Adı : {yeniUrun4.Ad}");
			Console.WriteLine($" Bölüm Adı : {yeniUrun4.BolumAdi}");
			Console.WriteLine($" Kilo : {yeniUrun4.Kilo}");
			Console.WriteLine($" Kullanış Durumu : {yeniUrun4.Bozukmu}");
			Console.WriteLine($" Giriş Tarihi : {yeniUrun4.CreateTime}");
		}
	}
}
