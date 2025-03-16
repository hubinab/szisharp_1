Console.Write("Kérem adjon meg egy szót: ");
var szo = Console.ReadLine();
Console.WriteLine($"A karakterek száma {(szo!.Length % 2 == 0?"páros":"páratlan")}");