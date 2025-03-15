Console.Write("Adja meg, hogy idáig mennyi tobozt gyűjtöttek (300 és 800): ");
int tobozDB = Convert.ToInt32(Console.ReadLine());

int kosar = tobozDB / 50;
int maradek = tobozDB % 50;

if (kosar != 0 && maradek == 0)
    Console.WriteLine($"A mai napon {kosar} kosár van tele.");

if (maradek != 0)
    Console.WriteLine($"A mai napon {kosar} kosár van tele és {maradek} toboz került a következő kosárba.");

