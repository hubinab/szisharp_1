Console.Write("Adja meg a megtakarított pénzét (Ft)! ");
int Penz = Convert.ToInt32(Console.ReadLine());
Console.Write("Mennyibe kerül egy mozijegy (Ft)? ");
int Jegy = Convert.ToInt32(Console.ReadLine());

// Az egész ellenőrzés nincs benne! A ToInt32 konverziónál elhasal, ha nem egészet adnak be.
if (Penz <= 0 || Jegy <= 0)
{
    Console.WriteLine("Hibás a bemenő adat.");
}
else
{
    Console.WriteLine($"A megtakarított pénzből {Penz/Jegy} mozijegyet lehet vásárolni.");   
}

