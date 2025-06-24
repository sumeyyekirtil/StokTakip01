namespace StokTakip01
{
    class Stok
    {
        public string Tur;
        public void KontrolEt()
        {
			Console.WriteLine();
        }
    }
    class Meyveler : Stok
    {
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
            meyveler.Tur = "Meyve"; //Tur Stok class ının kalıtımdan dolayı kullanılabilir

        }
    }
}
