// Console yaklaşımı
Console.Write("Sayı: ");                            // kullanıcıdan veri girişi istemek için bir ifade yazdırılır line ifadesi kullanılmadığı için alt satıra geçilmez
int n = Convert.ToInt32(Console.ReadLine());        // kullanıcıdan veri girişi istenir girilen değeri okumak ve interger e çevirmek için kullanlırı
Console.WriteLine(n * 2);                           // oluşturulan n değişkenini yeni değeriyle yazdırmak ve bir alt satıra geçmek için kullanılır

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

double root = Math.Sqrt(25);                        // kök işlemleri için sqrt kullanılır
Console.WriteLine(root);

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

string text = "Görsel Programlama";      
int length = text.Length;                           // sitring ifadelerin uzunluğunu öğrenmek için Lenght kullanılır(boşluk da bir deerdir ve uzunluğa dahildir)
Console.WriteLine(length);

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Console.Write("Adınızı giriniz: ");
string name = Console.ReadLine();                   // işlem sonunda isteğimiz zaten string bir değer olduğu için "Convert.ToInt32" değimi kullanılarak değişitirimez
Console.WriteLine("Merhaba " + name);               // + ifadesi string birleştirme için kullanılmış ve Merhaba ve değişkeni birlikte kullanmamızı sağlamıştır

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

string isim = "Ayşe";
int age = 20;

Console.WriteLine(
    $"Öğrencinin adı {isim}, yaşı {age}.");         // string birleştirme kullanmak yerine daha pratik olarak satır başına "$" ifadesi koyarak süsülü parantezler içerisinde
                                                    // değişkenleri yazdırılabilir
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Console.Write("Bir sayı girin: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int sayi))             // baştaki int hangi veri türüne dönüştürülüceği belirlenir parantez içi ilk değişken dönüştürülücek değeri sondaki değişken 
{                                                  // sonucun atanacağı değişkeni verir bu işlem sonucunda dönüştürülebilirse true verir ve değişkeni atar dönüştüremezse false verir
    Console.WriteLine($"Girilen sayı: {sayi}");
}
else
{
    Console.WriteLine("Geçerli bir tam sayı girilmedi.");
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
int sayac = 1;

do
{
    Console.WriteLine($"Sayaç: {sayac}");
    sayac++;
}
while (sayac <= 5);                               // do while işlemlerinde sistem en az bir kez çalışır, koşul sonda denetlenir

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
