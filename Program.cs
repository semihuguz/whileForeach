//1den baslayarak consoledan girilen sayiya kadar ortalamasini hesaplip yazdiran program.
int sayi = int.Parse(Console.WriteLine("Sayi giriniz :"));
Console.ReadLine();
int sayac =1;
int toplam = 0;
while (sayac <= sayi)
{
    toplam+=sayac ;
    sayac++;
}
Console.WriteLine(toplam/sayi);

//a'dan z'ye butun harfleri console yazdir.
char character = 'a';
while(character<='z')
{
    Console.WriteLine(character);
    character++;
}
Console.WriteLine("******Foreach******");

string [] arabalar = {"BMW","Toyota","Ford","Mercedes"};

foreach (var araba in arabalar)
{   
    Console.WriteLine(araba);
}
