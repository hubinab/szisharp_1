Theft[] Lopasok;

using(StreamReader filebe = new StreamReader("kereglista.txt"))
{
    filebe.ReadLine();
    string[] sorok = filebe.ReadToEnd().Trim().Split("\n");
    Lopasok = new Theft[sorok.Length];
    for (int i = 0; i < sorok.Length; i++)
    {
        string[] sor = sorok[i].Trim().Split(";");
        Theft lopas = new Theft(sor[0], sor[1], sor[2], sor[3], int.Parse(sor[4]));
        Lopasok[i] = lopas;
    }
}

Console.WriteLine($"1. feladat: {Lopasok.Length} alkalommal lopta meg az erdő lakóit.");

int maxErtek = 0;
int maxErtekIndex = 0;

for (int i = 0; i < Lopasok.Length; i++)
{
    if (Lopasok[i].ertek >= maxErtek)
    {
        maxErtek = Lopasok[i].ertek;
        maxErtekIndex = i;
    }
}

Console.WriteLine($"2. feladat: Legértékesebb lopás adatai: ");
Console.WriteLine($"\tSértett neve: {Lopasok[maxErtekIndex].nev}");
Console.WriteLine($"\tEllopott tárgy: {Lopasok[maxErtekIndex].targy}");
Console.WriteLine($"\tHelyszín: {Lopasok[maxErtekIndex].helyszin}");
Console.WriteLine($"\tTobozok száma: {Lopasok[maxErtekIndex].ertek} db");

double osszErtek = 0;

for (int i = 0; i < Lopasok.Length; i++)
{
    osszErtek += Lopasok[i].ertek;
}

Console.WriteLine($"3. feladat: Átlagosan {osszErtek/Lopasok.Length:F2} toboz értékben lopott az éji tolvaj.");

int talaltIndex = -1;

for (int i = 0; i < Lopasok.Length; i++)
{
    if (Lopasok[i].helyszin == "Indián falu")
    {
        talaltIndex = i;
        break;
    }    
}

if (talaltIndex >= 0)
{
    Console.WriteLine("4. feladat: Volt az indián faluban lopás: ");
    Console.WriteLine($"\tSértett neve: {Lopasok[talaltIndex].nev}");
    Console.WriteLine($"\tA lopás dátuma: {Lopasok[talaltIndex].datum}");
} 
else
{
    Console.WriteLine("4. feladat: Nem volt ilyen eset.");
}

Dictionary <string, int> SzotarHonap = new Dictionary<string, int> 
{
    {"január",1},{"február",2},{"március",3},{"április",4},
    {"május",5},{"június",6},{"július",7},{"augusztus",8},
    {"szeptember",9},{"október",10},{"november",11},{"december",12}
};

Console.Write("5. feladat: Kérem adjon meg egy hónapot: ");
string hoBe = Console.ReadLine()!;

int hoOssz = 0;

for (int i = 0; i < Lopasok.Length; i++)
{
    if (int.Parse(Lopasok[i].datum.Split(".")[1]) == SzotarHonap[hoBe])
    {
        hoOssz++;
    }
}

Console.WriteLine($"\tAz éji tolvaj {hoOssz} alkalommal lopott a {SzotarHonap[hoBe]} hónapban.");

using(StreamWriter fileki = new StreamWriter("lazac.txt"))
{
    fileki.WriteLine("Név;Tárgy;Dátum;Helyszín");
    for (int i = 0; i < Lopasok.Length; i++)
    {
        if (Lopasok[i].targy == "Lazac")
        {
            fileki.WriteLine($"{Lopasok[i].nev};{Lopasok[i].targy};{Lopasok[i].datum};{Lopasok[i].helyszin}");
        }
    }
}
record Theft(string nev, string targy, string datum, string helyszin, int ertek);
