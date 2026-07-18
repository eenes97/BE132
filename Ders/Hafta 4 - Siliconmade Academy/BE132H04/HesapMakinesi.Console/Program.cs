string input = "";

Console.Write("Sayi1: ");
input = Console.ReadLine();
double sayi1 = double.Parse(input);

Console.Write("Sayi2: ");
input = Console.ReadLine();
double sayi2 = double.Parse(input);

Console.Write("İslem: ");
input = Console.ReadLine();
string islem = input;

double sonuc = 0;

switch (islem)
{

    case "+":
        sonuc = Topla(sayi1, sayi2);
        break;
    case "-":
        sonuc = Cikar(sayi1, sayi2);
        break;
    case "*":
        sonuc = Carp(sayi1, sayi2);
        break;
    case "/":
        sonuc = Bol(sayi1, sayi2);
        break;
    default:
        Console.WriteLine("Geçersiz işlem!");
        break;
}

Console.WriteLine($"Sonuç: {sonuc}");

double Topla(double sayi1, double sayi2)
{
    double sonuc = sayi1 + sayi2;
    return sonuc;
}

double Cikar(double sayi1, double sayi2)
{
    double sonuc = sayi1 - sayi2;
    return sonuc;
}

double Carp(double sayi1, double sayi2)
{
    double sonuc = sayi1 * sayi2;
    return sonuc;
}

double Bol(double sayi1, double sayi2)
{
    if(sayi2 == 0)
    {
        Console.WriteLine("Sıfıra bölme hatası!");
        return 0;
    }
    double sonuc = sayi1 / sayi2;
    return sonuc;
}