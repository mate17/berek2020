using berek2020;
using System.Text;

List<Ber>  dolgozo = [];

using StreamReader sr = new("..\\..\\..\\berek2020.txt", Encoding.UTF8);
sr.ReadLine();
while (!sr.EndOfStream)
{
    dolgozo.Add(new(sr.ReadLine()));
}
Console.Write("3. feladat: ");
Console.WriteLine($"a dolgozók száma: {dolgozo.Count} fő");

Console.Write("4. feladat: ");
var f4 = dolgozo.Average(d => d.Bere);
Console.WriteLine($"Bérek Átlaga: {f4/1000:0.0} eFt");

Console.Write("5. feladat: ");
Console.Write("Kérem a részleg nevét: ");
string f5 = Console.ReadLine();
Console.Write("6. feladat: ");
int max = 0;
for (int i = 0; i < dolgozo.Count; i++)
{
    if (dolgozo[i].Reszleg  == f5.ToLower())
    {
        if (dolgozo[i].Bere > dolgozo[max].Bere)
        {
            max = i;
        }
    }
}
if (max == 0 && dolgozo[max].Reszleg != f5.ToLower())
{
    Console.WriteLine("A megadott részleg nem létezik a cégnél!");
}
else
{
    Console.WriteLine($"\n\tNév: {dolgozo[max].Nev}\n\tNem: {dolgozo[max].Neme}\n\tBelépés: {dolgozo[max].Belepes}\n\tBér: {dolgozo[max].Bere} forint");
}
Console.WriteLine("7. feladat: Statisztika");
var f7 = dolgozo.GroupBy(d => d.Reszleg);
foreach (var fel in f7)
{
    Console.WriteLine($"{fel.Key}: {fel.Count()} db");
}
Console.WriteLine(f7);
