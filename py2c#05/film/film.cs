string[] szovegTomb = new string[100];
string Cim = "#";
int i = 0;

Console.WriteLine("Adjon meg filmcímeket!");
Console.Write($"{i+1}. ");
Cim = Console.ReadLine();

do
{
    szovegTomb[i] = Cim;
    i++;
    Console.Write($"{i+1}. ");
    Cim = Console.ReadLine();
} while (Cim != "");

Console.Write("Adja meg a kedvenc betűjét! ");
char kedvencBetu = Convert.ToChar(Console.ReadLine());

Console.WriteLine($"Az ajánlott film: {Leggyakoribb(szovegTomb, kedvencBetu)}");


// Visszaadja, hogy egy karakter hányszor fordul elő egy szövegben
int StrChrCnt (string Szoveg, char Betu)
{
    int count = 0;
    foreach (char karakter in Szoveg)
    {
        if (karakter == Betu)
        {
            count++;
        }
    }
    return count;
}

// Visszaadja a szövegtömbből, hogy melyikben forduk elő legtöbbször egy karakter
string Leggyakoribb (string[] Szovegek, char Betu)
{
    int MaxNum = 0;
    int Num;
    string MaxChr = "";
    for (int i = 0; i < Szovegek.Length && Szovegek[i] != null; i++)
    {
        Num = StrChrCnt(Szovegek[i], Betu);
        if (MaxNum < Num)
        {
            MaxChr = Szovegek[i];
            MaxNum = Num;
        }
    }
    return MaxChr;
}
