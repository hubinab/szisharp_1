// 1. feladat érdemjegy
System.Console.Write("Kérek egy jegyet 1-5-ig: ");
int jegy /*= int.Parse(Console.ReadLine())*/;
jegy = 5;
switch (jegy)
{
    case 1:
        System.Console.WriteLine("Elégtelen");
        break;
    case 2:
        System.Console.WriteLine("Elégséges");
        break;
    case 3:
        System.Console.WriteLine("Közepes");
        break;
    case 4:
        System.Console.WriteLine("Jó");
        break;
    case 5:
        System.Console.WriteLine("Jeles");
        break;

    default:
        System.Console.WriteLine("Nem helyes számot adtál meg!");
        break;
}

// 2-es feladat hó/negyedév
System.Console.Write("Kérem a hónap nevét: ");
string honap;
// honap = Console.ReadLine();
honap = "December";

switch (honap)
{
    case "Január":
    case "Február":
    case "Március":
        System.Console.WriteLine("1. negyedév");
        break;
    case "Április":
    case "Május":
    case "Június":
        System.Console.WriteLine("2. negyeév");
        break;
    case "Július":
    case "Agusztus":
    case "Szeptember":
        System.Console.WriteLine("3. negyedév");
        break;
    case "Október":
    case "November":
    case "December":
        System.Console.WriteLine("4. negyedév");
        break;
}

// 3. feladat hó/évszak
System.Console.Write("Kérem a hónap sorszámát: ");
int ho;
// ho = int.Parse(Console.ReadLine());
ho = 12;

switch (ho)
{
    case 12:
    case 1:
    case 2:
        System.Console.WriteLine("Tél");
        break;
    case 3:
    case 4:
    case 5:
        System.Console.WriteLine("Tavasz");
        break;
    case 6:
    case 7:
    case 8:
        System.Console.WriteLine("Nyár");
        break;
    case 9:
    case 10:
    case 11:
        System.Console.WriteLine("Ősz");
        break;
}

// 4. feladat alvás
System.Console.Write("Add meg hány órát alszol: ");
int hany_ora;
// hany_ora = int.Parse(Console.ReadLine());
hany_ora = 12;

if (hany_ora >= 0 && hany_ora <= 6)
{
    System.Console.WriteLine("Kevés!");
}else if (hany_ora <= 9)
{
    System.Console.WriteLine("Átlagos!");  
} else if (hany_ora<=12)
{
    System.Console.WriteLine("sok!");    
}else
{
    System.Console.WriteLine("Nagyon sok!");    
}

switch (hany_ora)
{
    case 0:
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
    case 6:
        System.Console.WriteLine("Kevés!");
        break;
    case 7:
    case 8:
    case 9:
        System.Console.WriteLine("Átlagos!");
        break;
    case 10:
    case 11:
    case 12:
        System.Console.WriteLine("sok!");
        break;
    case 13:
    case 14:
    case 15:
    case 16:
    case 17:
    case 18:
    case 19:
    case 20:
    case 21:
    case 22:
    case 23:
    case 24:
        System.Console.WriteLine("Nagyon sok!");
        break;
}

