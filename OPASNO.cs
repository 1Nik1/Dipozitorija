using System;

class Cat
{
    private bool opasna;

    public bool Opasna { get => opasna; set => opasna = value; }

    public void Opasnost()
    {
        Opasna = false;
    }
}

class Gepard : Cat
{
    public new void Opasnost()
    {
        base.Opasnost();
        Opasna = true;
    }
}

class Program
{
    static void Main()
    {
        Gepard g = new Gepard();
        g.Opasnost();

        Console.WriteLine("Vrijednost opasna u objektu g: " + g.Opasna);

        Console.ReadLine();
    }
}
