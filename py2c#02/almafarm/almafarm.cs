const int maxDBPerRekesz = 12;

Console.Write("Adja meg a rendelt rekeszek darabszámát (5-20): ");
int rekeszDB = Convert.ToInt32(Console.ReadLine());
Console.Write("Adja meg a mai napon leszüretelt almák darabszámot (100-200): ");
int almakDB = Convert.ToInt32(Console.ReadLine());

if (rekeszDB * maxDBPerRekesz <= almakDB)
{
    Console.WriteLine("A rendelt mennyiség teljesíthető.");
}
else
{
    Console.WriteLine($"A rendelt mennyiség nem teljesíthető, max. {almakDB/12} rekeszt lehet értékesíteni.");
}
