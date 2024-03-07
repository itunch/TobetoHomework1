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