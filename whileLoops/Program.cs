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