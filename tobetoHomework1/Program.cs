using tobetoHomework1.Models;
//1- Switch case ile müşteriden alınan sipariş numarasına göre 
//hangi ürünün sipariş edildiğini belirleyen algoritma yazınız.
//Input için Scanner kullanınız


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

/*2- 
 * kullanıcıdan kaç ürün almak istediğini soran,her ürünün fiyatını alarak 
 * toplam alışveriş tutarını hesaplayan bir algoritma yazınız.
 * (Input için Scanner ve döngü için for döngüsü kullanınız)
*/

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

//3- Do-While ve While döngüsü nedir? Bununla ilgili örnek yapınız.

//Girilen sayı negatif değer olana dek 62 çıkaran program
Console.Write("0'dan büyük olacak şekilde başlangıç değerinizi girin: ");
int baslangic = Convert.ToInt32(Console.ReadLine());
int sayac = 0;
if (baslangic < 0)
{
    throw new Exception("Girilen sayı negatif olamaz!");
}

do
{
    if (baslangic > 0)
    {
        baslangic -= 62;
        sayac++;
    }



}
while (baslangic > 0);
{

    Console.WriteLine(sayac + ". adımda girilen sayı negatife dönüştü. Anlık değer : " + baslangic);

}




//4-Kullanıcının 1 ile 10 arasında rastgele bir sayıyı tahmin etmesini isteyen
//ve doğru tahmin edene kadar devam eden bir program yazınız.
//(While döngüsü ile yapınız ve rastgele sayı üretmek için Random sınıfını kullanınız)

Console.WriteLine("--------------------------------");
Console.WriteLine("--------------------------------");

Console.Write("1 ile 10 arasında bir sayı giriniz: ");
int tahmin = Convert.ToInt16(Console.ReadLine());

Random rnd = new Random();
int randSayi = rnd.Next(1, 10);

int tahminSayaci = 1;

while (true)
{

    if (tahmin == randSayi)
    {
        Console.WriteLine("Tebrikler");
        Console.WriteLine(tahminSayaci + ".Tahminde sayıyı buldunuz.");
        break;
    }
    else
    {
        Console.Write("Yanlış Tahmin! Yeni sayı giriniz: ");
        tahminSayaci++;
        tahmin = Convert.ToInt16(Console.ReadLine());
    }
}



Console.WriteLine("--------------------------------");
Console.WriteLine("--------------------------------");

//5 - Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.

Console.Write("Mükemmel sayı kontrolü yapmak istediğiniz sayıyı giriniz :");
double mukemmelSayi = Convert.ToDouble(Console.ReadLine());
double tempToplam = 0;
for (int i = 1; i < mukemmelSayi; i++)
{
    if (mukemmelSayi % i == 0)
    {
        tempToplam = tempToplam + i;
        Console.WriteLine(tempToplam);
    }

}

if (tempToplam == mukemmelSayi)
{
    Console.WriteLine("Sayı mükemmeldir.");
}
else
{
    Console.WriteLine("Sayı mükemmel sayı değildir!");
}
Console.WriteLine("--------------------------------");
Console.WriteLine("--------------------------------");

//6 - String metotlarını araştırınız. Her bir metot için örnek yapınız.

//1- Length metodu: 
Console.Write("Length-> ");
int mesajUzunlugu;
Console.Write("Girilen mesajın kaç karakter olduğunu ölçmek için bir şeyler yazınız: ");
string mesaj=Console.ReadLine();
Console.WriteLine("Girilen yazı "+ mesaj.Length+ " Karakter Uzunluğundadır.");
Console.WriteLine("///////////");
//2- ToUpper Metodu:
Console.Write("ToUpper-> ");
Console.WriteLine(mesaj.ToUpper());
Console.WriteLine("///////////");
//3- ToLower Metodu:
Console.Write("ToLower-> ");
Console.WriteLine(mesaj.ToLower());
Console.WriteLine("///////////");
//4- Trim metodu
Console.Write("Trim-> ");
Console.WriteLine(mesaj.Trim());
Console.WriteLine("///////////");
//5- SubString metodu
Console.Write("Substring-> ");
Console.WriteLine(mesaj.Substring(2));
Console.WriteLine("///////////");
//5.1- SubString2 metodu
Console.Write("Substring2-> ");
//Console.WriteLine(mesaj.Substring(2,3));
Console.WriteLine("///////////");
//6- IndexOf metodu
Console.Write("IndexOf-> ");
char harf = 'e';
Console.WriteLine(mesaj.IndexOf(harf));
Console.WriteLine("///////////");
//7-Contains metodu
Console.Write("Contains-> ");
Console.Write("İçinde aramak istediğiniz kelimeyi giriniz :");
string word= Console.ReadLine();
if(mesaj.Contains(word))
{
    Console.WriteLine(word + " ifadesi bu metinde bulunmaktadır");
}
else
{
    Console.WriteLine(word + " ifadesi bu metinde BULUNMAMAKTADIR!");
}
Console.WriteLine("///////////");

//8-Replace metodu
Console.Write("Replace-> ");
Console.WriteLine("İlk hali :" + mesaj);
Console.WriteLine("Replace -> " + mesaj.Replace("e", "3"));
Console.WriteLine("///////////");

//9-Split metodu
Console.Write("Split-> ");
string dersler = "Matematik,Fen,Edebiyat,İngilizce";
string[] dersListe = dersler.Split(','); 
foreach (string ders in dersListe)
{
    Console.WriteLine(ders);
}

//10-Join metodu
Console.Write("Join-> ");
List<string> joinList = new List<string>();

joinList.Add("1");
joinList.Add("2");
joinList.Add("3");

string joinSonuc=string.Join("-Missisipi", joinList);
Console.WriteLine(joinSonuc);







Console.WriteLine("--------------------------------");
Console.WriteLine("--------------------------------");

//7 - kullanıcıdan öğrenci sayısını isteyen her öğrenci için
//öğrenci adı, öğrenci soyadı,1.sınav notu,2.sınav notu,3.sınav notu isteyen
//ve daha sonra not ortalamasını hesaplayıp ekrana yazdıran algoritma yapınız.
//(For döngüsü kullanınız)


Console.Write("Öğrenci sayısını giriniz: ");
int ogrenciSayisi = Convert.ToInt16(Console.ReadLine());
string ogrenciAdi, soyAdi;
int birinciSinav = 0, ikinciSinav = 0, ucuncuSinav = 0, ortalama;


for (int i = 0; i < ogrenciSayisi; i++)
{
    Console.Write("Öğrenci adını giriniz: ");
    ogrenciAdi = Console.ReadLine();
    Console.Write("Öğrenci soyadını giriniz: ");
    soyAdi = Console.ReadLine();
    Console.Write("1. sınav notunu giriniz: ");
    birinciSinav = Convert.ToInt16(Console.ReadLine());
    Console.Write("2. sınav notunu giriniz: ");
    ikinciSinav = Convert.ToInt16(Console.ReadLine());
    Console.Write("3. sınav notunu giriniz: ");
    ucuncuSinav = Convert.ToInt16(Console.ReadLine());

    if (birinciSinav <= 100 && birinciSinav >= 0 && ikinciSinav <= 100 && ikinciSinav >= 0 && ucuncuSinav <= 100 && ucuncuSinav >= 0)
    {
        ortalama = (birinciSinav + ikinciSinav + ucuncuSinav) / 3;
        Console.WriteLine("Sevgili " + ogrenciAdi + soyAdi + "Not ortalamanız :" + ortalama);
    }


    else
    {
        Console.WriteLine("Geçerli bir not giriniz veya boş değer girmeyiniz.");
    }


}



Console.WriteLine("--------------------------------");
Console.WriteLine("--------------------------------");
