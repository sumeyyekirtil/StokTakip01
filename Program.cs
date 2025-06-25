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
    class Sebze : Stok
    {
		public int Kilo { get; set; }
		public string Ad { get; set; }
	}
    class Meyveler : Stok
    {
        public string Cesit { get; set; }
		public int Kilo { get; set; }
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
        }
    }
}
