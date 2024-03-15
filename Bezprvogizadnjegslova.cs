using System;

class KlasaB
{
    public string BezPrvogIZadnjeg(string tekst)
    {
        if (tekst.Length <= 2)
        {
            Console.WriteLine("Tekst mora imati više od 2 znaka jer inače nema što ispisati!!!!!!!!!!!!!!!!!!!!!!");
            return "";
        }

        return tekst.Substring(1, tekst.Length - 2);
    }
}

class Program
{
    static void Main()
    {
        KlasaB objekt = new KlasaB();

        Console.WriteLine("Unesite riječ:");
        string unos = Console.ReadLine();

        if (unos.Length > 2)
        {
            string rezultat = objekt.BezPrvogIZadnjeg(unos);
            Console.WriteLine("Riječ bez prvog i zadnjeg slova: " + rezultat);
        }
        else
        {
            Console.WriteLine("Tekst mora imati više od 2 znaka jer inače nema što ispisati!!!!!!!!!!!!!!!!!!!!!!");
        }

        Console.ReadLine(); // Zaustavi konzolu da se zatvori odmah
    }
}
