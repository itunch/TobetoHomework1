//1- Switch case ile müşteriden alınan sipariş numarasına göre 
//hangi ürünün sipariş edildiğini belirleyen algoritma yazınız.
//Input için Scanner kullanınız

using tobetoHomework1.Models;

Console.WriteLine("Bilgisayar ekipmanları listesi");
Console.WriteLine("--------------------------------");

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
Console.Write("Sipariş etmek istediğiniz ürünün kodunu giriniz: ");

int siparisNo = Convert.ToInt32(Console.ReadLine());


switch (siparisNo)
{
    case 1:
        Console.WriteLine("Sipariş ettiğiniz ürün:" + list[0].UrunAdi + " Fiyat:" + list[0].UrunFiyati);
        break;
    case 2:
        Console.WriteLine("Sipariş ettiğiniz ürün:" + list[1].UrunAdi + " Fiyat:" + list[1].UrunFiyati);
        break;
    case 3:
        Console.WriteLine("Sipariş ettiğiniz ürün:" + list[2].UrunAdi + " Fiyat:" + list[2].UrunFiyati);
        break;
    case 4:
        Console.WriteLine("Sipariş ettiğiniz ürün:" + list[3].UrunAdi + " Fiyat:" + list[3].UrunFiyati);
        break;
    case 5:
        Console.WriteLine("Sipariş ettiğiniz ürün:" + list[4].UrunAdi + " Fiyat:" + list[4].UrunFiyati);
        break;
    case 6:
        Console.WriteLine("Sipariş ettiğiniz ürün:" + list[5].UrunAdi + " Fiyat:" + list[5].UrunFiyati);
        break;

    default:
        Console.WriteLine("Hatalı ürün numarası girdiniz");
        break;
}


Console.WriteLine("--------------------------------");
Console.WriteLine("--------------------------------");