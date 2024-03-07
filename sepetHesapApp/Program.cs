/*2- 
 * kullanıcıdan kaç ürün almak istediğini soran,her ürünün fiyatını alarak 
 * toplam alışveriş tutarını hesaplayan bir algoritma yazınız.
 * (Input için Scanner ve döngü için for döngüsü kullanınız)
*/


using tobetoHomework1.Models;

var list = new List<Urunler>()
{

    new Urunler() { UrunId = 1, UrunAdi = "BenQ 4k Monitor", UrunFiyati = 5000 },
    new Urunler() { UrunId = 2, UrunAdi = "Logitech G213 Mouse", UrunFiyati = 1000 },
    new Urunler() { UrunId = 3, UrunAdi = "Razer Klavye", UrunFiyati = 3200 },
    new Urunler() { UrunId = 4, UrunAdi = "AMD 8M İşlemci", UrunFiyati = 4200 },
    new Urunler() { UrunId = 5, UrunAdi = "Coolmaster Laptop Soğutucu", UrunFiyati = 5600 },
    new Urunler() { UrunId = 6, UrunAdi = "Monster Gaming Laptop", UrunFiyati = 67000 }
};
foreach (var item in list)
{
    Console.WriteLine("Ürün numarası:" + item.UrunId + " Ürün Adı:" + item.UrunAdi + " Ürün Fiyatı:" + item.UrunFiyati);
}

Console.WriteLine("--------------------------------");
//Console.Write("Sipariş etmek istediğiniz ürünün kodunu giriniz: ");

//int siparisNo = Convert.ToInt32(Console.ReadLine());

Console.Write("Kaç adet ürün satın almak istiyorsunuz? :");
int urunSayisi = Convert.ToInt16(Console.ReadLine());
int toplamTutar = 0;
int tempUrun = 0;

for (int i = 1; i <= urunSayisi; i++)
{
    Console.Write(i + ".ürünün ürün kodunu giriniz: ");
    tempUrun = Convert.ToInt16(Console.ReadLine());
    toplamTutar += list[tempUrun - 1].UrunFiyati;

}
Console.WriteLine("Toplam sipariş tutarınız: " + toplamTutar + " TL");

Console.WriteLine("--------------------------------");
Console.WriteLine("--------------------------------");