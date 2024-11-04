
namespace Zkouska;

internal class Program
{
    static void Main(string[] args)
    {
        Zkouska[] zkousky  = GetZkousky();
        foreach(Zkouska  zkouska in zkousky)
        {
            ZobrazZkousku(zkouska);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        Console.ReadKey();
    }

    private static Zkouska[] GetZkousky()
    {
        return
        [
            new Zkouska
            {
                Osoba = new Osoba { Jmeno="Jan",Prijmeni="Novák"},
                Datum = DateTime.Now,
                Nazev = "Politologie",
                Vysledky = 
                [
                    new Vysledek { Otazka = "Volební systém USA", Body=5},
                    new Vysledek { Otazka = "Historie OSN", Body = 1 },
                    new Vysledek { Otazka = "Zakládající smlouvy EU", Body = 10 }
                ]
            },
            new Zkouska
            {
                Osoba = new Osoba { Jmeno = "Jan", Prijmeni = "Novák" },
                Datum = DateTime.Now.AddDays(-1),
                Nazev = "Matematika",
                Vysledky =
                [
                    new Vysledek { Otazka = "Limity", Body = 5 },
                    new Vysledek { Otazka = "Derivace", Body = 1 }
                ]
            },
        ];
    }

    private static void ZobrazZkousku(Zkouska zkouska)
    {
        Console.WriteLine($"Osoba: {zkouska.Osoba.Jmeno} {zkouska.Osoba.Prijmeni}");
        Console.WriteLine($"Datum: {zkouska.Datum:d}");
        Console.WriteLine($"Název {zkouska.Nazev}");

        int sum = 0;
        int i = 1;
        foreach (Vysledek vysledek in zkouska.Vysledky)
        {
            Console.WriteLine($"{i}) {vysledek.Otazka}: {vysledek.Body}");
            sum = sum + vysledek.Body;
            i++;
        }

        Console.WriteLine("==================");
        Console.WriteLine($"Celkem {sum}");
    }
}
