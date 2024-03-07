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
