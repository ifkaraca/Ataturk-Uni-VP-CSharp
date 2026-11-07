Console.Write("Ad: ");
string ad = Console.ReadLine();

Console.Write("Doğum Yılı: ");
int dYil = Convert.ToInt32(Console.ReadLine());

Console.Write("Bulunduğumuz Yıl: ");
int bYil = Convert.ToInt32(Console.ReadLine());

int yas = bYil - dYil;
Console.WriteLine($"Merhaba {ad}. Yaklaşık yaşınız: {yas}");

