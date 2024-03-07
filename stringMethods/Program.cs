//6 - String metotlarını araştırınız. Her bir metot için örnek yapınız.

//1- Length metodu: 
Console.Write("Length-> ");
Console.Write("Girilen mesajın kaç karakter olduğunu ölçmek için bir şeyler yazınız: ");
string mesaj = Console.ReadLine();
Console.WriteLine("Girilen yazı " + mesaj.Length + " Karakter Uzunluğundadır.");
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
string word = Console.ReadLine();
if (mesaj.Contains(word))
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

string joinSonuc = string.Join("-Missisipi", joinList);
Console.WriteLine(joinSonuc);


Console.WriteLine("--------------------------------");
Console.WriteLine("--------------------------------");