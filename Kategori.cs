namespace StokTakip01
{
	public class Kategori : OrtakOzellikler //erişime açık yapıldı
	{
		public string? Banner { get; set; } //Başlık
		public bool UstMenu { get; set; } //T/F
		public bool AltMenu { get; set; }
		public bool YanMenu { get; set; }
	}
}
